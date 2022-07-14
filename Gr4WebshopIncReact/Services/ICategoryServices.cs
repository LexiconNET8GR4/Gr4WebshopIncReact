using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gr4WebshopIncReact.Models;

namespace Gr4WebshopIncReact.Services
{
    public interface ICategoryServices
    {
        public Category CreateCategory(Category category);
        public bool Delete(Guid id);
        public List<Category> GetAll();
        public Category FindById(Guid id);
        public Category Update(Category category);
        public List<Category> FindByProduct(Product product);
        public List<Category> FindByName(string Name);
        public Category AddProduct(Category category,Product product);
        public Category AddSubCategory(Category parent, Category subCategory);



    }
}
