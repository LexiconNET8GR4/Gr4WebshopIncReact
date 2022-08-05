using Gr4WebshopIncReact.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gr4WebshopIncReact.Services
{
    public class CustomerDummyServices : ICustomerServices
    {
        public Customer CreateCustomer(string firstName, string lastName)
        {
            throw new NotImplementedException();
        }

        public Customer CreateCustomer(string firstName, string lastName, User user)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Customer customer)
        {
            throw new NotImplementedException();
        }

        public Customer GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> Search(string SearchPhrase)
        {
            throw new NotImplementedException();
        }

        public Customer Update(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
