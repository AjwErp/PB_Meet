using AJWManagementPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.ViewModels
{
    public class DgmAccountsDepartmentReportsListViewModel
    {
        public IEnumerable<MonthlyAcountReportsViewModel> MonthlyAcountReportsViewModel { get; set; }
        public IEnumerable<aDailyCash> aDailyCash { get; set; }

    }
}
