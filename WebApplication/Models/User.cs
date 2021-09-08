using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

#nullable disable

namespace WebApplication.Models
{
    public partial class User: IdentityUser
    {
        public string Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Roles { get; set; }
    }
}
