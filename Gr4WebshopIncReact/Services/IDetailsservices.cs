using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gr4WebshopIncReact.Models;

namespace Gr4WebshopIncReact.Services
{
    interface IDetailsservices
    {
        Details GetDetails(Guid productId);
    }
}
