using AJWManagementPortal.Data;
using AJWManagementPortal.Extensions.IRepository;
using AJWManagementPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Extensions.Repository
{          // This Repository Folder Created for Yearly + Monthly General Ledger Book ----------By Yousaf Rakib Shb------
    public class MonthlyMainBankLedgerBookRepository: RepositoryBase<MonthlyMainBankLedgerBook>, IMonthlyMainBankLedgerBookRepository
    {
        private readonly ApplicationDbContext _repositoryContext;
        public MonthlyMainBankLedgerBookRepository(ApplicationDbContext repositoryContext)
           : base(repositoryContext)
        {
            this._repositoryContext = repositoryContext;
        }
        public bool SaveMonthlyMainBankLedgerBookRepository(List<MonthlyMainBankLedgerBook> data)
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

        public bool UpdateMonthlyMainBankLedgerBookRepository(List<MonthlyMainBankLedgerBook> data)
        {
            try
            {
                foreach (var model in data)
                {
                    var result = _repositoryContext.MonthlyMainBankLedgerBook.Where(x => x.MainBankDailyCashId == model.MainBankDailyCashId).FirstOrDefault();
                    result.SignPManager = model.SignPManager;
                    result.PManagerRemarks = model.PManagerRemarks;
                    result.SignGM = model.SignGM;
                    result.GMRemarks = model.GMRemarks;
                    result.SignCeo = model.SignCeo;
                    result.CeoRemarks = model.CeoRemarks;
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
