using AJWManagementPortal.Data;
using AJWManagementPortal.Extensions.IRepository;
using AJWManagementPortal.Models;
using AJWManagementPortal.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        private readonly IMonthlyGeneralLedgerBookRepository _monthlyGeneralLadgerBookRepository;
        private readonly IYearlyGeneralLedgerBookRepository _yearlyGeneralLadgerBookRepository;
        //private readonly IWebHostEnvironment _iwebhost;
        //IWebHostEnvironment iwebhost
        //                _iwebhost = iwebhost;

        public GeneralLedgerController(ApplicationDbContext db)
        {
            _db = db;

        }
        //--------------------------------------------------start-----------------general ledger BOOK---Daily/Monthly/Yearly--------------

        //GET 1 - for General Ledger List
        public IActionResult GeneralLedgerBookList()
        {
            GeneralLedgerBookListViewModel generalLedgerBookListViewModel = new GeneralLedgerBookListViewModel();
            generalLedgerBookListViewModel.MonthlyGeneralLedgerBooks = _db.MonthlyGeneralLedgerBook.ToList().GroupBy(x => new { x.DailyCashDate.Year, x.DailyCashDate.Month }).Select(group => group.First());
            generalLedgerBookListViewModel.YearlyGeneralLedgerBooks = _db.YearlyGeneralLedgerBook.ToList().GroupBy(x => new { x.DailyCashDate.Year }).Select(group => group.First());
            return View(generalLedgerBookListViewModel);
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
            DateTime now = DateTime.Now;
            var startDate = new DateTime(now.Year, now.Month, 1);
            var endDate = startDate.AddMonths(1).AddDays(-1);
            TransAndBank trans = new TransAndBank();
            trans.aDailyCashes = _db.aDailyCashes
            .Where(z => z.ValueDate >= startDate && z.ValueDate <= endDate && z.DelProduction != 0)
            .ToList();
            return View("MonthlyGeneralLedgerBook", trans);
        }

        public JsonResult InsertMonthlyGeneralLedgerBook(List<MonthlyGeneralLedgerBook> data)
        {
            bool result = false;
            int response = 0;
            var monthlyGeneralLadgerBookList = _db.MonthlyGeneralLedgerBook.AsNoTracking().ToList();

            var existMonthlyGeneralLedgerBookList = data
                                               .Join(monthlyGeneralLadgerBookList, NLB => NLB.DailyCashId, ELB => ELB.DailyCashId, (NLB, ELB) => new { NLB, ELB })
                                               .Where(x => x.NLB.DailyCashId == x.ELB.DailyCashId)
                                               .Select(x => x.NLB).ToList()
                                               .ToList();

            var newMonthlyGeneralLedgerBookList = (from NLB in data
                                                   where !(from ELB in monthlyGeneralLadgerBookList select ELB.DailyCashId)
                                                   .Contains(NLB.DailyCashId)
                                                   select NLB).ToList();

            if (newMonthlyGeneralLedgerBookList.Count > 0)
            {
                result = _monthlyGeneralLadgerBookRepository.SaveMonthlyGeneralLedgerBookRepository(newMonthlyGeneralLedgerBookList);
            }

            if (existMonthlyGeneralLedgerBookList.Count > 0)
            {
                result = _monthlyGeneralLadgerBookRepository.UpdateMonthlyGeneralLedgerBookRepository(existMonthlyGeneralLedgerBookList);
            }

            if (result == true)
            {
                response = 1;
            }
            else
            {
                response = 2;
            }

            return Json(response);

        }

        //GET 1- for MonthlyGeneralLedgerBook report ended
        //POST 1- for MonthlyGeneralLedgerBook Report
        //POST 1- for MonthlyGeneralLedgerBook Report ended

        //GET 1- for YearlyGeneralLedgerBook
        public IActionResult YearlyGeneralLedgerBook()
        {
            int year = DateTime.Now.Year;
            DateTime startDate = new DateTime(year, 1, 1);
            DateTime endDate = new DateTime(year, 12, 31);

            List<MonthlyGeneralLedgerBook> monthlyGeneralLadgerBookList = _db.MonthlyGeneralLedgerBook
            .Where(z => z.DailyCashDate >= startDate && z.DailyCashDate <= endDate)
            .ToList();
            return View("YearlyGeneralLedgerBook", monthlyGeneralLadgerBookList);
        }

        public JsonResult InsertYearlyGeneralLedgerBook(List<YearlyGeneralLedgerBook> data)
        {
            bool result = false;
            int response = 0;
            var yearlyGeneralLadgerBookList = _db.YearlyGeneralLedgerBook.AsNoTracking().ToList();

            var existYearlyGeneralLedgerBookList = data
                                               .Join(yearlyGeneralLadgerBookList, NLB => NLB.DailyCashId, ELB => ELB.DailyCashId, (NLB, ELB) => new { NLB, ELB })
                                               .Where(x => x.NLB.DailyCashId == x.ELB.DailyCashId)
                                               .Select(x => x.NLB).ToList()
                                               .ToList();

            var newYearlyGeneralLedgerBookList = (from NLB in data
                                                  where !(from ELB in yearlyGeneralLadgerBookList select ELB.DailyCashId)
                                                  .Contains(NLB.DailyCashId)
                                                  select NLB).ToList();

            if (newYearlyGeneralLedgerBookList.Count > 0)
            {
                result = _yearlyGeneralLadgerBookRepository.SaveYearlyGeneralLedgerBookRepository(newYearlyGeneralLedgerBookList);
            }

            if (existYearlyGeneralLedgerBookList.Count > 0)
            {
                result = _yearlyGeneralLadgerBookRepository.UpdateYearlyGeneralLedgerBookRepository(existYearlyGeneralLedgerBookList);
            }

            if (result == true)
            {
                response = 1;
            }
            else
            {
                response = 2;
            }

            return Json(response);

        }

        //GET 1- for YearlyGeneralLedgerBook report ended
        //POST 1- for YearlyGeneralLedgerBook Report
        //POST 1- for YearlyGeneralLedgerBook Report ended
        //--------------------------------------------------ended-----------------general ledger BOOK---Daily/Monthly/Yearly--------------

    }
}
