using FubarDev.FtpServer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Quartz;


namespace EasyITCenter.ServerCoreStructure {

    /// <summary>
    /// The server runtime data.
    /// </summary>
    public partial class SrvRuntime {


        public static string SrvStartPath { get; set; } = Path.GetDirectoryName(Environment.CurrentDirectory);
        public static string SrvVersion { get; set; } = Assembly.GetEntryAssembly()?.GetName()?.Version?.ToString();
        public static string StartupPath { get; set; } = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        
        public static string WebRootPath { get; set; } = Path.Combine(SrvRuntime.StartupPath, "wwwroot");


        public static string SrvDocPath { get; set; } = Path.Combine(SrvRuntime.WebRootPath, "server-doc");
        public static string SrvDownloadsPath { get; set; } = Path.Combine(SrvRuntime.WebRootPath, "server-downloads");


        public static string SrvModulesPath { get; set; } = Path.Combine(SrvRuntime.WebRootPath, "server-integrated", "server-modules");
        public static string SrvPrivatePath { get; set; } = Path.Combine(SrvRuntime.WebRootPath, "server-private");


        public static string SrvGenerators_path { get; set; } = Path.Combine(SrvRuntime.WebRootPath, "server-generators");
        public static string SrvLibraryPath { get; set; } = Path.Combine(SrvRuntime.WebRootPath, "server-library");


        public static string SrvPagesWebPath { get; set; } = Path.Combine(SrvRuntime.WebRootPath, "server-PagesWeb");
        public static string SrvPagesHelpPath { get; set; } = Path.Combine(SrvRuntime.WebRootPath, "server-PagesHelp");
        

        public static string SystemAppsPath { get; set; } = Path.Combine(SrvRuntime.WebRootPath, "system-apps");
        public static string SystemPortalPath { get; set; } = Path.Combine(SrvRuntime.WebRootPath, "system-portal");
        public static string ServerPortalPath { get; set; } = Path.Combine(SrvRuntime.WebRootPath, "server-portal");
        

        public static string SrvUserPath { get; set; } = Path.Combine(SrvRuntime.WebRootPath, "server-users");
        public static string SrvUserGuestPath { get; set; } = Path.Combine(SrvRuntime.WebRootPath, "server-users","guest");
        public static string SrvTempPath { get; set; } = Path.Combine(SrvRuntime.WebRootPath, "server-temp", "temp");


        public static string ConfigFile { get; set; } = "config.json";
        public static string OpenApiDescriptionFile { get; set; } = "/swagger/" + Assembly.GetEntryAssembly()?.GetName()?.Version?.ToString() + "/swagger.json";
        public static string DataPath { get; set; } = "Data";
        public static bool DebugMode { get; set; } = "Development" == Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");


        public static List<object> LocalDBTableList = new();
        public static CancellationTokenSource ServerCancelToken = new CancellationTokenSource();
        public static string[] ServerArgs;
        public static string ServerCoreStatus = ServerStatusTypes.Stopped.ToString();
        public static bool SrvRestartReq;
        public static bool FTPSrvStatus;


        public static IFtpServerHost? ServerFTPProvider;
        public static IScheduler? SrvScheduler;
        public static IServiceCollection SrvServices;
        public static IServiceProvider SrvServiceProvider;
        public static IActionDescriptorCollectionProvider ActionRouterProvider;
        public static List<IHostedService> SrvHostedServiceManager = new();


        public static List<Tuple<WebSocket, WebSocketLocation>> CentralWebSocketList = new List<Tuple<WebSocket, WebSocketLocation>>();
        public static List<ActionDescriptor> SrvRegisteredRoutesList;
        public static List<Tuple<int, string, string, Process>> SrvProcessManager = new();


        public static Dictionary<object, object> FileRotatorTool = new();

    }
}