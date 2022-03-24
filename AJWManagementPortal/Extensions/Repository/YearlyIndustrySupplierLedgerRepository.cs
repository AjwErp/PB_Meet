using AJWManagementPortal.Data;
using AJWManagementPortal.Extensions.IRepository;
using AJWManagementPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Extensions.Repository
{
    public class YearlyIndustrySupplierLedgerRepository : RepositoryBase<YearlyIndustrySupplierLedger>, IYearlyIndustrySupplierLedgerRepository
    {
        private readonly ApplicationDbContext _repositoryContext;
        public YearlyIndustrySupplierLedgerRepository(ApplicationDbContext repositoryContext)
           : base(repositoryContext)
        {
            this._repositoryContext = repositoryContext;
        }

        public bool SaveYearlyIndustrySupplierLedger(string txtYearlyIndustrySupplierLedger)
        {
            try
            {
                YearlyIndustrySupplierLedger yearlyIndustrySupplierLedger = new YearlyIndustrySupplierLedger();
                yearlyIndustrySupplierLedger.LedgerName = txtYearlyIndustrySupplierLedger;
                yearlyIndustrySupplierLedger.CreatedDate = DateTime.Now;

                Create(yearlyIndustrySupplierLedger);
                _repositoryContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<YearlyIndustrySupplierLedger> GetYearlyIndustrySupplierLedger()
        {
            var yearlyIndustrySupplierLedgerList = _repositoryContext.YearlyIndustrySupplierLedger.ToList();
            return yearlyIndustrySupplierLedgerList;
        }
    }
}
