using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Models
{
    public class ProductionFileUploadViewModel
    {
        public List<ProductionFileOnFileSystem> ProductionFilesOnFileSystem { get; set; }
        public List<ProductionFileOnDatabaseModel> ProductionFilesOnDatabase { get; set; }
        public List<ProductionFileOnDatabaseDmsModel> ProductionFilesOnDatabaseDms { get; set; }
    }
}
