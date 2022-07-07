using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Gr4WebshopIncReact.Models
{
    public class Details
        {
            public Guid Id { get; set; }
            public string Data { get; set; }
            public Guid ProductKey { get; set; }
            public Product Product { get; set; }
        }
}
