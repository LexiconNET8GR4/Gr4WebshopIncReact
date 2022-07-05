using Gr4WebshopIncReact.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gr4WebshopIncReact.Services
{
    public class PaymentMethodDummyServices : IPaymentMethodServices
    {
        public PaymentMethod CreatePaymentMethod(string name)
        {
            throw new NotImplementedException();
        }

        public bool Delete(PaymentMethod paymentMethod)
        {
            throw new NotImplementedException();
        }

        public PaymentMethod GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<PaymentMethod> Search(string SearchPhrase)
        {
            throw new NotImplementedException();
        }

        public PaymentMethod Update(PaymentMethod paymentMethod)
        {
            throw new NotImplementedException();
        }
    }
}
