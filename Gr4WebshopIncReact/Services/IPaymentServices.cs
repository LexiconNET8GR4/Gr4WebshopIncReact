using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gr4WebshopIncReact.Models;

namespace Gr4WebshopIncReact.Services
{
    public interface IPaymentServices
    {
        public Payment CreatePayment(Order order, PaymentMethod method);
        public Payment GetById(Guid id);
        public List<Payment> Search(string SearchPhrase);
        public Payment Update(Payment payment);
        public bool Delete(Payment payment);
    }
}
