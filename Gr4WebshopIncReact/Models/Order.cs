using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gr4WebshopIncReact.Models
{
    public class Order
    {
        public Guid Id { get; set; }

        public Customer Customer { get; set; }
        public List<Product> Products { get; set; }
        public double TotalCost { get; set; }

        public string ShippingAddress { get; set; }
        public DateTime OrderDate { get; set; }

        public string Status { get; set; }

        public PaymentMethod PaymentMethod { get; set; }
        public Coupon Coupon { get; set; }
    }
}
