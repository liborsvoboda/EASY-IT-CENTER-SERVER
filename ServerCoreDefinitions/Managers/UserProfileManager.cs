using EasyITCenter.DevPortal;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyITCenter.Managers {


    public class UserProfileManager
    {
        private readonly UserManager<WebUser> _userManager;
        private readonly SignInManager<WebUser> _signInManager;
        IHttpContextAccessor _httpContextAccessor;

        private WebUser _currentUser;

        public UserProfileManager(UserManager<WebUser> userManager, SignInManager<WebUser> signInManager, IHttpContextAccessor httpContextAccessor)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _httpContextAccessor = httpContextAccessor;
        }

        public WebUser CurrentUser
        {
            get
            {
                if (_currentUser == null)
                    _currentUser = _userManager.GetUserAsync(_httpContextAccessor.HttpContext.User).Result;

                return _currentUser;
            }
        }

        public bool IsHasPassword(WebUser user)
        {
            return _userManager.HasPasswordAsync(user).Result;
        }

        public bool IsEmailConfirmed(WebUser user)
        {
            return _userManager.IsEmailConfirmedAsync(user).Result;
        }
    }
}
