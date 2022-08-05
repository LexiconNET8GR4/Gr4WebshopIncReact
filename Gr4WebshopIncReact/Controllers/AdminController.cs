using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Gr4WebshopIncReact.Models;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Gr4WebshopIncReact.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            List<string> images = Directory.GetFiles("wwwroot/uploaded_images").ToList();
            for (int i = 0; i < images.Count; i++)
            {
                images[i] = images[i].Split("/")[1];
            }

            return View(images);
        }
        public IActionResult UploadSingleImage()
        {
            return View("SingleForm", new FileUploadingModel());
        }

        public IActionResult UploadMultipleImageS()
        {
            return View("MultipleForm", new FilesUploadingModel());
        }

    }
}
