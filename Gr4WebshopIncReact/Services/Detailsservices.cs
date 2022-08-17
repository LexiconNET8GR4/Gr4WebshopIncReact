using Gr4WebshopIncReact.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gr4WebshopIncReact.Data;

namespace Gr4WebshopIncReact.Services
{
    public class Detailsservices : IDetailsservices
    {
        private readonly ApplicationDbContext _context;

        public Detailsservices(ApplicationDbContext context)
        {
            _context = context;
        }

        public Details GetDetails(Guid productId)
        {
            return _context.Details.Where(d => d.ProductKey == productId).FirstOrDefault();
        }
    }
}
