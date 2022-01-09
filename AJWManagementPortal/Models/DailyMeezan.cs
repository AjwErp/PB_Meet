using AJWManagementPortal.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Models
{
    public class DailyMeezan
    {
        public IEnumerable<aDailyCash> aDailyCashes ;
        public IEnumerable<MeezanBankIEReport> Bank ;
        public IEnumerable<MeezanBankIEVoucher> BankVo ;
        public IEnumerable<DailySuppliersCashTransactionReport> dSuppliers;
        public IEnumerable<MonthlyAcountReportsViewModel> MonthlyAcountReportsViewModel { get; set; }
    }
}
