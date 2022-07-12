using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gr4WebshopIncReact.Models.DTOS
{
    public class DetailsDTO:Details
    {
        public DetailsDTO()
        {
            ProductKey = Guid.Empty;
            Product = null;
            
        }
        public DetailsDTO(Details details) : this()
        {
            if (details != null) 
            { 
                Id = details.Id;
                Data = details.Data;
            }
        }
    }
}
