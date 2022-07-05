using Gr4WebshopIncReact.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gr4WebshopIncReact.Services
{
    public class CartDummyServices : ICartServices
    {
        private readonly IProductServices _productServices;

        public CartDummyServices(IProductServices productServices)
        {
            _productServices = productServices;
        }
        public bool AddToCart(Product product, double amount)
        {
            return true;
        }

        public bool RemoveFromCart(Product product, double amount)
        {
            throw new NotImplementedException();
        }
    }
}
