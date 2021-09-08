using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using WebApplication.ViewModel;
using WebApplication.Models;

namespace WebApplication.Pages
{
    [AllowAnonymous]
    public class RegisterModel : PageModel
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly PomagajLokalnieContext _context;
        private readonly ILogger<RegisterModel> _logger;

        [BindProperty]
        public Register Model { get; set; }

        public RegisterModel(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager,PomagajLokalnieContext context,ILogger<RegisterModel> logger)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
            _logger = logger;
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                var user = new IdentityUser()
                {
                    UserName = Model.Email,
                    Email = Model.Email
                };

                var newAppUser = new User()
                { 
                    Login = Model.Email,
                    Password = Model.Password,
                    Roles = Model.Roles
                };
                var result = await _userManager.CreateAsync(user, Model.Password);
                
                _context.Users.Add(newAppUser);
                await _context.SaveChangesAsync();
               
                
                
                if (result.Succeeded)
                {
                    _logger.LogInformation("User created a new account with password.");
                    await _signInManager.SignInAsync(user, false);
                    if (newAppUser.Roles.Equals("Company"))
                    {
                        return RedirectToPage("Account");    
                    }
                    if (newAppUser.Roles.Equals("User"))
                    {
                        return RedirectToPage("Index");    
                    }
                    return RedirectToPage("Index");
                    
                }
                foreach (var error in result.Errors) ModelState.AddModelError(string.Empty, error.Description);
               
            }

            return RedirectToPage("Login");
        }

    }
}