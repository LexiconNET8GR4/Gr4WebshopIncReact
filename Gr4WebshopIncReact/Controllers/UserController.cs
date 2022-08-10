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

namespace Gr4WebshopIncReact.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly IUserServices _userServices;
        public UserController(IUserServices userServices)
        {
            _userServices = userServices;
        }


        [Route("getallusers")]
        [Authorize(Roles = "Admin")]
        public ActionResult GetAllUsers()
        {
            var allUsers = _userServices.GetAll();
            List<AdminUserDTO> allUsersDTO = new List<AdminUserDTO>();
            foreach(var user in allUsers)
            {
                allUsersDTO.Add(new AdminUserDTO(user));
            }
            return Json(allUsersDTO);
        }
        
        
        [Route("edituser")]
        [Authorize(Roles ="Admin")]
        public ActionResult EditUser(ApplicationUser user)
        {
            AdminUserDTO adminUserDTO = new AdminUserDTO(_userServices.Update(user));
            return Json(adminUserDTO);
        }



        [Route("deleteuser")]
        [Authorize(Roles = "Admin")]
        public ActionResult DeleteUser(Guid id)
        {

            if (_userServices.Delete(id)) return StatusCode(200);
            else return BadRequest();
        }



    }
}
