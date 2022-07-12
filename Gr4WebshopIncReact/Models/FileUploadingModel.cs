using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Gr4WebshopIncReact.Models
{
    /// Model used for uploading files
    /// Validation and storage handled by controller
    public class FileUploadingModel
    {
        [Required(ErrorMessage = "Please choose an image")]
        [Display(Name = "Display Image")]
        public IFormFile File { get; set; }
    }
}
