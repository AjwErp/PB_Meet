using AJWManagementPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Extensions.IRepository
{      // This IRepository Folder Created for Yearly + Monthly General Ledger Book ----------By Yousaf Rakib Shb------
    public interface IMonthlyMainBankLedgerBookRepository
    {
        public bool SaveMonthlyMainBankLedgerBookRepository(List<MonthlyMainBankLedgerBook> data);
        public bool UpdateMonthlyMainBankLedgerBookRepository(List<MonthlyMainBankLedgerBook> data);
    }
}
