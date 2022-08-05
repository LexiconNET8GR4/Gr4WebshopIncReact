using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Gr4WebshopIncReact.Models
{
    public class Payment
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public Guid OrderKey {get;set; }
        public Order Order { get; set; }

        [Required]
        public Guid MethodKey {get; set; }
        public PaymentMethod Method { get; set; }
    }
}
