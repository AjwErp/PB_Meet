using AJWManagementPortal.Data;
using AJWManagementPortal.Extensions.IRepository;
using AJWManagementPortal.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Account.Controllers
{
    //This Controller for::Yearly Internal Account Ledger Reports For Account Office::
    [Area("Account")]
    public class YearlyInternalAccountLedgerController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly IYearlyInternalLedgerRepository _yearlyInternalLedgerRepository;
        public YearlyInternalAccountLedgerController(ApplicationDbContext db, IYearlyInternalLedgerRepository yearlyInternalLedgerRepository)
        {
           this._yearlyInternalLedgerRepository = yearlyInternalLedgerRepository;
           this._db = db;
        }
        
        public IActionResult CreateYearlyInternalLedger()
        {
            return View();
        }

        public JsonResult InsertYearlyInternalLedger(string txtYearlyInternalLedger)
        {
            bool result = false;
            int response = 0;
            result = _yearlyInternalLedgerRepository.SaveYearlyInternalLedger(txtYearlyInternalLedger);

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

        public IActionResult YearlyInternalAccountLedgerBook(string id, string value)
        {
            ViewBag.LedgerId = id;
            ViewBag.HeaderText = value + " Ledger Book";
            return View();
        }
    }
}
