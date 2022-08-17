using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gr4WebshopIncReact.Models;

namespace Gr4WebshopIncReact.Services
{
    public interface IOrderServices
    {
        public Order CreateOrder(Customer customer, List<CheckoutItem> products, string shippingAddress, PaymentMethod paymentMethod);
        public Order CreateOrder(Customer customer, List<CheckoutItem> products, string shippingAddress, PaymentMethod paymentMethod, Coupon coupon);
        public Order GetById(Guid id);
        public List<Order> Search(string SearchPhrase);
        public Order Update(Order order);
        public bool Delete(Guid id);
    }
}
