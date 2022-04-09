using AJWManagementPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Extensions.IRepository
{
    public interface IMonthlyIncomeExpenseInternalAccountReportRepository
    {
        public bool SaveMonthlyIncomeExpenseInternalAccount(MonthlyIncomeExpenceInternalAccountReport data);
    }
}
