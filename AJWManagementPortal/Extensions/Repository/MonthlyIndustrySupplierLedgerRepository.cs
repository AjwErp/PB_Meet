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

        public List<MonthlyIndustrySupplierLedgerViewModel> GetMonthlyIndustrySupplierLedgers()
        {
            try
            {
                List<MonthlyIndustrySupplierLedgerViewModel> monthlyIndustrySupplierLedgerViewModels = new List<MonthlyIndustrySupplierLedgerViewModel>();

                DateTime now = DateTime.Now;
                var startDate = new DateTime(now.Year, now.Month, 1);
                var endDate = startDate.AddMonths(1).AddDays(-1);

                monthlyIndustrySupplierLedgerViewModels = _repositoryContext.MonthlyIndustrySupplierLedger
                    .Join(_repositoryContext.MonthlyGeneralLedgerBook, MIL => MIL.LedgerName, MGLB => MGLB.LedgerType, (MIL, MGLB) => new { MIL, MGLB })
                    .Where(z => z.MGLB.DailyCashDate >= startDate && z.MGLB.DailyCashDate <= endDate)
                    .Select(x => new MonthlyIndustrySupplierLedgerViewModel
                    {
                        DailyCashId = x.MGLB.DailyCashId,
                        Devit = x.MGLB.Devit,
                        Credit = x.MGLB.Credit,
                        PreOrderCheckNo = x.MGLB.PreOrderCheckNo,
                        Description = x.MGLB.Description,
                        LedgerType = x.MGLB.LedgerType,
                        DailyCashDate = x.MGLB.DailyCashDate,
                    }).ToList();

                return monthlyIndustrySupplierLedgerViewModels;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public List<MonthlyIndustrySupplierLedger> GetMonthlyIndustrySupplierLedgerType()
        {
            var monthlyIndustrySupplierLedgerList = _repositoryContext.MonthlyIndustrySupplierLedger.ToList();
            return monthlyIndustrySupplierLedgerList;
        }

        public bool SaveMonthlyIndustrySupplierLedgerBook(List<MonthlyIndustrySupplierLedgerBook> data)
        {
            try
            {
                foreach (var result in data)
                {
                    _repositoryContext.MonthlyIndustrySupplierLedgerBook.Add(result);
                    _repositoryContext.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool UpdateMonthlyIndustrySupplierLedgerBook(List<MonthlyIndustrySupplierLedgerBook> data)
        {
            try
            {
                foreach (var model in data)
                {
                    var result = _repositoryContext.MonthlyIndustrySupplierLedgerBook.Where(x => x.DailyCashId == model.DailyCashId).FirstOrDefault();
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
