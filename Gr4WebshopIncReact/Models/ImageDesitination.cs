using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Gr4WebshopIncReact.Models
{
    public class ImageDesitination
    {
        [Key]
        public Guid Id { get; set; }

        public string ImageDestination { get; set; }
        [Required]
        public Guid ProductKey { get; set; }
        public Product Product { get; set; }
    }
}
