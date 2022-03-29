using AJWManagementPortal.Data;
using AJWManagementPortal.Models;
using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        private readonly INotyfService _notyf;
        private readonly IHostingEnvironment _env;
        private string meezanBankIncomeExportReportFileUploadFolder = "Reports/MezaanBankIncomeExportReport/";

        //This is referance for ApplicationDB || NotifyAlertService || HostingEnvironment 
        public YearlyAccountsReportController(ApplicationDbContext db, INotyfService notyf, IHostingEnvironment env)
        {
            _db = db;
            _notyf = notyf;
            _env = env;
        }
        //GET --Title Page---for YearlyClosingReportTitlePage--start

        public IActionResult YearlyClosingReportTitlePage()
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
        #region YEARLY CLOSING REPORT
        public IActionResult YearlyClosingReport()
        {
            var model = new YearlyClosingReport
            {
                ValueDate = System.Convert.ToDateTime(DateTime.Now.ToString("MM-dd-yyyy"))
            };
            return View(model);
        }
        [HttpPost]
        public ActionResult YearlyClosingReport(YearlyClosingReport model)
        {
            if (!ModelState.IsValid)
                return View(model);
            //If Same Date Sheet Already Exist then Display Message for dont Create Same Date Sheet
            var reportExist = _db.YearlyClosingReports.Where(x => x.Month == model.ValueDate.Month && x.Year == model.ValueDate.Year);
            if (reportExist.Any())
            {
                _notyf.Information("Report already exist for month of" + model.ValueDate.ToString("MMMM"));
                return View(model);
            }

            model.DelProduction = 1;
            model.Month = model.ValueDate.Month;
            model.Year = model.ValueDate.Year;
            _db.YearlyClosingReports.Add(model);
            _db.SaveChanges();
            _notyf.Information("Report successfully added for year" + model.ValueDate.ToString("MMMM"));
            return RedirectToAction("AccountsMonthlyYearlyReports", "AccountsMonthlyYearly");
        }
        public IActionResult EditYearlyClosingReport(int id, bool IsEdit)
        {
            var model = _db.YearlyClosingReports.Where(x => x.Id == id).Select(c => new YearlyClosingReport()
            {
                ValueDate = Convert.ToDateTime(c.ValueDate.ToString("MM-dd-yyyy")),
                SignAManager = c.SignAManager,
                AManagerRemarks = c.AManagerRemarks,
                DelProduction = c.DelProduction,
                Month = c.Month,
                Year = c.Year,
                Status = c.Status
            }).FirstOrDefault();
            ViewBag.EditStatus = IsEdit;

            return View(model);
        }
        [HttpPost]
        public ActionResult EditYearlyClosingReport(YearlyClosingReport model)
        {
            if (!ModelState.IsValid)
                return View(model);
            _db.Entry(model).State = EntityState.Modified;
            _db.SaveChanges();
            _notyf.Success("Edited successfully");

            return RedirectToAction("AccountsMonthlyYearlyReports", "AccountsMonthlyYearly");
        }
        public async Task<IActionResult> DeleteYearlyClosingReport(int id)
        {

            var report = await _db.YearlyClosingReports.FindAsync(id);
            if (report == null)
            {
                return RedirectToAction("AccountsMonthlyYearlyReports", "AccountsMonthlyYearly");
            }

            try
            {
                report.DelProduction = 0;
                _db.Entry(report).State = EntityState.Modified;
                await _db.SaveChangesAsync();
                _notyf.Success("Deleted successfully");
                return RedirectToAction("AccountsMonthlyYearlyReports", "AccountsMonthlyYearly");
            }
            catch (DbUpdateException /* ex */)
            {
                return RedirectToAction("AccountsMonthlyYearlyReports", "AccountsMonthlyYearly");
            }
        }
        #endregion
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
