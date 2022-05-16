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

        public List<MonthlyInternalLedgerViewModel> GetMonthlyInternalLedgers(string id)
        {
            try
            {
                List<MonthlyInternalLedgerViewModel> monthlyInternalLedgerViewModels = new List<MonthlyInternalLedgerViewModel>();

                DateTime now = DateTime.Now;
                var startDate = new DateTime(now.Year, now.Month, 1);
                var endDate = startDate.AddMonths(1).AddDays(-1);

                monthlyInternalLedgerViewModels = _repositoryContext.MonthlyInternalLedger
                    .Join(_repositoryContext.MonthlyGeneralLedgerBook, MIL => MIL.LedgerName, MGLB => MGLB.LedgerType, (MIL, MGLB) => new { MIL, MGLB })
                    .Where(x => x.MIL.Id == Convert.ToInt32(id))
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
                var uniId = Guid.NewGuid().ToString();
                foreach (var result in data)
                {
                    result.UniId = uniId;
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
            var result1 = _repositoryContext.MonthlyInternalAccountLedgerBook.GroupBy(x => x.UniId)
                 .SelectMany(s => s.OrderBy(o => o.Id).Take(1)).ToList();
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

        public List<MonthlyInternalAccountLedgerBook> GetMonthlyInternalLedgersByUniId(string uniId)
        {
            try
            {
                var monthlyInternalLedgerViewModels = _repositoryContext.MonthlyInternalAccountLedgerBook
                    .Where(x => x.UniId == uniId).ToList();

                return monthlyInternalLedgerViewModels;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public List<MonthlyInternalAccountLedgerBook> GetMonthlyInternalAccountLedgerBook()
        {
            var result = new List<MonthlyInternalAccountLedgerBook>();
            var uniqLits = _repositoryContext.MonthlyInternalAccountLedgerBook.GroupBy(x => x.UniId)
                 .Select(x => x.Key).ToList();

            foreach (var key in uniqLits)
            {
                var findFirst = _repositoryContext.MonthlyInternalAccountLedgerBook.Where(x => x.UniId == key).FirstOrDefault();
                result.Add(findFirst);
            }
            return result;
        }

        public bool DeleteMonthlyInternalLedgersByUniId(string uniId)
        {
            var result = false;
            try
            {
                var data = _repositoryContext.MonthlyInternalAccountLedgerBook
                    .Where(x => x.UniId == uniId).ToList();

                if (data.Count > 0)
                {
                    _repositoryContext.MonthlyInternalAccountLedgerBook.RemoveRange(data);
                    if (_repositoryContext.SaveChanges() > 0) result = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }

            return result;
        }
    }
}
