using System;
using System.Collections.Generic;

namespace AJWManagementPortal.Models
{
    public class TransAndBank
    {
        public List<BankBalane> Bank1 = new List<BankBalane>();
        public List<MeezanBankIEReport> Bank2 = new List<MeezanBankIEReport>();
        public List<MeezanBankIEVoucher> BankVoucher = new List<MeezanBankIEVoucher>();
        public List<aDailyCash> aDailyCashes = new List<aDailyCash>();
        public DateTime date { get; set; }
        public bool hide { get; set; }
        public MeezanBankIEVoucher meezanVoucher = new MeezanBankIEVoucher();
        public List<Image> images = new List<Image>();
        public List<DailySuppliersCashTransactionReport> suppliers = new List<DailySuppliersCashTransactionReport>();
        public List<DCashClosingSupplierLedger> DCCSupplier = new List<DCashClosingSupplierLedger>();
        public DCashClosingSupplierLedger DCCSupplier1 = new DCashClosingSupplierLedger();
        public IEnumerable<AccountsYearlyReportTitlePage> TitleP = new List<AccountsYearlyReportTitlePage>();

    }
}
