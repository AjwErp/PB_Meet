using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Models
{
    //This Model refer To PDf File Upload on Database(Admin Office)
    public class FileOnDatabaseModel : FileModel
    {//This class Inharit from ::FileModel class::
        public byte[] Data { get; set; }
    }
}
