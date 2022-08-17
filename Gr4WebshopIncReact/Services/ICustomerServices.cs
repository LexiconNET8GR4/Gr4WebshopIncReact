using Gr4WebshopIncReact.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gr4WebshopIncReact.Services
{
    public interface ICustomerServices
    {
        public Customer CreateCustomer(string firstName, string lastName, string email, string adress, string number);
        public Customer CreateCustomer( ApplicationUser user);
        public Customer GetById(Guid id);
        public List<Customer> Search(string SearchPhrase);
        public Customer Update(Customer customer);
        public bool Delete(Customer customer);
    }
}
