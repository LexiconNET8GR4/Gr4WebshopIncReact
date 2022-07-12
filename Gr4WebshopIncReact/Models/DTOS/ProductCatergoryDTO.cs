using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gr4WebshopIncReact.Models.DTOS
{
    public class ProductCatergoryDTO:ProductCategory
    {
        public ProductCatergoryDTO(ProductCategory productCategory)
        {
            ProductKey = Guid.Empty;
            Product = null;
        }
    }
}
