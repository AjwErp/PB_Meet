using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Models.ViewModels
{                //This ViewModel Created for Monthly+Yearly General Ledger Book
    public class GeneralLedgerBookListViewModel
    {
        public IEnumerable<YearlyGeneralLedgerBook> YearlyGeneralLedgerBooks;
        public IEnumerable<MonthlyGeneralLedgerBook> MonthlyGeneralLedgerBooks;
        //public List<YearlyGeneralLedgerBook> YearlyGeneralLedgerBooks { get; set; }
        //public List<MonthlyGeneralLedgerBook> MonthlyGeneralLedgerBooks { get; set; }
    }
}
