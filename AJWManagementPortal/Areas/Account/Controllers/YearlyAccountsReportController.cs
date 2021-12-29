using AJWManagementPortal.Data;
using AJWManagementPortal.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Account.Controllers
{
    //This Controller for::Yearly Reprots for Account Office::
    [Area("Account")]
    public class YearlyAccountsReportController : Controller
    { //here we create constrauctor of DB class
        private readonly ApplicationDbContext _db;
        public YearlyAccountsReportController(ApplicationDbContext db)
        {
            _db = db;
        }
        //GET --Title Page---for YearlyClosingReportTitlePage--start
        [HttpGet]
        public async Task<IActionResult> YearlyClosingReportTitlePage()
        {
            return View();
        }
        //GET --Title Page---for YearlyClosingReportTitlePage--ended
        //POST --Title Page--for YearlyClosingReportTitlePage--start
        //GET ---Title Page--for YearlyClosingReportTitlePage--ended

        //--------------Start---------------------AJW MAnagement Staff Working Plan---------------------
        //[HttpGet]
        //public async Task<IActionResult> AccountsYearlyReportTitlePages()
        //{
        //    return View();
        //}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> YearlyClosingReportTitlePage(AccountsYearlyReportTitlePage title, string id)
        {
            DateTime today = DateTime.Today;

            if (id == null)
            {
                id = today.ToString("yyyy-MM-dd");
                //return NotFound();
            }
            id = id.Replace("-", "/");
            DateTime dateTime10 = DateTime.Parse(id);

            title.YRTitle = "";
            title.YRStatus = "3";
            title.DelAccountsYR = 1;
            title.DelDgmYR = 1;
            //v.Remarks = "";
            _db.Add(title);
            await _db.SaveChangesAsync();
            //return RedirectToAction(nameof(DailyMeezanBankVoucherReport));



            ViewBag.Data = _db.AccountsYearlyReportTitlePages;


            ViewBag.Data1 = _db.AccountsYearlyReportTitlePages.ToList();
            ViewBag.hide = false;
            return View("AccountsMonthlyYearlyReports", title);
        }

        //-----------------------------------------------------------------------------------------------------
        //GET ---1-- for YearlyIncomeExpenseBankAndInternalReport---START
        public IActionResult YearlyIncomeExpenseBankAndInternalReport()
        {
            return View();
        }
        //Get---1-- for YearlyIncomeExpenseBankAndInternalReport---END
        //POST---1-- for YearlyIncomeExpenseBankAndInternalReport---START
        //POST---1-- for YearlyIncomeExpenseBankAndInternalReport---END


        //GET ---2-- for AJWInvestmentPlan---START
        public IActionResult AJWInvestmentPlan()
        {
            return View();
        }
        //Get---2-- for AJWInvestmentPlan---END
        //POST---2-- for AJWInvestmentPlan---START
        //POST---2-- for AJWInvestmentPlan---END


        //GET ---3-- for SaleOfficeIncomeWasoolAccountOffice---START
        public IActionResult SaleOfficeIncomeWasoolAccountOffice()
        {
            return View();
        }
        //Get---3 for SaleOfficeIncomeWasoolAccountOffice---END
        //POST---3-- for SaleOfficeIncomeWasoolAccountOffice---START
        //POST---3-- for SaleOfficeIncomeWasoolAccountOffice---END



        //GET ---4-- for BankAccountProfitableByBankAddBankAccount---START
        public IActionResult BankAccountProfitableByBankAddBankAccount()
        {
            return View();
        }
        //Get---4-- for BankAccountProfitableByBankAddBankAccount---END
        //POST---4 for BankAccountProfitableByBankAddBankAccount---START
        //POST---4-- for BankAccountProfitableByBankAddBankAccount---END


        //GET ---5-- for InternalAccountClosingBalancesAddBankAccount---START
        public IActionResult InternalAccountClosingBalancesAddBankAccount()
        {
            return View();
        }
        //Get---5-- for InternalAccountClosingBalancesAddBankAccount---END
        //POST---5 for InternalAccountClosingBalancesAddBankAccount---START
        //POST---5-- for InternalAccountClosingBalancesAddBankAccount---END


        //GET ---6-- for YearlyInternalAccountExpenseReport---START
        public IActionResult YearlyInternalAccountExpenseReport()
        {
            return View();
        }
        //Get---6-- for YearlyInternalAccountExpenseReport---END
        //POST---6 for YearlyInternalAccountExpenseReport---START
        //POST---6-- for YearlyInternalAccountExpenseReport---END


        //GET ---7-- for IncomeTaxDeductBankChequeCashAndOtherTax---START
        public IActionResult IncomeTaxDeductBankChequeCashAndOtherTax()
        {
            return View();
        }
        //Get---7-- for IncomeTaxDeductBankChequeCashAndOtherTax---END
        //POST---7 for IncomeTaxDeductBankChequeCashAndOtherTax---START
        //POST---7-- for IcomeExpenseIncomeTaxDeductBankChequeCashAndOtherTaxMeezanBankYearlyReport---END



    }
}

