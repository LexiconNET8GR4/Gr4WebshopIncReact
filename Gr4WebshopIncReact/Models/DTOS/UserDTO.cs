using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gr4WebshopIncReact.Models.DTOS
{
    public class UserDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public List<Guid> OrderHistory { get; set; }

        public UserDTO(ApplicationUser user)
        {
            FirstName = user.FirstName;
            LastName = user.LastName;
            Adress = user.Adress;
            PhoneNumber = user.PhoneNumber;
            Email = user.Email;
            OrderHistory = new List<Guid>();
            if(user.OrderHistory!=null)
            foreach(Order o in user.OrderHistory)
            {
                OrderHistory.Add(o.Id);
            }
        }
    }
}
