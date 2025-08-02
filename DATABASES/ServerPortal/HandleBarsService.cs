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
using ScrapySharp.Network;


namespace EasyITCenter.Controllers {

    public class DataToTemplateRequest {
        public string Template { get; set; }
        public string Data { get; set; }
    }

    [AllowAnonymous]
    [Route("/ServerPortalApi")]
    public class HandleBarsService : Controller {

        private readonly Microsoft.AspNetCore.Hosting.IWebHostEnvironment _hostingEnvironment;
        public HandleBarsService(Microsoft.AspNetCore.Hosting.IWebHostEnvironment hostingEnvironment) {
            _hostingEnvironment = hostingEnvironment;
        }


        /// <summary>
        /// Generate HTML code from Template and JSON Data set, 
        /// </summary>
        /// <param name="codegenRequest"></param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpPost("/ServerPortalApi/HandleBarsService/GetTemplateCode")]
        [Consumes("application/json")]
        public async Task<IActionResult> GetTemplateCode([FromBody] DataToTemplateRequest codegenRequest) {
            try {
                var template = Handlebars.Compile(codegenRequest.Template);
                string? result = template(JsonConvert.DeserializeObject<object>(codegenRequest.Data));

                return Json(new HandlerResult() { Result = result, Success = true });
            } catch (Exception ex) {
                return Json(new HandlerResult() { Result = DataOperations.GetErrMsg(ex), Success = false });
            }
        }



    }
}
