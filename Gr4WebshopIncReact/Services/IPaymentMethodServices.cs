using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gr4WebshopIncReact.Models;

namespace Gr4WebshopIncReact.Services
{
    public interface IPaymentMethodServices
    {
        public PaymentMethod CreatePaymentMethod(string name);
        public PaymentMethod GetById(Guid id);
        public List<PaymentMethod> Search(string SearchPhrase);
        public PaymentMethod Update(PaymentMethod paymentMethod);
        public bool Delete(PaymentMethod paymentMethod);
    }
}
