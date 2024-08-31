using FubarDev.FtpServer;
using FubarDev.FtpServer.AccountManagement;
using FubarDev.FtpServer.FileSystem.DotNet;
using EasyITCenter.Services;
using LettuceEncrypt;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Quartz;
using SimpleMvcSitemap;
using Microsoft.AspNetCore.Mvc.Razor;
using EasyITCenter.GitServer.Services;
using EasyITCenter.GitServer.Repositorys;
using EasyITCenter.GitServer.Interfaces;
using EasyITCenter.GitServer.Models;
using EasyITCenter.GitServer.Controllers;
using RefactorWebSites;
using Westwind.AspNetCore.Markdown;
using ServerCorePages;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.AspNetCore.Authentication.Facebook;
using Snickler.RSSCore.Extensions;
using FileContextCore;

namespace EasyITCenter.ServerCoreConfiguration {

    /// <summary>
    /// Server Core Configuration Settings of Security, Communications, Technologies, Modules Rules,
    /// Rights, Conditions, Formats, Services, Logging, etc..
    /// </summary>
    public class ServerConfigurationServices {


        /// <summary>
        /// Configure AutoMinify Js,Css 
        /// </summary>
        /// <param name="services"></param>
        internal static void ConfigureAutoMinify(ref IServiceCollection services) {
            if (ServerConfigSettings.EnableAutoMinify)
            {
                services.AddWebOptimizer(cfg =>
                {
                    cfg.MinifyCssFiles(); cfg.MinifyJsFiles();/*cfg.MinifyHtmlFiles();*/
                }, option => {  
                    option.EnableTagHelperBundling = true; 
                    option.AllowEmptyBundle = true;
                });
            }
        }

        /// <summary>
        /// Custom Secure FTP Server
        /// </summary>
        /// <param name="services">The services.</param>
        internal static void ConfigureFTPServer(ref IServiceCollection services) {
            if (ServerConfigSettings.ServerFtpEngineEnabled) {
                services.AddFtpServer(
                    builder => {
                        if (!ServerConfigSettings.ServerFtpSecurityEnabled) { 
                            builder.UseDotNetFileSystem().DisableChecks().UseSingleRoot().EnableAnonymousAuthentication(); } else { builder.UseDotNetFileSystem().DisableChecks().UseRootPerUser(); 
                        }
                    });
                services.Configure<FtpServerOptions>(opt => { opt.ServerAddress = "127.0.0.1"; /*opt.Port*/ });
                services.Configure<DotNetFileSystemOptions>(opt => {
                    opt.RootPath = !ServerConfigSettings.ServerFtpSecurityEnabled ? Path.Combine(ServerRuntimeData.FTPServerPath,"guest") : ServerRuntimeData.FTPServerPath;
                    opt.AllowNonEmptyDirectoryDelete = true;
                });
                services.AddSingleton<IMembershipProvider, HostedFtpServerMembershipProvider>();
                services.AddHostedService<HostedFtpServer>();

                using (var serviceProvider = services.BuildServiceProvider()) {
                    ServerRuntimeData.ServerFTPProvider = serviceProvider.GetRequiredService<IFtpServerHost>();
                    ServerRuntimeData.ServerFTPRunningStatus = true;
                }
            }
        }

        /// <summary>
        /// Server Core: Configure Cookie Politics
        /// </summary>
        /// <param name="services"></param>
        internal static void ConfigureCookie(ref IServiceCollection services) {
            services.Configure<CookiePolicyOptions>(options => {
                options.ConsentCookie.Name = ServerConfigSettings.ConfigCoreServerRegisteredName;
                options.CheckConsentNeeded = context => false;
                options.MinimumSameSitePolicy = SameSiteMode.Lax;
                options.Secure = CookieSecurePolicy.Always;
                options.HttpOnly = Microsoft.AspNetCore.CookiePolicy.HttpOnlyPolicy.None;
                //options.ConsentCookie.IsEssential = false;
            });
        }

