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


        /// <summary>
        /// Server Startup Path
        /// </summary>
        public static string SrvStartPath { get; set; } = Path.GetDirectoryName(Environment.CurrentDirectory);


        /// <summary>
        /// Server Version
        /// </summary>
        public static string SrvVer { get; set; } = Assembly.GetEntryAssembly()?.GetName()?.Version?.ToString();

        /// <summary>
        /// Gets or Sets the startup_path.
        /// </summary>
        public static string Startup_path { get; set; } = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

        /// <summary>
        /// Gets or Sets the setting_folder.
        /// </summary>
        public static string Setting_folder { get; set; } = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), Assembly.GetEntryAssembly().GetName().FullName.Split(',')[0]);

        /// <summary>
        /// Gets or Sets the startup_path.
        /// </summary>
        public static string WebRoot_path { get; set; } = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "wwwroot");




        public static string SrvAdmin_path { get; set; } = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "wwwroot", "server-admin");
        public static string SrvPrivate_path { get; set; } = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "wwwroot", "server-private");
        public static string SrvIntegrated_path { get; set; } = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "wwwroot", "server-Integrated");
        public static string SrvGenerators_path { get; set; } = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "wwwroot", "server-Generators");
        public static string SrvWebPagesPath { get; set; } = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "wwwroot", "server-PagesWeb");
        public static string SrvHelpPagesPath { get; set; } = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "wwwroot", "server-PagesHelp");
        public static string SysPortalPath { get; set; } = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "wwwroot", "system-Portal");
        public static string SrvSharedPath { get; set; } = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "wwwroot", "server-shared");
        public static string SrvTemplatesPath { get; set; } = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "wwwroot", "server-Templates");

        public static string SrvOtherLanguagesPath { get; set; } = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "wwwroot", "server-otherlangs");


        /// <summary>
        /// Users Storages Path
        /// </summary>
        public static string UserPath { get; set; } = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "wwwroot", "server-users");

        /// <summary>
        /// GIT SubServer Path Definition
        /// </summary>
        public static string GitServerPath { get; set; } = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "wwwroot", "server-users");

        /// <summary>
        /// FTP SubServer Path Definition
        /// </summary>
        public static string FTPServerPath { get; set; } = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "wwwroot", "server-users");


        /// <summary>
        /// Gets or Sets the configure file.
        /// </summary>
        public static string ConfigFile { get; set; } = "config.json";


        /// <summary>
        /// OpenApi Online API Description And API Testing
        /// </summary>
        public static string OpenApiDescriptionFile { get; set; } = "/swagger/" + Assembly.GetEntryAssembly()?.GetName()?.Version?.ToString() + "/swagger.json";

        /// <summary>
        /// Gets or Sets the data path.
        /// </summary>
        public static string DataPath { get; set; } = "Data";

        /// <summary>
        /// Gets or Sets the debug mode.
        /// </summary>
        public static bool DebugMode { get; set; } = "Development" == Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

        /// <summary>
        /// The local db table list.
        /// </summary>
        public static List<object> LocalDBTableList = new();

        /// <summary>
        /// Cancellation Token for Server Remote Control
        /// </summary>
        public static CancellationTokenSource ServerCancelToken = new CancellationTokenSource();

        /// <summary>
        /// Server Starup Args
        /// </summary>
        public static string[] ServerArgs;

        /// <summary>
        /// Server Core Status
        /// </summary>
        public static string ServerCoreStatus = ServerStatusTypes.Stopped.ToString();

        /// <summary>
        /// Server Restart Request Indicator
        /// </summary>
        public static bool SrvRestartReq;

        /// <summary>
        /// Server FTP Status 
        /// </summary>
        public static bool FTPSrvStatus;

        /// <summary>
        /// Server FTP Provider for Remote Control
        /// </summary>
        public static IFtpServerHost? ServerFTPProvider;

        /// <summary>
        /// Scheduler Server Controller For Manage
        /// </summary>
        public static IScheduler? SrvScheduler;

        /// <summary>
        /// Registered Server Services
        /// </summary>
        public static IServiceCollection SrvServices;

        /// <summary>
        /// Central List With references on Hosted Server Services For Access and Using Hosted
        /// Functionalities for example: Start/Stop Service And More Other sub services for Optimal Hosting
        /// </summary>
        public static IServiceProvider SrvServiceProvider;


        /// <summary>
        /// Registered routers Control
        /// </summary>
        public static IActionDescriptorCollectionProvider ActionRouterProvider;



        /// <summary>
        /// Server Hosted Services Manager
        /// </summary>
        public static List<IHostedService> SrvHostedServiceManager = new();


        /// <summary>
        /// Central WebSocket List for Easy one place Using
        /// </summary>
        public static List<Tuple<WebSocket, WebSocketLocation>> CentralWebSocketList = new List<Tuple<WebSocket, WebSocketLocation>>();

        /// <summary>
        /// ServerCore FilesLibrary For Rotator
        /// TODO Clean
        /// </summary>
        public static Dictionary<object, object> FileRotatorTool = new();

        /// <summary>
        /// Registered Routes List Update 
        /// </summary>
        public static List<ActionDescriptor> SrvRegisteredRoutesList;


        /// <summary>
        /// Server Process Manager
        /// Pid, ProcessName, Description, Process
        /// </summary>
        public static List<Tuple<int,string,string,Process>> SrvProcessManager = new ();

        /// <summary>
        /// Connected Databases Contexts For 
        /// Central Point Using
        /// </summary>
        //public static List<object> ConnectedDatabases = new List<object>();

        //Generic Complicated Example
        //public static List<Tuple<string, T>>? ServerHostedServicesContollerList = new List<Tuple<string, T>>();
    }
}