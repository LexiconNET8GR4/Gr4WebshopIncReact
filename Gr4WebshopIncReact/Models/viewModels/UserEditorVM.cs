using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gr4WebshopIncReact.Models.viewModels
{
    public class UserEditorVM
    {
        public List<ApplicationUser> Users { get; set; }
        public List <IdentityRole> Roles { get; set; }
    }
}
