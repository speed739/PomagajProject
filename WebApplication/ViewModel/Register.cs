using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace WebApplication.ViewModel
{
    public class Register
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public  string Email { get; set; }
        
        [Required]
        [DataType(DataType.Password)]
        public  string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(Password), ErrorMessage = "Password is not the same")]
        public  string ConfirmPassword { get; set; }
        [Required] [Display(Name = "Type")] public string Roles { get; set; }
        
        
    }
}