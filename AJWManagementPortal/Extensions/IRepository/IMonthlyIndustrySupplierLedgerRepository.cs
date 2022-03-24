using AJWManagementPortal.Models;
using AJWManagementPortal.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Extensions.IRepository
{
    public interface IMonthlyIndustrySupplierLedgerRepository
    {
        bool SaveMonthlyIndustrySupplierLedger(string txtMonthlyIndustrySupplierLedger);
        List<MonthlyIndustrySupplierLedgerViewModel> GetMonthlyIndustrySupplierLedgers();
        List<MonthlyIndustrySupplierLedger> GetMonthlyIndustrySupplierLedgerType();
        bool SaveMonthlyIndustrySupplierLedgerBook(List<MonthlyIndustrySupplierLedgerBook> data);
        bool UpdateMonthlyIndustrySupplierLedgerBook(List<MonthlyIndustrySupplierLedgerBook> data);
    }
}
