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
        public List<Product> Search(string SearchPhrase);
        public Product Update(Product product);
        public bool Delete(Product product);
    }
}

