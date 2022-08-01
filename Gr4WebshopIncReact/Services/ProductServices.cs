using Gr4WebshopIncReact.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gr4WebshopIncReact.Data;
using Microsoft.EntityFrameworkCore;

namespace Gr4WebshopIncReact.Services
{
    public class ProductServices : IProductServices
    {
        private readonly ApplicationDbContext _context;

        public ProductServices(ApplicationDbContext context)
        {
            _context = context;
        }
        public Product CreateProduct(string name)
        {
            Product product = new Product() {
                Id = Guid.NewGuid(),
                Name=name
            };
            Details details = new Details();
            details.Id = Guid.NewGuid();
            product.Details = details;
            _context.Add(details);
            _context.Add(product);
            return _context.SaveChanges()>0?product:null;
            
        }

        public bool Delete(Guid id)
        {
            Product product = GetById(id);
            if (product == null) return false;
            _context.Products.Remove(product);
            return _context.SaveChanges() > 0 ? true : false;
        }

        public List<Product> GetAll()
        {
            List<Product> products = _context.Products
                .Include(p => p.Details)
                .Include(p => p.ImagesDestination)
                .Include(p => p.Categories)
                .ToList();
            if (products == null || products.Count() == 0) return null;
            
            return products;
        }

        public Product GetById(Guid id)
        {
            Product product=_context.Products.Where(p=>p.Id==id)
                .Include(p => p.Details)
                .Include(p => p.ImagesDestination)
                .Include(p => p.Categories)
                .FirstOrDefault();
            if (product == null) return null;
            return product;
        }

        public List<Product> Find(string SearchPhrase)
        {
            List<Product> products = _context.Products.Where(p =>
                p.Details.Data.Contains(SearchPhrase) ||
                p.Name.Contains(SearchPhrase) ||
                p.Description.Contains(SearchPhrase) ||
                p.Brand.Contains(SearchPhrase)
                )
            .Include(p => p.Details)
            .Include(p => p.ImagesDestination)
            .Include(p => p.Categories)
            .ToList();
            return products;
        }

        public Product Update(Product product)
        {
            _context.Update(product);
            return _context.SaveChanges() > 0 ? product : null;
        }

        public List<Product> FindByName(string SearchPhrase)
        {
            List<Product> products = _context.Products.Where(p =>
            p.Name.Contains(SearchPhrase)
            ).ToList();
            return products;
        }

        public List<Product> FindByBrand(string SearchPhrase)
        {
            List<Product> products = _context.Products.Where(p =>
            p.Brand.Contains(SearchPhrase)
            )
            .Include(p => p.Details)
            .Include(p => p.ImagesDestination)
            .Include(p => p.Categories)
            .ToList();
            return products;
        }

        public List<Product> FindByCategory(Guid CategoryId)
        {
            List<Category> categories = _context.Categories.Where(c => c.Id==CategoryId).ToList();

            List<Product> products = new List<Product>();
            List<ProductCategory> productCategories = new List<ProductCategory>();
            if (categories == null || categories.Count == 0) return null;
            foreach(Category c in categories)
            {
                productCategories.Add(_context.ProductCategories.Where(p => p.CategoryKey == c.Id).FirstOrDefault());
            }
            if(productCategories!=null&&productCategories.Count>0) foreach(ProductCategory pc in productCategories)
            {
                if(pc!=null)products.Add(_context.Products.Where(p => p.Id == pc.ProductKey)
                .Include(p => p.Details)
                .Include(p => p.ImagesDestination)
                .Include(p => p.Categories)
                .FirstOrDefault());
            }
            return products;
        }

        public List<Product> FindByDetails(string SearchPhrase)
        {
            List<Product> products = _context.Products.Where(p =>
            p.Details.Data.Contains(SearchPhrase)
            )
                .Include(p => p.Details)
                .Include(p => p.ImagesDestination)
                .Include(p => p.Categories)
                .ToList();
            return products;
        }

        public List<Product> FindByDescription(string SearchPhrase)
        {
            List<Product> products = _context.Products.Where(p =>
            p.Description.Contains(SearchPhrase)
            )
                .Include(p => p.Details)
                .Include(p => p.ImagesDestination)
                .Include(p => p.Categories)
                .ToList();
            return products;
        }
    }
}
