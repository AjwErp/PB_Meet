using AJWManagementPortal.Data;
using AJWManagementPortal.Extensions.IRepository;
using AJWManagementPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Extensions.Repository
{
    public class MonthlyInternalLedgerRepository : RepositoryBase<MonthlyInternalLedger>, IMonthlyInternalLedgerRepository
    {
        private readonly ApplicationDbContext _repositoryContext;
        public MonthlyInternalLedgerRepository(ApplicationDbContext repositoryContext)
           : base(repositoryContext)
        {
            this._repositoryContext = repositoryContext;
        }

        public bool SaveMonthlyInternalLedger(string txtMonthlyInternalLedger)
        {
            try
            {
                MonthlyInternalLedger monthlyInternalLedger = new MonthlyInternalLedger();
                monthlyInternalLedger.LedgerName = txtMonthlyInternalLedger;
                monthlyInternalLedger.CreatedDate = DateTime.Now;
                Create(monthlyInternalLedger);
                _repositoryContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public List<MonthlyInternalLedger> GetMonthlyInternalLedger ()
        {
            var monthlyInternalLedgerList = _repositoryContext.MonthlyInternalLedger.ToList();
            return monthlyInternalLedgerList;
        }
    }
}
