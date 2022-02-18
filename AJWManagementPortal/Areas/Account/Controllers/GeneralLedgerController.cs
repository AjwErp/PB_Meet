using AJWManagementPortal.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Account.Controllers
{
    //This Controller for ::General/Daily/Monthly/Yearly/ Ledger for Account Office::
    [Area("Account")]
    public class GeneralLedgerController : Controller
    {
        private readonly ApplicationDbContext _db;
        //private readonly IWebHostEnvironment _iwebhost;
        //IWebHostEnvironment iwebhost
        //                _iwebhost = iwebhost;

        public GeneralLedgerController(ApplicationDbContext db, IMonthlyGeneralLedgerBookRepository monthlyGeneralLadgerBookRepository, IYearlyGeneralLedgerBookRepository yearlyGeneralLadgerBookRepository)
        {
            _db = db;
            this._monthlyGeneralLadgerBookRepository = monthlyGeneralLadgerBookRepository;
            this._yearlyGeneralLadgerBookRepository = yearlyGeneralLadgerBookRepository;
        }
        //--------------------------------------------------start-----------------general ledger BOOK---Daily/Monthly/Yearly--------------

        //GET 1 - for General Ledger List
        public IActionResult GeneralLedgerBookList()
        {
            return View();
        }
        //GET 1 - for General Ledger List ended
        //POST 1- for General ledger Report List
        //POST 1- for General ledger Report List ended
     
        public IActionResult DailyGeneralLedgerBook()
        {
            return View();
        }
        //GET 1- for DailyGeneralLedgerBook report ended
        //POST 1- for DailyGeneralLedgerBook Report
        //POST 1- for DailyGeneralLedgerBook Report ended

        //GET 1- for MonthlyGeneralLedgerBook
        public IActionResult MonthlyGeneralLedgerBook()
        {
            return View();
        }
        //GET 1- for MonthlyGeneralLedgerBook report ended
        //POST 1- for MonthlyGeneralLedgerBook Report
        //POST 1- for MonthlyGeneralLedgerBook Report ended

        //GET 1- for YearlyGeneralLedgerBook
        public IActionResult YearlyGeneralLedgerBook()
        {
            return View();
        }
        //GET 1- for YearlyGeneralLedgerBook report ended
        //POST 1- for YearlyGeneralLedgerBook Report
        //POST 1- for YearlyGeneralLedgerBook Report ended
        //--------------------------------------------------ended-----------------general ledger BOOK---Daily/Monthly/Yearly--------------

    }
}
