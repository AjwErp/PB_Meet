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
    [Area("Account")]
    public class MonthlyInternalAccountLedgerController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly IMonthlyInternalLedgerRepository _monthlyInternalLedgerRepository;
        public MonthlyInternalAccountLedgerController(ApplicationDbContext db, IMonthlyInternalLedgerRepository monthlyInternalLedgerRepository)
        {
            this._db = db;
            this._monthlyInternalLedgerRepository = monthlyInternalLedgerRepository;
        }

        public IActionResult MonthlyInternalAccountLedgerBookView(string id)
        {
            var result = _monthlyInternalLedgerRepository.GetMonthlyInternalLedgersByUniId(id);
            return View(result);
        }

        public IActionResult MonthlyInternalAccountLedgerBookDelete(string id)
        {
            var result = _monthlyInternalLedgerRepository.DeleteMonthlyInternalLedgersByUniId(id);
            return RedirectToAction("InternalAccountLedgerBookList", "InternalAccountLedgers");
        }

        public IActionResult CreateMonthlyInternalLedger()
        {
            return View();
        }

        public JsonResult InsertMonthlyInternalLedger(string txtMonthlyInternalLedger)
        {
            bool result = false;
            int response = 0;
            result = _monthlyInternalLedgerRepository.SaveMonthlyInternalLedger(txtMonthlyInternalLedger);

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

        public IActionResult MonthlyInternalAccountLedgerBook(string id, string value)
        {
            ViewBag.LedgerId = id;
            ViewBag.HeaderText = value + " Ledger Book";

            List<MonthlyInternalLedgerViewModel> monthlyInternalLedgerViewModels = new List<MonthlyInternalLedgerViewModel>();
            monthlyInternalLedgerViewModels = _monthlyInternalLedgerRepository.GetMonthlyInternalLedgers(id);

            if (monthlyInternalLedgerViewModels == null)
            {
                monthlyInternalLedgerViewModels = new List<MonthlyInternalLedgerViewModel>();
            }

            return View("MonthlyInternalAccountLedgerBook", monthlyInternalLedgerViewModels);
        }

        public JsonResult InsertMonthlyInternalAccountLedgerBook(List<MonthlyInternalAccountLedgerBook> data)
        {
            bool result = false;
            int response = 0;
            var monthlyInternalAccountLedgerBookList = _db.MonthlyInternalAccountLedgerBook.AsNoTracking().ToList();

            var existMonthlyInternalAccountLedgerBookList = data
                                               .Join(monthlyInternalAccountLedgerBookList, NLB => NLB.DailyCashId, ELB => ELB.DailyCashId, (NLB, ELB) => new { NLB, ELB })
                                               .Where(x => x.NLB.DailyCashId == x.ELB.DailyCashId)
                                               .Select(x => x.NLB).ToList()
                                               .ToList();

            var newMonthlyInternalAccountLedgerBookList = (from NLB in data
                                                           where !(from ELB in monthlyInternalAccountLedgerBookList select ELB.DailyCashId)
                                                           .Contains(NLB.DailyCashId)
                                                           select NLB).ToList();

            if (newMonthlyInternalAccountLedgerBookList.Count > 0)
            {
                result = _monthlyInternalLedgerRepository.SaveMonthlyInternalAccountLedgerBook(newMonthlyInternalAccountLedgerBookList);
            }

            if (existMonthlyInternalAccountLedgerBookList.Count > 0)
            {
                result = _monthlyInternalLedgerRepository.UpdateMonthlyInternalAccountLedgerBook(existMonthlyInternalAccountLedgerBookList);
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


