using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EasyITCenter.Controllers
{
    //[Authorize(Roles = "admin")]
    [ApiController]
    [Route("/DevPortal")]
    public class DashboardsController : Controller
    {
        public IActionResult DevPortal()
        {
            return RedirectToAction("AdminDashboard");
        }

        public IActionResult Dashboard1()
        {
            return View();
        }

        public IActionResult Dashboard2()
        {
            return View();
        }

    }
}