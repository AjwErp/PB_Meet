using AJWManagementPortal.Data;
using AJWManagementPortal.Extensions.IRepository;
using AJWManagementPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Extensions.Repository
{
    public class MonthlyIndustrySupplierLedgerRepository : RepositoryBase<MonthlyIndustrySupplierLedger>, IMonthlyIndustrySupplierLedgerRepository
    {
        private readonly ApplicationDbContext _repositoryContext;
        public MonthlyIndustrySupplierLedgerRepository(ApplicationDbContext repositoryContext)
           : base(repositoryContext)
        {
            this._repositoryContext = repositoryContext;
        }

        public bool SaveMonthlyIndustrySupplierLedger(string txtMonthlyIndustrySupplierLedger)
        {
            try
            {
                MonthlyIndustrySupplierLedger monthlyIndustrySupplierLedger = new MonthlyIndustrySupplierLedger();
                monthlyIndustrySupplierLedger.LedgerName = txtMonthlyIndustrySupplierLedger;
                monthlyIndustrySupplierLedger.CreatedDate = DateTime.Now;

                Create(monthlyIndustrySupplierLedger);
                _repositoryContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<MonthlyIndustrySupplierLedger> GetMonthlyIndustrySupplierLedger()
        {
            var monthlyIndustrySupplierLedgerList = _repositoryContext.MonthlyIndustrySupplierLedger.ToList();
            return monthlyIndustrySupplierLedgerList;
        }
    }
}
