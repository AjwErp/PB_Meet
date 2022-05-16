using AJWManagementPortal.Data;
using AJWManagementPortal.Models;
using AJWManagementPortal.ViewModels;
using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Account.Controllers
{
    [Area("Account")]
    public class AccountsMonthlyYearlyController : Controller
    { //here we create constrauctor of DB class
        private readonly ApplicationDbContext _db;
        //This Variable use for Sweet alert notification........
        private readonly INotyfService _notyf;
        public AccountsMonthlyYearlyController(ApplicationDbContext db, INotyfService notyf)
        {
            _db = db;
            _notyf = notyf;
        }

        //GET --AccountsMonthlyYearlyReports--start----
        public async Task<IActionResult> AccountsMonthlyYearlyReports()
        {
            var model = new AccountsYearlyReportViewModel();

            //--Monthly/Yearly List View for All Sheets---1 -Monthly Closing Page------
            var monthlyClosingReport = await (from a in _db.MonthlyClosingReports
                                              where a.DelProduction != 0
                                              select new MonthlyAcountReportsViewModel
                                              {
                                                  Id = a.Id,
                                                  Date = a.ValueDate,
                                                  IsMonthlyClosingReport = true,
                                                  Title = "Monthly Accounts Report"
                                              }).ToListAsync();

            //--Monthly/Yearly List View for All Sheets----2 Monthly meezanBankMonthlyIncomeExpenseReports------
            var meezanBankMonthlyIncomeExpenseReports = await (from a in _db.MeezanBankMonthlyIncomeExpenseReports
                                                               where a.DelProduction != 0
                                                               select new MonthlyAcountReportsViewModel
                                                               {
                                                                   Id = a.Id,
                                                                   Date = a.ValueDate,
                                                                   IsMeezanBankIncomeExpenseReport = true,
                                                                   Title = "Meezan Bank Monthly Income/Expence Report"
                                                               }).ToListAsync();

            //--Monthly/Yearly List View for All Sheets----3 Monthly meezanBankMonthlyIncomeExpenseReports------

            //var MonthlyIncomeExpenceInternalAccount = await (from a in _db.MeezanBankMonthlyIncomeExpenseReports
            //                                                   where a.DelProduction != 0
            //                                                   select new MonthlyAcountReportsViewModel
            //                                                   {
            //                                                       Id = a.Id,
            //                                                       Date = a.ValueDate,
            //                                                       IsMeezanBankIncomeExpenseReport = true,
            //                                                       Title = "Meezan Bank Monthly Income/Expence Report"
            //                                                   }).ToListAsync();
            //--Monthly/Yearly List View for All Sheets----4 Monthly meezanBankMonthlyIncomeExpenseReports------

            //var meezanBankMonthlyIncomeExpenseReports = await (from a in _db.MeezanBankMonthlyIncomeExpenseReports
            //                                                   where a.DelProduction != 0
            //                                                   select new MonthlyAcountReportsViewModel
            //                                                   {
            //                                                       Id = a.Id,
            //                                                       Date = a.ValueDate,
            //                                                       IsMeezanBankIncomeExpenseReport = true,
            //                                                       Title = "Meezan Bank Monthly Income/Expence Report"
            //                                                   }).ToListAsync();
            //--Monthly/Yearly List View for All Sheets----1+2 Union of MonthlyClosing + MeezanBankIE Reprot ------

            //----Monthly Income Expence Internal Account Report List---
            var monthlyIncomeExpenceInternalAccount = await (from a in _db.MonthlyIncomeExpenceInternalAccountReport

                                                             select new MonthlyAcountReportsViewModel
                                                             {
                                                                 Id = a.Id,
                                                                 Date = Convert.ToDateTime(a.SelectedDate),
                                                                 IsMonthlyIncomeExpenceInternalAccountReport = true,
                                                                 Title = "Monthly Income Expence Internal Account Report"
                                                             }).ToListAsync();

            var trialBalance = _db.TrialBalanceAccountOffice.Select(x => new
            {
                SelectedDate = x.SelectedDate.Substring(0, 10),
                KeyValue = x.KeyValue
            }).ToList();
            var trialBalance2 = trialBalance.GroupBy(n => new { n.SelectedDate, n.KeyValue }).Select(x => new { x.Key.SelectedDate, x.Key.KeyValue }).ToList();

            var trialBalanceAccountOffice = (from a in trialBalance2

                                             select new MonthlyAcountReportsViewModel
                                             {
                                                 Id = a.KeyValue == null ? 0 : Convert.ToInt32(a.KeyValue),
                                                 Date = Convert.ToDateTime(a.SelectedDate),
                                                 IsTrialBalanceAccountOfficeReport = true,
                                                 Title = "Monthly Trial Balance Account Office Report"
                                             }).ToList();

            model.MonthlyAcountReportsViewModel = monthlyClosingReport.Union(meezanBankMonthlyIncomeExpenseReports).Union(monthlyIncomeExpenceInternalAccount).Union(trialBalanceAccountOffice).OrderBy(x => x.Date);

            //model.MonthlyAcountReportsViewModel = model.MonthlyAcountReportsViewModel.Union(monthlyIncomeExpenceInternalAccount).OrderBy(x => x.Date);

            //--Monthly/Yearly List View for All Sheets----3 Yearly Closing Report------
            var yearlyClosingReport = await (from a in _db.YearlyClosingReports
                                             where a.DelProduction != 0
                                             select new YearlyAcountReportsViewModel
                                             {
                                                 Id = a.Id,
                                                 Date = a.ValueDate,
                                                 IsYearlyClosingReport = true,
                                                 Title = "Yearly Accounts Report"
                                             }).ToListAsync();
            model.YearlyAcountReportsViewModel = yearlyClosingReport.OrderBy(x => x.Date);

            //model.AccountsYearlyReportTitlePage = _db.AccountsYearlyReportTitlePages.Where(q => q.DelAccountsYR != 0).ToList().GroupBy(elem => elem.YRDate).Select(group => group.First());

            return View(model);
        }
        //GET --AccountsMonthlyYearlyReports--ended----
        //POST --AccountsMonthlyYearlyReports--start----
        //POST --AccountsMonthlyYearlyReports--ended----

        public async Task<IActionResult> SendMonthlyClosingReportToDgmOffice(string remarks)
        {
            var currentMonthlyReportData = (dynamic)null;
            var currentMeezanBankIncomeExpenseReportData = (dynamic)null;


            remarks = remarks.Replace("-", "/");
            DateTime dateTime10 = DateTime.Parse(remarks);
            //Send Monthly Report To DGM Office using This Code 1: MonthlyClosingReports-----
            var monthlyReportData = _db.MonthlyClosingReports.Where(i => i.ValueDate.Equals(dateTime10) && i.DelProduction != 0).FirstOrDefault();
            if (monthlyReportData != null)
            {
                monthlyReportData.Status = "1";
                currentMonthlyReportData = await _db.MonthlyClosingReports.FindAsync(monthlyReportData.Id);

            }
            //Send Monthly Report To DGM Office using This Code 2: MeezanBankMonthlyIncomeExpenseReports-----

            var meezanBankIncomeExpenseReportData = _db.MeezanBankMonthlyIncomeExpenseReports.Where(i => i.ValueDate.Equals(dateTime10) && i.DelProduction != 0).FirstOrDefault();
            if (meezanBankIncomeExpenseReportData != null)
            {
                meezanBankIncomeExpenseReportData.Status = "1";
                currentMeezanBankIncomeExpenseReportData = await _db.MeezanBankMonthlyIncomeExpenseReports.FindAsync(meezanBankIncomeExpenseReportData.Id);
            }
            if (currentMonthlyReportData != null)
            {
                _db.Entry(currentMonthlyReportData).CurrentValues.SetValues(monthlyReportData);

            }
            if (currentMeezanBankIncomeExpenseReportData != null)
            {
                _db.Entry(currentMeezanBankIncomeExpenseReportData).CurrentValues.SetValues(meezanBankIncomeExpenseReportData);

            }
            await _db.SaveChangesAsync();
            //for Sweet alert Notification use this Technique.....................
            _notyf.Success("Report successfully sent to D.G.M office");
            return RedirectToAction("AccountsMonthlyYearlyReports");
        }
        //public async Task<IActionResult> SendMeezanBankIncomeExpenseReportToDgmOffice(int id)
        //{
        //    var report = await _db.MeezanBankMonthlyIncomeExpenseReports.FindAsync(id);
        //    if (report == null)
        //    {
        //        return RedirectToAction("AccountsMonthlyYearlyReports");
        //    }

        //    try
        //    {
        //        report.Status = "1";
        //        _db.Entry(report).State = EntityState.Modified;
        //        await _db.SaveChangesAsync();
        //        _notyf.Success("Report successfully sent to D.G.M office");
        //        return RedirectToAction("AccountsMonthlyYearlyReports");
        //    }
        //    catch (DbUpdateException /* ex */)
        //    {
        //        return RedirectToAction("AccountsMonthlyYearlyReports");
        //    }
        //}

    }
}