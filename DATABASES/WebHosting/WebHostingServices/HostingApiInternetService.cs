using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EasyITCenter.DevPortal;
using Octokit;
using static EasyITCenter.ServerCoreDBSettings.ServerApiGeneratorServerIndexService;
using static EasyITCenter.Controllers.PlayGroundStudioControllers;
using ScrapySharp.Network;

namespace EasyITCenter.Controllers {

    [Authorize]
    [Route("/HostingApi")]
    public class HostingApiInternetService : Controller {

        private readonly Microsoft.AspNetCore.Hosting.IWebHostEnvironment _hostingEnvironment;
        /// <summary>
        /// IS FOR WORKING WITH WWWDATA OF PROJECT FOLDER
        /// If Used in Code Path file storage modify Project wwwroot 
        /// not need Transfer changed data from BIN/DEGUG to Project
        /// Usage: _hostingEnvironment.WebRootPath
        /// </summary>
        /// <param name="hostingEnvironment"></param>
        public HostingApiInternetService(Microsoft.AspNetCore.Hosting.IWebHostEnvironment hostingEnvironment) {
            _hostingEnvironment = hostingEnvironment;
        }

        [HttpPost("/HostingApi/DownloadService/GetGithubRepos")]
        [Consumes("application/json")]
        public async Task<IActionResult> GetGithubReposInfo(MDGeneratorCreateIndexRequest webfilesrequest) {

            GitHubClient? github = new GitHubClient(new ProductHeaderValue("MyAmazingApp"));
            User? user = await github.User.Get("half-ogre");
            Console.WriteLine(user.Followers + " folks love the half ogre!");

            return Json(new HandlerResult() { Result = new { user }, Success = true });
        }


        [HttpPost("/HostingApi/DownloadService/DownloadHtmlPage")]
        [Consumes("application/json")]
        public async Task<IActionResult> DownloadHtmlPage([FromBody] string url) {

            ScrapingBrowser? browser = new ScrapingBrowser();
            WebPage? resultsPage = await browser.NavigateToPageAsync(new Uri(url));


            return Json(new HandlerResult() { Result = new { resultsPage.Html.InnerHtml }, Success = true });
        }


    }
}
