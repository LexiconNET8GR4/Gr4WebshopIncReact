using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gr4WebshopIncReact.Services;
using Gr4WebshopIncReact.Models;
using Gr4WebshopIncReact.Models.DTOS;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Authorization;
using System.Text.Json;
using Microsoft.AspNetCore.Identity;

namespace Gr4WebshopIncReact.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : Controller
    {
        private readonly IOrderServices _orderServices;
        private readonly UserManager<ApplicationUser> _userManager;

        public OrderController(IOrderServices orderServices, UserManager<ApplicationUser> userManager)
        {
            _orderServices = orderServices;
            _userManager = userManager;
        }

        [Route("deleteorder")]
        [Authorize(Roles ="Admin")]
        public ActionResult DeleteOrder(Guid orderId)
        {
            if (_orderServices.Delete(orderId)) return StatusCode(200);
            else return BadRequest();
        }

        //[Route("editorder")]
        //[Authorize(Roles = "Admin")]
        //public ActionResult EditOrder(string orderDTO)
        //{
        //    var recievedData = Newtonsoft.Json.JsonConvert.DeserializeObject<OrderDTO>(orderDTO);
        //    Order orderToEdit = recievedData.ConvertToOrder();
        //    var orderToReturn = new OrderDTO(_orderServices.Update(orderToEdit));
        //    return Json(orderToReturn);
        //}

        [Route("editorder")]
        [Authorize(Roles = "Admin")]
        public ActionResult EditOrder(string orderId, string shippingAdress, string checkoutItems)
        {
            var checkoutItemsList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<CheckoutItem>>(checkoutItems);
            Guid recievedId;
            Order orderToEdit;
            if (Guid.TryParse(orderId, out recievedId))
                orderToEdit = _orderServices.GetById(recievedId);
            else
                return BadRequest();

            if (orderToEdit == null)
                return BadRequest();


            if (shippingAdress != null)
                orderToEdit.ShippingAddress = shippingAdress;

            _orderServices.UpdateOrderProducts(orderToEdit, checkoutItemsList);

            var orderToReturn = new OrderDTO(_orderServices.Update(orderToEdit));
            return Json(orderToReturn);
        }

        [Route("getorder")]
        [Authorize]
        public ActionResult GetOrder(Guid orderId)
        {
            Order order = _orderServices.GetById(orderId);
            if (order.UserKey == User.Identity.Name) return Json(new OrderDTO(order));
            else return BadRequest();
        }


        [Route("getorderasadmin")]
        [Authorize(Roles="Admin")]
        public ActionResult GetOrderAsAdmin(Guid orderId)
        {
            Order order = _orderServices.GetById(orderId);
            if (order == null)
            {
                return BadRequest();
            }
            return Json(new OrderDTO(order));
        }

        [Route("getordersbyuserid")]
        [Authorize(Roles ="Admin")]
        public ActionResult GetOrdersByUserId(Guid userId)
        {
            List<Order> orders = _orderServices.GetByUserId(userId);
            if (orders == null || orders.Count < 1) return BadRequest();
            List<OrderDTO> orderDTOs = new List<OrderDTO>();
            foreach(Order o in orders)
            {
                OrderDTO orderDTO = new OrderDTO(o);
                orderDTOs.Add(orderDTO);
            }
            return Json(orderDTOs);
        }

        [Route("getmyorders")]
        [Authorize]
        public ActionResult GetMyOrders()
        {
            var userId = Guid.Parse(_userManager.GetUserId(User));
            List<Order> orders = _orderServices.GetByUserId(userId);
            if (orders == null || orders.Count < 1) return BadRequest();
            List<OrderDTO> orderDTOs = new List<OrderDTO>();
            foreach (Order o in orders)
            {
                OrderDTO orderDTO = new OrderDTO(o);
                orderDTOs.Add(orderDTO);
            }
            return Json(orderDTOs);
        }
    }
}
