using Gr4WebshopIncReact.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gr4WebshopIncReact.Services
{
    public class OrderDummyServices : IOrderServices
    {
        public Order CreateOrder(Customer customer, List<Product> products, string shippingAddress, PaymentMethod paymentMethod)
        {
            throw new NotImplementedException();
        }

        public Order CreateOrder(Customer customer, List<Product> products, string shippingAddress, PaymentMethod paymentMethod, Coupon coupon)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Order order)
        {
            throw new NotImplementedException();
        }

        public Order GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Order> Search(string SearchPhrase)
        {
            throw new NotImplementedException();
        }

        public Order Update(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
