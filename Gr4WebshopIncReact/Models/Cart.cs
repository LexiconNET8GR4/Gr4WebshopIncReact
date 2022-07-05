using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gr4WebshopIncReact.Models
{
    public class Cart
    {
        public List<CartProduct> products { get; set; }
        public Coupon coupon { get; set; }
    }
}
