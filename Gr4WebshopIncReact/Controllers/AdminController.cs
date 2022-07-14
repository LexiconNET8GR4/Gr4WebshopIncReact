using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Gr4WebshopIncReact.Models;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Gr4WebshopIncReact.Models.viewModels;

namespace Gr4WebshopIncReact.Controllers
{
    // Disabled during testing
    //[Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private static AdminIndexVM indexVM;

        public AdminController()
        {
            if (indexVM == null)
            {
                indexVM = new AdminIndexVM();
            }
            UpdateViewModel();
        }

        public IActionResult Index()
        {
            List<string> images = Directory.GetFiles("wwwroot/uploaded_images").ToList();
            for (int i = 0; i < images.Count; i++)
            {
                images[i] = images[i].Split("/")[1];
            }

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

            // Get the image paths
            List<string> images = Directory.GetFiles("wwwroot/uploaded_images").ToList();
            for (int i = 0; i < images.Count; i++)
            {
                images[i] = images[i].Split("/")[1];
            }

            indexVM.ImageLocations = images;
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
