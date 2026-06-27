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


        [AllowAnonymous]
        [HttpGet("/InformationService/GetStripePublicKey")]
        [Consumes("application/json")]
        public async Task<IActionResult> GetStripePublicKey() {
            ServerParameterList data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions {
                IsolationLevel = IsolationLevel.ReadUncommitted //with NO LOCK
            })) {
                if(HttpContext.Request.Host.Host.ToLower() == "localhost") {
                    data = new EasyITCenterContext().ServerParameterLists.Where(a => a.Key == "StripeTestPublicKey").FirstOrDefault();
                } else {
                    data = new EasyITCenterContext().ServerParameterLists.Where(a => a.Key == "StripePublicKey").FirstOrDefault();
                }
                
            }
            return base.Json(new WebClasses.JsonResult() { Result = data.Value, Status = DBResult.success.ToString() });
        }


        [Authorize]
        [HttpGet("/InformationService/GetStorageFolderList")]
        [Consumes("application/json")]
        public async Task<IActionResult> GetStorageFolderList()
        {
            ServerParameterList data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadUncommitted //with NO LOCK
            }))
            {
                data = new EasyITCenterContext().ServerParameterLists.Where(a => a.Key == "DefaultUserStorageFolders").FirstOrDefault();
            }
            return base.Json(new WebClasses.JsonResult() { Result = data.Value, Status = DBResult.success.ToString() });
        }
    }
}
