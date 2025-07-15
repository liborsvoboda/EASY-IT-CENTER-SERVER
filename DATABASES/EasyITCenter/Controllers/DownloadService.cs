using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Octokit;
using ScrapySharp.Network;


namespace EasyITCenter.Controllers {


    [Authorize]
    [Route("/DownloadService")]
    public class DownloadService : Controller {


        /// <summary>
        /// Html From URL Downloader Return InnerHtml
        /// 
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        [HttpPost("/DownloadService/DownloadHtmlPage")]
        [Consumes("application/json")]
        public async Task<IActionResult> DownloadHtmlPage([FromBody] string url) {

            ScrapingBrowser? browser = new ScrapingBrowser();
            WebPage? resultsPage = await browser.NavigateToPageAsync(new Uri(url));

            return Json(new HandlerResult() { Result = new { resultsPage.Html.InnerHtml }, Success = true });
        }


      
    }
}
