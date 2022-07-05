using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gr4WebshopIncReact.Models
{
    public class User
    {
        public Guid id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string adress { get; set; }
        public string phoneNumber { get; set; }
        public string email { get; set; }

        public List<Order> orderHistory { get; set; }
    }
}
