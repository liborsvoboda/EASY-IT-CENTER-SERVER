using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EasyITCenter.DBModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;


namespace EasyITCenter.Controllers {


 
    [AllowAnonymous]
    [Route("/UserStorageService")]
    public class UserStorageService : Controller {

        private readonly Microsoft.AspNetCore.Hosting.IWebHostEnvironment _hostingEnvironment;
        public UserStorageService(Microsoft.AspNetCore.Hosting.IWebHostEnvironment hostingEnvironment) {
            _hostingEnvironment = hostingEnvironment;
        }




        /// <summary>
        /// FancyTree Code Library Browser Data
        /// </summary>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpGet("/UserStorageService/GetFancyTreeCodeLibrary")]
        [Consumes("application/json")]
        public async Task<IActionResult> GetFancyTreeCodeLibrary() {
            List<SolutionCodeLibraryList> data = new(); string lastCodeType = null;
            List<FancyTreeJsonData> result = new(); FancyTreeJsonData codeGroup = new();
            try {


                data.ForEach(code => {
                    if (code.InheritedCodeType != lastCodeType) {
                        if (lastCodeType != null) { result.Add(codeGroup); }
                        codeGroup = new FancyTreeJsonData() { title = code.InheritedCodeType, checkbox = false, folder = true, key = string.Empty, children = new List<FancyTreeChildren>() };
                        codeGroup.children.Add(new FancyTreeChildren() { title = code.Name, key = code.CodeContent });
                    } else { codeGroup.children.Add(new FancyTreeChildren() { title = code.Name, key = code.CodeContent }); }

                    lastCodeType = code.InheritedCodeType;
                });
                result.Add(codeGroup);
                return base.Json(result);
            } catch (Exception ex) {
                return base.Json(result);
            }
        }
    }
}
