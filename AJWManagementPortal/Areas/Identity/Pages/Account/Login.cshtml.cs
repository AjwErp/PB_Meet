using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using AJWManagementPortal.Models;
using AJWManagementPortal.Utility;

namespace AJWManagementPortal.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class LoginModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ILogger<LoginModel> _logger;

        public LoginModel(SignInManager<ApplicationUser> signInManager, 
            ILogger<LoginModel> logger,
            UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public string ReturnUrl { get; set; }

        [TempData]
        public string ErrorMessage { get; set; }

        public class InputModel
        {
            [Required]
            [EmailAddress]
            public string Email { get; set; }

            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; }

            [Required(ErrorMessage = "This field is Required")]
            [Display(Name = "Department")]
            public string Department { get; set; }

            [Display(Name = "Remember me?")]
            public bool RememberMe { get; set; }
        }

        public async Task OnGetAsync(string returnUrl = null)
        {
            if (!string.IsNullOrEmpty(ErrorMessage))
            {
                ModelState.AddModelError(string.Empty, ErrorMessage);
            }

            returnUrl = returnUrl ?? Url.Content("~/");

            // Clear the existing external cookie to ensure a clean login process
            await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);

            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();

            ReturnUrl = returnUrl;
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");

            if (ModelState.IsValid)
            {
                // This doesn't count login failures towards account lockout
                // To enable password failures to trigger account lockout, set lockoutOnFailure: true
                var result = await _signInManager.PasswordSignInAsync(Input.Email, Input.Password, Input.RememberMe, lockoutOnFailure: true);
                string role = Input.Department;

                var user = _userManager.FindByEmailAsync(Input.Email);
                if (result.Succeeded)
                {
                    if (user.Result.Department.Equals(SD.Ceo) && role == SD.Ceo)
                    {
                        return Redirect("~/Ceo/Ceo/CeoDashboard");
                    }
                    else if (user.Result.Department.Equals(SD.Gm) && role == SD.Gm)
                    {
                        return Redirect("~/Gm/Gm/GmDashboard");
                    }
                    else if (user.Result.Department.Equals(SD.Dgm) && role == SD.Dgm)
                    {
                        return Redirect("~/Dgm/Dgm/DgmDashboard");
                    }
                    else if (user.Result.Department.Equals(SD.Hrm) && role == SD.Hrm)
                    {
                        return Redirect("~/HRM/Hrm/HrmDashboard");
                    }
                    else if (user.Result.Department.Equals(SD.Production) && role == SD.Production)
                    {
                        return Redirect("~/Production/Production/ProductionDashboard");
                    }
                    else if (user.Result.Department.Equals(SD.Dms) && role == SD.Dms)
                    {
                        return Redirect("~/Dms/Dms/DmsDashboard");
                    }
                    else if (user.Result.Department.Equals(SD.Admin) && role == SD.Admin)
                    {
                        return Redirect("~/Admin/Admin/AdminDashboard");
                    }
                    else if (user.Result.Department.Equals(SD.AccountManager) && role == SD.AccountManager)
                    {
                        return Redirect("~/Account/Account/AccountDashboard");
                    }
                    else
                    {
                        await _signInManager.SignOutAsync();
                        return RedirectToPage("./AccessDenied");
                    }

                    _logger.LogInformation("User logged in.");
                    return LocalRedirect(returnUrl);
                }
                if (result.RequiresTwoFactor)
                {
                    return RedirectToPage("./LoginWith2fa", new { ReturnUrl = returnUrl, RememberMe = Input.RememberMe });
                }
                if (result.IsLockedOut)
                {
                    _logger.LogWarning("User account locked out.");
                    return RedirectToPage("./Lockout");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                    return Page();
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}
