using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;


namespace EasyITCenter.Controllers {


    public class FancyTreeJsonDataRequest
    {
        public string WebRootPath { get; set; }
        public string FileMask { get; set; }
        public bool RootDirectoryOnly { get; set; }
    }

    public class FancyTreeJsonData
    {
        public string title { get; set; }
        public bool folder { get; set; }
        public bool checkbox { get; set; }
        public string key { get; set; }
    }

    [AllowAnonymous]
    [Route("/JsonGeneratorService")]
    public class JsonGeneratorService : Controller {

        private readonly Microsoft.AspNetCore.Hosting.IWebHostEnvironment _hostingEnvironment;
        public JsonGeneratorService(Microsoft.AspNetCore.Hosting.IWebHostEnvironment hostingEnvironment) {
            _hostingEnvironment = hostingEnvironment;
        }




        /// <summary>
        /// Must set path with path\\path or path/path
        /// FileMask *.*, *.html, index.html
        /// </summary>
        /// <param name="jsonDataRequest"></param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpPost("/JsonGeneratorService/GetFancyTreeJsonData")]
        [Consumes("application/json")]
        public async Task<IActionResult> GetFancyTreeJsonData([FromBody] FancyTreeJsonDataRequest jsonDataRequest) {
            try {
                List<string>? loadFiles = null; List<FancyTreeJsonData> result = new();
                loadFiles = FileOperations.GetPathFiles(Path.Combine(SrvRuntime.Startup_path, DbOperations.GetServerParameterLists("DefaultStaticWebFilesFolder").Value, jsonDataRequest.WebRootPath), $"{jsonDataRequest.FileMask}", jsonDataRequest.RootDirectoryOnly ? SearchOption.TopDirectoryOnly : SearchOption.AllDirectories);

                loadFiles.ForEach(htmlFile => { 
                    result.Add(new FancyTreeJsonData() { title = Path.GetFileName(htmlFile).ToLower() == "index.html" ? htmlFile.Split(Path.DirectorySeparatorChar.ToString())[htmlFile.Split(Path.DirectorySeparatorChar.ToString()).Length - 2] : Path.GetFileNameWithoutExtension(htmlFile), checkbox = false, folder = false, key = htmlFile.Split(DbOperations.GetServerParameterLists("DefaultStaticWebFilesFolder").Value)[1] });
                });

                return base.Json(new WebClasses.JsonResult() { Result = result, Status = DBResult.success.ToString() });
            } catch (Exception ex) {
                return base.Json(new WebClasses.JsonResult() { Result = DataOperations.GetErrMsg(ex), Status = DBResult.error.ToString(), ErrorMessage = DataOperations.GetErrMsg(ex) });
            }
        }



    }
}
