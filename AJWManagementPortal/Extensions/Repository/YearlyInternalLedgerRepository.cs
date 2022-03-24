using AJWManagementPortal.Data;
using AJWManagementPortal.Extensions.IRepository;
using AJWManagementPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Extensions.Repository
{
    public class YearlyInternalLedgerRepository : RepositoryBase<YearlyInternalLedger>, IYearlyInternalLedgerRepository
    {
        private readonly ApplicationDbContext _repositoryContext;
        public YearlyInternalLedgerRepository(ApplicationDbContext repositoryContext)
           : base(repositoryContext)
        {
            this._repositoryContext = repositoryContext;
        }

        public bool SaveYearlyInternalLedger(string txtYearlyInternalLedger)
        {
            try
            {
                YearlyInternalLedger yearlyInternalLedger = new YearlyInternalLedger();
                yearlyInternalLedger.LedgerName = txtYearlyInternalLedger;
                yearlyInternalLedger.CreatedDate = DateTime.Now;

                Create(yearlyInternalLedger);
                _repositoryContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<YearlyInternalLedger> GetYearlyInternalLedger()
        {
            var yearlyInternalLedgerList = _repositoryContext.YearlyInternalLedger.ToList();
            return yearlyInternalLedgerList;
        }
    }
}
