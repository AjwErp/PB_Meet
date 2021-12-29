using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Models
{
    public class DailyTransactionReportM
    {
        //public List<BankBalane> Bank1 = new List<BankBalane>();
        //public List<MeezanBankIEReport> Bank2 = new List<MeezanBankIEReport>();
        public List<AccountDailyContinueSheetM> DailyContinueSheetMs = new List<AccountDailyContinueSheetM>();
        public DateTime DCSDate { get; set; }
        public bool hide { get; set; }
        //public MeezanBankIEVoucher meezanVoucher = new MeezanBankIEVoucher();

    }
}
