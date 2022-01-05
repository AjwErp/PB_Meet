using AJWManagementPortal.Data;
using AJWManagementPortal.Models;
using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Account.Controllers
{
    //This Controller for ::All Monthly reports for Account Office::
    [Area("Account")]
    public class MonthlyAccountsReportController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly INotyfService _notyf;
        public MonthlyAccountsReportController(ApplicationDbContext db, INotyfService notyf)
        {
            _db = db;
            _notyf = notyf;
        }

        //GET --Title Page---for MonthlyClosingReportTitlePage--start
        public IActionResult MonthlyClosingReportTitlePage()
        {
            return View();
        }
        //GET --Title Page---for MonthlyClosingReportTitlePage--ended
        //POST --Title Page--for MonthlyClosingReportTitlePage--start
        //GET ---Title Page--for MonthlyClosingReportTitlePage--ended

        //GET --1---for Monthly Meezan Bank Income/Expense Monthly report--start
        public IActionResult MeezanBankIncomeExpenseMonthlyreport()
        {
            var model = new MeezanBankMonthlyIncomeExpenseReport
            {
                ValueDate = Convert.ToDateTime(DateTime.Now.ToString("MM-dd-yyyy"))
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult MeezanBankIncomeExpenseMonthlyreport(MeezanBankMonthlyIncomeExpenseReport model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var reportExist = _db.MeezanBankMonthlyIncomeExpenseReports.Where(x => x.Month == model.ValueDate.Month && x.Year == model.ValueDate.Year);
            if (reportExist.Any())
            {
                _notyf.Information("Report already exist for month of" + model.ValueDate.ToString("MMMM"));
                return View(model);
            }

            model.DelProduction = 1;
            model.Month = model.ValueDate.Month;
            model.Year = model.ValueDate.Year;
            _db.MeezanBankMonthlyIncomeExpenseReports.Add(model);
            _db.SaveChanges();
            return RedirectToAction("AccountsMonthlyYearlyReports", "AccountsMonthlyYearly");
        }
        //GET --1---for Monthly Meezan Bank Income/Expense Monthly report--ended
        //POST --1--for Monthly Meezan Bank Income/Expense Monthly report--start
        //GET ---1--for Monthly Meezan Bank Income/Expense Monthly report--ended

        //GET----2 --for Monthly Monthly Income/Expense Main Bank Account Meezan ---start
        public IActionResult MonthlyIncomeExpenseMainBankAccountMeezan()
        {
            return View();
        }
        //GET --2--for Monthly Monthly Income/Expense Main Bank Account Meezan--- ended
        //POST --2--for Monthly Monthly Income/Expense Main Bank Account Meezan---start 
        //POST ---2--for Monthly Monthly Income/Expense Main Bank Account Meezan --ended

        //GET----3 --for Monthly BOP Monthly Income/Expence Report--start
        public IActionResult BOPMonthlyIncomeExpenceReport()
        {
            return View();
        }
        //GET --3--for Monthly BOP Monthly Income/Expence Report---ended
        //POST --3--for Monthly Monthly Income/Expense Main Bank Account Meezan--start 
        //POST ---3--for Monthly Monthly Income/Expense Main Bank Account Meezan--ended

        //GET----4 --for Monthly Income/Expence Main Bank Account BOP--start
        public IActionResult MonthlyIncomeExpenceMainBankAccountBOP()
        {
            return View();
        }
        //GET --4--for Monthly Income/Expence Main Bank Account BOP---ended
        //POST --4--for Monthly Income/Expence Main Bank Account BOP--start 
        //POST ---4--for Monthly Income/Expence Main Bank Account BOP--ended

        //GET----5--for Monthly Income/Expence Internal Account--start
        public IActionResult MonthlyIncomeExpenceInternalAccount()
        {
            return View();
        }
        //GET --5--for Monthly Income/Expence Internal Account---ended
        //POST --5--for Monthly Income/Expence Internal Account--start 
        //POST ---5--for Monthly Income/Expence Internal Account--ended

        //GET----6--for Monthly Income/Expence Petty Accountt--start
        public IActionResult MonthlyIncomeExpencePettyAccount()
        {
            return View();
        }
        //GET --6--for Monthly Income/Expence Petty Account---ended
        //POST --6--for Monthly Income/Expence Petty Account--start 
        //POST ---6--for Monthly Income/Expence Petty Account--ended

        //GET----7--for Trial Balance Account Office--start
        public IActionResult TrialBalanceAccountOffice()
        {
            return View();
        }
        //GET --7--for Trial Balance Account Office---ended
        //POST --7--for Trial Balance Account Office--start 
        //POST ---7--for Trial Balance Account Office--ended

        //GET----8--for Loan List-Staff/Labour--start
        public IActionResult LoanListStaffLabour()
        {
            return View();
        }
        //GET --8--for Loan List-Staff/Labour---ended
        //POST --8--for Loan List-Staff/Labour--start 
        //POST ---8--for Loan List-Staff/Labour--ended


        //GET----9--for Advance List-Staff/Labour--start
        public IActionResult AdvanceListStaffLabour()
        {
            return View();
        }
        //GET --9--for Advance List-Staff/Labour---ended
        //POST --9--for Advance List-Staff/Labour--start 
        //POST ---9--for Advance List-Staff/Labour--ended

        //GET----10--for Daily Suppliers Transaction Report--start
        public IActionResult DailySuppliersTransactionReport()
        {
            return View();
        }
        //GET --10--for Daily Suppliers Transaction Report---ended
        //POST --10--for Daily Suppliers Transaction Report--start 
        //POST ---10--for Daily Suppliers Transaction Report--ended

        //GET----11--for Monthly Internal Laan-Daan Report--start
        public IActionResult MonthlyInternalLoanDaanReport()
        {
            return View();
        }
        //GET --11--for Monthly Internal Laan-Daan Report---ended
        //POST --11--for Monthly Internal Laan-Daan Report--start 
        //POST ---11--for Monthly Internal Laan-Daan Report--ended

        //GET----12--for Accounts & Sales Office Income Report--start
        public IActionResult AccountsSalesOfficeIncomeReport()
        {
            return View();
        }
        //GET --12--for Accounts & Sales Office Income Report---ended
        //POST --12--for Accounts & Sales Office Income Report--start 
        //POST ---12--for Accounts & Sales Office Income Report--ended

        //GET----13--for Monthly stock Report--start
        public IActionResult MonthlyStockReport()
        {
            return View();
        }
        //GET --13--for Monthly stock Report---ended
        //POST --13--for Monthly stock Report--start 
        //POST ---13--for Monthly stock Report--ended
        //GET----14--for Suppliers Telephonic Report--start
        public IActionResult SuppliersTelephonicReport()
        {
            return View();
        }
        //GET --14--for Suppliers Telephonic Report---ended
        //POST --14--for Suppliers Telephonic Report--start 
        //POST ---14--for Suppliers Telephonic Report--ended

        //GET----15--for MonthlyAccountOfficeClosingCheckList--start
        public IActionResult MonthlyAccountOfficeClosingCheckList()
        {
            return View();
        }
        //GET --15--for MonthlyAccountOfficeClosingCheckList---ended
        //POST --15--for MonthlyAccountOfficeClosingCheckList--start 
        //POST ---15--for MonthlyAccountOfficeClosingCheckList--ended

        //GET----15--for AccountOfficeMonthlyQueryForm--start
        public IActionResult AccountOfficeMonthlyQueryForm()
        {
            return View();
        }
        //GET --15--for AccountOfficeMonthlyQueryForm---ended
        //POST --15--for AccountOfficeMonthlyQueryForm--start 
        //POST ---15--for AccountOfficeMonthlyQueryForm--ended

        public IActionResult MonthlyClosingReport()
        {
            var model = new MonthlyClosingReport
            {
                ValueDate = System.Convert.ToDateTime(DateTime.Now.ToString("MM-dd-yyyy"))
            };
            return View(model);
        }
        [HttpPost]
        public ActionResult MonthlyClosingReport(MonthlyClosingReport model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var reportExist = _db.MonthlyClosingReports.Where(x => x.Month == model.ValueDate.Month && x.Year == model.ValueDate.Year);
            if (reportExist.Any())
            {
                _notyf.Information("Report already exist for month of" + model.ValueDate.ToString("MMMM"));
                return View(model);
            }

            model.DelProduction = 1;
            model.Month = model.ValueDate.Month;
            model.Year = model.ValueDate.Year;
            _db.MonthlyClosingReports.Add(model);
            _db.SaveChanges();
            return RedirectToAction("AccountsMonthlyYearlyReports", "AccountsMonthlyYearly");
        }
    }
}
