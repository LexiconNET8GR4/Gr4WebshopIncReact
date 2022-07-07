using Gr4WebshopIncReact.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gr4WebshopIncReact.Services
{
    public class ProductDummyServices : IProductServices
    {
        public Product CreateProduct(string name)
        {
            Product product = new Product() {
            Id=Guid.NewGuid(),
            Name=name,
            Type="Type",
            Price= 10,
            CurrentPrice=11,
            SaleAmount=12,
            SalePercentage=0,
            Storage=0,
            DateStocked="Today",
            Brand="Brand"
            };
            
            return product;
        }

        public bool Delete(Guid id)
        {
            return true;
        }

        public List<Product> GetAll()
        {
            Product product1 = new Product();
            Product product2 = new Product();
            List<Product> products = new List<Product>()
            {
                product1,
                product2
            };
            return products;
        }

        public Product GetById(Guid id)
        {
            Product product = new Product();
            return product;
        }

        public List<Product> Search(string SearchPhrase)
        {

            Product product1 = new Product();
            Product product2 = new Product();
            List<Product> products = new List<Product>()
            {
                product1,
                product2
            };
            return products;
        }

        public Product Update(Product product)
        {
            
            return product;
        }
    }
}