        /// <summary>
        /// Server Core: Configure Server Controllers
        /// options.SuppressImplicitRequiredAttributeForNonNullableReferenceTypes = [ValidateNever]
        /// in Class options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore
        /// = [JsonIgnore] in Class
        /// </summary>
        /// <param name="services"></param>
        internal static void ConfigureControllers(ref IServiceCollection services) {
            
            services.AddRouting(options => { options.LowercaseUrls = true;options.LowercaseQueryStrings = true; });

            services.AddControllersWithViews(options => {
                //if (ServerConfigSettings.ConfigServerStartupOnHttps) { options.Filters.Add(new RequireHttpsAttribute()); }
                options.SuppressImplicitRequiredAttributeForNonNullableReferenceTypes = true;
            }).AddNewtonsoftJson(options => {
                options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                options.SerializerSettings.ContractResolver = new DefaultContractResolver();
                options.SerializerSettings.Formatting = Formatting.Indented;
            }).AddJsonOptions(x => {
                //x.JsonSerializerOptions.PropertyNameCaseInsensitive = true;
                x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
                x.JsonSerializerOptions.WriteIndented = true;
                x.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
                x.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
            });
        }

        /// <summary>
        /// Server Core: Configure Server Logging
        /// </summary>
        /// <param name="services"></param>
        internal static void ConfigureLogging(ref IServiceCollection services) {
            if (ServerRuntimeData.DebugMode) {
                services.AddLogging(builder => {
                    builder.AddConsole().AddDebug().SetMinimumLevel(LogLevel.Debug)
                    .AddFilter<ConsoleLoggerProvider>(category: null, level: LogLevel.Debug)
                    .AddFilter<DebugLoggerProvider>(category: null, level: LogLevel.Debug);
                });
            }
            services.AddHttpLogging(logging => {
                logging.LoggingFields = HttpLoggingFields.All;
                logging.RequestHeaders.Add("sec-ch-ua"); logging.ResponseHeaders.Add("RequestJsonFormatNotCorrectly");
                logging.MediaTypeOptions.AddText("application/javascript");
                logging.RequestBodyLogLimit = logging.ResponseBodyLogLimit = 4096;
            });
        }

