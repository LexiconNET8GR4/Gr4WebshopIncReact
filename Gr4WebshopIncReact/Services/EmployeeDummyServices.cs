﻿using Gr4WebshopIncReact.Models;
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

        public ApplicationUser CreateUser(string FirstName, string LastName, string adress, string phoneNumber, string email)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Employee employee)
        {
            throw new NotImplementedException();
        }

        public bool Delete(ApplicationUser user)
        {
            throw new NotImplementedException();
        }

        public ApplicationUser GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<ApplicationUser> Search(string SearchPhrase)
        {
            throw new NotImplementedException();
        }

        public Employee Update(Employee employee)
        {
            throw new NotImplementedException();
        }

        public ApplicationUser Update(ApplicationUser user)
        {
            throw new NotImplementedException();
        }
    }
}
