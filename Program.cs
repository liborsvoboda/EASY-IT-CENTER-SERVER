using LicenseVerify;
using Microsoft.AspNetCore;
using NuGet.Packaging;
using ServiceStack;
using System.Runtime.InteropServices;


[assembly: AssemblyVersion("2.0.*")]
namespace EasyITCenter {

    /// <summary>
    /// Server Main Definition Starting Point Of Project
    /// </summary>
    public class EICServer {
        private static SrvConfig _srvConfig = new();
        private static readonly SrvRuntime _srvRuntime = new();
        internal static readonly string SwaggerDesc = "Full Backend Server DB & API & WebSocket model";

        /// <summary>
        /// Startup Server Initialization Server Setting Data
        /// </summary>
        public static readonly SrvConfig SrvConfig = _srvConfig;

        /// <summary>
        /// Startup Server Initialization Server Runtime Data
        /// </summary>
        public static readonly SrvRuntime SrvRuntime = _srvRuntime;

        /// <summary>
        /// Server Startup Process
        /// </summary>
        /// <param name="args"></param>
        public static async Task Main(string[] args) {
            SrvRuntime.ServerArgs = args;

            await StartServer();

            //Restart Server Control
            while (SrvRuntime.SrvRestartReq) {
                SrvRuntime.SrvRestartReq = false;
                await StartServer();
            }
        }

        /// <summary>
        /// Server Restart Controller
        /// </summary>
        public static void RestartServer() {
            SrvRuntime.SrvRestartReq = true;
            SrvRuntime.ServerCancelToken.Cancel();
        }

        /// <summary>
        /// Server Start Controller
        /// </summary>
        private static async Task StartServer() {

            try {
                CheckLicense();
                SrvRuntime.ServerCancelToken = new CancellationTokenSource();
                FileOperations.LoadOrCreateSettings();

                IHostBuilder? hostBuilder = BuildWebHost(SrvRuntime.ServerArgs);
                if (CoreOperations.SrvOStype.IsWindows()) {
                    hostBuilder.UseWindowsService(options => {
                        options.ServiceName = SrvConfig.ConfigCoreServerRegisteredName;
                    });
                }

                //Process Server Configuration
                IHost? Ihost = hostBuilder.Build();

                //Databse Migration Control

                /*
                if (SrvConfig.DatabaseMigrationEnabled) {
                    using (IServiceScope? scope = Ihost.Services.CreateScope()) {
                        EasyITCenterContext? myDbContext = scope.ServiceProvider.GetRequiredService<EasyITCenterContext>();
                        await myDbContext.Database.MigrateAsync();
                    }
                }*/

                //Load DB Local AutoUpdate Dials Tables to Memory
                if (SrvConfig.ServiceUseDbLocalAutoupdatedDials) { ServerStartupDbDataLoading(); }

                //Start Server
                await Ihost.RunAsync(SrvRuntime.ServerCancelToken.Token);
            } catch (Exception Ex) {
                
                CoreOperations.SendEmail(new SendMailRequest() { Content = DataOperations.GetErrMsg(Ex) });
                Console.WriteLine("Server Startup Error: " + DataOperations.GetErrMsg(Ex));
                Environment.Exit(3);
            }
        }

        /// <summary>
        /// Final Preparing Server HostBuilder Definition
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        private static IHostBuilder BuildWebHost(string[] args) {

            LoadConfigurationFromFile();LoadConfigurationFromDb();
            
            return Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder => {
                if (SrvConfig.ConfigServerStartupOnHttps || SrvConfig.ConfigServerStartupHTTPAndHTTPS) {
                    webBuilder.ConfigureKestrel(options => {
                        options.AddServerHeader = true;
                        options.ListenAnyIP(SrvConfig.ConfigServerStartupHttpsPort, opt => {
                            opt.Protocols = HttpProtocols.Http1AndHttp2;
                            opt.KestrelServerOptions.AllowAlternateSchemes = true;

                            if (!SrvConfig.ConfigServerGetLetsEncrypt) {
                                opt.UseHttps(SrvConfig.ConfigCertificatePath.Length > 0
                                    ? CoreOperations.GetSelfSignedCertificateFromFile(SrvConfig.ConfigCertificatePath)
                                        : CoreOperations.GetSelfSignedCertificate(SrvConfig.ConfigCertificatePassword),
                                      cfg => {
                                          cfg.SslProtocols = System.Security.Authentication.SslProtocols.Tls12 | System.Security.Authentication.SslProtocols.Tls11 | System.Security.Authentication.SslProtocols.Tls | System.Security.Authentication.SslProtocols.Ssl2 | System.Security.Authentication.SslProtocols.Ssl3;
                                          cfg.ClientCertificateMode = ClientCertificateMode.NoCertificate;
                                          cfg.AllowAnyClientCertificate();
                                      });
                            }
                        });
                    });
                }

                //Lets Encrypt
                if (SrvConfig.ConfigServerStartupOnHttps && SrvConfig.ConfigServerGetLetsEncrypt) {
                    webBuilder.UseKestrel(options => { 
                        IServiceProvider? appServices = options.ApplicationServices;
                        options.ConfigureHttpsDefaults(h => {
                            h.SslProtocols = System.Security.Authentication.SslProtocols.Tls12 | System.Security.Authentication.SslProtocols.Tls11 | System.Security.Authentication.SslProtocols.Tls | System.Security.Authentication.SslProtocols.Ssl2 | System.Security.Authentication.SslProtocols.Ssl3;
                            h.ClientCertificateMode = ClientCertificateMode.RequireCertificate;
                            h.UseLettuceEncrypt(appServices);//.UseServerCertificateSelector;
                        });
                    });
                }


                //udelat seznam naslouchani na urcitych portech portal=1,moduly=2 udelat v tom poradek
                //webBuilder.UseUrls(new string[] { "http://*:5000", "https://*:5001" });

                if (SrvConfig.ConfigServerStartupHTTPAndHTTPS) {
                    webBuilder.UseUrls($"https://*:{SrvConfig.ConfigServerStartupHttpsPort}",$"http://*:{SrvConfig.ConfigServerStartupHttpPort}");
                } else {
                    webBuilder.UseUrls(SrvConfig.ConfigServerStartupOnHttps ? $"https://*:{SrvConfig.ConfigServerStartupHttpsPort}" : $"http://*:{SrvConfig.ConfigServerStartupHttpPort}");
                }

                //webBuilder.UseModularStartup<AppHost>();

                webBuilder.UseStartup<Startup>();
                webBuilder.UseWebRoot(SrvRuntime.WebRoot_path);
                webBuilder.UseContentRoot(Directory.GetCurrentDirectory());
                webBuilder.UseStaticWebAssets();

            });
        }

