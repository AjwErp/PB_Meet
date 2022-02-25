using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace AJWManagementPortal.Extensions.IRepository
{             // This IRepository Folder Created for Yearly + Monthly General Ledger Book ----------By Yousaf Rakib Shb------
    public interface IRepositoryBase<T>
    {
        IQueryable<T> FindAll();
        IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression);
        void Create(T entity);
        void Update(T entity);
    }
}
