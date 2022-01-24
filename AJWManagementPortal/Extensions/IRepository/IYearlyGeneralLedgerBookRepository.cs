using AJWManagementPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Extensions.IRepository
{
    public interface IYearlyGeneralLedgerBookRepository
    {
        public bool SaveYearlyGeneralLedgerBookRepository(List<YearlyGeneralLedgerBook> data);
        public bool UpdateYearlyGeneralLedgerBookRepository(List<YearlyGeneralLedgerBook> data);
    }
}
