using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gr4WebshopIncReact.Models.DTOS
{
    public class ProductDTO:Product
    {
        public ProductDTO() { 
        
        }
        public ProductDTO(Product product)
        {
            Name = product.Name;
            Description = product.Description;
            CoverImageDestination = product.CoverImageDestination;
            ImagesDestination = product.ImagesDestination;
            Type = product.Type;
            Details =new DetailsDTO(product.Details);
            Price = product.Price;
            CurrentPrice = product.CurrentPrice;
            SaleAmount = product.SaleAmount;
            SalePercentage = product.SalePercentage;
            Storage = product.Storage;
            DateStocked = product.DateStocked;
            Brand = product.Brand;
        }
        
        

        
    }
}
