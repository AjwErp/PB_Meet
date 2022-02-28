﻿using AJWManagementPortal.Data;
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
    [Area("Account")]
    public class MainBankLedgerController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly IMonthlyMainBankLedgerBookRepository _monthlyMainBankLadgerBookRepository;
        private readonly IYearlyMainBankLedgerBookRepository _yearlyMainBankLadgerBookRepository;

        public MainBankLedgerController(ApplicationDbContext db, IMonthlyMainBankLedgerBookRepository monthlyMainBankLadgerBookRepository, IYearlyMainBankLedgerBookRepository yearlyMainBankLadgerBookRepository)
        {
            _db = db;
            this._monthlyMainBankLadgerBookRepository = monthlyMainBankLadgerBookRepository;
            this._yearlyMainBankLadgerBookRepository = yearlyMainBankLadgerBookRepository;
        }

        public IActionResult MainBankLedgerBookList()
        {
            MainBankLedgerBookListViewModel mainBankLedgerBookListViewModel = new MainBankLedgerBookListViewModel();
            mainBankLedgerBookListViewModel.MonthlyMainBankLedgerBook = _db.MonthlyMainBankLedgerBook.ToList().GroupBy(x => new { x.MainBankDailyCashDate.Year, x.MainBankDailyCashDate.Month }).Select(group => group.First());
            mainBankLedgerBookListViewModel.YearlyMainBankLedgerBook = _db.YearlyMainBankLedgerBook.ToList().GroupBy(x => new { x.MainBankDailyCashDate.Year }).Select(group => group.First());
            return View(mainBankLedgerBookListViewModel);
        }

        public IActionResult DailyMainBankLedgerBook()
        {
            return View();
        }

        public IActionResult MonthlyMainBankLedgerBook()
        {
            DateTime now = DateTime.Now;
            var startDate = new DateTime(now.Year, now.Month, 1);
            var endDate = startDate.AddMonths(1).AddDays(-1);
            var result = _db.MeezanBankIEReports.ToList();
            //.Where(z => z.ValueDate >= startDate && z.ValueDate <= endDate && z.DelProduction != 0 && z.DelProduction!=0)
            //.ToList();
            return View("MonthlyMainBankLedgerBook", result);
        }

        public JsonResult InsertMonthlyGeneralLedgerBook(List<MonthlyMainBankLedgerBook> data)
        {
            bool result = false;
            int response = 0;
            var monthlyMainBankLadgerBookList = _db.MonthlyMainBankLedgerBook.AsNoTracking().ToList();

            var existMonthlyMainBankLedgerBookList = data
                                               .Join(monthlyMainBankLadgerBookList, NLB => NLB.MainBankDailyCashId, ELB => ELB.MainBankDailyCashId, (NLB, ELB) => new { NLB, ELB })
                                               .Where(x => x.NLB.MainBankDailyCashId == x.ELB.MainBankDailyCashId)
                                               .Select(x => x.NLB).ToList()
                                               .ToList();

            var newMonthlyMainBankLedgerBookList = (from NLB in data
                                                    where !(from ELB in monthlyMainBankLadgerBookList select ELB.MainBankDailyCashId)
                                                    .Contains(NLB.MainBankDailyCashId)
                                                    select NLB).ToList();

            if (newMonthlyMainBankLedgerBookList.Count > 0)
            {
                result = _monthlyMainBankLadgerBookRepository.SaveMonthlyMainBankLedgerBookRepository(newMonthlyMainBankLedgerBookList);
            }

            if (existMonthlyMainBankLedgerBookList.Count > 0)
            {
                result = _monthlyMainBankLadgerBookRepository.UpdateMonthlyMainBankLedgerBookRepository(existMonthlyMainBankLedgerBookList);
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

        public IActionResult YearlyMainBankLedgerBook()
        {
            int year = DateTime.Now.Year;
            DateTime startDate = new DateTime(year, 1, 1);
            DateTime endDate = new DateTime(year, 12, 31);

            List<MonthlyMainBankLedgerBook> monthlyMainBankLadgerBookList = _db.MonthlyMainBankLedgerBook.ToList();
            //.Where(z => z.MainBankDailyCashDate >= startDate && z.MainBankDailyCashDate <= endDate)
            //.ToList();
            return View("YearlyMainBankLedgerBook", monthlyMainBankLadgerBookList);
        }

        public JsonResult InsertYearlyMainBankLedgerBook(List<YearlyMainBankLedgerBook> data)
        {
            bool result = false;
            int response = 0;
            var yearlyMainBankLadgerBookList = _db.YearlyMainBankLedgerBook.AsNoTracking().ToList();

            var existYearlyMainBankLedgerBookList = data
                                               .Join(yearlyMainBankLadgerBookList, NLB => NLB.MainBankDailyCashId, ELB => ELB.MainBankDailyCashId, (NLB, ELB) => new { NLB, ELB })
                                               .Where(x => x.NLB.MainBankDailyCashId == x.ELB.MainBankDailyCashId)
                                               .Select(x => x.NLB).ToList()
                                               .ToList();

            var newYearlyMainBankLedgerBookList = (from NLB in data
                                                   where !(from ELB in yearlyMainBankLadgerBookList select ELB.MainBankDailyCashId)
                                                   .Contains(NLB.MainBankDailyCashId)
                                                   select NLB).ToList();

            if (newYearlyMainBankLedgerBookList.Count > 0)
            {
                result = _yearlyMainBankLadgerBookRepository.SaveYearlyMainBankLedgerBookRepository(newYearlyMainBankLedgerBookList);
            }

            if (existYearlyMainBankLedgerBookList.Count > 0)
            {
                result = _yearlyMainBankLadgerBookRepository.UpdateYearlyMainBankLedgerBookRepository(existYearlyMainBankLedgerBookList);
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
    }
}
