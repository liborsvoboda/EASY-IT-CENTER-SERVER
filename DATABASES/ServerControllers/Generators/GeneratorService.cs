

using XmlDocMarkdown.Core;
using static TorchSharp.torch;

namespace EasyITCenter.Controllers {

    /// <summary>
    /// Server Routing Rulles
    /// </summary>
    [AllowAnonymous]
    [Route("GeneratorService")]
    [ApiController]
    //[ApiExplorerSettings(IgnoreApi = true)]
    public class GeneratorService : ControllerBase {



        public class XmlToMdWebDocsRequest {
            public string DllFilename { get; set; }
        }


        /// <summary>
        /// Generate MD Doc from Dll
        /// InputPath is Dll FilenamePath, Output Path For Export
        /// </summary>
        /// <param name="xmlToMdWebDocsRequest"></param>
        /// <returns></returns>
        [HttpPost("/GeneratorService/XmlToMdWebDocs")]
        public async Task<IActionResult> XmlToMdWebDocs([FromBody] XmlToMdWebDocsRequest xmlToMdWebDocsRequest) {
            try {

                if (HttpContextExtension.IsLogged()) {
                    XmlDocMarkdownGenerator.Generate(Path.Combine(SrvRuntime.SrvUserPath, HttpContextExtension.GetUserName(), "Generators", "Input", xmlToMdWebDocsRequest.DllFilename), Path.Combine(SrvRuntime.SrvUserPath, HttpContextExtension.GetUserName(), "Generators", "Output"),
                        new XmlDocMarkdownSettings() { GenerateToc = true, IncludeObsolete = true, VisibilityLevel = XmlDocVisibilityLevel.Private }
                        );

                    FileOperations.CopyFile(Path.Combine(SrvRuntime.SrvUserPath, HttpContextExtension.GetUserName(), "Generators", "Output", xmlToMdWebDocsRequest.DllFilename.ToLower().Replace(".dll", ".md")), Path.Combine(SrvRuntime.SrvUserPath, HttpContextExtension.GetUserName(), "Generators", "Output", "index.md"));
                    FileOperations.CopyDirectory(Path.Combine(SrvRuntime.SrvGeneratorsPath, "javascript", "md-browser"), Path.Combine(SrvRuntime.SrvUserPath, HttpContextExtension.GetUserName(), "Generators", "Output"));

                    return base.Ok(new WebClasses.JsonResult() { Result = string.Empty, Status = DBResult.success.ToString() });
                } else {
                    return base.Ok(new WebClasses.JsonResult() { Result = String.Empty, Status = DBResult.UnauthorizedRequest.ToString() });
                }
            } catch (Exception ex) {
                return base.Ok(new WebClasses.JsonResult() { Result = DataOperations.GetErrMsg(ex), Status = DBResult.error.ToString(), ErrorMessage = DataOperations.GetErrMsg(ex) });
            }
        }
            
       



        /// <summary>
        /// Md Files To Web Book
        /// </summary>
        /// <returns></returns>
        [HttpGet("/GeneratorService/MdFilesToWebBook")]
        public async Task<IActionResult> MdFilesToWebBook() {
            try {
                if (HttpContextExtension.IsLogged()) {

                    FileOperations.DeleteDirectory(Path.Combine(SrvRuntime.SrvTempPath, "MdBook"));
                    FileOperations.CopyDirectory(Path.Combine(SrvRuntime.SrvGeneratorsPath, "javascript", "md-book"), Path.Combine(SrvRuntime.SrvTempPath, "MdBook"));

                    EASYTools.Summary.GlobalFunctions.CreateSummaryFromPath(Path.Combine(SrvRuntime.SrvUserPath, HttpContextExtension.GetUserName(), "Generators", "Input"));
                    FileOperations.CopyDirectory(Path.Combine(SrvRuntime.SrvUserPath, HttpContextExtension.GetUserName(), "Generators", "Input"), Path.Combine(SrvRuntime.SrvTempPath, "MdBook", "src"));

                    RunProcessRequest processRequest = new RunProcessRequest() { 
                        Command = Path.Combine(SrvRuntime.SrvTempPath, "MdBook", "generate-mdbook.bat"), ProcessType = ProcessType.bat, WaitForExit = true,
                        WorkingDirectory = Path.Combine(SrvRuntime.SrvTempPath, "MdBook")
                    };
                    await ProcessOperations.ServerProcessStartAsync(processRequest);

                    FileOperations.CopyDirectory(Path.Combine(SrvRuntime.SrvTempPath, "MdBook", "book"), Path.Combine(SrvRuntime.SrvUserPath, HttpContextExtension.GetUserName(), "Generators", "Output"));
                    FileOperations.DeleteDirectory(Path.Combine(SrvRuntime.SrvTempPath, "MdBook"));

                    return base.Ok(new WebClasses.JsonResult() { Result = string.Empty, Status = DBResult.success.ToString() });
                } else {
                    return base.Ok(new WebClasses.JsonResult() { Result = String.Empty, Status = DBResult.UnauthorizedRequest.ToString() });
                }
            } catch (Exception ex) {
                return base.Ok(new WebClasses.JsonResult() { Result = DataOperations.GetErrMsg(ex), Status = DBResult.error.ToString(), ErrorMessage = DataOperations.GetErrMsg(ex) });
            }

        }

    }
}