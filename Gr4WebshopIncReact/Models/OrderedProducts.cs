using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Gr4WebshopIncReact.Models
{
    // Class needed for many-to-many relation
    public class OrderedProducts
    {
        [Required]
        public Guid OrderKey { get; set; }
        public Order Order { get; set; }

        [Required]
        public Guid ProductKey { get; set; }
        public Product Product { get; set; }
    }
}
