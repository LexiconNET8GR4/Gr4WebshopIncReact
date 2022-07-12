using Gr4WebshopIncReact.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Gr4WebshopIncReact.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileUploadingController : Controller
    {
        // Validation variables
        private readonly long maxSizeBytes = 8000000; // 8 MB is the maximum size allowed to be uploaded
        private readonly string[] allowedFormats = {    "image/png",
                                                        "image/jpg",
                                                        "image/jpeg"}; // Are the formats allowed to be uploaded
        // Destination for files
        private readonly string imageDestination = "wwwroot/uploaded_images"; 

        /// <summary>
        /// Post function to be accessed from the frontend, inquires about upload validity before requesting it be saved locally
        /// </summary>
        /// <param name="model">Wraps the file in a more easily modifibale class</param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult UploadNewImage([FromForm] FileUploadingModel model)
        {
            string rejectionMsg = "ModelState not valid"; // Return a message for result of action
            if (ModelState.IsValid)
            {
                // Request validation of the uploaded file,
                // Validating function also updates potential rejection message
                if (ImageIsLegal(model, out rejectionMsg))
                {
                    // Once validated upload the file to the desination folder
                    UploadedFile(model, imageDestination);
                }
            }
            return Json(rejectionMsg);
        }

        /// <summary>
        /// Validate the leagality of a uploaded file, compare it to legal image formats and size restrictions
        /// </summary>
        /// <param name="model">File to validate</param>
        /// <param name="rejectionMessage">An out param for returning an error message explaning the reasoning for the rejection, if any </param>
        /// <returns></returns>
        private bool ImageIsLegal(FileUploadingModel model, out string rejectionMessage)
        {
            rejectionMessage = "No error detected"; // No inital errors detected

            // Sanity check
            #region SanityCheck
            if (model == null)
            {
                rejectionMessage = "No file recieved";
                return false;
            }
            #endregion

            // File size check
            #region FileSize
            if (model.File.Length > maxSizeBytes)
            {
                rejectionMessage = $"File size exceeds maximum allowed ({maxSizeBytes} bytes)";
                return false;
            }
            #endregion

            // File format check
            #region FileFormat
            bool legalFormatDetected = false;
            for (int i = 0; i < allowedFormats.Length; i++)
            {
                if (string.Equals(model.File.ContentType, allowedFormats[i], StringComparison.OrdinalIgnoreCase))
                {
                    legalFormatDetected = true;
                    break;
                }
            }

            if (legalFormatDetected == false)
            {
                rejectionMessage = "No legal file format detected, please use one of the following:";
                for (int i = 0; i < allowedFormats.Length; i++)
                {
                    rejectionMessage += " " + allowedFormats[i];
                }
                return false;
            }
            #endregion

            // If all checks have been passed return true
            return true;
        }

        private void UploadedFile(FileUploadingModel model, string destination)
        {
            string uniqueFileName = null;

            // Run sanity check
            if (model != null) 
                return;
          
            // Give the file a unique name by attaching a guid after the files name.
            string nameUnextended = model.File.FileName.Split(".")[0];
            string extension = model.File.FileName.Split(".")[1];
            uniqueFileName = nameUnextended + "_" + Guid.NewGuid().ToString() + "." + extension;

            // Upload the file to the determined destination
            string filePath = Path.Combine(destination, uniqueFileName);
            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                model.File.CopyTo(fileStream);
            }
        }

    }
}
