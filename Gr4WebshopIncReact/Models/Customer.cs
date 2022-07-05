using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gr4WebshopIncReact.Models
{
    public class Customer
    {
        public Guid id { get; set; }

        public string firstName { get; set; }
        public string lastName { get; set; }
        public string adress { get; set; }
        public string phoneNumber { get; set; }
        public string email { get; set; }

        public Order order { get; set; }
        public User user { get; set; }
    }
}
