using AJWManagementPortal.Data;
using AJWManagementPortal.Extensions.IRepository;
using AJWManagementPortal.Models;
using AJWManagementPortal.Models.ViewModels;
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

        public List<MonthlyInternalLedgerViewModel> GetMonthlyInternalLedgers()
        {
            try
            {
                List<MonthlyInternalLedgerViewModel> monthlyInternalLedgerViewModels = new List<MonthlyInternalLedgerViewModel>();

                DateTime now = DateTime.Now;
                var startDate = new DateTime(now.Year, now.Month, 1);
                var endDate = startDate.AddMonths(1).AddDays(-1);

                monthlyInternalLedgerViewModels = _repositoryContext.MonthlyInternalLedger
                    .Join(_repositoryContext.MonthlyGeneralLedgerBook, MIL => MIL.LedgerName, MGLB => MGLB.LedgerType, (MIL, MGLB) => new { MIL, MGLB })
                    //.Where(z => z.MGLB.DailyCashDate >= startDate && z.MGLB.DailyCashDate <= endDate)
                    .Select(x => new MonthlyInternalLedgerViewModel
                    {
                        DailyCashId = x.MGLB.DailyCashId,
                        Devit = x.MGLB.Devit,
                        Credit = x.MGLB.Credit,
                        PreOrderCheckNo = x.MGLB.PreOrderCheckNo,
                        Description = x.MGLB.Description,
                        LedgerType = x.MGLB.LedgerType,
                        DailyCashDate = x.MGLB.DailyCashDate,
                    }).ToList();

                return monthlyInternalLedgerViewModels;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public List<MonthlyInternalLedger> GetMonthlyInternalLedgerType()
        {
            var monthlyInternalLedgerList = _repositoryContext.MonthlyInternalLedger.ToList();
            return monthlyInternalLedgerList;
        }

        public bool SaveMonthlyInternalAccountLedgerBook(List<MonthlyInternalAccountLedgerBook> data)
        {
            try
            {
                foreach (var result in data)
                {
                    _repositoryContext.MonthlyInternalAccountLedgerBook.Add(result);
                    _repositoryContext.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool UpdateMonthlyInternalAccountLedgerBook(List<MonthlyInternalAccountLedgerBook> data)
        {
            try
            {
                foreach (var model in data)
                {
                    var result = _repositoryContext.MonthlyInternalAccountLedgerBook.Where(x => x.DailyCashId == model.DailyCashId).FirstOrDefault();
                    result.AMSignature = model.AMSignature;
                    result.AMRemark = model.AMRemark;
                    result.DGMSignature = model.DGMSignature;
                    result.DGMRemark = model.DGMRemark;
                    result.GMSignature = model.GMSignature;
                    result.GMRemark = model.GMRemark;
                    result.Balance = model.Balance;
                    result.Credit = model.Credit;
                    result.Devit = model.Devit;
                    result.PreOrderCheckNo = model.PreOrderCheckNo;
                    result.Description = model.Description;
                    result.DailyCashDate = model.DailyCashDate;
                    result.UpdatedDate = DateTime.Now;
                    _repositoryContext.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
