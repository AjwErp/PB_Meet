
using System.Collections.Generic;

namespace AJWManagementPortal.Models.ViewModels
{
    public class IndustrySupplierLedgerBookViewModel
    {
        public List<MonthlyIndustrySupplierLedgerBook> monthlyIndustrySupplierLedgers { get; set; }
        public List<YearlyIndustrySupplierLedger> yearlyIndustrySupplierLedgers{ get; set; }
    }
}
