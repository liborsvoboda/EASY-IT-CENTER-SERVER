using DataType = System.ComponentModel.DataAnnotations.DataType;

namespace EasyITCenter.WebClasses {

    public enum Color {
        Primary,
        Info,
        Default,
        Warning,
        Danger
    }

    public enum MenuType {
        Header,
        Home,
        Link,
        Tree
    }

    public enum PageAlertType {
        Error,
        Info,
        Warning,
        Success
    }

    public class HandlerResult {
        public bool Success { get; set; }
        public object Result { get; set; }
        public string Message { get; set; }
    }

    /// <summary>
    /// WebApi Responses
    /// </summary>
    public enum DBWebApiResponses {
        emailExist,
        emailNotExist,
        loginInfoSentToEmail
    }

    /// <summary>
    /// Custom Class For Login over Server Web Pages
    /// </summary>
    public class ServerWebPagesLogin {
        public string? Username { get; set; } = null;
        public string? Password { get; set; } = null;

        // public string? Role { get; set; } = null;
    }

    /// <summary>
    /// Server WebPages Communication Token Definition for Security content And Load Allowed Content
    /// </summary>
    public class ServerWebPagesToken {
        public Dictionary<string, string> Data { get; set; }
        public ClaimsPrincipal? UserClaims { get; set; } = null;
        public SecurityToken? Token { get; set; } = null;
        public string? stringToken { get; set; } = null;
        public bool IsValid { get; set; } = false;
        public string userRole { get; set; } = null;
    }

    /// <summary>
    /// WebPages User Verification class
    /// </summary>
    public class EmailVerification {
        public string EmailAddress { get; set; } = null;
        public string Language { get; set; } = null;
    }

    /// <summary>
    /// WebPages User Registration class
    /// </summary>
    public class WebRegistration {
        public string EmailAddress { get; set; } = null;
        public string Password { get; set; } = null;
        public string Language { get; set; } = null;
    }

    public class UserProfile {
        public string EmailAddress { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string? Password { get; set; }
        public string Language { get; set; }
    }

    /// <summary>
    /// Custom Class For UserConfig over Server Web Pages
    /// </summary>
    public class UserConfig {
        public bool UserAutoTranslate { get; set; }
        public bool UserSubscribeNews { get; set; }
    }


    public class WebPrivateMessage {
        public int ParentId { get; set; }
        public string Message { get; set; }
        public string Language { get; set; }
    }

    public class WebDiscussionContribution {
        public int ParentId { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public string Language { get; set; }
    }


    /// <summary>
    /// Custom WebMessage Class For Server Web Pages
    /// </summary>
    public class WebMessage {
        public string Message { get; set; }
    }

    public class WebSettingList1 {
        public List<WebSetting> Settings { get; set; }
    }

    public class WebSetting {
        public string Key { get; set; }
        public string Value { get; set; }
    }

    public class MinifiedFile {
        public string SpecificationType { get; set; }
        public string FileName { get; set; }
        public string FileContent { get; set; }
    }

    public class WebFileList {
        public List<WebFile> WebFile { get; set; }
    }

    public class WebFile {
        public string WebFileName { get; set; }
        public string? WebFileNameFullPath { get; set; }
        public string? WebFileContent { get; set; }
    }


    public class WebSystemLogMessage {
        public string? LogLevel { get; set; }
        public string Message { get; set; }
        public int? UserId { get; set; }
        public string? UserName { get; set; }
        public string? ImageName { get; set; }
        public byte[]? Image { get; set; }
        public string? AttachmentName { get; set; }
        public byte[]? Attachment { get; set; }
    }


    public class SetPasswordInput {
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "New password")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm new password")]
        [Compare("NewPassword", ErrorMessage = "The new password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }

    public class ChangePasswordInput {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Current password")]
        public string OldPassword { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "New password")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm new password")]
        [Compare("NewPassword", ErrorMessage = "The new password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }
}