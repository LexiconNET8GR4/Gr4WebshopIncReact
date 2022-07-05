using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gr4WebshopIncReact.Models
{
    public class ShippingMethod
    {
        public Guid id { get; set; }
        public string type { get; set; }
        public string provider { get; set; }
    }
}
