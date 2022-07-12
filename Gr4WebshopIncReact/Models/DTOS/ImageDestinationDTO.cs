using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gr4WebshopIncReact.Models.DTOS
{
    public class ImageDestinationDTO:ImageDestination
    {
        public ImageDestinationDTO(ImageDestination imageDestination)
        {
            Product = null;
            ProductKey = Guid.Empty;
        }
    }
}
