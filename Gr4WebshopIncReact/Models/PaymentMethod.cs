using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Gr4WebshopIncReact.Models
{
    public class PaymentMethod
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Type { get; set; }

    }
}
