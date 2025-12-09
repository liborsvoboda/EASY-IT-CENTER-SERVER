using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing.Template;
using System.Data.Entity.Core.Metadata.Edm;
using System.Net.Http;
using System.Net.Http.Headers;

namespace EasyITCenter.Controllers {

    [Authorize]
    [ApiController]
    [Route("ServerDocsService")]
     //[ApiExplorerSettings(IgnoreApi = true)]
    public class ServerDocApi : ControllerBase {

        private readonly Microsoft.AspNetCore.Hosting.IWebHostEnvironment _hostingEnvironment;

        public ServerDocApi(Microsoft.AspNetCore.Hosting.IWebHostEnvironment hostingEnvironment) {
            _hostingEnvironment = hostingEnvironment;
        }

        /// <summary>
        /// Server Inteligent Documentation Generator Api StratupPath is WebFolder On Development is
        /// need WebRootPath WegbRootPath is Development Folder
        /// </summary>
        [HttpGet("/ServerDocsService/GenerateMdBook")]
        public async Task<string> GenerateMdBook() {
            try {
                    List<DocSrvDocTemplateList> templates; List<DocSrvDocumentationList> data;
                    FileOperations.CreatePath(Path.Combine(SrvRuntime.ServerDocPath, "md-book", "src"), true); 
                   
                    using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions { IsolationLevel = IsolationLevel.ReadUncommitted })) {
                        data = new EasyITCenterContext().DocSrvDocumentationLists.Where(a => a.DocumentationGroup.Active && a.Active)
                        .Include(a => a.DocumentationGroup).OrderBy(a => a.DocumentationGroup.Sequence)
                           .ThenBy(a => a.Sequence).ThenBy(a => a.Name).ToList();
                    }

                    string lastDocGroup = "", summary = "" + Environment.NewLine, docDescription = "";
                    if (data.Any()) {

                        data.ForEach(documentation => {
                            if (lastDocGroup != documentation.DocumentationGroup.Name) {
                                if (lastDocGroup != "") { summary += "    ```  " + Environment.NewLine + Environment.NewLine + "---" + Environment.NewLine; }
                                summary += "# " + documentation.DocumentationGroup.Name + "  " + Environment.NewLine + Environment.NewLine + "    ```markdown  " + Environment.NewLine; lastDocGroup = documentation.DocumentationGroup.Name;
                            }

                            summary += "- [" + "Ver." + documentation.AutoVersion + ": " + documentation.Name + "](" + DataOperations.RemoveWhitespace(documentation.Name) + ".md" + ")   " + Environment.NewLine;

                            docDescription = "# Úvod   " + documentation.DocumentationGroup.Name + "  " + Environment.NewLine + Environment.NewLine + documentation.DocumentationGroup.Description + Environment.NewLine + documentation.Description + Environment.NewLine + Environment.NewLine;
                            
                            System.IO.File.WriteAllText(Path.Combine(SrvRuntime.ServerDocPath,  "md-book", "src", DataOperations.RemoveWhitespace(documentation.Name) + ".md"), docDescription + documentation.MdContent, Encoding.UTF8);
                        }); summary += "    ```  " + Environment.NewLine + Environment.NewLine + "---" + Environment.NewLine;

                        System.IO.File.WriteAllText(Path.Combine(SrvRuntime.ServerDocPath, "md-book", "src", "SUMMARY.md"), summary, Encoding.UTF8);

                        RunProcessRequest process = new RunProcessRequest();
                        if (CoreOperations.SrvOStype.IsWindows()) {
                            process = new RunProcessRequest() {
                                Command = Path.Combine(SrvRuntime.ServerDocPath, "md-book", "generate-mdbook.cmd"),
                                WorkingDirectory = Path.Combine(SrvRuntime.ServerDocPath, "md-book"),
                                ProcessType = ProcessType.cmd,
                            };
                        } else {
                            process = new RunProcessRequest() {
                                Command = Path.Combine(SrvRuntime.ServerDocPath, "md-book", "generate-mdbook.sh"),
                                WorkingDirectory = Path.Combine(SrvRuntime.ServerDocPath, "md-book"),
                                ProcessType = ProcessType.sh,
                            };
                        }
                    ProcessOperations.ServerProcessStartAsync(process);
                    }
                
                return JsonSerializer.Serialize(new ResultMessage() { InsertedId = 0, Status = DBResult.success.ToString(), RecordCount = 1, ErrorMessage = string.Empty });
            } catch (Exception ex) { return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.error.ToString(), RecordCount = 0, ErrorMessage = DataOperations.GetUserApiErrMessage(ex) }); }
        }
    }
}