using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication.Models
{
    public partial class OfferType
    {
        public OfferType()
        {
            Offers = new HashSet<Offer>();
        }

        public int OfferTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Offer> Offers { get; set; }
    }
}
