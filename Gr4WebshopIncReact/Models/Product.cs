using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gr4WebshopIncReact.Models
{
    public class Product
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public string CoverImageDestination { get; set; }
        public List<string> ImagesDestination { get; set; }
        public string Type { get; set; }
        public Details Details { get; set; }

        public double Price { get; set; }
        public double CurrentPrice { get; set; }
        public double SaleAmount { get; set; }
        public double SalePercentage { get; set; }

        public int Storage { get; set; }
        public string DateStocked { get; set; }
        public string Brand { get; set; }
    }
}
