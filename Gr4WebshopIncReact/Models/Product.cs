using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Gr4WebshopIncReact.Models
{
    public class Product
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public string CoverImageDestination { get; set; }
        public List<ImageDesitination> ImagesDestination { get; set; } // Should be renamed
        //public string Type { get; set; }
        public Guid DetailsKey {get; set; }
        public Details Details { get; set; }
        public List<ProductCategory> Categories { get; set; }

        public double Price { get; set; }
        public double CurrentPrice { get; set; }
        public double SaleAmount { get; set; }
        public double SalePercentage { get; set; }

        public int Storage { get; set; }
        public DateTime DateStocked { get; set; }
        public string Brand { get; set; }
    }
}
