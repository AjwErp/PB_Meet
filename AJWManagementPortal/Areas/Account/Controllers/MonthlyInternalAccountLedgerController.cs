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
            return View();
        }
    }
}


