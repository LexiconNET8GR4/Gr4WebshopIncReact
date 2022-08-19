using Gr4WebshopIncReact.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gr4WebshopIncReact.Services
{
    public interface IUserServices
    {
        public ApplicationUser CreateUser(string FirstName, string LastName, string adress, string phoneNumber, string email);
        public ApplicationUser GetById(Guid id);
        public List<ApplicationUser> Search(string SearchPhrase);
        public ApplicationUser Update(ApplicationUser user);
        public bool Delete(Guid id);
        public List<ApplicationUser> GetAll();
        public List<ApplicationUser> GetAllWithRole(string RoleName);
    }
}
