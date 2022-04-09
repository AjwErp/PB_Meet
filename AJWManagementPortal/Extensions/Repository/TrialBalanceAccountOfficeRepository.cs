using AJWManagementPortal.Data;
using AJWManagementPortal.Extensions.IRepository;
using AJWManagementPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Extensions.Repository 
{
    public class TrialBalanceAccountOfficeRepository : RepositoryBase<TrialBalanceAccountOffice>, ITrialBalanceAccountOfficeRepository
    {
        private readonly ApplicationDbContext _repositoryContext;
        public TrialBalanceAccountOfficeRepository(ApplicationDbContext repositoryContext)
           : base(repositoryContext)
        {
            this._repositoryContext = repositoryContext;
        }

        public bool SaveTrialBalanceAccountOffice(List<TrialBalanceAccountOffice> data)
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
    }
}
