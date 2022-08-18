using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gr4WebshopIncReact.Models;
using Gr4WebshopIncReact.Models.DTOS;
using Microsoft.AspNetCore.Authorization;
using Gr4WebshopIncReact.Services;
using Microsoft.AspNetCore.Identity;
using Gr4WebshopIncReact.Data;

namespace Gr4WebshopIncReact.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class CheckoutController : Controller
    {
        private readonly IOrderServices _orderServices;
        private readonly ICustomerServices _customerServices;

        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IUserServices _userServices;

        public CheckoutController(IOrderServices orderServices,ICustomerServices customerServices, UserManager<ApplicationUser> userManager,IUserServices userServices)
        {
            _orderServices = orderServices;
            _customerServices = customerServices;
            _userManager = userManager;
            _userServices = userServices;
        }

        [Route("registered")]
        [Authorize]
        [HttpPost]
        public ActionResult Registered(string checkoutItems,string customerId,string shippingAddress)
        {
            var checkoutItemsList =Newtonsoft.Json.JsonConvert.DeserializeObject<List<CheckoutItem>>(checkoutItems);
            Customer customer = _customerServices.GetById(Guid.Parse(customerId));
            if (customer == null) 
            {
                var userId = _userManager.GetUserId(User);
                var user = _userServices.GetById(Guid.Parse(userId));
                customer = new Customer( user);
            }
            Order order=_orderServices.CreateOrder(customer, checkoutItemsList, shippingAddress, new PaymentMethod() { Id = Guid.NewGuid(), Type = "Dummy Test" });
            Receipt receipt = new Receipt(order);
            return Json(receipt);
        }


        [Route("anonymous")]
        public ActionResult Anonymous(string checkoutItems,string customerDTO, string shippingAddress)
        {
            CustomerDTO customer = Newtonsoft.Json.JsonConvert.DeserializeObject<CustomerDTO>(customerDTO);
            var checkoutItemsList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<CheckoutItem>>(checkoutItems);
            Customer newCustomer = _customerServices.CreateCustomer(customer.FirstName, customer.LastName,customer.Email,customer.Adress,customer.PhoneNumber);
            Order order = _orderServices.CreateOrder(newCustomer, checkoutItemsList, shippingAddress, new PaymentMethod() { Id = Guid.NewGuid(), Type = "Dummy Test" });
            Receipt receipt = new Receipt(order);
            return Json(receipt);
        }

        [Route("getuserdata")]
        [Authorize]
        public async Task<ActionResult> GetUserData()
        {
            
            var myuser=_userManager.GetUserId(User);
            var user = await _userManager.GetUserAsync(User);
            UserDTO userDTO = new UserDTO(user);
            

            return Json(userDTO);
        }



    }
    
}
