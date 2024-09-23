using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EasyITCenter.Controllers
{
    public class SettingsController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToPage("/DevPortal/Profile");
        }

        public IActionResult TwoFactorAuth()
        {
            return RedirectToPage("/DevPortal/TwoFactorAuth/Config");
        }
    }
}