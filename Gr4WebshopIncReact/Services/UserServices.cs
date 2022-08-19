using Gr4WebshopIncReact.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gr4WebshopIncReact.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

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

        public bool Delete(Guid id)
        {
            var userToDelete = GetById(id);
            if (userToDelete == null) return false;

            //Guard against deleting admins
            var adminRoleId = _context.Roles.Where(ur => ur.NormalizedName == "ADMIN").FirstOrDefault().Id;
            var userRoles = _context.UserRoles.Where(ur => ur.RoleId == adminRoleId&&ur.UserId==id.ToString()).Count();
            if (userRoles > 0) return false;

            
            _context.Users.Remove(userToDelete);
            return _context.SaveChanges() > 0 ? true : false;
        }

        public List<ApplicationUser> GetAll()
        {
            List<ApplicationUser> users = _context.Users.ToList();
            foreach(var user in users)
            {
                user.OrderHistory = _context.Orders.Where(o => o.UserKey == user.Id).ToList();
            }
            return users;
        }

        public List<ApplicationUser> GetAllWithRole(string RoleName)
        {
            // Find the role with the name passed
            IdentityRole role;
            try
            {
                role = _context.Roles.First(x => x.Name == RoleName);
            }
            catch (NullReferenceException)
            {
                // If no role with the passed name, there aren't any users with the role.
                return new List<ApplicationUser>();
            }

            // Find the users with the role by checking the connector class for the many-to-many relation
            List<IdentityUserRole<string>> connecters = _context.UserRoles.Where<IdentityUserRole<string>>(x => x.RoleId == role.Id).ToList();
            List<ApplicationUser> usersWithRole = new List<ApplicationUser>();
            foreach (IdentityUserRole<string> c in connecters)
            {
                usersWithRole.AddRange(_context.Users.Where<ApplicationUser>(x => x.Id == c.UserId).ToList());
            }

            // There shouldn't be duplicates in this list but to make sure only return distinct discoveries
            return usersWithRole.Distinct().ToList();
        }

        public ApplicationUser GetById(Guid id)
        {
            var user = _context.Users.Where(u => u.Id == id.ToString())
                .Include(oh=>oh.OrderHistory)
                .FirstOrDefault();
            if (user != null) return user;
            return null;
        }

        public List<ApplicationUser> Search(string SearchPhrase)
        {
            throw new NotImplementedException();
        }

        public ApplicationUser Update(ApplicationUser user)
        {
            _context.Users.Update(user);
            return _context.SaveChanges() > 0 ? user : null;
        }
    }
}
