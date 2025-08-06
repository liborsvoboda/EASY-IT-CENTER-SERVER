using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandlebarsDotNet;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Octokit;
using PuppeteerExtraSharp.Plugins.ExtraStealth.Evasions;
using ScrapySharp.Network;


namespace EasyITCenter.Controllers {




    [AllowAnonymous]
    [Route("/JsonGeneratorService")]
    public class JsonGeneratorService : Controller {

        private readonly Microsoft.AspNetCore.Hosting.IWebHostEnvironment _hostingEnvironment;
        public JsonGeneratorService(Microsoft.AspNetCore.Hosting.IWebHostEnvironment hostingEnvironment) {
            _hostingEnvironment = hostingEnvironment;
        }



        public class GetFancyTreeJsonDataRequest {
            public string WebRootPath { get; set; }
        }

        public class FancyTreeJsonData {
            public string Title { get; set; }
            public bool Folder { get; set; }
            public bool Checkbox { get; set; }
            public string Key { get; set; }
        }

        [AllowAnonymous]
        [HttpPost("/JsonGeneratorService/GetFancyTreeJsonData")]
        [Consumes("application/json")]
        public async Task<IActionResult> GetFancyTreeJsonData([FromBody] GetFancyTreeJsonDataRequest jsonDataRequest) {
            try {
                List<string>? loadFiles = null; List<FancyTreeJsonData> result = new();
                loadFiles = FileOperations.GetPathFiles(Path.Combine(SrvRuntime.Startup_path, DbOperations.GetServerParameterLists("DefaultStaticWebFilesFolder").Value, jsonDataRequest.WebRootPath), "*.html", SearchOption.TopDirectoryOnly);

                loadFiles.ForEach(htmlFile => { 
                    result.Add(new FancyTreeJsonData() { Title = Path.GetFileName(htmlFile), Checkbox = false, Folder = false, Key = htmlFile.Split(DbOperations.GetServerParameterLists("DefaultStaticWebFilesFolder").Value)[1] });
                });

                return Json(new HandlerResult() { Result = result, Success = true });
            } catch (Exception ex) {
                return Json(new HandlerResult() { Result = DataOperations.GetErrMsg(ex), Success = false });
            }
        }



    }
}
