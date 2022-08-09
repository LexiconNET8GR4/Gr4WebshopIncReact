using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gr4WebshopIncReact.Models;
using Gr4WebshopIncReact.Services;
using Gr4WebshopIncReact.Data;

namespace Gr4WebshopIncReact.Services
{
    public class UserServices : IUserServices
    {
        private readonly ApplicationDbContext _context;

        public UserServices(ApplicationDbContext context)
        {
            _context = context;
        }
        public ApplicationUser CreateUser(string FirstName, string LastName, string adress, string phoneNumber, string email)
        {
            throw new NotImplementedException();
        }

        public bool Delete(ApplicationUser user)
        {
            throw new NotImplementedException();
        }

        public ApplicationUser GetById(Guid id)
        {
            var user = _context.Users.Where(u => u.Id == id.ToString()).FirstOrDefault();
            if (user != null) return user;
            return null;
        }

        public List<ApplicationUser> Search(string SearchPhrase)
        {
            throw new NotImplementedException();
        }

        public ApplicationUser Update(ApplicationUser user)
        {
            throw new NotImplementedException();
        }
    }
}
