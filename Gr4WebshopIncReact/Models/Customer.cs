using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Gr4WebshopIncReact.Models
{
    public class Customer
    {
        
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Adress { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string Email { get; set; }
        public Guid OrderKey { get; set; }
        public Order Order { get; set; }

        public Guid? UserKey { get; set; }
        public ApplicationUser User { get; set; }

        public Customer(ApplicationUser user)
        {
            Id = Guid.Parse(user.Id);
            FirstName = user.FirstName;
            LastName = user.LastName;
            Email = user.Email;
            Adress = user.Adress;
            PhoneNumber = user.PhoneNumber;
            UserKey = Guid.Parse(user.Id);
            User = user;
        }

        public Customer(string firstName, string lastName, string email, string adress,string phoneNumber)
        {
            Id = Guid.NewGuid();
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Adress = adress;
            PhoneNumber = phoneNumber;
        }
    }
}
