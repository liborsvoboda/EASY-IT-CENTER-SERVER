using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Playwright;
using PuppeteerSharp;
using ScrapySharp.Network;
using Westwind.AspNetCore.Markdown;
using System.Diagnostics;
using Octokit;

namespace EasyITCenter.Controllers {




    [AllowAnonymous]
    [Route("/ProcessService")]
    public class ProcessService : Controller {



        [HttpPost("/ProcessService/StartProcessScript")]
        [Consumes("application/json")]
        public async Task<IActionResult> StartProcessScript(RunProcessRequest processRequest) {

            if (ServerApiServiceExtension.IsAdmin() || ServerApiServiceExtension.IsWebAdmin()) {
                ProcessOperations.ServerProcessStart(processRequest);
            }
            return base.Json(new WebClasses.JsonResult() { Result = string.Empty, Status = DBResult.success.ToString() });
        }



      
    }
}
