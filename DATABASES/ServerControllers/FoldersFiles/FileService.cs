

namespace EasyITCenter.Controllers {

    /// <summary>
    /// Server Routing Rulles
    /// </summary>
    [AllowAnonymous]
    [Route("FileService")]
    [ApiController]
    //[ApiExplorerSettings(IgnoreApi = true)]
    public class FileService : ControllerBase {


        public class RenameFilesRequest {
            public string SourceFilename { get; set; }
            public string TargetFilename { get; set; }
            public string WebRootPath { get; set; }
            public bool RootDirectoryOnly { get; set; }
        }


        public class ReplaceFileContentRequest {
            public string FileMask { get; set; }
            public string SourceContent { get; set; }
            public string TargetContent { get; set; }
            public string WebRootPath { get; set; }
            public bool RootDirectoryOnly { get; set; }

        }


        /// <summary>
        /// Admin Rename Files In Server Storage
        /// </summary>
        /// <param name="renameFilesRequest"></param>
        /// <returns></returns>
        [HttpPost("/FileService/RenameFiles")]
        public async Task<IActionResult> RenameFiles([FromBody] RenameFilesRequest renameFilesRequest) {
            try {

                if (HtttpContextExtension.IsAdmin() || HtttpContextExtension.IsWebAdmin()) {
                    renameFilesRequest.WebRootPath = renameFilesRequest.WebRootPath.StartsWith("/") ? renameFilesRequest.WebRootPath.Substring(1) : renameFilesRequest.WebRootPath.StartsWith("\\") ? renameFilesRequest.WebRootPath.Substring(1) : renameFilesRequest.WebRootPath;
                    
                    List<string>? sourceFiles = FileOperations.GetPathFiles(Path.Combine(SrvRuntime.WebRootPath, renameFilesRequest.WebRootPath), renameFilesRequest.SourceFilename, renameFilesRequest.RootDirectoryOnly ? SearchOption.TopDirectoryOnly : SearchOption.AllDirectories);
                    sourceFiles.ForEach(file => { 
                            FileOperations.MoveFile(file, Path.Combine(FileOperations.GetDirectoryFromFilePath(file), renameFilesRequest.TargetFilename));
                    });

                    return base.Ok(new WebClasses.JsonResult() { Result = sourceFiles.Count.ToString(), Status = DBResult.success.ToString() });
                } else {
                    return base.Ok(new WebClasses.JsonResult() { Result = String.Empty, Status = DBResult.UnauthorizedRequest.ToString() });
                }
            } catch (Exception ex) {
                return base.Ok(new WebClasses.JsonResult() { Result = DataOperations.GetErrMsg(ex), Status = DBResult.error.ToString(), ErrorMessage = DataOperations.GetErrMsg(ex) });
            }
            
        }


        /// <summary>
        /// Admin Replace Content in Files In Server Storage
        /// </summary>
        /// <param name="renameFilesRequest"></param>
        /// <returns></returns>
        [HttpPost("/FileService/ReplaceFileContent")]
        public async Task<IActionResult> ReplaceFileContent([FromBody] ReplaceFileContentRequest replaceFileContentRequest) {
            try {

                if (HtttpContextExtension.IsAdmin() || HtttpContextExtension.IsWebAdmin()) {
                    replaceFileContentRequest.WebRootPath = replaceFileContentRequest.WebRootPath.StartsWith("/") ? replaceFileContentRequest.WebRootPath.Substring(1) : replaceFileContentRequest.WebRootPath.StartsWith("\\") ? replaceFileContentRequest.WebRootPath.Substring(1) : replaceFileContentRequest.WebRootPath;

                    List<string>? sourceFiles = FileOperations.GetPathFiles(Path.Combine(SrvRuntime.WebRootPath, replaceFileContentRequest.WebRootPath), replaceFileContentRequest.FileMask, replaceFileContentRequest.RootDirectoryOnly ? SearchOption.TopDirectoryOnly : SearchOption.AllDirectories);
                    sourceFiles.ForEach(file => { 
                        string fileContent = FileOperations.ReadTextFile(file);
                        fileContent = fileContent.Replace(replaceFileContentRequest.SourceContent, replaceFileContentRequest.TargetContent);
                        FileOperations.WriteToFile(file, fileContent, true);
                    });

                    return base.Ok(new WebClasses.JsonResult() { Result = sourceFiles.Count.ToString(), Status = DBResult.success.ToString() });
                } else {
                    return base.Ok(new WebClasses.JsonResult() { Result = String.Empty, Status = DBResult.UnauthorizedRequest.ToString() });
                }
            }
            catch (Exception ex) {
                return base.Ok(new WebClasses.JsonResult() { Result = DataOperations.GetErrMsg(ex), Status = DBResult.error.ToString(), ErrorMessage = DataOperations.GetErrMsg(ex) });
            }

        }

    }
}