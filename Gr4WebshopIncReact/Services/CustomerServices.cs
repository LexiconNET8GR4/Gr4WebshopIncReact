using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gr4WebshopIncReact.Models;
using Gr4WebshopIncReact.Services;
using Gr4WebshopIncReact.Data;
using Microsoft.EntityFrameworkCore;


namespace Gr4WebshopIncReact.Services
{
    public class CustomerServices : ICustomerServices
    {
        private readonly ApplicationDbContext _context;

        public CustomerServices(ApplicationDbContext context)
        {
            _context = context;
        }
        public Customer CreateCustomer(string firstName, string lastName)
        {
            Customer customer = new Customer(firstName, lastName);
            _context.Customers.Add(customer);
            return _context.SaveChanges() > 0 ? customer : null;

        }

        public Customer CreateCustomer(string firstName, string lastName, ApplicationUser user)
        {
            Customer customer = new Customer(firstName, lastName, user);
            _context.Customers.Add(customer);
            return _context.SaveChanges() > 0 ? customer : null;
        }

        public bool Delete(Customer customer)
        {
            throw new NotImplementedException();
        }

        public Customer GetById(Guid id)
        {
            var customer=_context.Customers.Where(c => c.Id == id)
                .Include(c=>c.User)
                .FirstOrDefault();
            return customer;
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
