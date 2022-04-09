using AJWManagementPortal.Data;
using AJWManagementPortal.Extensions.IRepository;
using AJWManagementPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Extensions.Repository
{
    public class MonthlyIncomeExpenseInternalAccountReportRepository : RepositoryBase<MonthlyIncomeExpenceInternalAccountReport>, IMonthlyIncomeExpenseInternalAccountReportRepository
    {
        private readonly ApplicationDbContext _repositoryContext;
        public MonthlyIncomeExpenseInternalAccountReportRepository(ApplicationDbContext repositoryContext)
           : base(repositoryContext)
        {
            this._repositoryContext = repositoryContext;
        }
        public bool SaveMonthlyIncomeExpenseInternalAccount(MonthlyIncomeExpenceInternalAccountReport data)
        {
            try
            {
                Create(data);
                _repositoryContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
