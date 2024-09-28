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
using Microsoft.Identity.Client.Platforms.Features.DesktopOs.Kerberos;
using SharpCompress;
using Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http;

namespace EasyITCenter.Controllers {

    public enum DocsType {
        Html,
        MarkDown
    }

    public class GithubDownloadRequest {
        public string RepoUrl { get; set; }
        public DocsType Source { get; set; }
        public string TargetPath { get; set; }
    }

    public class GithubSearchRequest {
        public string SearchedValue { get; set; }
        public Language Language { get; set; }
    }

    //githubRepo
    //https://octokitnet.readthedocs.io/en/latest/


    [Authorize]
    [Route("/HostingApi")]
    public class HostingApiInternetService : Controller {

        private readonly Microsoft.AspNetCore.Hosting.IWebHostEnvironment _hostingEnvironment;
        public HostingApiInternetService(Microsoft.AspNetCore.Hosting.IWebHostEnvironment hostingEnvironment) {
            _hostingEnvironment = hostingEnvironment;
        }



        /// <summary>
        /// Search in GitHub Repos By Value and Language
        /// </summary>
        /// <param name="searchRequest"></param>
        /// <returns></returns>
        [HttpPost("/HostingApi/DownloadService/GetGitHubReposList")]
        [Consumes("application/json")]
        public async Task<IActionResult> GetGitHubReposList([FromBody] GithubSearchRequest searchRequest) {
            try {
                GitHubClient client = new GitHubClient(new ProductHeaderValue("EIC&ESB_Groupware"));
                SearchRepositoriesRequest? gitSearchRequest = new SearchRepositoriesRequest(searchRequest.SearchedValue) { PerPage = 200, Language = searchRequest.Language };
                SearchRepositoryResult? sa = await client.Search.SearchRepo(gitSearchRequest);

                return Json(new HandlerResult() { Result = new { sa.Items }, Success = true });
            } catch (Exception ex) {
                return new ContentResult() { Content = DataOperations.GetErrMsg(ex), StatusCode = StatusCodes.Status200OK };
            }
        }



        /// <summary>
        /// Get Readme For Selected Repository
        /// </summary>
        /// <param name="downloadRequest"></param>
        /// <returns></returns>
        [HttpPost("/HostingApi/DownloadService/SaveGitHubRepoReadme")]
        [Consumes("application/json")]
        public async Task<IActionResult> SaveGitHubRepoReadme([FromBody] GithubDownloadRequest downloadRequest) {
            try {

                GitHubClient client = new GitHubClient(new ProductHeaderValue("EIC&ESB_Groupware"));
                SearchRepositoriesRequest? gitSearchRequest = new SearchRepositoriesRequest() { In = InQualifier.Readme.AsEnumerable() };

                string? sa = downloadRequest.Source == DocsType.MarkDown ? 
                    (await client.Repository.Content.GetReadme(downloadRequest.RepoUrl.ToLower().Split("github.com/")[1].Split("/")[0], downloadRequest.RepoUrl.ToLower().Replace(".git","").Split("/").Last())).Content
                    : await client.Repository.Content.GetReadmeHtml(downloadRequest.RepoUrl.ToLower().Split("github.com/")[1].Split("/")[0], downloadRequest.RepoUrl.ToLower().Replace(".git", "").Split("/").Last());

                return Json(new HandlerResult() { Result = new { sa }, Success = true });
            } catch (Exception ex) {
                return new ContentResult() { Content = DataOperations.GetErrMsg(ex), StatusCode = StatusCodes.Status200OK };
            }
        }


        /// <summary>
        /// Download Full GitHub Repository For Developing
        /// 
        /// </summary>
        /// <param name="repoUrl"></param>
        /// <returns></returns>
        [HttpPost("/HostingApi/DownloadService/DownloadGitRepo")]
        [Consumes("application/json")]
        public async Task<IActionResult> DownloadGitRepo([FromBody] GithubDownloadRequest downloadRequest) {
            try {
                GitHubClient client = new GitHubClient(new ProductHeaderValue("EIC&ESB_Groupware"));
                SearchRepositoriesRequest? gitSearchRequest = new SearchRepositoriesRequest() { };
                byte[]? sa = await client.Repository.Content.GetArchive(downloadRequest.RepoUrl.ToLower().Split("github.com/")[1].Split("/")[0], downloadRequest.RepoUrl.ToLower().Replace(".git", "").Split("/").Last()); 

                return Json(new HandlerResult() { Result = new { sa }, Success = true });
                } catch (Exception ex) { return new ContentResult() { Content = DataOperations.GetErrMsg(ex), StatusCode = StatusCodes.Status200OK };
            }
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
