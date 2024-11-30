using RedirectResult = Microsoft.AspNetCore.Mvc.RedirectResult;

namespace EasyITCenter.ServerCoreDBSettings {

    /// <summary>
    /// Server Routing Rulles
    /// </summary>
    [AllowAnonymous]
    //[ApiExplorerSettings(IgnoreApi = true)]
    public class ServerApiRoutingStatusPagesService : ControllerBase {


        /// <summary>
        /// StartUp Web Redirection
        /// </summary>
        /// <returns></returns>
        [HttpGet("/")]
        public IActionResult Index() {
            return SrvConfig.RedirectOnPageNotFound ?
                new RedirectResult(SrvConfig.RedirectPath) : 
                new RedirectResult(SrvConfig.RedirectPath.StartsWith("/") ? SrvConfig.RedirectPath : "/" + SrvConfig.RedirectPath);
        }



        [HttpGet("/ServerControls/404NonExistPage")]
        public ContentResult NonExistPage() {

            string? nonExistPageFinal = new EasyITCenterContext().ServerModuleAndServiceLists.
                Where(a => a.Name.ToLower() == "404NonExistPage".ToLower()).FirstOrDefault()?.CustomHtmlContent;
            if (nonExistPageFinal != null) {
                base.StatusCode(StatusCodes.Status404NotFound);
                return base.Content(nonExistPageFinal, "text/html");
            } else {
                base.StatusCode(StatusCodes.Status404NotFound); 
                return base.Content("Missing \"404NonExistPage\" Template 404 in: Generator Dynamic Wesites.");
            }
        }

        [HttpGet("/ServerControls/401UnauthorizedPage")]
        public ContentResult UnauthorizedPage() {

            string? nonExistPageFinal = new EasyITCenterContext().ServerModuleAndServiceLists.
                Where(a => a.Name.ToLower() == "401UnauthorizedPage".ToLower()).FirstOrDefault()?.CustomHtmlContent;
            if (nonExistPageFinal != null) {
                base.StatusCode(StatusCodes.Status401Unauthorized);
                return base.Content(nonExistPageFinal, "text/html");
            }
            else {
                base.StatusCode(StatusCodes.Status401Unauthorized);
                return base.Content("Missing \"401UnauthorizedPage\" Template 404 in: Generator Dynamic Wesites.");
            }
        }


    }
}