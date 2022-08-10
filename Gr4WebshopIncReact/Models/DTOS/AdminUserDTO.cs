using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gr4WebshopIncReact.Models.DTOS
{
    public class AdminUserDTO :UserDTO
    {
        public string UserName { get; set; }
        public AdminUserDTO(ApplicationUser user):base (user)
        {
            UserName = user.UserName;
            
        }
        
    }
}
