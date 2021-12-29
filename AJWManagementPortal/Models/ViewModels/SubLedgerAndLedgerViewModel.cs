using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Models.ViewModels
{
    //This view Model support for Ledger/SubLedger (Account Office)
    public class SubLedgerAndLedgerViewModel
    {
        public IEnumerable<Ledger> LedgerList { get; set; }
        public SubLedger SubLedger { get; set; }
        public List<string> SubLedgerList { get; set; }
        public string StatusMessage { get; set; }
    }
}
