using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gr4WebshopIncReact.Models;

namespace Gr4WebshopIncReact.Services
{
    public interface ICartServices
    {
        public bool AddToCart(Product product, double amount);
        public bool RemoveFromCart(Product product, double amount );

    }
}