        /// <summary>
        /// Server Startup DB Data loading for minimize DB Connect TO Frequency Dials Without
        /// Changes With Full Auto Filling Non Exist Records
        /// Example: LanguageList
        /// </summary>
        private static void ServerStartupDbDataLoading() { DbOperations.LoadOrRefreshStaticDbDials(); }

        /// <summary>
        /// Checking Valid License on StartUp
        /// </summary>
        private static void CheckLicense() {
            bool licenseStatus = LicenseControlller.VerifyLicense(out LicenseData licenseModel, true);
            if (string.IsNullOrEmpty(licenseModel.Status)) { Console.WriteLine("Missing License file in \"Data\" folder"); }
            Console.WriteLine("License Info: " + JsonSerializer.Serialize(licenseModel));
            if (!licenseStatus) { Console.WriteLine("Server will be in 30 second ShutDown"); Thread.Sleep(30 * 1000); 
                Environment.Exit(5); 
            }
        }

        /// <summary>
        /// Server Core: Load Configuration From Config File In Startup Folder/Data/config.json
        /// For Linux is Loaded from server FOLder/Data/config.json
        /// For Windows sysDrive://ProgramData/EasyITCenter/config.json
        /// its Alone Different Setting FOR More Platforms
        /// </summary>
        private static void LoadConfigurationFromFile() {
            try {
                //Load From Config File
                string json = CoreOperations.SrvOStype.IsWindows()
                    ?  File.ReadAllText(Path.Combine(SrvRuntime.Setting_folder, SrvRuntime.ConfigFile), FileOperations.FileDetectEncoding(Path.Combine(SrvRuntime.Setting_folder, SrvRuntime.ConfigFile)))
                    : File.ReadAllText(Path.Combine(SrvRuntime.Startup_path, "Data", SrvRuntime.ConfigFile), FileOperations.FileDetectEncoding(Path.Combine(SrvRuntime.Startup_path, "Data", SrvRuntime.ConfigFile)))
                    ;

                Dictionary<string, object> exportServerSettingList = new Dictionary<string, object>();
                exportServerSettingList.AddRange(JsonSerializer.Deserialize<Dictionary<string, object>>(json).ToList());

                exportServerSettingList.ToList().ForEach(configItem => {
                    foreach (PropertyInfo property in _srvConfig.GetType().GetProperties()) {
                        if (configItem.Key == property.Name) {
                            try { property.SetValue(_srvConfig, Convert.ChangeType(configItem.Value.ToString(), property.GetValue(SrvConfig).GetType())); } catch { }
                        }
                    }
                });
            } catch (Exception ex) {
                CoreOperations.SendEmail(new SendMailRequest() { Content = DataOperations.GetErrMsg(ex) }, true);
                Console.WriteLine("LoadConfigurationFromFile Error: " + DataOperations.GetErrMsg(ex));
                Environment.Exit(10);
            }
        }

        /// <summary>
        /// Server Core: Load Configuration From Database First Must be From File With DB
        /// Connection, Others File Settings than DB connection is Optional
        /// </summary>
        private static void LoadConfigurationFromDb() {
            try {
                //Load Configuration From Database
                List<ServerSettingList> ConfigData = new EasyITCenterContext().ServerSettingLists.ToList();
                foreach (PropertyInfo property in _srvConfig.GetType().GetProperties()) {
                    if (ConfigData.FirstOrDefault(a => a.Key == property.Name) != null) {
                        property.SetValue(_srvConfig, Convert.ChangeType(ConfigData.First(a => a.Key == property.Name).Value, property.PropertyType), null);
                    }
                }
            } catch (Exception ex) {
                CoreOperations.SendEmail(new SendMailRequest() { Content = DataOperations.GetErrMsg(ex) });
                Console.WriteLine("LoadConfigurationFromDb Error: " + Environment.NewLine
                    + "Config File from Folder: "
                    + (CoreOperations.SrvOStype.IsWindows() ? Path.Combine(SrvRuntime.Setting_folder, SrvRuntime.ConfigFile) : Path.Combine(SrvRuntime.Startup_path, "Data", SrvRuntime.ConfigFile))
                    + "With ConnectionString: " + SrvConfig.DatabaseConnectionString + Environment.NewLine 
                    + "Has Error: " + DataOperations.GetErrMsg(ex));
                Environment.Exit(20);
            }
        }
    }
}