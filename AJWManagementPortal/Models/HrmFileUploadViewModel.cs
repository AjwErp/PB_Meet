using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Models
{
    public class HrmFileUploadViewModel
    {
        public List<HrmFileOnFileSystem> HrmFilesOnFileSystem { get; set; }
        public List<HrmFileOnDatabaseModel> HrmFilesOnDatabase { get; set; }
        public List<HrmFileOnDatabaseDmsModel> HrmFilesOnDatabaseDms { get; set; }
    }
}
