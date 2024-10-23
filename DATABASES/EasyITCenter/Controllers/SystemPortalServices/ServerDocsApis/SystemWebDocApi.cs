namespace EasyITCenter.Controllers {

    [ApiController]
    [Route("/WebApi/WebDocumentation")]
     //[ApiExplorerSettings(IgnoreApi = true)]
    public class SystemWebDocApi : ControllerBase {

        /// <summary>
        /// For Webroot folder Update with detect changes and modify static pages
        /// </summary>
        private readonly Microsoft.AspNetCore.Hosting.IWebHostEnvironment _hostingEnvironment;

        public SystemWebDocApi(Microsoft.AspNetCore.Hosting.IWebHostEnvironment hostingEnvironment) {
            _hostingEnvironment = hostingEnvironment;
        }

        /// <summary>
        /// Documentation Code Manager Html Preview Api Startup Viewer
        /// </summary>
        /// <returns></returns>
        [HttpGet("/WebApi/WebDocumentation/MdLibraryPreview/{id}")]
        public IActionResult GetMdLibraryPreview(int id) {
            string data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions {
                IsolationLevel = IsolationLevel.ReadUncommitted
            })) {
                data = new EasyITCenterContext().DocSrvDocumentationCodeLibraryLists.Where(a => a.Id == id).First().MdContent;
            }
            FileOperations.ClearFolder(Path.Combine(_hostingEnvironment.WebRootPath, "server-doc", "md-preview", "data"));
            System.IO.File.WriteAllText(Path.Combine(_hostingEnvironment.WebRootPath, "server-doc", "md-preview", "data", "preview.md"), data, Encoding.UTF8);
            return new RedirectResult("/server-doc/md-preview");
        }


        /// <summary> MD Preview Api file after Saving Its same for Library & Document </summary>
        /// <param name="id">The identifier.</param> <returns></returns>
        [HttpGet("/WebApi/WebDocumentation/MdPreviewFile")]
        public string GetMdPreviewFile(int id) {
            string previewMd = System.IO.File.ReadAllText(Path.Combine(_hostingEnvironment.WebRootPath, "server-doc", "md-preview", "data", "preview.md"));
            return previewMd.ToString();
        }


        /// <summary>
        /// Documentation Code Manager Html Preview Api Startup Viewer
        /// </summary>
        /// <returns></returns>
        [HttpGet("/WebApi/WebDocumentation/MdDocPreview/{id}")]
        public IActionResult GetMdDocumentPreview(int id) {
            string data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions {
                IsolationLevel = IsolationLevel.ReadUncommitted
            })) {
                data = new EasyITCenterContext().DocSrvDocumentationLists.Where(a => a.Id == id).First().MdContent;
            }
            FileOperations.ClearFolder(System.IO.Path.Combine(_hostingEnvironment.WebRootPath, "server-doc", "md-preview", "data"));
            System.IO.File.WriteAllText(System.IO.Path.Combine(_hostingEnvironment.WebRootPath, "server-doc", "md-preview", "data", "preview.md"), data, Encoding.UTF8);
            return new RedirectResult("/server-doc/md-preview");
        }
    }
}