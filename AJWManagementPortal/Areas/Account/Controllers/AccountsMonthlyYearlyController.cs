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
            var monthlyClosingReport = await (from a in _db.MonthlyClosingReports
                                              where a.DelProduction != 0
                                              select new MonthlyAcountReportsViewModel
                                              {
                                                  Id = a.Id,
                                                  Date = a.ValueDate,
                                                  IsMonthlyClosingReport = true,
                                                  Title = "Monthly Accounts Report"
                                              }).ToListAsync();
            var meezanBankMonthlyIncomeExpenseReports = await (from a in _db.MeezanBankMonthlyIncomeExpenseReports
                                                               where a.DelProduction != 0
                                                               select new MonthlyAcountReportsViewModel
                                                               {
                                                                   Id = a.Id,
                                                                   Date = a.ValueDate,
                                                                   IsMeezanBankIncomeExpenseReport = true,
                                                                   Title = "Meezan Bank Monthly Income/Expence Report"
                                                               }).ToListAsync();
            model.MonthlyAcountReportsViewModel = monthlyClosingReport.Union(meezanBankMonthlyIncomeExpenseReports).OrderBy(x => x.Date);
            model.AccountsYearlyReportTitlePage = _db.AccountsYearlyReportTitlePages.Where(q => q.DelAccountsYR != 0).ToList().GroupBy(elem => elem.YRDate).Select(group => group.First());

            return View(model);
        }
        //GET --AccountsMonthlyYearlyReports--ended----
        //POST --AccountsMonthlyYearlyReports--start----
        //POST --AccountsMonthlyYearlyReports--ended----

        public async Task<IActionResult> SendMonthlyClosingReportToDgmOffice(int id)
        {
            var report = await _db.MonthlyClosingReports.FindAsync(id);
            if (report == null)
            {
                return RedirectToAction("AccountsMonthlyYearlyReports");
            }

            try
            {
                report.Status = "1";
                _db.Entry(report).State = EntityState.Modified;
                await _db.SaveChangesAsync();
                _notyf.Success("Report successfully sent to D.G.M office");
                return RedirectToAction("AccountsMonthlyYearlyReports");
            }
            catch (DbUpdateException /* ex */)
            {
                return RedirectToAction("AccountsMonthlyYearlyReports");
            }
            
        }
        public async Task<IActionResult> SendMeezanBankIncomeExpenseReportToDgmOffice(int id)
        {
            var report = await _db.MeezanBankMonthlyIncomeExpenseReports.FindAsync(id);
            if (report == null)
            {
                return RedirectToAction("AccountsMonthlyYearlyReports");
            }

            try
            {
                report.Status = "1";
                _db.Entry(report).State = EntityState.Modified;
                await _db.SaveChangesAsync();
                _notyf.Success("Report successfully sent to D.G.M office");
                return RedirectToAction("AccountsMonthlyYearlyReports");
            }
            catch (DbUpdateException /* ex */)
            {
                return RedirectToAction("AccountsMonthlyYearlyReports");
            }
        }

    }
}
