using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gr4WebshopIncReact.Models
{
    public class Coupon
    {
        public Guid Id { get; set; }
        public double Amount { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}
