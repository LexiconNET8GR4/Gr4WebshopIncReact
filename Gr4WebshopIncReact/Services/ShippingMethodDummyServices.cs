using Gr4WebshopIncReact.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gr4WebshopIncReact.Services
{
    public class ShippingMethodDummyServices : IShippingMethodServices
    {
        public ShippingMethod CreateShippingMethod(string type, string provider)
        {
            throw new NotImplementedException();
        }

        public bool Delete(ShippingMethod shippingMethod)
        {
            throw new NotImplementedException();
        }

        public ShippingMethod GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<ShippingMethod> Search(string SearchPhrase)
        {
            throw new NotImplementedException();
        }

        public ShippingMethod Update(ShippingMethod shippingMethod)
        {
            throw new NotImplementedException();
        }
    }
}
