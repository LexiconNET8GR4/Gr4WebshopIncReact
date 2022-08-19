using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Gr4WebshopIncReact.Models;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Gr4WebshopIncReact.Models.viewModels;
using Gr4WebshopIncReact.Data;
using Microsoft.AspNetCore.Identity;
using Gr4WebshopIncReact.Models.DTOS;

namespace Gr4WebshopIncReact.Controllers
{
    // Disabled during testing
    //[Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private static ProductMgmtVM productVM;
        private static CategoryMgmtVM categoryVM;
        private static UserMgmtVM userVM;
        private static OrderMgmtVM orderVM;
        private readonly ApplicationDbContext _context;

        public AdminController(ApplicationDbContext context)
        {
            _context = context;

            if (productVM == null)
            {
                productVM = new ProductMgmtVM();
                UpdateProductVM();
            }
            if (categoryVM == null)
            {
                categoryVM = new CategoryMgmtVM();
                UpdateCategoryVM();
            }
            if (userVM == null)
            {
                userVM = new UserMgmtVM();
                UpdateUserVM();
            }
            if (orderVM == null)
            {
                orderVM = new OrderMgmtVM();
                UpdateOrderVM();
            }
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ProductManagement()
        {
            UpdateProductVM();
            return View(productVM);
        }
        public IActionResult CategoryManagement()
        {
            UpdateCategoryVM();
            return View(categoryVM);
        }
        public IActionResult UserManagement()
        {
            UpdateUserVM();
            return View(userVM);
        }

        public IActionResult OrderManagement()
        {
            UpdateOrderVM();
            return View(orderVM);
        }

        private void UpdateOrderVM()
        {
            // Ensure it exists
            if (orderVM == null)
            {
                orderVM = new OrderMgmtVM();
            }
            orderVM.OrderCreationVM = new OrderCreationVM
            {
                Orders = _context.Orders.ToList(),
                Users = _context.Users.ToList(),
                Products = _context.Products.ToList()
            };
        }

        private void UpdateUserVM()
        {
            // Ensure it exists
            if (userVM == null)
            {
                userVM = new UserMgmtVM();
            }

            userVM.Users = _context.Users.OrderBy(x => x.FirstName).ThenBy(y => y.LastName).ToList();
            userVM.UserEditorVM = new UserEditorVM
            {
                Users = userVM.Users,
                Roles = _context.Roles.OrderBy(x => x.Name).ToList()
            };
        }

        private void UpdateCategoryVM()
        {    
            // Ensure it exists
            if (categoryVM == null)
            {
                categoryVM = new CategoryMgmtVM();
            }

            categoryVM.Categories = _context.Categories.OrderBy(x => x.Name).ToList();
        }

        private void UpdateProductVM()
        {
            // Ensure it exists
            if (productVM == null)
            {
                productVM = new ProductMgmtVM();
            }

            // Create a fresh file uploading container
            productVM.FilesUploader = new FilesUploadingModel();

            // Get products
            productVM.Products = _context.Products.OrderBy(x => x.Name).ToList();

            // Get the image paths
            List<string> images = Directory.GetFiles("wwwroot/uploaded_images").ToList();
            for (int i = 0; i < images.Count; i++)
            {
                images[i] = images[i].Split("/")[1];
            }
            productVM.ImageLocations = images;

            // Create a fresh ProductCreation view model
            productVM.ProductCreatorVM = new ProductCreationVM
            {
                ImageLocations = images,
                Categories = _context.Categories.ToList()
            };

            // Create a fresh ProductEditor view model
            productVM.ProductEditorVM = new ProductEditorVM
            {
                ImageLocations = images,
                Categories = _context.Categories.ToList(),
                Products = _context.Products.OrderBy(x => x.Name).ToList()
            };

        }

        public IActionResult GetUserRoles(string userId)
        {
            // Get all role-to-user connectors involved with the requested user
            List<IdentityUserRole<string>> userRoles = _context.UserRoles.Where(x => x.UserId == userId).ToList();

            // Extract the role keys
            List<string> roleIds = new List<string>();
            for (int i = 0; i < userRoles.Count; i++)
            {
                roleIds.Add(userRoles[i].RoleId);
            }

            // Find all roles with matching keys
            List<IdentityRole> roles = _context.Roles.Where(x => roleIds.Contains(x.Id)).ToList();

            return Json(roles);
        }

        public IActionResult GetCustomer(string customerId)
        {

            Customer customerToReturn;
            Guid recievedId;

            // Parse recieved id
            if (Guid.TryParse(customerId, out recievedId) == false) 
                return BadRequest();

            customerToReturn = _context.Customers.Find(recievedId);

            // Sanity check
            if (customerToReturn == null)
                return BadRequest();

            CustomerDTO dtoToRetrun = new CustomerDTO { 
                FirstName = customerToReturn.FirstName,
                LastName = customerToReturn.LastName,
                Adress = customerToReturn.Adress,
                Email = customerToReturn.Email
            };

            return Json(dtoToRetrun);
        }
    }
}
