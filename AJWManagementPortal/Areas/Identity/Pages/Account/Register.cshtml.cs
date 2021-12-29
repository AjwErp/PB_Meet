using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using AJWManagementPortal.Models;
using AJWManagementPortal.Utility;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;

namespace AJWManagementPortal.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailSender _emailSender;
        private readonly RoleManager<IdentityRole> _roleManager;

        public RegisterModel(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            ILogger<RegisterModel> logger,
            IEmailSender emailSender,
             RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
            _roleManager = roleManager;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public class InputModel
        {
            [Required]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }

            //these properties we add manully

            [Required(ErrorMessage = "This field is Required")]
            [Display(Name = "User Name")]
            public string Name { get; set; }


            [Required(ErrorMessage = "This field is Required")]
            [Display(Name = "CNIC")]
            public string CNIC { get; set; }


            [Required(ErrorMessage = "This field is Required")]
            [Display(Name = "Mobile No")]
            public string MobileNumber { get; set; }


            [Required(ErrorMessage = "This field is Required")]
            [Display(Name = "Department")]
            public string Department { get; set; }

            [Required(ErrorMessage = "This field is Required")]
            [Display(Name = "Designation")]
            public string Designation { get; set; }

            [Required(ErrorMessage = "This field is Required")]
            [Display(Name = "Gender")]
            public string Gender { get; set; }

            [Required(ErrorMessage = "This field is Required")]
            [Display(Name = "Martial Status")]
            public string Martialstatus { get; set; }

            [Required(ErrorMessage = "This field is Required")]
            [Display(Name = "Blood Gp")]
            public string Bloodgp { get; set; }

            //[Required(ErrorMessage = "This field is Required plz select profile image")]
            [Display(Name = "Profile Image")]
            public string Photo { get; set; }

            //[Required(ErrorMessage = "This field is Required plz select profile image")]
            [Display(Name = "Profile Image")]
            public string Photopath { get; set; }

            [Required(ErrorMessage = "This field is Required")]
            [Display(Name = "Address")]
            public string Address { get; set; }

            public byte[] Profile { get; set; }



        }

        public async Task OnGetAsync(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            string role = Input.Department;

            returnUrl = returnUrl ?? Url.Content("~/");
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser
                {
                    UserName = Input.Email,
                    Email = Input.Email,
                    Name = Input.Name,
                    CNIC = Input.CNIC,
                    MobileNumber = Input.MobileNumber,
                    Department = Input.Department,
                    Designation = Input.Designation,
                    Gender = Input.Gender,
                    Martialstatus = Input.Martialstatus,
                    Bloodgp = Input.Bloodgp,
                    Photo = Input.Photo,
                    Photopath = Input.Photopath,
                    Address = Input.Address,
                    Profile = Input.Profile
                };
                var result = await _userManager.CreateAsync(user, Input.Password);
                if (result.Succeeded)
                {
                    //here 
                    //here start manually add role manager

                    if (!await _roleManager.RoleExistsAsync(SD.Ceo))
                    {
                        await _roleManager.CreateAsync(new IdentityRole(SD.Ceo));
                    }
                    if (!await _roleManager.RoleExistsAsync(SD.Gm))
                    {
                        await _roleManager.CreateAsync(new IdentityRole(SD.Gm));
                    }
                    if (!await _roleManager.RoleExistsAsync(SD.Dgm))
                    {
                        await _roleManager.CreateAsync(new IdentityRole(SD.Dgm));
                    }
                    if (!await _roleManager.RoleExistsAsync(SD.Admin))
                    {
                        await _roleManager.CreateAsync(new IdentityRole(SD.Admin));
                    }
                    if (!await _roleManager.RoleExistsAsync(SD.Production))
                    {
                        await _roleManager.CreateAsync(new IdentityRole(SD.Production));
                    }
                    if (!await _roleManager.RoleExistsAsync(SD.Hrm))
                    {
                        await _roleManager.CreateAsync(new IdentityRole(SD.Hrm));
                    }
                    if (!await _roleManager.RoleExistsAsync(SD.Dms))
                    {
                        await _roleManager.CreateAsync(new IdentityRole(SD.Dms));
                    }
                    if (!await _roleManager.RoleExistsAsync(SD.AccountManager))
                    {
                        await _roleManager.CreateAsync(new IdentityRole(SD.AccountManager));
                    }
                    //await _userManager.AddToRoleAsync(user, SD.Admin);
                    //ended role description
                    //here start manulayy add different role
                    if (role == SD.Ceo)
                    {
                        await _userManager.AddToRoleAsync(user, SD.Ceo);
                    }
                    else
                    {
                        if (role == SD.Gm)
                        {
                            await _userManager.AddToRoleAsync(user, SD.Gm);
                        }
                        else
                        {
                            if (role == SD.Dgm)
                            {
                                await _userManager.AddToRoleAsync(user, SD.Dgm);
                            }
                            else if(role == SD.Admin)
                            {
                                await _userManager.AddToRoleAsync(user, SD.Admin);
                                //    //if we comment bellow given both line then admin login come to index page without registered user

                                //    //await _signInManager.SignInAsync(user, isPersistent: false);
                                //    //return LocalRedirect(returnUrl);
                                //}
                            }
                            else if(role == SD.AccountManager)
                            {
                                await _userManager.AddToRoleAsync(user, SD.AccountManager);
                            }
                            else if(role == SD.Hrm)
                            {
                                await _userManager.AddToRoleAsync(user, SD.Hrm);
                            }else if(role == SD.Dms)
                            {
                                await _userManager.AddToRoleAsync(user, SD.Dms);
                            }else if(role == SD.Production)
                            {
                                await _userManager.AddToRoleAsync(user, SD.Production);
                            }
                        }
                    }

                    //await _userManager.AddToRoleAsync(user, SD.ManagerUser);
                    //Here ---End--- to add Role Manager
                    return RedirectToAction("Index", "Home", new { area = "Home" });


                    _logger.LogInformation("User created a new account with password.");

                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                    var callbackUrl = Url.Page(
                        "/Account/ConfirmEmail",
                        pageHandler: null,
                        values: new { area = "Identity", userId = user.Id, code = code, returnUrl = returnUrl },
                        protocol: Request.Scheme);

                    await _emailSender.SendEmailAsync(Input.Email, "Confirm your email",
                        $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

                    if (_userManager.Options.SignIn.RequireConfirmedAccount)
                    {
                        return RedirectToPage("RegisterConfirmation", new { email = Input.Email, returnUrl = returnUrl });
                    }
                    else
                    {
                        await _signInManager.SignInAsync(user, isPersistent: false);
                        return LocalRedirect(returnUrl);
                    }
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}
