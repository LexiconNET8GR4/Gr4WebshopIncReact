using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gr4WebshopIncReact.Models
{
    public class Product
    {
        public Guid id { get; set; }

        public string name { get; set; }
        public string description { get; set; }
        public string coverImageDestination { get; set; }
        public List<string> imagesDestination { get; set; }
        public string type { get; set; }
        public Details details { get; set; }

        public double price { get; set; }
        public double currentPrice { get; set; }
        public double saleAmount { get; set; }
        public double salePercentage { get; set; }

        public int storage { get; set; }
        public string dateStocked { get; set; }
        public string brand { get; set; }
    }
}
