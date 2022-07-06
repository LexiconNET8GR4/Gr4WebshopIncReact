using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gr4WebshopIncReact.Models
{
    public class Cart
    {
        public List<CartProduct> Products { get; set; }
        public Coupon Coupon { get; set; }
    }
}
