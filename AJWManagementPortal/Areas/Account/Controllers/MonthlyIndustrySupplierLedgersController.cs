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
    public class MonthlyIndustrySupplierLedgersController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly IMonthlyIndustrySupplierLedgerRepository _monthlyIndustrySupplierLedgerRepository;

        public MonthlyIndustrySupplierLedgersController(ApplicationDbContext db, IMonthlyIndustrySupplierLedgerRepository monthlyIndustrySupplierLedgerRepository)
        {
            this._db = db;
            this._monthlyIndustrySupplierLedgerRepository = monthlyIndustrySupplierLedgerRepository;
        }

        public IActionResult CreateMonthlyIndustrySupplierLedger()
        {
            return View();
        }

        public IActionResult MonthlyIndustrySupplierLedgerBook(string id, string value)
        {
            ViewBag.LedgerId = id;
            ViewBag.HeaderText = value + " Ledger Book";

            List<MonthlyIndustrySupplierLedgerViewModel> monthlyIndustrySupplierLedgerViewModel = new List<MonthlyIndustrySupplierLedgerViewModel>();
            monthlyIndustrySupplierLedgerViewModel = _monthlyIndustrySupplierLedgerRepository.GetMonthlyIndustrySupplierLedgers();

            if (monthlyIndustrySupplierLedgerViewModel == null)
            {
                monthlyIndustrySupplierLedgerViewModel = new List<MonthlyIndustrySupplierLedgerViewModel>();
            }

            return View("MonthlyIndustrySupplierLedgerBook", monthlyIndustrySupplierLedgerViewModel);
        }

        public JsonResult InsertMonthlyIndustrySupplierLedgerBook(List<MonthlyIndustrySupplierLedgerBook> data)
        {
            bool result = false;
            int response = 0;
            var monthlyIndustrySupplierLedgerBookList = _db.MonthlyIndustrySupplierLedgerBook.AsNoTracking().ToList();

            var existMonthlyIndustrySupplierLedgerBookList = data
                                               .Join(monthlyIndustrySupplierLedgerBookList, NLB => NLB.DailyCashId, ELB => ELB.DailyCashId, (NLB, ELB) => new { NLB, ELB })
                                               .Where(x => x.NLB.DailyCashId == x.ELB.DailyCashId)
                                               .Select(x => x.NLB).ToList()
                                               .ToList();

            var newMonthlyIndustrySupplierLedgerBookList = (from NLB in data
                                                            where !(from ELB in monthlyIndustrySupplierLedgerBookList select ELB.DailyCashId)
                                                            .Contains(NLB.DailyCashId)
                                                            select NLB).ToList();

            if (newMonthlyIndustrySupplierLedgerBookList.Count > 0)
            {
                result = _monthlyIndustrySupplierLedgerRepository.SaveMonthlyIndustrySupplierLedgerBook(newMonthlyIndustrySupplierLedgerBookList);
            }

            if (existMonthlyIndustrySupplierLedgerBookList.Count > 0)
            {
                result = _monthlyIndustrySupplierLedgerRepository.UpdateMonthlyIndustrySupplierLedgerBook(existMonthlyIndustrySupplierLedgerBookList);
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

        public JsonResult InsertMonthlyIndustrySupplierLedger(string txtMonthlyIndustrySupplierLedger)
        {
            bool result = false;
            int response = 0;
            result = _monthlyIndustrySupplierLedgerRepository.SaveMonthlyIndustrySupplierLedger(txtMonthlyIndustrySupplierLedger);

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
