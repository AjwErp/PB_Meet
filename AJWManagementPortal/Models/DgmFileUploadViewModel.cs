using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Models
{
    public class DgmFileUploadViewModel
    {
        public List<DgmFileOnFileSystem> DgmFilesOnFileSystem { get; set; }
        public List<DgmFileOnDatabaseModel> DgmFilesOnDatabase { get; set; }
        public List<DgmFileOnDatabaseDmsModel> DgmFilesOnDatabaseDms { get; set; }
    }
}
