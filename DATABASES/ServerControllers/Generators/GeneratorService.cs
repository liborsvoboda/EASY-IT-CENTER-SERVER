

using FastReport.Utils;
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
                    FileOperations.ClearFolder(Path.Combine(SrvRuntime.SrvUserPath, HttpContextExtension.GetUserName(), "Generators", "Output"));

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
                    string folder = DataOperations.RandomString(20);
                    FileOperations.ClearFolder(Path.Combine(SrvRuntime.SrvUserPath, HttpContextExtension.GetUserName(), "Generators", "Output"));

                    FileOperations.CopyDirectory(Path.Combine(SrvRuntime.SrvGeneratorsPath, "javascript", "md-book"), Path.Combine(SrvRuntime.SrvTempPath, folder));

                    EASYTools.Summary.GlobalFunctions.CreateSummaryFromPath(Path.Combine(SrvRuntime.SrvUserPath, HttpContextExtension.GetUserName(), "Generators", "Input"));
                    FileOperations.CopyDirectory(Path.Combine(SrvRuntime.SrvUserPath, HttpContextExtension.GetUserName(), "Generators", "Input"), Path.Combine(SrvRuntime.SrvTempPath, folder, "src"));

                    RunProcessRequest processRequest = new RunProcessRequest() { 
                        Command = Path.Combine(SrvRuntime.SrvTempPath, folder, "generate-mdbook.bat"), ProcessType = ProcessType.bat, WaitForExit = true,
                        WorkingDirectory = Path.Combine(SrvRuntime.SrvTempPath, folder)
                    };
                    await ProcessOperations.ServerProcessStartAsync(processRequest);
                    
                    FileOperations.CopyDirectory(Path.Combine(SrvRuntime.SrvTempPath, folder, "book"), Path.Combine(SrvRuntime.SrvUserPath, HttpContextExtension.GetUserName(), "Generators", "Output"));
                    FileOperations.DeleteDirectory(Path.Combine(SrvRuntime.SrvTempPath, folder));

                    return base.Ok(new WebClasses.JsonResult() { Result = string.Empty, Status = DBResult.success.ToString() });
                } else {
                    return base.Ok(new WebClasses.JsonResult() { Result = String.Empty, Status = DBResult.UnauthorizedRequest.ToString() });
                }
            } catch (Exception ex) {
                return base.Ok(new WebClasses.JsonResult() { Result = DataOperations.GetErrMsg(ex), Status = DBResult.error.ToString(), ErrorMessage = DataOperations.GetErrMsg(ex) });
            }

        }



        [HttpGet("/GeneratorService/RotateGallery")]
        public async Task<IActionResult> RotateGallery()
        {
            try
            {
                if (HttpContextExtension.IsLogged())
                {
                    string folder = DataOperations.RandomString(20);
                    FileOperations.ClearFolder(Path.Combine(SrvRuntime.SrvUserPath, HttpContextExtension.GetUserName(), "Generators", "Output"));

                    FileOperations.CopyDirectory(Path.Combine(SrvRuntime.SrvGeneratorsPath, "javascript", "rotategallery"), Path.Combine(SrvRuntime.SrvTempPath, folder));
                    FileOperations.CopyDirectory(Path.Combine(SrvRuntime.SrvUserPath, HttpContextExtension.GetUserName(), "Generators", "Input"), Path.Combine(SrvRuntime.SrvTempPath, folder, "images"));

                    List<string> images = FileOperations.GetPathFiles(Path.Combine(SrvRuntime.SrvTempPath, folder, "images"), "*.*", SearchOption.AllDirectories);

                    string htmlContent = string.Empty; int index = 1;
                    images.ForEach(image => {
                        htmlContent += $"<div class=\"item\">\r\n      <img class=\"content\" src=\".{image.Split(folder)[1].Replace(Path.DirectorySeparatorChar, '/')}\"/>\r\n      <div class=\"caption\">{index++}</div>\r\n    </div>";
                    });

                    string fileContent = FileOperations.ReadTextFile(Path.Combine(SrvRuntime.SrvTempPath, folder, "index.html"));
                    fileContent = fileContent.Replace("AUTOCONTENT", htmlContent);
                    FileOperations.WriteToFile(Path.Combine(SrvRuntime.SrvTempPath, folder, "index.html"), fileContent, true);

                    
                    FileOperations.CopyDirectory(Path.Combine(SrvRuntime.SrvTempPath, folder), Path.Combine(SrvRuntime.SrvUserPath, HttpContextExtension.GetUserName(), "Generators", "Output"));
                    FileOperations.DeleteDirectory(Path.Combine(SrvRuntime.SrvTempPath, folder));

                    return base.Ok(new WebClasses.JsonResult() { Result = string.Empty, Status = DBResult.success.ToString() });
                }
                else
                {
                    return base.Ok(new WebClasses.JsonResult() { Result = String.Empty, Status = DBResult.UnauthorizedRequest.ToString() });
                }
            }
            catch (Exception ex)
            {
                return base.Ok(new WebClasses.JsonResult() { Result = DataOperations.GetErrMsg(ex), Status = DBResult.error.ToString(), ErrorMessage = DataOperations.GetErrMsg(ex) });
            }

        }



        /// <summary>
        /// Xml Project File To MarkDown
        /// </summary>
        /// <returns></returns>
        [HttpGet("/GeneratorService/XmlToMarkdown")]
        public async Task<IActionResult> XmlToMarkdown() {
            try {
                if (HttpContextExtension.IsLogged()) {
                    string folder = DataOperations.RandomString(20);
                    FileOperations.ClearFolder(Path.Combine(SrvRuntime.SrvUserPath, HttpContextExtension.GetUserName(), "Generators", "Output"));

                    FileOperations.CopyDirectory(Path.Combine(SrvRuntime.SrvGeneratorsPath, "dotnet", "XmlToMD"), Path.Combine(SrvRuntime.SrvTempPath, folder));
                    List<string> xmlFiles = FileOperations.GetPathFiles(Path.Combine(SrvRuntime.SrvUserPath, HttpContextExtension.GetUserName(), "Generators", "Input"), "*.xml", SearchOption.TopDirectoryOnly);
                    
                    xmlFiles.ForEach(async xmlFile => {
                        FileOperations.CopyFile(xmlFile, Path.Combine(SrvRuntime.SrvTempPath, folder, xmlFile.Split(Path.DirectorySeparatorChar).Last()));
                        RunProcessRequest processRequest = new RunProcessRequest() {
                            Command = Path.Combine(SrvRuntime.SrvTempPath, folder, $"Vsxmd.exe"), ProcessType = ProcessType.exe, 
                            WaitForExit = true, WorkingDirectory = Path.Combine(SrvRuntime.SrvTempPath, folder), Arguments = $" {xmlFile.Split(Path.DirectorySeparatorChar).Last()}"
                        };
                        await ProcessOperations.ServerProcessStartAsync(processRequest);

                        FileOperations.CopyFile(Path.Combine(SrvRuntime.SrvTempPath, folder, xmlFile.Split(Path.DirectorySeparatorChar).Last().Replace(".xml",".md")), Path.Combine(SrvRuntime.SrvUserPath, HttpContextExtension.GetUserName(), "Generators", "Output", xmlFile.Split(Path.DirectorySeparatorChar).Last().Replace(".xml", ".md")));
                    });

                    FileOperations.DeleteDirectory(Path.Combine(SrvRuntime.SrvTempPath, folder));
                    return base.Ok(new WebClasses.JsonResult() { Result = string.Empty, Status = DBResult.success.ToString() });
                } else {
                    return base.Ok(new WebClasses.JsonResult() { Result = String.Empty, Status = DBResult.UnauthorizedRequest.ToString() });
                }
            } catch (Exception ex) {
                return base.Ok(new WebClasses.JsonResult() { Result = DataOperations.GetErrMsg(ex), Status = DBResult.error.ToString(), ErrorMessage = DataOperations.GetErrMsg(ex) });
            }

        }



        /// <summary>
        /// XML Project file to Documentation Web
        /// </summary>
        /// <returns></returns>
        [HttpGet("/GeneratorService/XmlToMdWebDocs")]
        public async Task<IActionResult> XmlToMdWebDocs() {
            try {
                if (HttpContextExtension.IsLogged()) {
                    string folder = DataOperations.RandomString(20);
                    FileOperations.ClearFolder(Path.Combine(SrvRuntime.SrvUserPath, HttpContextExtension.GetUserName(), "Generators", "Output"));

                    FileOperations.CopyDirectory(Path.Combine(SrvRuntime.SrvGeneratorsPath, "dotnet", "XmlToWeb"), Path.Combine(SrvRuntime.SrvTempPath, folder));
                    List<string> xmlFiles = FileOperations.GetPathFiles(Path.Combine(SrvRuntime.SrvUserPath, HttpContextExtension.GetUserName(), "Generators", "Input"), "*.xml", SearchOption.TopDirectoryOnly);

                    xmlFiles.ForEach(xmlFile => {
                        FileOperations.CopyFile(xmlFile, Path.Combine(SrvRuntime.SrvTempPath, folder,"src", xmlFile.Split(Path.DirectorySeparatorChar).Last()));
                    });

                    RunProcessRequest processRequest = new RunProcessRequest() {
                        Command = Path.Combine(SrvRuntime.SrvTempPath, folder, $"HtmlGenerator.bat"),
                        ProcessType = ProcessType.bat, WaitForExit = true, WorkingDirectory = Path.Combine(SrvRuntime.SrvTempPath, folder),
                        Arguments = null
                    };
                    await ProcessOperations.ServerProcessStartAsync(processRequest);

                    FileOperations.CopyDirectory(Path.Combine(SrvRuntime.SrvTempPath, folder, "Root"), Path.Combine(SrvRuntime.SrvUserPath, HttpContextExtension.GetUserName(), "Generators", "Output"));
                    FileOperations.DeleteDirectory(Path.Combine(SrvRuntime.SrvTempPath, folder));
                    return base.Ok(new WebClasses.JsonResult() { Result = string.Empty, Status = DBResult.success.ToString() });
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