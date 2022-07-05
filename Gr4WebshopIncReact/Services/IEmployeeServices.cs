using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gr4WebshopIncReact.Models;

namespace Gr4WebshopIncReact.Services
{
    public interface IEmployeeServices : IUserServices
    {
        public Employee CreateEmployee(string name);
        public Employee Update(Employee employee);
        public bool Delete(Employee employee);
    }
}
