using EasyITCenter.Controllers;
using IdentityModel.OidcClient;
using Microsoft.AspNetCore.Http;
using ServerCorePages;
using System.Linq;
using System.Xml.Serialization;

namespace EasyITCenter.ControllersExtensions {

    public class FilePath {
        public string WebRootPath { get; set; }
    }


    /// <summary>
    /// Server Root Controller
    /// </summary>
    [ApiController]
    [Authorize]
    [Route("FileMinifyService")]
    public class FileMinifyService : Controller {

        /// <summary>
        ///  Minifi File And Save As Minify to Min.File
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        [HttpPost("/FileMinifyService/MinifyAndSaveMinToPath"), DisableRequestSizeLimit]
        public async Task<string> MinifyAndSaveMinToPath(FilePath filePath) {
            try {
                string fileContent = null;
                filePath.WebRootPath = filePath.WebRootPath.StartsWith("/") ? filePath.WebRootPath.Substring(1) : filePath.WebRootPath.StartsWith("\\") ? filePath.WebRootPath.Substring(1) : filePath.WebRootPath;

                if (filePath.WebRootPath.ToLower().Split(".").Last() == "js") {
                    fileContent = NUglify.Uglify.Js(FileOperations.ReadTextFile(Path.Combine(SrvRuntime.WebRootPath, filePath.WebRootPath))).Code;
                } else if (filePath.WebRootPath.ToLower().Split(".").Last() == "css") {
                    fileContent = NUglify.Uglify.Css(FileOperations.ReadTextFile(Path.Combine(SrvRuntime.WebRootPath, filePath.WebRootPath))).Code;
                }

                System.IO.File.WriteAllText(Path.Combine(SrvRuntime.WebRootPath, filePath.WebRootPath.ToLower().Contains(".min.") 
                    ? filePath.WebRootPath : filePath.WebRootPath.Replace($".{filePath.WebRootPath.Split(".").Last()}", $".min.{filePath.WebRootPath.Split(".").Last()}"))
                    , fileContent);

                return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.success.ToString(), RecordCount = 1, ErrorMessage = string.Empty });
            } catch (Exception ex) { return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.error.ToString(), RecordCount = 0, ErrorMessage = "error:" + DataOperations.GetUserApiErrMessage(ex) }); }
        }


    }
}