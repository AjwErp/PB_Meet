using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Models
{
    //This Model refer to PDF File upload on System (Admin Office)
    public class FileOnFileSystem :FileModel
    {//This class Inharit from ::FileModel class::
        public string FilePath { get; set; }
    }
}
