using Microsoft.AspNetCore.Identity;

namespace EasyITCenter.ServerCoreStructure {

    /// <summary>
    /// Server User Management Definition
    /// </summary>
    public class UserManagement {
        public UserManager<ApplicationUser> UserManager { get; set; }
        public SignInManager<ApplicationUser> SignInManager { get; set; }
    }


    /// <summary>
    /// Class Definition for Server Emailer In List of this claas you can use Mass Emailer
    /// </summary>
    public class SendMailRequest {
        public string? Sender { get; set; } = null;
        public List<string>? Recipients { get; set; } = null;
        public string? Subject { get; set; } = null;
        public string? Content { get; set; } = null;
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

    /// <summary>
    /// Server Process class for running external prrocesses
    /// </summary>
    public class RunProcessRequest {
        public string Command { get; set; }
        public string? WorkingDirectory { get; set; } = null;
        public string? Arguments { get; set; } = null;
        public bool WaitForExit = true;
    }


}