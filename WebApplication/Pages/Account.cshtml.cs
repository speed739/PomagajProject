using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using WebApplication.Models;

namespace WebApplication.Pages
{
    public class AccountModel : PageModel
    {
        [BindProperty]
        public Company Model { get; set; }
        private readonly PomagajLokalnieContext _context;
        private ILogger<IdentityUser> _logger;
        private readonly User _user;

        public AccountModel(PomagajLokalnieContext context, ILogger<IdentityUser> logger,User user)
        {
            _context = context;
            _logger = logger;
            _user = user;
        }
        
        public void OnGet()
        {
            
        }
        public async Task<IActionResult> OnPostAsync()
        {
            // if (ModelState.IsValid)
            // {
            //     
            //
            //    if (result >0)
            //     {
            //         _logger.LogInformation("Update processed successfully");
            //      return RedirectToPage("Index");
            //     }
            //  }
            //
             return RedirectToPage("./Index");
        }
        
        
    }
}