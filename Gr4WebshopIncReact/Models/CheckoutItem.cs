using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gr4WebshopIncReact.Models
{
    public class CheckoutItem
    {
        public Guid ProductId { get; set; }
        public double Quantity { get; set; }

    }
}
