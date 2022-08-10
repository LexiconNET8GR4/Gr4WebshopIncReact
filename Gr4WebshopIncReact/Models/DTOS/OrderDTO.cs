using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gr4WebshopIncReact.Models.DTOS
{
    public class OrderDTO
    {
        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }

        public List<Guid> ProductIds { get; set; }
        
        public string UserId { get; set; } 

        public string ShippingAddress { get; set; }
        public DateTime OrderDate { get; set; }

        public string Status { get; set; }

        public Guid PaymentId { get; set; }
        public Guid ShipmentID { get; set; }
        public Guid ShippingMethodId { get; set; }
        public Guid CouponId { get; set; }


        public OrderDTO(Order order)
        {
            Id = order.Id;
            CustomerId = order.CustomerKey;
            ProductIds = new List<Guid>();
            foreach(var p in order.Products)
            {
                ProductIds.Add(p.ProductKey);
            }
            UserId = order.UserKey;
            ShippingAddress = order.ShippingAddress;
            OrderDate = order.OrderDate;
            Status = order.Status;
            PaymentId = order.PaymentKey;
            ShippingMethodId = order.ShippingMethod.Id;
            CouponId = order.Coupon.Id;
        }

        public Order ConvertToOrder()
        {
            Order order = new Order() {
                Id = this.Id,
                CustomerKey = this.CustomerId,
                UserKey=this.UserId,
                ShippingAddress=this.ShippingAddress,
                OrderDate=this.OrderDate,
                Status=this.Status,
                PaymentKey=this.PaymentId,
                ShippingMethod=new ShippingMethod() { Id=this.ShippingMethodId},
                Coupon=new Coupon() { Id=this.CouponId}
            };
            List<OrderedProduct> Products = new List<OrderedProduct>();
            foreach(var p in ProductIds)
            {
                OrderedProduct orderedProduct = new OrderedProduct()
                {
                    ProductKey = p,
                    OrderKey = this.Id
                };
            }
            return order;

        }
    }


}
