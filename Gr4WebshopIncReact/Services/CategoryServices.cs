using Gr4WebshopIncReact.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gr4WebshopIncReact.Data;
using Gr4WebshopIncReact.Models.DTOS;

namespace Gr4WebshopIncReact.Services
{
    public class CategoryServices : ICategoryServices
    {
        private readonly ApplicationDbContext _context;
        private readonly IProductServices _productServices;

        public CategoryServices(ApplicationDbContext context,IProductServices productServices)
        {
            _context = context;
            _productServices = productServices;
        }

        public Category AddProduct(Category category, Product product)
        {
            return null;
        }

        public Category CreateCategory(Category category)
        {
            _context.Add(category);
            return _context.SaveChanges()>0?category:null;
            
        }

        public bool Delete(Guid id)
        {
            _context.Categories.Remove(FindById(id));
            return _context.SaveChanges() > 0 ? true : false;
        }

        public Category FindById(Guid id)
        {

            Category category = _context.Categories.Where(c => c.Id == id).FirstOrDefault();
            category.SubCategories = _context.SubCategories.Where(s => s.MainKey == category.Id).ToList();
            return category;
        }

        public List<Category> FindByName(string Name)
        {
            List<Category> categories = _context.Categories.Where(c => c.Name == Name).ToList();
            foreach(Category category in categories){
                category.SubCategories = _context.SubCategories.Where(s => s.MainKey == category.Id).ToList(); 
            }
            
            return categories;
        }

        public List<Category> FindByProduct(Product product)
        {
            List<ProductCategory> productCategories = _context.ProductCategories.Where(pc => pc.ProductKey == product.Id).ToList();
            List<Category> categories = new List<Category>();
            foreach(var p in productCategories)
            {
                categories.Add(FindById(p.CategoryKey));
            }
            return categories;
        }

        public List<Category> FindSubCategories(Category category)
        {
            List<Category> categories = new List<Category>();
            List<SubCategory> subCategories = _context.SubCategories.Where(s => s.MainKey == category.Id).ToList();
            if (subCategories == null || subCategories.Count == 0) return null;
            foreach(SubCategory s in subCategories)
            {
                categories.Add(FindById(s.SubKey));
            }
            return categories;
        }

        public List<Category> GetAll()
        {
            List<Category> categories = _context.Categories.ToList();
            foreach(Category category in categories)
            {
                category.SubCategories = _context.SubCategories.Where(s => s.MainKey == category.Id).ToList();
            }
            return categories;
        }

        public Category Update(Category category)
        {
            _context.Categories.Update(category);
            return _context.SaveChanges() > 0 ? category : null;
        }
    }
}
