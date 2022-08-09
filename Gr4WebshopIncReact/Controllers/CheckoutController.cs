using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gr4WebshopIncReact.Models;
using Gr4WebshopIncReact.Models.DTOS;
using Microsoft.AspNetCore.Authorization;
using Gr4WebshopIncReact.Services;

namespace Gr4WebshopIncReact.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class CheckoutController : Controller
    {
        private readonly IOrderServices _orderServices;
        private readonly ICustomerServices _customerServices;

        public CheckoutController(IOrderServices orderServices,ICustomerServices customerServices)
        {
            _orderServices = orderServices;
            _customerServices = customerServices;
        }

        [Route("registered")]
        [Authorize]
        public ActionResult Registered(string checkoutItems,Guid customerId,string shippingAddress)
        {
            var checkoutItemsList=Newtonsoft.Json.JsonConvert.DeserializeObject<List<CheckoutItem>>(checkoutItems);
            Customer customer = _customerServices.GetById(customerId);
            if (customer == null) return BadRequest();
            Order order=_orderServices.CreateOrder(customer, checkoutItemsList, shippingAddress, new PaymentMethod() { Id = Guid.NewGuid(), Type = "Dummy Test" });
            Receipt receipt = new Receipt(order);
            return Json(receipt);
        }


        [Route("anonymous")]
        public ActionResult Anonymous(string checkoutItems,CustomerDTO customer, string shippingAddress)
        {
            var checkoutItemsList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<CheckoutItem>>(checkoutItems);
            Customer newCustomer = _customerServices.CreateCustomer(customer.FirstName, customer.LastName);
            Order order = _orderServices.CreateOrder(newCustomer, checkoutItemsList, shippingAddress, new PaymentMethod() { Id = Guid.NewGuid(), Type = "Dummy Test" });
            Receipt receipt = new Receipt(order);
            return Json(receipt);
        }



    }
    
}
