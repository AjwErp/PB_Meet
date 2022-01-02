using AJWManagementPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.ViewModels
{
    public class DgmAccountsDepartmentReportsListViewModel
    {
        public IEnumerable<MonthlyClosingReport> MonthlyClosingReport { get; set; }
    }
}
