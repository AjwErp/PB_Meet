using AJWManagementPortal.Data;
using AJWManagementPortal.Extensions.IRepository;
using AJWManagementPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Extensions.Repository
{                 // This Repository Folder Created for Yearly + Monthly General Ledger Book ----------By Yousaf Rakib Shb------
    public class MonthlyGeneralLedgerBookRepository : RepositoryBase<MonthlyGeneralLedgerBook>, IMonthlyGeneralLedgerBookRepository
    {
        private readonly ApplicationDbContext _repositoryContext;
        public MonthlyGeneralLedgerBookRepository(ApplicationDbContext repositoryContext)
           : base(repositoryContext)
        {
            this._repositoryContext = repositoryContext;
        }
        public bool SaveMonthlyGeneralLedgerBookRepository(List<MonthlyGeneralLedgerBook> data)
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

        public bool UpdateMonthlyGeneralLedgerBookRepository(List<MonthlyGeneralLedgerBook> data)
        {
            try
            {
                foreach (var model in data)
                {
                    var result = _repositoryContext.MonthlyGeneralLedgerBook.Where(x => x.DailyCashId == model.DailyCashId).FirstOrDefault();
                    result.SignPManager = model.SignPManager;
                    result.PManagerRemarks = model.PManagerRemarks;
                    result.SignGM = model.SignGM;
                    result.GMRemarks = model.GMRemarks;
                    result.SignCeo = model.SignCeo;
                    result.CeoRemarks = model.CeoRemarks;
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
