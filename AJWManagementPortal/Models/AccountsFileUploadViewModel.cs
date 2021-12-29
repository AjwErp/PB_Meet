using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Models
{
    public class AccountsFileUploadViewModel
    {
        public List<AccountsFileOnFileSystem> AccountsFilesOnFileSystem { get; set; }
        public List<AccountsFileOnDatabaseModel> AccountsFilesOnDatabase { get; set; }
        public List<AccountsFileOnDatabaseDmsModel> AccountsFilesOnDatabaseDms { get; set; }
    }
}
