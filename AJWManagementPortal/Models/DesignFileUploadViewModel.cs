using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Models
{
    public class DesignFileUploadViewModel
    {
        public List<DesignFileOnFileSystem> DesignFilesOnFileSystem { get; set; }
        public List<DesignFileOnDatabaseModel> DesignFilesOnDatabase { get; set; }
        public List<DesignFileOnDatabaseDmsModel> DesignFilesOnDatabaseDms { get; set; }
    }
}
