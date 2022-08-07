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

namespace Gr4WebshopIncReact.Controllers
{
    // Disabled during testing
    //[Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private static AdminIndexVM indexVM; 
        private readonly ApplicationDbContext _context;

        public AdminController(ApplicationDbContext context)
        {
            _context = context;

            if (indexVM == null)
            {
                indexVM = new AdminIndexVM();
            }
            UpdateViewModel();
        }

        public IActionResult Index()
        {
            /*List<string> images = Directory.GetFiles("wwwroot/uploaded_images").ToList();
            for (int i = 0; i < images.Count; i++)
            {
                images[i] = images[i].Split("/")[1];
            }*/

            return View(indexVM);
        }

        public IActionResult ProductManagement()
        {
            UpdateViewModel();
            return View(indexVM);
        }

        private void UpdateViewModel()
        {
            // Ensure it exists
            if (indexVM == null)
            {
                indexVM = new AdminIndexVM();
            }

            // Create a fresh file uploading container
            indexVM.FilesUploader = new FilesUploadingModel();

            // Get products
            indexVM.Products = _context.Products.ToList();

            // Get the image paths
            List<string> images = Directory.GetFiles("wwwroot/uploaded_images").ToList();
            for (int i = 0; i < images.Count; i++)
            {
                images[i] = images[i].Split("/")[1];
            }
            indexVM.ImageLocations = images;

            // Create a fresh ProductCreation view model
            indexVM.ProductCreatorVM = new ProductCreationVM
            {
                ImageLocations = images,
                Categories = _context.Categories.ToList()
            };

            // Create a fresh ProductEditor view model
            indexVM.ProductEditorVM = new ProductEditorVM
            {
                ImageLocations = images,
                Categories = _context.Categories.ToList(),
                Products = _context.Products.ToList()
            };

        }
        [HttpPost]
        public IActionResult TestingAxiosInPages()
        {
            return Json("Test recieved");
        }

        // Remove before push
        #region Decripit
        public IActionResult UploadSingleImage()
        {
            return View("SingleForm", new FileUploadingModel());
        }

        public IActionResult UploadMultipleImageS()
        {
            return View("MultipleForm", new FilesUploadingModel());
        }
        #endregion
    }
}
