using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gr4WebshopIncReact.Models.DTOS
{

    public class ProductDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string CoverImageDestination { get; set; }
        public List<string> ImagesDestination { get; set; } // Should be renamed
        //public string Type { get; set; }
        public string Details { get; set; }
        public List<Guid> Categories { get; set; }

        public double Price { get; set; }
        public double CurrentPrice
        {
            get
            {
                if (SaleAmount > 0) return Price - SaleAmount;
                if (SalePercentage > 0) return Price * (1 - SalePercentage);
                return Price;
            }
        }
        public double SaleAmount { get; set; }
        public double SalePercentage { get; set; }

        public double Stock { get; set; }
        public DateTime DateStocked { get; set; }
        public string Brand { get; set; }

        public ProductDTO(Product p)
        {
            Id = p.Id;
            Name = p.Name;
            Description = p.Description;
            CoverImageDestination = p.CoverImageDestination;
            ImagesDestination = new List<string>();
            if(p.ImagesDestination!=null&&p.ImagesDestination.Count>0) 
                foreach(ImageDestination i in p.ImagesDestination)
                {
                    ImagesDestination.Add(i.Path);
                }
            if(p.Details!=null)Details = p.Details.Data;
            Categories = new List<Guid>();
            if(p.Categories!=null&&p.Categories.Count>0)
                foreach(ProductCategory c in p.Categories)
                {
                    Categories.Add(c.CategoryKey);
                }
            Price = p.Price;
            SaleAmount = p.SaleAmount;
            SalePercentage = p.SalePercentage;
            Stock = p.Stock;
            DateStocked = p.DateStocked;
            Brand = p.Brand;
        }


    }
}
