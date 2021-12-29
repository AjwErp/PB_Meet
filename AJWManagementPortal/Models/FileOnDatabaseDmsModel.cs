using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Models
{ 
    //This Model refer to File Upload On DMS (DMS Office)
    public class FileOnDatabaseDmsModel : FileModel
    {//This class Inharit from ::FileModel class::
        public byte[] Data { get; set; }
    }
}
