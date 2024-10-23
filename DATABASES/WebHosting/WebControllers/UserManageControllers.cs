using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

using EasyITCenter.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DataType = System.ComponentModel.DataAnnotations.DataType;

namespace EasyITCenter.WebControllers {

    public class WebUserController : Controller {

        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ILogger<WebUserController> _logger;
        private ApplicationUser _currentUser;

        public WebUserController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, ILogger<WebUserController> logger) {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
        }

        public ApplicationUser CurrentUser {
            get {
                if (_currentUser == null) {
                    var user = _userManager.GetUserAsync(User);
                    if (user == null) {
                        throw new ApplicationException($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
                    }

                    _currentUser = user.Result;
                }
                return _currentUser;
            }
        }


        public bool IsEmailConfirmed {
            get {
                return _userManager.IsEmailConfirmedAsync(CurrentUser).Result;
            }
        }

        public bool IsHasPassword {
            get {
                return _userManager.HasPasswordAsync(CurrentUser).Result;
            }
        }


        [ValidateAntiForgeryToken]
        [HttpPost("/ServerPortal/User/Logout")]
        [Consumes("application/json")]
        public async Task<IActionResult> Logout() {
            await _signInManager.SignOutAsync();
            _logger.LogInformation("User logged out.");
            return RedirectToPage("/Index");
        }


        [ValidateAntiForgeryToken]
        [HttpPost("/UserManage/ChangePassword")]
        [Consumes("application/json")]
        public async Task<IActionResult> ChangePassword(ChangePasswordInput model) {
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            var changePasswordResult = await _userManager.ChangePasswordAsync(CurrentUser, model.OldPassword, model.NewPassword);
            if (!changePasswordResult.Succeeded) {
                foreach (var error in changePasswordResult.Errors) {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
                return BadRequest(ModelState);
            }

            await _signInManager.SignInAsync(CurrentUser, isPersistent: false);
            _logger.LogInformation("User changed their password successfully.");

            return Ok("Your password has been changed.");
        }


        [HttpPost("/UserManage/SetPassword")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SetPassword(SetPasswordInput model) {
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            var addPasswordResult = await _userManager.AddPasswordAsync(CurrentUser, model.NewPassword);
            if (!addPasswordResult.Succeeded) {
                foreach (var error in addPasswordResult.Errors) {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
                return BadRequest(ModelState);
            }

            await _signInManager.SignInAsync(CurrentUser, isPersistent: false);
            _logger.LogInformation("User set password successfully.");

            return Ok("Your password has been set.");
        }
    }
}