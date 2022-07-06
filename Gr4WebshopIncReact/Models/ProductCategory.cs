using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Gr4WebshopIncReact.Models
{
    // Class required for many-to-many relation
    public class ProductCategory
    {
        [Required]
        public Guid ProductKey { get; set; }
        public Product Product { get; set; }
        [Required]
        public Guid CategoryKey { get; set; }
        public Category Category { get; set; }
    }
}
