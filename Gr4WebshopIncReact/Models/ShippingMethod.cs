using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gr4WebshopIncReact.Models
{
    public class ShippingMethod
    {
        public Guid Id { get; set; }
        public string Type { get; set; }
        public string Provider { get; set; }
    }
}
