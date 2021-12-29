using AJWManagementPortal.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Account.Controllers
{
    [Area("Account")]
    public class AccountsMonthlyYearlyController : Controller
    { //here we create constrauctor of DB class
        private readonly ApplicationDbContext _db;
        public AccountsMonthlyYearlyController(ApplicationDbContext db)
        {
            _db = db;
        }

        //GET --AccountsMonthlyYearlyReports--start----
        public IActionResult AccountsMonthlyYearlyReports()
        {
            return View(_db.AccountsYearlyReportTitlePages.Where(q => q.DelAccountsYR != 0).ToList().GroupBy(elem => elem.YRDate).Select(group => group.First()));
        }
        //GET --AccountsMonthlyYearlyReports--ended----
        //POST --AccountsMonthlyYearlyReports--start----
        //POST --AccountsMonthlyYearlyReports--ended----


    }
}
