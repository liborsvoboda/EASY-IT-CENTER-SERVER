using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ScrapySharp.Network;
using Westwind.AspNetCore.Markdown;


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

            return base.Json(new WebClasses.JsonResult() { Result = new { resultsPage.Html.InnerHtml }, Status = DBResult.success.ToString() });
        }



        [HttpPost("/ServerApi/GeneratorServerServices/DownloadMarkdownFromUrlToStatic")]
        [Consumes("application/json")]
        public async Task<string> DownloadMarkdownFromUrlToStatic([FromBody] string markdownUrl) {

            string MdAsHtml = await Markdown.ParseFromUrlAsync(markdownUrl, true, false, false);
            return MdAsHtml;
        }

    }
}
