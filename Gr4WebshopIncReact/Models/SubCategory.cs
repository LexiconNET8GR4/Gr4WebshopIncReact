using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Gr4WebshopIncReact.Models
{
    // Class needed for many-to-many relation
    public class SubCategory
    {
        [Required]
        public Guid MainKey { get; set; }
        public Category MainCat { get; set; }

        [Required]
        public Guid SubKey { get; set; }
        public Category SubCat { get; set; }
    }
}
