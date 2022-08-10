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
        private static ProductMgmtVM productVM;
        private static CategoryMgmtVM categoryVM;
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
    }
}
