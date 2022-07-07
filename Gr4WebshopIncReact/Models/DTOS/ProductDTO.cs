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
            Id = product.Id;
            Name = product.Name;
            Description = product.Description;
            CoverImageDestination = product.CoverImageDestination;
            ImagesDestination = product.ImagesDestination;
            Details =new DetailsDTO(product.Details);
            
            Price = product.Price;
            SaleAmount = product.SaleAmount;
            SalePercentage = product.SalePercentage;
            Storage = product.Storage;
            DateStocked = product.DateStocked;
            Brand = product.Brand;
            Categories = new List<ProductCategory>();
            if(product.Categories!=null&& product.Categories.Count>0) foreach(ProductCategory productCategory in product.Categories)
            {
                ProductCatergoryDTO productCatergoryDTO = new ProductCatergoryDTO(productCategory);
                Categories.Add(productCatergoryDTO);
            }
        }
        
        

        
    }
}
