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
        //for Daily Accounts Reports in DGM Office
        //public IEnumerable<aDailyCash> aDailyCashes { get; set; }

        public IEnumerable<DailyMeezan> DailyMeezan { get; set; } 
        public IEnumerable<MeezanBankIEReport> MeezanBankIEReport { get; set; }

        public IEnumerable<DailySuppliersCashTransactionReport> DailySuppliersCashTransactionReportliers { get; set; }

    }
}
