using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandlebarsDotNet;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Octokit;
using ScrapySharp.Network;


namespace EasyITCenter.Controllers {

    public class DataToTemplateRequest {
        public string Template { get; set; }
        public JsonDocument Data { get; set; }
    }

    //githubRepo
    //https://github.com/Handlebars-Net/Handlebars.Net


    [Authorize]
    [Route("/HandleBarsService")]
    public class HandleBarsService : Controller {

        private readonly Microsoft.AspNetCore.Hosting.IWebHostEnvironment _hostingEnvironment;
        public HandleBarsService(Microsoft.AspNetCore.Hosting.IWebHostEnvironment hostingEnvironment) {
            _hostingEnvironment = hostingEnvironment;
        }


        /// <summary>
        /// Generate HTML code from Template and JSON Data set, 
        /// Template Example:
        /// string source = "<div class='entry'><h1>{{title}}</h1><div class='body'>{{body}}</div></div>";
        /// </summary>
        /// <param name="codegenRequest"></param>
        /// <returns></returns>
        [HttpPost("/HandleBarsService/GetTemplateCode")]
        [Consumes("application/json")]
        public async Task<IActionResult> GetTemplateCode([FromBody] DataToTemplateRequest codegenRequest) {
            try {

                //var data = new {  title = "My new post",   body = "This is my first post!" };
                //string source = @"<div class=""entry""><h1>{{title}}</h1><div class=""body"">{{body}}</div></div>";

                var template = Handlebars.Compile(codegenRequest.Template);
                string? result = template(codegenRequest.Data.ObjectToJson());

                return Json(new HandlerResult() { Result = new { result }, Success = true });
            } catch (Exception ex) {
                return new ContentResult() { Content = DataOperations.GetErrMsg(ex), StatusCode = StatusCodes.Status200OK };
            }
        }



    }
}
