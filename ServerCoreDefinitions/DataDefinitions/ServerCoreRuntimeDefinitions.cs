/*
* Server Core Definitions and extensions
* for optimal running in One clean code structure
*/

using FubarDev.FtpServer;
using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Quartz;

namespace EasyITCenter.ServerCoreStructure {

    /// <summary>
    /// The server runtime data.
    /// </summary>
    public partial class ServerRuntimeData {




        /// <summary>
        /// Gets or Sets Project Root Directory.
        /// </summary>
        public static string ContentRootPath { get; set; } = Path.GetDirectoryName(Environment.CurrentDirectory);



        public static string ServerVerion { get; set; } = Assembly.GetEntryAssembly()?.GetName()?.Version?.ToString();

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
        public static string WebRoot_path { get; set; } = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), ServerConfigSettings.DefaultStaticWebFilesFolder);


        /// <summary>
        /// Server WebPages Path for Generated Web Pages.
        /// </summary>
        public static string ServerWeb_path { get; set; } = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), ServerConfigSettings.DefaultStaticWebFilesFolder, "server-webpages");

        /// <summary>
        /// Server Integrated Web Tools Path.
        /// Tools are Programatically Used
        /// </summary>
        public static string ServerIntegrated_path { get; set; } = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), ServerConfigSettings.DefaultStaticWebFilesFolder, "server-integrated");


        /// <summary>
        /// Server Path for Generators
        /// </summary>
        public static string ServerGenerators_path { get; set; } = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), ServerConfigSettings.DefaultStaticWebFilesFolder, "server-generator");


        /// <summary>
        /// Server Path for Generators
        /// </summary>
        public static string SystemWebPortal_path { get; set; } = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), ServerConfigSettings.DefaultStaticWebFilesFolder, "system-portal");



        /// <summary>
        /// Users Storages Path
        /// </summary>
        public static string UserPath { get; set; } = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), ServerConfigSettings.DefaultStaticWebFilesFolder, "server-users");

        /// <summary>
        /// GITsubServer Path Definition
        /// </summary>
        public static string GitServerPath { get; set; } = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), ServerConfigSettings.DefaultStaticWebFilesFolder, "server-users");

        /// <summary>
        /// FTPsubServer Path Definition
        /// </summary>
        public static string FTPServerPath { get; set; } = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), ServerConfigSettings.DefaultStaticWebFilesFolder, "server-users");


        /// <summary>
        /// Software Disctribution Path
        /// </summary>
        public static string DistributedPackagesPath { get; set; } = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), ServerConfigSettings.DefaultStaticWebFilesFolder, "server-distribution", "GeneratorsLibrary");



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
        public static bool ServerRestartRequest;

        /// <summary>
        /// Server Securited FTP Provider RunningStatus
        /// </summary>
        public static bool ServerFTPRunningStatus;

        /// <summary>
        /// Server Securited FTP Provider for Remote Control
        /// </summary>
        public static IFtpServerHost? ServerFTPProvider;

        /// <summary>
        /// Server Securited FTP Provider for Remote Control
        /// </summary>
        public static IScheduler? ServerAutoSchedulerProvider;


        /// <summary>
        /// Central WebSocket List for Easy one place Using
        /// </summary>
        public static List<Tuple<WebSocket, WebSocketLocation>> CentralWebSocketList = new List<Tuple<WebSocket, WebSocketLocation>>();

        /// <summary>
        /// Central List With references on Hested Server Sevices For Acess and Using Hosted
        /// Functionalities for example: Start/Stop Service And More Other sub services for Optimal Hosting
        /// </summary>
        public static IServiceProvider ServerServiceProvider;

        /// <summary>
        /// SercerCore FilesLibrary For Rotator
        /// TODO Clean
        /// </summary>
        public static Dictionary<object,object> FileRotatorRuntineLibrary = new();

        /// <summary>
        /// Registered routers Control
        /// </summary>
        public static IActionDescriptorCollectionProvider ActionRouterProvider;


        /// <summary>
        /// Registered Routes List Update 
        /// Over 
        /// </summary>
        public static List<ActionDescriptor> ServerRegisteredRoutesList;

        //Generic Complicated Example
        //public static List<Tuple<string, T>>? ServerHostedServicesContollerList = new List<Tuple<string, T>>();
    }
}