        /// <summary>
        /// Server Core: Configure Server Authentication Support
        /// IDENTITY FULL
        /// https://github.com/dotnet/AspNetCore.Docs/blob/main/aspnetcore/security/authentication/scaffold-identity/sample/StartupFull.cs
        /// ///https://learn.microsoft.com/en-us/aspnet/core/security/authentication/social/other-logins?view=aspnetcore-3.1
        /// </summary>
        /// <param name="services"></param>
        internal static void ConfigureAuthentication(ref IServiceCollection services) {


            //FUTURE  Certificate Auth
            //if (ServerConfigSettings.ConfigServerStartupHttpAndHttps || ServerConfigSettings.ConfigServerStartupOnHttps) {
            //    services.AddAuthentication(CertificateAuthenticationDefaults.AuthenticationScheme).AddCertificate(options =>
            //    {
            //        options.Events = new CertificateAuthenticationEvents {
            //            OnCertificateValidated = context => { var claims = new[]{
            //        new Claim(context.ClientCertificate.Subject,
            //            ClaimValueTypes.String, context.Options.ClaimsIssuer),
            //        new Claim(ClaimTypes.Name,context.ClientCertificate.Subject,
            //            ClaimValueTypes.String, context.Options.ClaimsIssuer)};
            //                context.Principal = new ClaimsPrincipal(new ClaimsIdentity(claims, context.Scheme.Name));
            //                context.Success();return Task.CompletedTask;
            //            }
            //        };
            //    });
            //}
            services.AddAuthentication(x => {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultSignInScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(x => {
                x.BackchannelHttpHandler = new HttpClientHandler { ServerCertificateCustomValidationCallback = delegate { return true; } };
                x.RequireHttpsMetadata = false;
                x.SaveToken = true;
                x.TokenValidationParameters = CoreOperations.ValidAndGetTokenParameters();
                x.ForwardSignIn = new EasyITCenterContext().ServerModuleAndServiceLists.Where(a => a.IsLoginModule).FirstOrDefault()?.UrlSubPath;

                if (ServerConfigSettings.ConfigTimeTokenValidationEnabled) { x.TokenValidationParameters.LifetimeValidator = EasyITCenterAuthenticationApi.TokenLifetimeValidator; }

                x.Events = new JwtBearerEvents {
                    OnAuthenticationFailed = context => {
                        if (context.Exception.GetType() == typeof(SecurityTokenExpiredException)) {
                            context.Response.Headers.Add("IS-TOKEN-EXPIRED", "true");
                        }
                        return Task.CompletedTask;
                    }
                };
            });

            /*
            services.AddAuthentication().AddGoogle(options => { 
                //options.ClientId = "";
                //options.ClientSecret = "";
            }).AddFacebook(options => {
                //options.ClientId = "";
                //options.ClientSecret = "";
                options.AppId = "";
                options.AppSecret = "";
            }).AddMicrosoftAccount(microsoftOptions => {
                //microsoftOptions.ClientId = "";
                //microsoftOptions.ClientSecret = "";
            }).AddTwitter(twitterOptions => {
                twitterOptions.ConsumerKey = "";
                twitterOptions.ConsumerSecret = "";
                twitterOptions.RetrieveUserDetails = true;
            });
            */
           
        }

        /// <summary>
        /// Configures the MVC server pages on Server format "cshtml"
        /// </summary>
        /// <param name="services">The services.</param>
        internal static void ConfigureServerWebPages(ref IServiceCollection services) {
            if (ServerConfigSettings.WebRazorPagesEngineEnabled) {
                if (ServerConfigSettings.WebRazorPagesCompileOnRuntime) {
                    services.AddMvc(options => {
                        options.CacheProfiles.Add("Default30", new CacheProfile() { Duration = 30 });
                        options.AllowEmptyInputInBodyModelBinding = true;
                        
                    }).AddRazorPagesOptions(opt => {
                        opt.RootDirectory = "/ServerCorePages";
                        opt.Conventions.AuthorizeFolder("/DefaultWebPages/GlobalLogin");

                        //TODO SEMDAT TY MODULY
                        //LAYOUTY
                        //options.Conventions.Add(new GlobalTemplatePageRouteModelConvention());
                        //options.Conventions.AddFolderRouteModelConvention("/OtherPages", model =>


                    //https://github.com/dotnet/AspNetCore.Docs/blob/main/aspnetcore/razor-pages/razor-pages-conventions/samples/6.x/SampleApp/Program.cs
                    //https://learn.microsoft.com/en-us/aspnet/core/mvc/views/view-components?view=aspnetcore-3.1 FULL DOC
                    //options.Conventions.Add(new GlobalTemplatePageRouteModelConvention());
                    //VYPADA TO, ZE CONVENTION Obohati vsechny stranky na urovni modelu
                    // options.Conventions.AddPageRoute("/Contact", "TheContactPage/{text?}"); stranka

                    }).AddRazorRuntimeCompilation();
                    //.WithRazorPagesAtContentRoot(); 
                }
                else {
                    services.AddMvc(options => {
                        options.CacheProfiles.Add("Default30", new CacheProfile() { Duration = 30 });
                    }).AddRazorPagesOptions(opt => {
                        opt.RootDirectory = "/ServerCorePages";
                        opt.Conventions.AuthorizeFolder("/DefaultWebPages/GlobalLogin");
                    });
                }
            }

            if (ServerConfigSettings.WebMvcPagesEngineEnabled) {
                if (ServerConfigSettings.WebRazorPagesCompileOnRuntime) {
                    services.AddMvc(options => {
                        options.EnableEndpointRouting = false;
                        options.AllowEmptyInputInBodyModelBinding = true;
                    }).AddRazorRuntimeCompilation();
                } else {
                    services.AddMvc(options => {
                        options.EnableEndpointRouting = false;
                        options.AllowEmptyInputInBodyModelBinding = true;
                    });
                }
            }
        }

        /// <summary>
        /// Server core: Configures LetsEncrypt using. Certificate will be saved in DataPath
        /// </summary>
        /// <param name="services">The services.</param>
        internal static void ConfigureLetsEncrypt(ref IServiceCollection services) {
            if (ServerConfigSettings.ConfigServerGetLetsEncrypt) {
                services.AddLettuceEncrypt(option => {
                    List<string> domainList = ServerConfigSettings.ConfigCertificateDomain.Contains(',')
                    ? ServerConfigSettings.ConfigCertificateDomain.Split(',').ToList()
                    : ServerConfigSettings.ConfigCertificateDomain.Split(';').ToList();

                    domainList.ForEach(domain => { if (string.IsNullOrWhiteSpace(domain)) domainList.Remove(domain); });
                    option.DomainNames = domainList.ToArray();
                    option.EmailAddress = ServerConfigSettings.EmailerServiceEmailAddress;
                    option.AcceptTermsOfService = true;
                    option.RenewDaysInAdvance = new TimeSpan(10, 0, 0, 0);
                    option.RenewalCheckPeriod = new TimeSpan(1, 0, 0, 0);
                }).PersistDataToDirectory(new DirectoryInfo(System.IO.Path.Combine(ServerRuntimeData.Startup_path, ServerRuntimeData.DataPath)), ServerConfigSettings.ConfigCertificatePassword);
            }
        }

        internal static void ConfigureRSSfeed(ref IServiceCollection services) {
            if (ServerConfigSettings.WebRSSFeedsEnabled) { services.AddRSSFeed<SomeRSSProvider>(); }
        }

        /// <summary>
        /// Server core: Configures the WebSocket logger monitor. For multi monitoring and for
        /// Example Posibilities
        /// </summary>
        /// <param name="services">The services.</param>
        internal static void ConfigureWebSocketLoggerMonitor(ref IServiceCollection services) {
            if (ServerConfigSettings.WebSocketServerMonitorEnabled) { services.AddSingleton<ILoggerProvider, ServerWebSockeMonitorService>(); }
        }

        /// <summary>
        /// Server Core: Configure HTTP Client for work with third party API
        /// </summary>
        /// <param name="services"></param>
        internal static void ConfigureThirdPartyApi(ref IServiceCollection services) {
            //services.AddHttpClient();
        }




        /// <summary>
        /// Server Core: Configures the Transient.
        /// </summary>
        /// <param name="services">The services.</param>
        internal static void ConfigureTransient(ref IServiceCollection services) {
            services.AddTransient<GitRepositoryService>();
            services.AddTransient<GitFileService>();
            //services.AddTransient<GithubUserController>();
            //services.AddTransient<GitAuthenticationService>();//, GitRepository<SolutionUserList>>();
        }



        /// <summary>
        /// Server Core: Configures the singletons. Its Register Custom Listeners For Actions
        /// </summary>
        /// <param name="services">The services.</param>
        internal static void ConfigureSingletons(ref IServiceCollection services) {
            services.AddSingleton<IHttpContextAccessor, ServerApiServiceExtension>();
            services.AddSingleton<ISitemapProvider, SitemapProvider>();
            services.AddSingleton<IHealthCheckPublisher, HealthCheckActionService>();
        }

        /// <summary>
        /// Server Core: Configure Custom Core Services
        /// </summary>
        /// <param name="services"></param>
        internal static void ConfigureScoped(ref IServiceCollection services) {
            services.AddScoped(typeof(IGenericApiServiceAsync<,>), typeof(GenericApiServiceAsync<,>));
            services.AddScoped(typeof(IGenericApiService<,>), typeof(GenericApiService<,>));
            services.AddScoped<StaticFileDbService> ();
        }

        /// <summary>
        /// Server Core: Configure Hosted Service to Runtime Core For Access to Root Functionalities
        /// </summary>
        /// <param name="services"></param>
        internal static void ConfigureCentralServicesProviders(ref IServiceCollection services) {
            ServerRuntimeData.ServerServiceProvider = services.BuildServiceProvider();
        }

        /// <summary>
        /// Server Core: Configure Custom Services
        /// </summary>
        /// <param name="services"></param>
        internal static void ConfigureDatabaseContext(ref IServiceCollection services) {
            if (ServerRuntimeData.DebugMode) { services.AddDatabaseDeveloperPageExceptionFilter(); }
            try {
                services.AddDbContext<EasyITCenterContext>(opt => opt.UseSqlServer(ServerConfigSettings.DatabaseConnectionString).UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking));
                //services.AddDbContext<Context>(options => options.UseFileContextDatabase(databaseName: "LocalDatabase",location: @"C:\Users\mjanatzek\Documents\Projects\test",password: "EasyITCenter"));
                //services.AddDbContext<dbcontext>(options => options.UseSqlite("connectionstring"));
            } catch (Exception ex) { }
        }
    }
}