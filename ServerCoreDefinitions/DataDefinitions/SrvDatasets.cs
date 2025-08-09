using Microsoft.AspNetCore.Identity;

namespace EasyITCenter.ServerCoreStructure {

    /// <summary>
    /// Database Connection string
    /// </summary>
    public partial class DBConn {
        /// <summary>
        /// Server Database Connection string for Full Service of Database
        /// Migration/Api/Check/Unlimited Develop !!!Warning: Check this connection for
        /// Read/Write/Exec is enabled In Config File Must Be Only This Paramneter
        /// </summary>
        public static string DatabaseConnectionString { get; set; } = "Server=127.0.0.1;Database=EasyITCenter;Trusted_Connection=True;TrustServerCertificate=True";

        /// <summary>
        /// Enable Disable Entity Framework Internal Cache I recommend turning it off : from Logic,
        /// Duplicit Functionality with Database Server in complex process can generate problems
        /// Recommended: false
        /// </summary>
        public static bool DatabaseInternalCachingEnabled { get; set; } = false;

        /// <summary>
        /// Time in Minutes for Database Valid Cache Data and Refreshing Duplicit Functionality with
        /// Database Server
        /// Recommended: 30
        /// </summary>
        public static int DatabaseInternalCacheTimeoutMin { get; set; } = 30;


        /// <summary>
        /// Enable Disable Database Migration Process on Starrtup
        /// 
        /// </summary>
        public static bool DatabaseMigrationEnabled { get; set; } = true;

        /// <summary>
        /// Enable Logging Server Warn and Errors To Database
        /// </summary>
        public static bool DatabaseLogWarnToDbEnabled { get; set; } = false;
    }

    /// <summary>
    /// License Server Data Format
    /// </summary>
    public partial class LicenseCheckRequest {
        public string UnlockCode { get; set; } = string.Empty;
        public string PartNumber { get; set; } = string.Empty;
    }


    /// <summary>
    /// WebSocket Extension Definition For Simple Central Control All Connection By Connection Path
    /// and Timeout
    /// </summary>
    public class WebSocketLocation {
        public string? socketAPIPath { get; set; }
        public DateTimeOffset? SocketTimeout { get; set; }
    }




}