using AJWManagementPortal.Data;
using AJWManagementPortal.Extensions.IRepository;
using AJWManagementPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Extensions.Repository
{                // This Repository Folder Created for Yearly + Monthly General Ledger Book ----------By Yousaf Rakib Shb------
    public class YearlyGeneralLedgerBookRepository : RepositoryBase<YearlyGeneralLedgerBook>, IYearlyGeneralLedgerBookRepository
    {
        private readonly ApplicationDbContext _repositoryContext;
        public YearlyGeneralLedgerBookRepository(ApplicationDbContext repositoryContext)
           : base(repositoryContext)
        {
            this._repositoryContext = repositoryContext;
        }
        public bool SaveYearlyGeneralLedgerBookRepository(List<YearlyGeneralLedgerBook> data)
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

        public bool UpdateYearlyGeneralLedgerBookRepository(List<YearlyGeneralLedgerBook> data)
        {
            try
            {
                foreach (var model in data)
                {
                    var result = _repositoryContext.YearlyGeneralLedgerBook.Where(x => x.DailyCashId == model.DailyCashId).FirstOrDefault();
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
                    result.LedgerType = model.LedgerType;
                    result.Description = model.Description;
                    result.DailyCashDate = model.DailyCashDate;
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
