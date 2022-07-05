using Gr4WebshopIncReact.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gr4WebshopIncReact.Services
{
    public class EmployeeDummyServices : IEmployeeServices
    {
        public Employee CreateEmployee(string name)
        {
            throw new NotImplementedException();
        }

        public User CreateUser(string FirstName, string LastName, string adress, string phoneNumber, string email)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Employee employee)
        {
            throw new NotImplementedException();
        }

        public bool Delete(User user)
        {
            throw new NotImplementedException();
        }

        public User GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<User> Search(string SearchPhrase)
        {
            throw new NotImplementedException();
        }

        public Employee Update(Employee employee)
        {
            throw new NotImplementedException();
        }

        public User Update(User user)
        {
            throw new NotImplementedException();
        }
    }
}
