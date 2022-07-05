using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gr4WebshopIncReact.Models;

namespace Gr4WebshopIncReact.Services
{
    public interface ICustomerServices
    {
        public Customer CreateCustomer(string firstName, string lastName);
        public Customer CreateCustomer(string firstName, string lastName, User user);
        public Customer GetById(Guid id);
        public List<Customer> Search(string SearchPhrase);
        public Customer Update(Customer customer);
        public bool Delete(Customer customer);
    }
}
