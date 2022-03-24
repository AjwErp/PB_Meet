using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Models.ViewModels
{
    public class MainBankLedgerBookListViewModel
    {
        public IEnumerable<YearlyMainBankLedgerBook> YearlyMainBankLedgerBook;
        public IEnumerable<MonthlyMainBankLedgerBook> MonthlyMainBankLedgerBook;
    }
}
