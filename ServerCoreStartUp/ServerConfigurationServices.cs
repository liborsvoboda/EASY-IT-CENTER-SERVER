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

using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.AspNetCore.Authentication.Facebook;
using Snickler.RSSCore.Extensions;
using FileContextCore;
using Microsoft.AspNetCore.Identity;
using EasyITCenter.ServerCoreDBSettings;
using ServiceAutoRegistration;
using ServiceAutoRegistration.Providers;
using LinqToDB;
using FileContextCore.FileManager;
using FileContextCore.Serializer;
using Microsoft.Extensions.DependencyInjection;
using PuppeteerExtraSharp.Plugins.Recaptcha;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using IdentityModel;
using Korzh.DbUtils;
using Google.Apis.Translate.v3;
using Microsoft.EntityFrameworkCore;
using BaGet;


namespace EasyITCenter.ServerCoreConfiguration {

    /// <summary>
    /// Server Core Configuration Settings of Security, Communications, Technologies, Modules Rules,
    /// Rights, Conditions, Formats, Services, Logging, etc..
    /// </summary>
    public class ServerConfigurationServices {



        internal static void AutoRegisterClassServices(ref IServiceCollection services) {
            /*
            services.AutoRegisterServices(options =>
            {
                options.Namespaces.Scoped = "Managers";
                options.Provider = new ClassRegistrationProvider();
            });
            */

        }








