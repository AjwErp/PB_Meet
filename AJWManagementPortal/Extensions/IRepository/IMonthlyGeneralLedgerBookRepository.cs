﻿using AJWManagementPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Extensions.IRepository
{
    public interface IMonthlyGeneralLedgerBookRepository
    {
        public bool SaveMonthlyGeneralLedgerBookRepository(List<MonthlyGeneralLedgerBook> data);
        public bool UpdateMonthlyGeneralLedgerBookRepository(List<MonthlyGeneralLedgerBook> data);
    }
}
