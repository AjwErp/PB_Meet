using System.Collections.Generic;
namespace AJWManagementPortal.Models.ViewModels
{
    public class InternalLedgerBookViewModel
    {
        public List<MonthlyInternalAccountLedgerBook> monthlyInternalLedgers { get; set; }
        public List<YearlyInternalLedger> yearlyInternalLedgers { get; set; }
    }
}
