using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Models
{ //This Model refer To PDF File Uploading  (Admin Office)
    public class FileUploadViewModel
    {
        public List<FileOnFileSystem> FilesOnFileSystem { get; set; }
        public List<FileOnDatabaseModel> FilesOnDatabase { get; set; }
        public List<FileOnDatabaseDmsModel> FilesOnDatabaseDms { get; set; }
    }
}
