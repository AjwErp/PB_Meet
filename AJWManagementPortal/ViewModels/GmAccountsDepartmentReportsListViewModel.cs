using AJWManagementPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.ViewModels
{
    public class GmAccountsDepartmentReportsListViewModel
    {
        public IEnumerable<MonthlyAcountReportsViewModel> MonthlyAcountReportsViewModel { get; set; }
    }
}
