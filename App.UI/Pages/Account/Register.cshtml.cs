using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using SharedTenant.Domain;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace App.UI.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ILogger<RegisterModel> _logger;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IEmailSender _emailSender;
        private readonly IConfiguration _config;

        public RegisterModel(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            ILogger<RegisterModel> logger,
            IEmailSender emailSender,
            IConfiguration config,
            RoleManager<IdentityRole> rolemanager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
            _config = config;
            _roleManager = rolemanager;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }
        [BindProperty(SupportsGet =true)]
        public string Actor { get; set; }
        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public class InputModel
        {
            [Required(ErrorMessage = "Email Field is requred")]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }


            [Display(Name = "UserName")]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            public string UserName { get; set; }


            [Required(ErrorMessage = "Password Field is requred")]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }

            [Required(ErrorMessage = "Photo Field is requred")]
            public IFormFile Photo { get; set; }

            [Required(ErrorMessage = "Address Field is requred")]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]

            public string Address { get; set; }
        }

        public async Task OnGetAsync(string actor =null, string returnUrl = null  )
        {
            if (string.IsNullOrEmpty(actor))
                Actor = "admin";
            else            Actor = actor;

            ReturnUrl = returnUrl;
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/");
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
            if (ModelState.IsValid)
            {

                string photopath = Directory.GetCurrentDirectory() + "/wwwroot/photos/"+Actor+"/";
                string photoname = Path.GetFileName(Input.Photo.FileName);
                string finalpath = photopath + photoname;
                using (var stream = System.IO.File.Create(finalpath))
                {
                    await Input.Photo.CopyToAsync(stream);
                }
                //var roleresult = RoleManager.Create(new IdentityRole(roleName));
                //await _userManager.AddToRoleAsync(""); 
                var user = new ApplicationUser { UserName = Input.UserName, Email = Input.Email, Photo = photoname };

                var result = await _userManager.CreateAsync(user, Input.Password);
                if (result.Succeeded)
                {
                    user.EmailConfirmed = true;
                    _logger.LogInformation("User created a new account with password.");

                    await _signInManager.SignInAsync(user, isPersistent: false);
                    if(Actor.Equals("customer"))
                    {
                        await _userManager.AddToRoleAsync(user, "Customer");
                    var userid = await _userManager.GetUserIdAsync(user);
                    return Redirect("/Account/Register/intersts/" + userid);
                    }
                    else if(Actor.Equals("librarian"))
                    {
                        await _userManager.AddToRoleAsync(user, "Librarian"); 
                        return Redirect("/Account/Register/paymentplan");


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
