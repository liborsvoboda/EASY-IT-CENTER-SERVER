using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChangelogGenerator.Core.Settings;
using ChangelogGenerator.Core;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Playwright;
using PuppeteerSharp;
using ScrapySharp.Network;
using Westwind.AspNetCore.Markdown;


namespace EasyITCenter.Controllers {




    [AllowAnonymous]
    [Route("/OperationService")]
    public class OperationService : Controller {



        [HttpGet("/OperationService/GenerateChangeLog")]
        [Consumes("application/json")]
        public async Task<IActionResult> GenerateChangeLog() {

            ChangelogSettings settings = new ChangelogSettings() { AllCommits = true };
            ChangelogCore core = new ChangelogCore();
            core.GenerateChangelog(settings);

            return base.Json(new WebClasses.JsonResult() { Result = string.Empty, Status = DBResult.success.ToString() });
        }



      
    }
}
