using AJWManagementPortal.Data;
using AJWManagementPortal.Extensions.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace AJWManagementPortal.Extensions.Repository
{        // This Repository Folder Created for Yearly + Monthly General Ledger Book ----------By Yousaf Rakib Shb------
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected ApplicationDbContext RepositoryContext { get; set; }
        protected RepositoryBase(ApplicationDbContext repositoryContext)
        {
            RepositoryContext = repositoryContext;
        }
        public IQueryable<T> FindAll()
        {
            return RepositoryContext.Set<T>().AsNoTracking();
        }
        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return RepositoryContext.Set<T>().Where(expression).AsNoTracking();
        }
        public void Create(T entity)
        {
            RepositoryContext.Set<T>().Add(entity);
        }
        public void Create(List<T> entity)
        {
            RepositoryContext.Set<T>().AddRange(entity);
        }
        public void Update(T entity)
        {
            RepositoryContext.Set<T>().Update(entity);
        }
        public void Update(List<T> entity)
        {
            RepositoryContext.Set<T>().UpdateRange(entity);
        }
    }
}
