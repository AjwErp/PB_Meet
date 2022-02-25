using AJWManagementPortal.Data;
using AJWManagementPortal.Extensions.IRepository;
using AJWManagementPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Extensions.Repository
{                 // This Repository Folder Created for Yearly + Monthly General Ledger Book ----------By Yousaf Rakib Shb------
    public class YearlyMainBankLedgerBookRepository : RepositoryBase<YearlyMainBankLedgerBook>, IYearlyMainBankLedgerBookRepository
    {
        private readonly ApplicationDbContext _repositoryContext;
        public YearlyMainBankLedgerBookRepository(ApplicationDbContext repositoryContext)
           : base(repositoryContext)
        {
            this._repositoryContext = repositoryContext;
        }
        public bool SaveYearlyMainBankLedgerBookRepository(List<YearlyMainBankLedgerBook> data)
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

        public bool UpdateYearlyMainBankLedgerBookRepository(List<YearlyMainBankLedgerBook> data)
        {
            try
            {
                foreach (var model in data)
                {
                    var result = _repositoryContext.YearlyMainBankLedgerBook.Where(x => x.MainBankDailyCashId == model.MainBankDailyCashId).FirstOrDefault();
                    result.AMSignature = model.AMSignature;
                    result.AMRemark = model.AMRemark;
                    result.DGMSignature = model.DGMSignature;
                    result.DGMRemark = model.DGMRemark;
                    result.GMSignature = model.GMSignature;
                    result.GMRemark = model.GMRemark;
                    result.Balance = model.Balance;
                    result.Credit = model.Credit;
                    result.Devit = model.Devit;
                    result.CDO = model.CDO;
                    result.Description = model.Description;
                    result.MainBankDailyCashDate = model.MainBankDailyCashDate;
                    result.UpdatedDate = DateTime.Now;
                    //Update(data);
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
