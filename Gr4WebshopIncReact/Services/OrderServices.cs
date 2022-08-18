using Gr4WebshopIncReact.Data;
using Gr4WebshopIncReact.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gr4WebshopIncReact.Services
{
    public class OrderServices : IOrderServices
    {
        private readonly ApplicationDbContext _context;
        private readonly IProductServices _productServices;

        public OrderServices(ApplicationDbContext context,IProductServices productServices)
        {
            _context = context;
            _productServices = productServices;
        }
        public Order CreateOrder(Customer customer, List<CheckoutItem> products, string shippingAddress, PaymentMethod paymentMethod)
        {

            Order order = CreateOrderCommon(customer, products, shippingAddress, paymentMethod);
            _context.Orders.Add(order);
            return _context.SaveChanges() > 0 ? order : null;
        }

        public Order CreateOrder(Customer customer, List<CheckoutItem> products, string shippingAddress, PaymentMethod paymentMethod, Coupon coupon)
        {
            Order order = CreateOrderCommon(customer, products, shippingAddress, paymentMethod);
            order.Coupon = coupon;
            _context.Orders.Add(order);
            return _context.SaveChanges() > 0 ? order : null;
        }

        public bool Delete(Guid id)
        {
            var orderToDelete = GetById(id);
            if (orderToDelete == null) return false;
            _context.Orders.Remove(orderToDelete);
            return _context.SaveChanges() > 0 ? true : false;
        }

        public Order GetById(Guid id)
        {
            Order? orderToReturn = _context.Orders.Find(id);
            return orderToReturn;
        }

        public List<Order> Search(string SearchPhrase)
        {
            throw new NotImplementedException();
        }

        public Order Update(Order order)
        {
            throw new NotImplementedException();
        }

        private Order CreateOrderCommon(Customer customer, List<CheckoutItem> products, string shippingAddress, PaymentMethod paymentMethod)
        {
            Order order = new Order();
            order.CustomerKey = customer.Id;
            order.Customer = customer;
            order.ShippingAddress = shippingAddress;
            order.Payment = new Payment() { Method = paymentMethod };
            order.Products = new List<OrderedProduct>();
            foreach(CheckoutItem c in products)
            {
                OrderedProduct orderedProduct = new OrderedProduct()
                {
                    OrderKey = order.Id,
                    ProductKey = c.ProductId,
                    Product=_productServices.GetById(c.ProductId),
                    Amount = c.Quantity
                };
                order.Products.Add(orderedProduct);
            }
            return order;
        }
    }
}
