using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gr4WebshopIncReact.Models;

namespace Gr4WebshopIncReact.Services
{
    public interface IShippingMethodServices
    {
        public ShippingMethod CreateShippingMethod(string type, string provider);
        public ShippingMethod GetById(Guid id);
        public List<ShippingMethod> Search(string SearchPhrase);
        public ShippingMethod Update(ShippingMethod shippingMethod);
        public bool Delete(ShippingMethod shippingMethod);
    }
}
