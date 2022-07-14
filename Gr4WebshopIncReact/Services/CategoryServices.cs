using Gr4WebshopIncReact.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gr4WebshopIncReact.Data;
using Gr4WebshopIncReact.Models.DTOS;
using Microsoft.EntityFrameworkCore;

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
            var AllreadyExists=_context.ProductCategories.Where(pc => pc.CategoryKey == category.Id && pc.ProductKey == product.Id).FirstOrDefault();
            if (AllreadyExists != null) { return FindById(AllreadyExists.CategoryKey); }
            else
            {
                ProductCategory productCategory = new ProductCategory()
                {
                    ProductKey = product.Id,
                    CategoryKey = category.Id
                };
                _context.ProductCategories.Add(productCategory);
                return _context.SaveChanges() > 0 ? category : null;
            }
        }

        public Category AddSubCategory(Category parent, Category subCategory)
        {
            return null;
        }

        public Category CreateCategory(Category category)
        {
            _context.Categories.Add(category);
            return _context.SaveChanges()>0?category:null;
            
        }

        public bool Delete(Guid id)
        {
            _context.Categories.Remove(FindById(id));
            return _context.SaveChanges() > 0 ? true : false;
        }

        public Category FindById(Guid id)
        {

            Category category = _context.Categories.Where(c => c.Id == id)
                .Include(c=>c.SubCategories)
                .FirstOrDefault();
            if (category == null) return null;
            return category;
        }

        public List<Category> FindByName(string Name)
        {
            List<Category> categories = _context.Categories.Where(c => c.Name == Name)
                .Include(c=>c.SubCategories)
                .ToList();
            
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

        public List<Category> GetAll()
        {
            List<Category> categories = _context.Categories
                .Include(c => c.SubCategories)
                .ToList();
            
            return categories;
        }

        public Category Update(Category category)
        {
            _context.Categories.Update(category);
            return _context.SaveChanges() > 0 ? category : null;
        }
    }
}
