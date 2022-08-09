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
        private static ProductMgmtVM indexVM; 
        private readonly ApplicationDbContext _context;

        public AdminController(ApplicationDbContext context)
        {
            _context = context;

            if (indexVM == null)
            {
                indexVM = new ProductMgmtVM();
            }
            UpdateViewModel();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ProductManagement()
        {
            return View(indexVM);
        }

        private void UpdateViewModel()
        {
            // Ensure it exists
            if (indexVM == null)
            {
                indexVM = new ProductMgmtVM();
            }

            // Create a fresh file uploading container
            indexVM.FilesUploader = new FilesUploadingModel();

            // Get products
            indexVM.Products = _context.Products.OrderBy(x => x.Name).ToList();

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
                Products = _context.Products.OrderBy(x => x.Name).ToList()
            };

        }
    }
}
