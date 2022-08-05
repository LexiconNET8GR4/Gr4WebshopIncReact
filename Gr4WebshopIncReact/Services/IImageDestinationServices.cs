using Gr4WebshopIncReact.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gr4WebshopIncReact.Services
{
    public interface IImageDestinationServices
    {
        public ImageDestination GetImageDestination(string Name);
        public ImageDestination AddImageDestination(Product product, string path);
    }
}
