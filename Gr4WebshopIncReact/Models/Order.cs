using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Gr4WebshopIncReact.Models
{
    public class Order
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public Guid CustomerKey { get; set; }
        public Customer Customer { get; set; }

        public Guid UserKey { get; set; }
        public ApplicationUser User { get; set; }

        public List<OrderedProducts> Products { get; set; }
        public double TotalCost { get; set; }

        public string ShippingAddress { get; set; }
        public DateTime OrderDate { get; set; }

        public string Status { get; set; }

        [Required]
        public Guid PaymentKey { get; set; }
        public Payment Payment { get; set; }
        [Required]
        public Guid ShipmentID { get; set; }
        public ShippingMethod ShippingMethod { get; set; }
        public Coupon Coupon { get; set; }
    }
}
