using System.Collections.Generic;
using Gr4WebshopIncReact.Models;
using Gr4WebshopIncReact.Models.DTOS;

namespace Gr4WebshopIncReact.Controllers
{
    public class Receipt
    {
        public Receipt(Order order)
        {
            OrderedProducts = new List<ProductDTO>();
            foreach(OrderedProduct p in order.Products)
            {
                ProductDTO productDTO = new ProductDTO(p.Product);
                OrderedProducts.Add(productDTO);
            }
            FirstName = order.Customer.FirstName;
            LastName = order.Customer.LastName;
            Adress = order.ShippingAddress;
            PhoneNumber = order.Customer.PhoneNumber;
            Email = order.Customer.Email;

        }
        public List<ProductDTO> OrderedProducts { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

    }
    
}
