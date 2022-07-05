using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gr4WebshopIncReact.Models
{
    public class Order
    {
        public Guid id { get; set; }

        public Customer customer { get; set; }
        public List<Product> products { get; set; }
        public double totalCost { get; set; }

        public string shippingAddress { get; set; }
        public DateTime orderDate { get; set; }

        public string status { get; set; }

        public PaymentMethod paymentMethod { get; set; }
        public Coupon coupon { get; set; }
    }
}