        /// <summary>
        /// Configure AutoMinify Js,Css 
        /// </summary>
        /// <param name="services"></param>
        internal static void ConfigureAutoMinify(ref IServiceCollection services) {
            if (SrvConfig.EnableAutoMinify) {
                services.AddWebOptimizer(cfg => {
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
            if (SrvConfig.ServerFtpEngineEnabled) {
                services.AddFtpServer(
                    builder => {
                        if (!SrvConfig.ServerFtpSecurityEnabled) { 
                            builder.UseDotNetFileSystem().DisableChecks().UseSingleRoot().EnableAnonymousAuthentication(); } else { builder.UseDotNetFileSystem().DisableChecks().UseRootPerUser(); 
                        }
                    });
                services.Configure<FtpServerOptions>(opt => { opt.ServerAddress = "127.0.0.1"; /*opt.Port*/ });
                services.Configure<DotNetFileSystemOptions>(opt => {
                    opt.RootPath = !SrvConfig.ServerFtpSecurityEnabled ? Path.Combine(SrvRuntime.FTPServerPath,"guest") : SrvRuntime.FTPServerPath;
                    opt.AllowNonEmptyDirectoryDelete = true;
                });
                services.AddSingleton<IMembershipProvider, HostedFtpServerMembershipProvider>();
                services.AddHostedService<HostedFtpServer>();

                using (var serviceProvider = services.BuildServiceProvider()) {
                    SrvRuntime.ServerFTPProvider = serviceProvider.GetRequiredService<IFtpServerHost>();
                    SrvRuntime.FTPSrvStatus = true;
                }
            }
        }

        /// <summary>
        /// Server Core: Configure Cookie Politics
        /// </summary>
        /// <param name="services"></param>
        internal static void ConfigureCookie(ref IServiceCollection services) {
            services.ConfigureApplicationCookie(options => {
                // Cookie settings
                options.Cookie.HttpOnly = true;
                options.ExpireTimeSpan = TimeSpan.FromMinutes(5);
                options.LoginPath = "/SrvAdmin/Account/Login";
                options.AccessDeniedPath = "/SrvAdmin/Account/AccessDenied";
                options.SlidingExpiration = true;
            });
            services.Configure<CookiePolicyOptions>(opt => {
                opt.ConsentCookie.Name = SrvConfig.ConfigCoreServerRegisteredName;
                opt.CheckConsentNeeded = context => false;
                opt.MinimumSameSitePolicy = SameSiteMode.Lax;
                opt.Secure = CookieSecurePolicy.Always;
                opt.ConsentCookie.IsEssential = true;
                opt.HttpOnly = Microsoft.AspNetCore.CookiePolicy.HttpOnlyPolicy.Always;
            });
        }

        /// <summary>
        /// Server Core: Configure Server Controllers
        /// options.SuppressImplicitRequiredAttributeForNonNullableReferenceTypes = [ValidateNever]
        /// in Class options.Serialize Settings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore
        /// = [JsonIgnore] in Class
        /// </summary>
        /// <param name="services"></param>
        internal static void ConfigureControllers(ref IServiceCollection services) {
            
            services.AddRouting(options => { options.LowercaseUrls = true;options.LowercaseQueryStrings = true; });

            services.AddControllersWithViews(options => {
                //if (ServerConfigSettings.ConfigServerStartupOnHttps) { options.Filters.Add(new RequireHttpsAttribute()); }
                options.SuppressImplicitRequiredAttributeForNonNullableReferenceTypes = true;
                options.EnableEndpointRouting = true;
            }).AddNewtonsoftJson(options => {
                options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                options.SerializerSettings.ContractResolver = new DefaultContractResolver();
                options.SerializerSettings.Formatting = Formatting.Indented;
            }).AddJsonOptions(x => {
                //x.JsonSerialize Options.PropertyNameCaseInsensitive = true;
                x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
                x.JsonSerializerOptions.WriteIndented = true;
                x.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
                //x.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
            });
        }

        /// <summary>
        /// Server Core: Configure Server Logging
        /// </summary>
        /// <param name="services"></param>
        internal static void ConfigureLogging(ref IServiceCollection services) {
            if (SrvRuntime.DebugMode) {
                services.AddLogging(builder => {
                    builder.AddConsole().AddDebug().SetMinimumLevel(LogLevel.Debug)
                    .AddFilter<ConsoleLoggerProvider>(category: null, level: LogLevel.Debug)
                    .AddFilter<DebugLoggerProvider>(category: null, level: LogLevel.Debug);
                });
            }
            services.AddHttpLogging(logging => {
                logging.LoggingFields = HttpLoggingFields.All;
                logging.RequestHeaders.Add("sec-ch-ua"); 
                logging.ResponseHeaders.Add("RequestJsonFormatNotCorrectly");
                logging.MediaTypeOptions.AddText("application/javascript");
                logging.RequestBodyLogLimit = logging.ResponseBodyLogLimit = 4096;
            });
        }


        /// <summary>
        /// Configures the MVC server pages on Server format "cshtml"
        /// </summary>
        /// <param name="services">The services.</param>
        internal static void ConfigureServerWebPages(ref IServiceCollection services) {
            if (SrvConfig.WebRazorPagesEngineEnabled) {
                if (SrvConfig.WebRazorPagesCompileOnRuntime) {
                    services.AddMvc(options => {
                        options.CacheProfiles.Add("Default30", new CacheProfile() { Duration = 30 });
                        options.AllowEmptyInputInBodyModelBinding = true;

                    }).AddRazorPagesOptions(opt => {
                        opt.RootDirectory = "/ServerCorePages";

                        //options.Conventions.AuthorizeFolder("/Account/Manage");
                        //options.Conventions.AuthorizePage("/Account/Logout");
                        //opt.Conventions.AuthorizeFolder($"/{ServerRuntimeData.ServerPrivate_path}");
                        //opt.Conventions.AuthorizeFolder($"/{ServerRuntimeData.ServerAdmin_path}");

                        /*
                        opt.Conventions.AllowAnonymousToPage("/DevPortal/Error");
                        */

                        //TODO SEMDAT TY MODULY
                        //options.Conventions.Add(new GlobalTemplatePageRouteModelConvention());
                        //options.Conventions.AddFolderRouteModelConvention("/OtherPages", model => model.add())


                        //https://github.com/dotnet/AspNetCore.Docs/blob/main/aspnetcore/razor-pages/razor-pages-conventions/samples/6.x/SampleApp/Program.cs
                        //https://learn.microsoft.com/en-us/aspnet/core/mvc/views/view-components?view=aspnetcore-3.1 FULL DOC
                        //options.Conventions.Add(new GlobalTemplatePageRouteModelConvention());
                        //VYPADA TO, ZE CONVENTION Obohati vsechny stranky na urovni modelu
                        // options.Conventions.AddPageRoute("/Contact", "TheContactPage/{text?}"); stranka

                    }).AddRazorRuntimeCompilation();
                    //.AddControllersAsServices(); PROBLEM WITH GIT
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

            if (SrvConfig.WebMvcPagesEngineEnabled) {
                if (SrvConfig.WebRazorPagesCompileOnRuntime) {
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
            if (SrvConfig.ConfigServerGetLetsEncrypt) {
                services.AddLettuceEncrypt(option => {
                    List<string> domainList = SrvConfig.ConfigCertificateDomain.Contains(',')
                    ? SrvConfig.ConfigCertificateDomain.Split(',').ToList()
                    : SrvConfig.ConfigCertificateDomain.Split(';').ToList();

                    domainList.ForEach(domain => { if (string.IsNullOrWhiteSpace(domain)) domainList.Remove(domain); });
                    option.DomainNames = domainList.ToArray();
                    option.EmailAddress = SrvConfig.EmailerServiceEmailAddress;
                    option.AcceptTermsOfService = true;
                    option.RenewDaysInAdvance = new TimeSpan(10, 0, 0, 0);
                    option.RenewalCheckPeriod = new TimeSpan(1, 0, 0, 0);
                }).PersistDataToDirectory(new DirectoryInfo(System.IO.Path.Combine(SrvRuntime.Startup_path, SrvRuntime.DataPath)), SrvConfig.ConfigCertificatePassword);
            }
        }


        internal static void ConfigureRssFeed(ref IServiceCollection services) {
            if (SrvConfig.WebRSSFeedsEnabled) { services.AddRSSFeed<SomeRSSProvider>(); }
        }

        /// <summary>
        /// Server core: Configures the WebSocket logger monitor. 
        /// For multi monitoring and for
        /// Example Possibilities
        /// </summary>
        /// <param name="services">The services.</param>
        internal static void ConfigureWebSocketLoggerMonitor(ref IServiceCollection services) {
            if (SrvConfig.WebSocketServerMonitorEnabled) { services.AddSingleton<ILoggerProvider, ServerWebSockeMonitorService>(); }
        }

        /// <summary>
        /// Server Core: Configure Clients for work with third party API
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
        /// Server Core: Configures the singletons. 
        /// Its Register Custom Listeners For Actions
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
            services.AddScoped<StaticFileDbService>();
            services.AddScoped<TranslateService>();
        }

        /// <summary>
        /// Server Core: Configure Hosted Service to Runtime Core For Access to Root Functionalities
        /// </summary>
        /// <param name="services"></param>
        internal static void ConfigureServerManagement(ref IServiceCollection services) {
            SrvRuntime.SrvServiceProvider = services.BuildServiceProvider();
            SrvRuntime.SrvServices = services;
        }

        /// <summary>
        /// Server Core: Configure Custom Services
        /// </summary>
        /// <param name="services"></param>
        internal static void ConfigureDatabaseContext(ref IServiceCollection services) {
            if (SrvRuntime.DebugMode) { services.AddDatabaseDeveloperPageExceptionFilter(); }
            try {
                //EIC&ESB MAIN DB
                services.AddDbContext<EasyITCenterContext>(opt => opt.UseSqlServer(SrvConfig.DatabaseConnectionString).UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking));

                //WEBHOSTING DB
                // Database File Example
                // services.AddDbContext<WebHostingDbContext>(
                //opt =>opt.UseFileContextDatabase<JSONSerializer, DefaultFileManager>(databaseName: "EICwebHosting", location: Path.Combine(ServerRuntimeData.WebRoot_path, FileOperations.GetLastFolderFromPath(ServerRuntimeData.ServerPrivate_path), "databases", "EICwebHosting.mdf"), password: "EICwebHOSTING"));
                //context.Database.Migrate();

            } catch (Exception ex) { }
        }


        /// <summary>
        /// Server Core: Configure Server Authentication Support
        /// Default Basic/JWT Authentication /Expiration BY 
        /// Main EasyITCenter Database
        /// </summary>
        /// <param name="services"></param>
        internal static void ConfigureDefaultAuthentication(ref IServiceCollection services) {

            if (!SrvConfig.EnableIdentityServer) {
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
                    if (SrvConfig.ConfigTimeTokenValidationEnabled) { x.TokenValidationParameters.LifetimeValidator = EasyITCenterAuthenticationApi.TokenLifetimeValidator; }
                    x.Events = new JwtBearerEvents {
                        OnAuthenticationFailed = context => {
                            if (context.Exception.GetType() == typeof(SecurityTokenExpiredException)) {
                                context.Response.Headers.Add("IS-TOKEN-EXPIRED", "true");
                            }
                            return Task.CompletedTask;
                        }
                    };
                });
            }
        }

        /// <summary>
        /// Configure Identity Server Management
        /// </summary>
        /// <param name="services"></param>
        internal static void ConfigureIdentityServer(ref IServiceCollection services) {
            if (SrvConfig.EnableIdentityServer) {
                /*
                services.AddIdentityServer(options => { options.UserInteraction.LoginUrl = "";})
                .AddCoreServices().AddInMemoryApiResources(new List<IdentityServer4.Models.ApiResource>())
                .AddInMemoryClients(new List<IdentityServer4.Models.Client>())
                .AddInMemoryCaching().AddResponseGenerators().AddValidators();
                */

                    //.AddUserStore<ApplicationUser>()
                    //.AddInMemoryIdentityResources(new List<IdentityServer4.Models.IdentityResource>())
                //.AddInMemoryApiResources(new List<IdentityServer4.Models.ApiResource>())
                //.AddInMemoryClients(new List<IdentityServer4.Models.Client>())
                //.AddInMemoryApiScopes(new List<IdentityServer4.Models.ApiScope>())
                //.AddCoreServices().AddInMemoryPersistedGrants()//.AddPluggableServices()
                //.AddJwtBearerClientAuthentication().AddCookieAuthentication()
                //.AddResponseGenerators().AddDeveloperSigningCredential();
                
                services.Configure<IdentityOptions>(options => {
                    options.Password.RequireDigit = true;
                    options.Password.RequireLowercase = true;
                    options.Password.RequireNonAlphanumeric = true;
                    options.Password.RequireUppercase = true;
                    options.Password.RequiredLength = 6;
                    options.Password.RequiredUniqueChars = 1;
                    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                    options.Lockout.MaxFailedAccessAttempts = 5;
                    options.Lockout.AllowedForNewUsers = true;
                    options.User.AllowedUserNameCharacters =
                    "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
                    options.User.RequireUniqueEmail = true;
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
        }
    }
}