using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gr4WebshopIncReact.Models
{
    public class Payment
    {
        public Guid id { get; set; }
        public Order order { get; set; }
        public PaymentMethod method { get; set; }
    }
}
