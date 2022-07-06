using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gr4WebshopIncReact.Models
{
    public class Payment
    {
        public Guid Id { get; set; }
        public Order Order { get; set; }
        public PaymentMethod Method { get; set; }
    }
}
