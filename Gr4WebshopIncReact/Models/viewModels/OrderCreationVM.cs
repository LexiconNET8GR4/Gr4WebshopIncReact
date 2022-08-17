using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gr4WebshopIncReact.Models.viewModels
{
    public class OrderCreationVM
    {
        public List<Order> Orders { get; set; }
        public List<ApplicationUser> Users { get; set; }
        public List<Product> Products { get; set; }
    }
}
