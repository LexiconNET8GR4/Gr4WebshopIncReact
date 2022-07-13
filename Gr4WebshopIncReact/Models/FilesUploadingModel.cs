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
    public class FilesUploadingModel
    {
        [Required(ErrorMessage = "Please choose images")]
        [Display(Name = "Cover Image")]
        public IFormFile[] Files { get; set; }
    }
}
