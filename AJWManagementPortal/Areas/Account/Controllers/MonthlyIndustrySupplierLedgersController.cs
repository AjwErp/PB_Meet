using AJWManagementPortal.Data;
using AJWManagementPortal.Extensions.IRepository;
using Microsoft.AspNetCore.Mvc;
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

        public IActionResult MonthlyIndustrySupplierLedgerBook(string id, string value)
        {
            ViewBag.LedgerId = id;
            ViewBag.HeaderText = value + " Ledger Book";
            return View();
        }
    }
}
