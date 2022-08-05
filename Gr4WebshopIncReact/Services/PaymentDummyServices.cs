using Gr4WebshopIncReact.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gr4WebshopIncReact.Services
{
    public class PaymentDummyServices : IPaymentServices
    {
        public Payment CreatePayment(Order order, PaymentMethod method)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Payment payment)
        {
            throw new NotImplementedException();
        }

        public Payment GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Payment> Search(string SearchPhrase)
        {
            throw new NotImplementedException();
        }

        public Payment Update(Payment payment)
        {
            throw new NotImplementedException();
        }
    }
}
