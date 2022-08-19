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

        public OrderController(IOrderServices orderServices)
        {
            _orderServices = orderServices;
        }

        [Route("deleteorder")]
        [Authorize(Roles ="Admin")]
        public ActionResult DeleteOrder(Guid orderId)
        {
            if (_orderServices.Delete(orderId)) return StatusCode(200);
            else return BadRequest();
        }

        [Route("editorder")]
        [Authorize(Roles = "Admin")]
        public ActionResult EditOrder(string orderDTO)
        {
            OrderDTO recievedData = Newtonsoft.Json.JsonConvert.DeserializeObject<OrderDTO>(orderDTO);
            Order orderToEdit = recievedData.ConvertToOrder();
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
    }
}
