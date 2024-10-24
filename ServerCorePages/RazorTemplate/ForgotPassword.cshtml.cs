﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;



namespace ServerCorePages
{
    public class ForgotPasswordModel : PageModel
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly string _emailSender;

        public ForgotPasswordModel(UserManager<IdentityUser> userManager, string emailSender)
        {
            _userManager = userManager;
            _emailSender = emailSender;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            [Required]
            [EmailAddress]
            public string Email { get; set; }
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid) {
                var user = await _userManager.FindByEmailAsync(Input.Email);
                if (user == null || !( await _userManager.IsEmailConfirmedAsync(user) )) {
                    // Don't reveal that the user does not exist or is not confirmed
                    return RedirectToPage("/DevPortal/ForgotPasswordConfirm");
                }

                // For more information on how to enable account confirmation and password reset please 
                // visit https://go.microsoft.com/fwlink/?LinkID=532713
                var code = await _userManager.GeneratePasswordResetTokenAsync(user);
                var callbackUrl = Url.Page("/DevPortal/Login");// (user.Id, code, Request.Scheme);
                //await _emailSender..SendResetPasswordAsync(Input.Email, callbackUrl);
                return RedirectToPage("/DevPortal/ForgotPasswordConfirm");
            }

            return Page();
        }
    }
}
