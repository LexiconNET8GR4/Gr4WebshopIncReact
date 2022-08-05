using Gr4WebshopIncReact.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gr4WebshopIncReact.Services
{
    public interface IUserServices
    {
        public User CreateUser(string FirstName, string LastName, string adress, string phoneNumber, string email);
        public User GetById(Guid id);
        public List<User> Search(string SearchPhrase);
        public User Update(User user);
        public bool Delete(User user);
    }
}
