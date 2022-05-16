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
        List<MonthlyInternalLedgerViewModel> GetMonthlyInternalLedgers(string id);
        bool SaveMonthlyInternalAccountLedgerBook(List<MonthlyInternalAccountLedgerBook> data);
        bool UpdateMonthlyInternalAccountLedgerBook(List<MonthlyInternalAccountLedgerBook> data);

        List<MonthlyInternalAccountLedgerBook> GetMonthlyInternalAccountLedgerBook();
        List<MonthlyInternalAccountLedgerBook> GetMonthlyInternalLedgersByUniId(string uniId);
        bool DeleteMonthlyInternalLedgersByUniId(string uniId);
    }
}
