using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gr4WebshopIncReact.Models.viewModels
{
    public class AdminIndexVM
    {
        public FilesUploadingModel FilesUploader { get; set; }
        public List<string> ImageLocations { get; set; }
    }
}
