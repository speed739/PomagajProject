using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication.Models
{
    public partial class Company
    {
        public string Id { get; set; }
        public int Nip { get; set; }
        public string Name { get; set; }
        public string BankAccount { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
