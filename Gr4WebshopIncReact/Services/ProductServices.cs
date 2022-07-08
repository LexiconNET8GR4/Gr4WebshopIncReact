using Gr4WebshopIncReact.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gr4WebshopIncReact.Data;

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
            _context.Products.Remove(product);
            return _context.SaveChanges() > 0 ? true : false;
        }

        public List<Product> GetAll()
        {
            List<Product> products = _context.Products.ToList();
            foreach(Product product in products)
            {
                product.Details = _context.Details.Where(d => d.Id == product.DetailsKey).FirstOrDefault();
                product.ImagesDestination = _context.Set<ImageDestination>().Where(i => i.ProductKey == product.Id).ToList();
            }
            return products;
        }

        public Product GetById(Guid id)
        {
            Product product=_context.Products.Where(p=>p.Id==id).FirstOrDefault();
            if (product == null) return null;
            product.Details = _context.Details.Where(d => d.Id == product.DetailsKey).FirstOrDefault();
            product.ImagesDestination = _context.Set<ImageDestination>().Where(i => i.ProductKey == product.Id).ToList();
            return product;
        }

        public List<Product> Search(string SearchPhrase)
        {
            throw new NotImplementedException();
        }

        public Product Update(Product product)
        {
            _context.Update(product);
            return _context.SaveChanges() > 0 ? product : null;
        }
    }
}
