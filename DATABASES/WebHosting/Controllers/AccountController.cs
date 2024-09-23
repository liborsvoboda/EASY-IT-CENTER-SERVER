using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EasyITCenter.DevPortal;

namespace EasyITCenter.Controllers {

    //[Authorize(Roles = "admin")]
    [ApiController]
    [Route("/DevPortal")]
    public class AccountController : ControllerBase {


        //[HttpPost("/DevPortal/Login")]
        public IActionResult Login() {
            return View();
        }

        public IActionResult Register() {
            return View();
        }


        public IActionResult ForgotPassword() {
            return View();
        }


        public IActionResult RecoverPassword() {
            return View();
        }
    }
}
