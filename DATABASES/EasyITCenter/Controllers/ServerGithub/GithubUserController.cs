using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using EasyITCenter.GitServer.Models;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using EasyITCenter.GitServer.Interfaces;
using EasyITCenter.GitServer.Models;

namespace EasyITCenter.GitServer.Controllers
{

    [ApiExplorerSettings(IgnoreApi = true)]
    public class GithubUserController : Controller
    {
        private SolutionUserList _user;
        public GithubUserController(SolutionUserList user)
        {
            _user = user;
        }


        public IActionResult Index()
        {
            return Content("ok");
        }


        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Login(GithubLoginModel model)
        {
            if (ModelState.IsValid) {
                var user = new EasyITCenterContext().SolutionUserLists.Where(r => r.Name == model.Username && r.Password == model.Password).FirstOrDefault();
                if (user != null) {
                    var identity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme, ClaimTypes.Name, ClaimTypes.Role);
                    identity.AddClaim(new Claim(ClaimTypes.PrimarySid, user.Id.ToString()));
                    identity.AddClaim(new Claim(ClaimTypes.NameIdentifier, user.Name));
                    identity.AddClaim(new Claim(ClaimTypes.Name, user.Name));
                    identity.AddClaim(new Claim(ClaimTypes.Email, user.Email));
                    var principal = new ClaimsPrincipal(identity);
                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
                    return Redirect("/servercoretools/webpages/Github");
                }
            }
            return View();
        }


        public IActionResult Register()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Register(SolutionUserList userRegistration)
        {
            if (ModelState.IsValid)
            {
                var dataAcept = new EasyITCenterContext().SolutionUserLists.Add(new SolutionUserList()
                {
                    UserName = userRegistration.UserName,
                    Name = userRegistration.Name,
                    SurName = userRegistration.SurName,
                    Password = userRegistration.Password,
                    RoleId = 4,
                    Description = userRegistration.Description,
                    Active = true,
                    //Email = model.Email,
                    TimeStamp = DateTimeOffset.Now.DateTime
                });
                await dataAcept.Context.SaveChangesAsync();
                return Redirect("/servercoretools/webpages/Github");
            }
            return View();
        }
        public async Task<IActionResult> Signout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return Redirect("/servercoretools/webpages/Github");
        }

    }
}