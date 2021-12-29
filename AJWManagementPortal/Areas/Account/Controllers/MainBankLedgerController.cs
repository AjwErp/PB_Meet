using AJWManagementPortal.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Account.Controllers
{
    //This Controller for ::Main Bank Ledgers Daily/Monthly/Yearly/ for account office::
    [Area("Account")]
    public class MainBankLedgerController : Controller
    {
        private readonly ApplicationDbContext _db;
        //private readonly IWebHostEnvironment _iwebhost;
        //IWebHostEnvironment iwebhost
        //                _iwebhost = iwebhost;

        public MainBankLedgerController(ApplicationDbContext db)
        {
            _db = db;

        }
        //GET- for MainBankLedgerBook List
        public IActionResult MainBankLedgerBookList()
        {
            return View();
        }
        //GET- for MainBankLedgerBook List ended
        //POST- for MainBankLedgerBook List
        //POST- for MainBankLedgerBook List ended
        //GET - for MainBankLedgerBook
        //--------------------------------------------------start-----------------general ledger BOOK---Daily/Monthly/Yearly--------------

        public IActionResult DailyMainBankLedgerBook()
        {
            return View();
        }
        //GET 1- for DailyMainBankLedgerBook report ended
        //POST 1- for DailyMainBankLedgerBook Report
        //POST 1- for DailyMainBankLedgerBook Report ended

        //GET 1- for MonthlyMainBankLedgerBook
        public IActionResult MonthlyMainBankLedgerBook()
        {
            return View();
        }
        //GET 1- for MonthlyMainBankLedgerBook report ended
        //POST 1- for MonthlyMainBankLedgerBook Report
        //POST 1- for MonthlyMainBankLedgerBook Report ended

        //GET 1- for YearlyMainBankLedgerBook
        public IActionResult YearlyMainBankLedgerBook()
        {
            return View();
        }
        //GET 1- for YearlyMainBankLedgerBook report ended
        //POST 1- for YearlyMainBankLedgerBook Report
        //POST 1- for YearlyMainBankLedgerBook Report ended
        //--------------------------------------------------ended-----------------general ledger BOOK---Daily/Monthly/Yearly--------------

    }
}
