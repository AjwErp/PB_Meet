using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Models
{
    public class StoreFileUploadViewModel
    {
        public List<StoreFileOnFileSystem> StoreFilesOnFileSystem { get; set; }
        public List<StoreFileOnDatabaseModel> StoreFilesOnDatabase { get; set; }
        public List<StoreFileOnDatabaseDmsModel> StoreFilesOnDatabaseDms { get; set; }
    }
}
