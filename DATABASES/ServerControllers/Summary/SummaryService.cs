using EASYTools.Summary;

using Microsoft.AspNetCore.Authentication.OAuth.Claims;

namespace EasyITCenter.Controllers {

    /// <summary>
    /// Server Routing Rulles
    /// </summary>
    [AllowAnonymous]
    [Route("SummaryService")]
    [ApiController]
    //[ApiExplorerSettings(IgnoreApi = true)]
    public class SummaryService : ControllerBase {


        public class SummaryFileRequest {
            public string MdFilesPath { get; set; }
        }


        /// <summary>
        /// Admin Generate Summary file in Path
        /// </summary>
        /// <param name="summaryFileRequest"></param>
        /// <returns></returns>
        [HttpPost("/SummaryService/GenerateSummaryFile")]
        public async Task<IActionResult> GenerateSummaryFile([FromBody] SummaryFileRequest summaryFileRequest) {
            try {

                if (HtttpContextExtension.IsAdmin() || HtttpContextExtension.IsWebAdmin()) {
                    summaryFileRequest.MdFilesPath = summaryFileRequest.MdFilesPath.StartsWith("/") ? summaryFileRequest.MdFilesPath.Substring(1) : summaryFileRequest.MdFilesPath.StartsWith("\\") ? summaryFileRequest.MdFilesPath.Substring(1) : summaryFileRequest.MdFilesPath;

                    GlobalFunctions.CreateSummaryFromPath(Path.Combine(SrvRuntime.WebRootPath, summaryFileRequest.MdFilesPath));
                    return base.Ok(new WebClasses.JsonResult() { Result = String.Empty, Status = DBResult.success.ToString() });
                } else {
                    return base.Ok(new WebClasses.JsonResult() { Result = String.Empty, Status = DBResult.UnauthorizedRequest.ToString() });
                }
            } catch (Exception ex) {
                return base.Ok(new WebClasses.JsonResult() { Result = DataOperations.GetErrMsg(ex), Status = DBResult.error.ToString(), ErrorMessage = DataOperations.GetErrMsg(ex) });
            }
            
        }



        /// <summary>
        /// Generate Sumary file in User Path
        /// </summary>
        /// <param name="summaryFileRequest"></param>
        /// <returns></returns>
        [HttpPost("/SummaryService/GenerateUserSummaryFile")]
        public async Task<IActionResult> GenerateUserSummaryFile([FromBody] SummaryFileRequest summaryFileRequest) {
            try {
                if (HtttpContextExtension.IsLogged()) {
                    summaryFileRequest.MdFilesPath = summaryFileRequest.MdFilesPath.StartsWith("/") ? summaryFileRequest.MdFilesPath.Substring(1) : summaryFileRequest.MdFilesPath.StartsWith("\\") ? summaryFileRequest.MdFilesPath.Substring(1) : summaryFileRequest.MdFilesPath;

                    GlobalFunctions.CreateSummaryFromPath(Path.Combine(SrvRuntime.SrvUserPath, HtttpContextExtension.GetUserName(), summaryFileRequest.MdFilesPath));
                    return base.Ok(new WebClasses.JsonResult() { Result = DBResult.success.ToString(), Status = DBResult.success.ToString() });
                } else { return base.Ok(new WebClasses.JsonResult() { Result = DBResult.UnauthorizedRequest.ToString(), Status = DBResult.UnauthorizedRequest.ToString() }); }
            } catch (Exception ex) {
                return base.Ok(new WebClasses.JsonResult() { Result = DataOperations.GetErrMsg(ex), Status = DBResult.error.ToString(), ErrorMessage = DataOperations.GetErrMsg(ex) });
            }

        }


    }
}