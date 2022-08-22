using Gr4WebshopIncReact.Data;
using Gr4WebshopIncReact.Models;
using Microsoft.EntityFrameworkCore;
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
            Order? orderToReturn = _context.Orders.Where(o => o.Id == id)
                .Include(p => p.Products)
                .Include(p => p.ShippingMethod)
                .Include(p => p.Payment)
                .FirstOrDefault();
            return orderToReturn;
        }

        public List<Order> GetByUserId(Guid id)
        {
            List<Order> orders = _context.Orders.Where(u => u.UserKey == id.ToString())
                .Include(o => o.Products)
                .Include(o => o.ShippingMethod)
                .Include(o => o.Payment)
                .ToList();
            return orders;
        }

        public List<Order> Search(string SearchPhrase)
        {
            throw new NotImplementedException();
        }

        public Order Update(Order order)
        {
            _context.Orders.Update(order);
            return _context.SaveChanges() > 0 ? order : null;
        }

        public Order UpdateOrderProducts(Order order, List<CheckoutItem> newProducts)
        {
            order.Products = new List<OrderedProduct>();
            List<OrderedProduct> oldProducts = _context.OrderedProducts.Where(op => op.OrderKey == order.Id).ToList();
            _context.RemoveRange(oldProducts);

            foreach (CheckoutItem c in newProducts)
            {
                OrderedProduct orderedProduct = new OrderedProduct()
                {
                    OrderKey = order.Id,
                    ProductKey = c.ProductId,
                    Product = _productServices.GetById(c.ProductId),
                    Amount = c.Quantity
                };
                order.Products.Add(orderedProduct);
            }


            return order;
        }

        private Order CreateOrderCommon(Customer customer, List<CheckoutItem> products, string shippingAddress, PaymentMethod paymentMethod)
        {
            // Feature not implemted, create dummy shipping method to avoid issues
            ShippingMethod shipping = new ShippingMethod()
            {
                Id = Guid.NewGuid(),
                Type = "Dummy Type",
                Provider = "Dummy Provider"

            };
            Order order = new Order();
            order.CustomerKey = customer.Id;
            order.Customer = customer;
            order.ShippingAddress = shippingAddress;
            order.Payment = new Payment() { Method = paymentMethod };
            order.Products = new List<OrderedProduct>();
            order.ShippingMethod = shipping;
            if (customer.UserKey != null) 
                order.UserKey = customer.UserKey.ToString();
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
