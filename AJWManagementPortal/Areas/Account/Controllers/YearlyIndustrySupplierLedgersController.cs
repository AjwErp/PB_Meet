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
    public class YearlyIndustrySupplierLedgersController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly IYearlyIndustrySupplierLedgerRepository _yearlyIndustrySupplierLedgerRepository;

        public YearlyIndustrySupplierLedgersController(ApplicationDbContext db, IYearlyIndustrySupplierLedgerRepository yearlyIndustrySupplierLedgerRepository)
        {
            this._db = db;
            this._yearlyIndustrySupplierLedgerRepository = yearlyIndustrySupplierLedgerRepository;
        }

        public IActionResult CreateYearlyIndustrySupplierLedger()
        {
            return View();
        }

        public JsonResult InsertYearlyIndustrySupplierLedger(string txtYearlyIndustrySupplierLedger)
        {
            bool result = false;
            int response = 0;
            result = _yearlyIndustrySupplierLedgerRepository.SaveYearlyIndustrySupplierLedger(txtYearlyIndustrySupplierLedger);

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

        public IActionResult YearlyIndustrySupplierLedgerBook(string id, string value)
        {
            ViewBag.LedgerId = id;
            ViewBag.HeaderText = value + " Ledger Book";
            return View();
        }
    }
}
