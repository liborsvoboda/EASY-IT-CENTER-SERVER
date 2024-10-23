using ColorCode.Compilation.Languages;
using Microsoft.AspNetCore.Antiforgery;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing.Template;
using System.Data.Entity.Core.Metadata.Edm;
using System.Net.Http;
using System.Net.Http.Headers;

namespace EasyITCenter.Controllers {


    [Authorize]
    [ApiController]
    [Route("ServerApi/DevGenHTML")]
    //[ApiExplorerSettings(IgnoreApi = true)]
    public class ServerApiDevGenHTMLApi : ControllerBase {


        /// <summary>
        /// For wwwroot folder Update with detect changes and modify static pages
        /// </summary>
        private readonly Microsoft.AspNetCore.Hosting.IWebHostEnvironment _hostingEnvironment;
        public ServerApiDevGenHTMLApi(Microsoft.AspNetCore.Hosting.IWebHostEnvironment hostingEnvironment) {
            _hostingEnvironment = hostingEnvironment;
        }



        [HttpGet("/ServerApi/DevGenHTML/GenerateFormFromClass")]
        public IResult GenerateFormFromClass() {

            var html = WebFormGenOperations.GenerateHtmlPage();
            return Results.Content(html, "text/html");
        }




    }
}