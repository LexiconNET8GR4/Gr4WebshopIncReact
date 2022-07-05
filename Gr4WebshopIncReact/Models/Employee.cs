using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Gr4WebshopIncReact.Models
{
    public class Employee
    {
        public IdentityRole role { get; set; }
    }
}
