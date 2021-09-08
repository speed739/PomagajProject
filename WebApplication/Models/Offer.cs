using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication.Models
{
    public partial class Offer
    {
        public Offer()
        {
            Vouchers = new HashSet<Voucher>();
        }

        public int OfferId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? OfferTypeId { get; set; }
        public double? Price { get; set; }
        public DateTime? DeletedAt { get; set; }

        public virtual OfferType OfferType { get; set; }
        public virtual ICollection<Voucher> Vouchers { get; set; }
    }
}
