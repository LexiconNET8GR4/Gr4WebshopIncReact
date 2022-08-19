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
    public class UserController : Controller
    {
        private readonly IUserServices _userServices;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<ApplicationUser> _userManager;
        public UserController(IUserServices userServices, RoleManager<IdentityRole> roleManager, UserManager<ApplicationUser> userManager)
        {
            _userServices = userServices;
            _roleManager = roleManager;
            _userManager = userManager;
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

        [Route("getuser")]
        [Authorize(Roles ="Admin")]
        public ActionResult GetUser(Guid id)
        {
            var user = _userServices.GetById(id);
            var userToReturn = new UserDTO(user);
            return Json(userToReturn);

        }
        
        // Saved original
        //[Route("edituser")]
        //[Authorize(Roles ="Admin")]
        //public ActionResult EditUser(ApplicationUser user)
        //{
        //    AdminUserDTO adminUserDTO = new AdminUserDTO(_userServices.Update(user));
        //    return Json(adminUserDTO);
        //}

        // Altered for easier front end usage
        [Route("edituser")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> EditUser(
            [Required] string id,
            string FirstName,
            string LastName,
            string Email,
            string Adress,
            string PhoneNumber,
            string Roles)
        {
            // Ensure a valid ID ahs been passed
            Guid recievedID;
            if (Guid.TryParse(id, out recievedID) == false)
            {
                return BadRequest();
            }

            // Ensure that the user to edit exists in the database
            ApplicationUser userToEdit;
            try
            {
                userToEdit = _userServices.GetById(recievedID);
            }
            catch (NullReferenceException)
            {
                return BadRequest();
            }
            userToEdit.FirstName = FirstName;
            userToEdit.LastName = LastName;
            userToEdit.Email = Email;
            userToEdit.NormalizedEmail = Email.ToUpper();
            userToEdit.Adress = Adress;
            userToEdit.PhoneNumber = PhoneNumber;
            List<string> aquiredRoles = Newtonsoft.Json.JsonConvert.DeserializeObject<List<string>>(Roles);

            // Remove old roles and add in the new ones
            await _userManager.RemoveFromRolesAsync(userToEdit, await _userManager.GetRolesAsync(userToEdit));
            foreach (string role in aquiredRoles)
            {
                if (await _roleManager.RoleExistsAsync(role))
                {
                    await _userManager.AddToRoleAsync(userToEdit, role);
                }
            }

            // Ensure that the last admin does not lose admin priveledge
            if (_userServices.GetAllWithRole("Admin").Count == 0)
            {
                if (await _roleManager.RoleExistsAsync("Admin"))
                {
                    await _roleManager.CreateAsync(new IdentityRole("Admin"));
                    await _userManager.AddToRoleAsync(userToEdit, "Admin");
                }
            }

            AdminUserDTO adminUserDTO = new AdminUserDTO(_userServices.Update(userToEdit));
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
