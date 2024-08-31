using EasyITCenter.ServerCoreStructure;
using Westwind.AspNetCore.Markdown;
using Microsoft.AspNetCore.Mvc.RazorPages;
namespace ServerCorePages {

    /// <summary>
    /// HTML Editor TINYMCE
    /// </summary>
    public class DevPortalModel : PageModel {
        public static ServerWebPagesToken serverWebPagesToken;
        public static string? action;
        public static string result;


        public void OnGet() {


            try {//Standalone Load File From Url Request
                string? requestedUrlPath = "";
                try { requestedUrlPath = ((string?)HttpContext.Items.FirstOrDefault(a => a.Key.ToString() == "FileValidUrl").Value); } catch { }
                string? filePath = System.IO.Path.Combine(ServerRuntimeData.WebRoot_path) + FileOperations.ConvertSystemFilePathFromUrl(requestedUrlPath);
                var fileContent = System.IO.File.ReadAllText(filePath);
                this.Content(fileContent);
                DevPortalModel.result = fileContent.ToString();
            } catch {
              
            }


            //Standalone Check Token
            string? requestToken = HttpContext.Request.Cookies.FirstOrDefault(a => a.Key == "ApiToken").Value;
            if (!string.IsNullOrWhiteSpace(requestToken)) {
                serverWebPagesToken = CoreOperations.CheckTokenValidityFromString(requestToken);
                if (serverWebPagesToken.IsValid) { User.AddIdentities(serverWebPagesToken.UserClaims.Identities); }
            }
            else { serverWebPagesToken = new ServerWebPagesToken(); }
        }

    }
}