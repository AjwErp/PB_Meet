using AJWManagementPortal.Models;
using AJWManagementPortal.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Extensions.IRepository
{
    public interface IMonthlyInternalLedgerRepository
    {
        bool SaveMonthlyInternalLedger(string txtMonthlyInternalLedger);
        List<MonthlyInternalLedger> GetMonthlyInternalLedgerType();
        List<MonthlyInternalLedgerViewModel> GetMonthlyInternalLedgers();
        bool SaveMonthlyInternalAccountLedgerBook(List<MonthlyInternalAccountLedgerBook> data);
        bool UpdateMonthlyInternalAccountLedgerBook(List<MonthlyInternalAccountLedgerBook> data);
    }
}
