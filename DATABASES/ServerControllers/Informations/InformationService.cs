using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace EasyITCenter.Controllers
{

    [AllowAnonymous]
    [Route("/InformationService")]
    public class InformationService : Controller
    {

        private readonly Microsoft.AspNetCore.Hosting.IWebHostEnvironment _hostingEnvironment;
        public InformationService(Microsoft.AspNetCore.Hosting.IWebHostEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }


        /// <summary>
        /// Get Server Version
        /// </summary>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpGet("/InformationService/GetVersion")]
        [Consumes("application/json")]
        public async Task<IActionResult> GetVersion()
        {
            return base.Json(new WebClasses.JsonResult() { Result = SrvRuntime.SrvVersion, Status = DBResult.success.ToString() });
        }



    }
}
