using Gr4WebshopIncReact.Models;
using Gr4WebshopIncReact.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gr4WebshopIncReact.Services
{
    public class ImageDestinationServices : IImageDestinationServices
    {
        private readonly ApplicationDbContext _context;

        public ImageDestinationServices(ApplicationDbContext context)
        {
            _context = context;
        }

        public ImageDestination AddImageDestination(Product product, string path)
        {
            ImageDestination imageDestination = new ImageDestination()
            {
                Id = Guid.NewGuid(),
                Path = path,
                Product = product,
                ProductKey = product.Id
            };
            _context.Add(imageDestination);
            return _context.SaveChanges() > 0 ? imageDestination : null;
        }

        public ImageDestination GetImageDestination(string path)
        {
            return _context.Set<ImageDestination>().Where(i => i.Path == path).FirstOrDefault();
        }
    }
}
