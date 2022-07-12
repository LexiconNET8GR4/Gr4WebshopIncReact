using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gr4WebshopIncReact.Models;

namespace Gr4WebshopIncReact.Services
{
    public interface IProductServices
    {
        public Product CreateProduct(string name);
        public Product GetById(Guid id);
        public List<Product> GetAll();
        public List<Product> Find(string SearchPhrase);
        public List<Product> FindByName(string SearchPhrase);
        public List<Product> FindByBrand(string SearchPhrase);
        public List<Product> FindByCategory(Guid CategoryId);
        public List<Product> FindByDetails(string SearchPhrase);
        public List<Product> FindByDescription(string SearchPhrase);

        public Product Update(Product product);
        public bool Delete(Guid id);
    }
}

