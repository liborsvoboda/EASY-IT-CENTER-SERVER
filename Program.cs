﻿using FluentStorage.Utils.Extensions;
using EASYTools.LicenseVerify;
using Microsoft.AspNetCore;
using System.Runtime.InteropServices;

[assembly: AssemblyVersion(ThisAssembly.Git.BaseVersion.Major + "." + ThisAssembly.Git.BaseVersion.Minor + "." + ThisAssembly.Git.BaseVersion.Patch)]

[assembly: AssemblyFileVersion(ThisAssembly.Git.SemVer.Major + "." + ThisAssembly.Git.SemVer.Minor + "." + ThisAssembly.Git.SemVer.Patch)]

[assembly: AssemblyInformationalVersion(
    ThisAssembly.Git.SemVer.Major + "." +
    ThisAssembly.Git.SemVer.Minor + "." +
    ThisAssembly.Git.Commits + "-" +
    ThisAssembly.Git.Branch + "+" +
    ThisAssembly.Git.Commit)]
[assembly: AssemblyVersion("2.0.*" + ThisAssembly.BuildEvn.BuildId)]
namespace EasyITCenter {

    /// <summary>
    /// Server Main Definition Starting Point Of Project
    /// </summary>
    public class EICServer {
        private static readonly DBConn _srvDBConn = new();
        private static readonly SrvRuntime _srvRuntime = new();
        internal static readonly string SwaggerDesc = "Full Backend Server DB & API & WebSocket model";

        /// <summary>
        /// Initialize DB Connection from config File
        /// </summary>
        public static readonly DBConn SrvDBConn = _srvDBConn;

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
                        options.ServiceName = DbOperations.GetServerParameterLists("ConfigCoreServerRegisteredName").Value;
                    });
                }

                //Process Server Configuration
                IHost? Ihost = hostBuilder.Build();

                //Databse Migration Control
                if (DBConn.DatabaseMigrationEnabled) {
                    using (IServiceScope? scope = Ihost.Services.CreateScope()) {
                        EasyITCenterContext? myDbContext = scope.ServiceProvider.GetRequiredService<EasyITCenterContext>();
                        await myDbContext.Database.MigrateAsync();
                    }
                }

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

            LoadConfigurationFromFile();
            DbOperations.LoadOrRefreshStaticDbDials();

            return Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder => {
                if (bool.Parse(DbOperations.GetServerParameterLists("ConfigServerStartupOnHttps").Value) || bool.Parse(DbOperations.GetServerParameterLists("ConfigServerStartupHTTPAndHTTPS").Value)) {
                    webBuilder.ConfigureKestrel(options => {
                        options.AddServerHeader = true;
                        options.ListenAnyIP(int.Parse(DbOperations.GetServerParameterLists("ConfigServerStartupHttpsPort").Value), opt => {
                            opt.Protocols = HttpProtocols.Http1AndHttp2;
                            opt.KestrelServerOptions.AllowAlternateSchemes = true;

                            if (!bool.Parse(DbOperations.GetServerParameterLists("ConfigServerGetLetsEncrypt").Value)) {
                                opt.UseHttps(DbOperations.GetServerParameterLists("ConfigCertificatePath").Value.Length > 0
                                    ? CoreOperations.GetSelfSignedCertificateFromFile(DbOperations.GetServerParameterLists("ConfigCertificatePath").Value)
                                        : CoreOperations.GetSelfSignedCertificate(DbOperations.GetServerParameterLists("ConfigCertificatePassword").Value),
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
                if (bool.Parse(DbOperations.GetServerParameterLists("ConfigServerStartupOnHttps").Value) && bool.Parse(DbOperations.GetServerParameterLists("ConfigServerGetLetsEncrypt").Value)) {
                    webBuilder.UseKestrel(options => {
                        IServiceProvider? appServices = options.ApplicationServices;
                        options.ConfigureHttpsDefaults(h => {
                            h.SslProtocols = System.Security.Authentication.SslProtocols.Tls12 | System.Security.Authentication.SslProtocols.Tls11 | System.Security.Authentication.SslProtocols.Tls | System.Security.Authentication.SslProtocols.Ssl2 | System.Security.Authentication.SslProtocols.Ssl3;
                            h.ClientCertificateMode = ClientCertificateMode.RequireCertificate;
                            h.UseLettuceEncrypt(appServices);//.UseServerCertificateSelector;
                        });
                    });
                }


                if (bool.Parse(DbOperations.GetServerParameterLists("ConfigServerStartupHTTPAndHTTPS").Value)) {
                    webBuilder.UseUrls($"https://*:{DbOperations.GetServerParameterLists("ConfigServerStartupHttpsPort").Value}", $"http://*:{DbOperations.GetServerParameterLists("ConfigServerStartupHttpPort").Value}");
                } else {
                    webBuilder.UseUrls(bool.Parse(DbOperations.GetServerParameterLists("ConfigServerStartupOnHttps").Value) ? $"https://*:{DbOperations.GetServerParameterLists("ConfigServerStartupHttpsPort").Value}" : $"http://*:{DbOperations.GetServerParameterLists("ConfigServerStartupHttpPort").Value}");
                }

                webBuilder.UseStartup<Startup>();
                webBuilder.UseWebRoot(Path.Combine(SrvRuntime.Startup_path, DbOperations.GetServerParameterLists("DefaultStaticWebFilesFolder").Value));
                webBuilder.UseContentRoot(Directory.GetCurrentDirectory());
                webBuilder.UseStaticWebAssets();

            });
        }


        /// <summary>
        /// Checking Valid License on StartUp
        /// </summary>
        private static void CheckLicense() {
            bool licenseStatus = LicenseControlller.VerifyLicense(out LicenseData licenseModel, true);
            if (string.IsNullOrEmpty(licenseModel.Status)) { Console.WriteLine("Missing License file in \"Data\" folder"); }
            Console.WriteLine("License Info: " + JsonSerializer.Serialize(licenseModel));
            if (!licenseStatus)
            {
                Console.WriteLine("Server will be in 30 second ShutDown"); Thread.Sleep(30 * 1000);
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
                    foreach (PropertyInfo property in _srvDBConn.GetType().GetProperties()) {
                        if (configItem.Key == property.Name) {
                            try { property.SetValue(_srvDBConn, Convert.ChangeType(configItem.Value.ToString(), property.PropertyType)); } catch { }
                        }
                    }
                    
                });
            } catch (Exception ex) {
                CoreOperations.SendEmail(new SendMailRequest() { Content = DataOperations.GetErrMsg(ex) }, true);
                Console.WriteLine("LoadConfigurationFromFile Error: " + DataOperations.GetErrMsg(ex));
                Environment.Exit(10);
            }
        }

    }
}