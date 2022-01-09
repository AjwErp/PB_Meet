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

namespace AJWManagementPortal.Areas.Dgm.Controllers
{
    //This Controller control & Refer to ::All Department Reports List for DGM Office:: 

    [Area("Dgm")]
    public class DgmAllDepartmentReportsController : Controller
    {

        //GET--Start------AccountsDepartmentReportsList----
        //This Method use for Account Office Reports daily/Monthly/Yearly Reporsitory List for DGM office 
        private readonly ApplicationDbContext _db;
        private readonly INotyfService _notyf;
        private string meezanBankIncomeExportReportFileUploadFolder = "Reports/MezaanBankIncomeExportReport/";


        public DgmAllDepartmentReportsController(ApplicationDbContext db, INotyfService notyf)
        {
            _db = db;
            _notyf = notyf;
        }
        public async Task<IActionResult> DgmAccountsDepartmentReportsList()
        {
            var model = new DgmAccountsDepartmentReportsListViewModel();
            var monthlyClosingReport = await(from a in _db.MonthlyClosingReports
                                             where (a.DelProduction != 0 && (Convert.ToInt32(a.Status) == 1))
                                             select new MonthlyAcountReportsViewModel
                                             {
                                                 Id = a.Id,
                                                 Date = a.ValueDate,
                                                 IsMonthlyClosingReportDgm = true,
                                                 Title = "Monthly Accounts Report"
                                             }).ToListAsync();
            var meezanBankMonthlyIncomeExpenseReports = await(from a in _db.MeezanBankMonthlyIncomeExpenseReports
                                                              where (a.DelProduction != 0 && (Convert.ToInt32(a.Status) == 1))
                                                              select new MonthlyAcountReportsViewModel
                                                              {
                                                                  Id = a.Id,
                                                                  Date = a.ValueDate,
                                                                  IsMeezanBankIncomeExpenseReportDgm = true,
                                                                  Title = "Meezan Bank Monthly Income/Expence Report"
                                                              }).ToListAsync();
            model.MonthlyAcountReportsViewModel = monthlyClosingReport.Union(meezanBankMonthlyIncomeExpenseReports).OrderBy(x => x.Date);
            model.aDailyCash = _db.aDailyCashes.Where(i => (Convert.ToInt32(i.Status) == 1 && i.DelProduction != 0)).ToList();
            return View(model);

            //var model = new DgmAccountsDepartmentReportsListViewModel();
            //model.MonthlyClosingReport = _db.MonthlyClosingReports.Where(i => (Convert.ToInt32(i.Status) == 1 && i.DelProduction != 0)).ToList();
            //model.aDailyCash = _db.aDailyCashes.Where(i => (Convert.ToInt32(i.Status) == 1 && i.DelProduction != 0)).ToList();
        }
        //GET--Ended------AccountsDepartmentReportsList----
        //POST--Start------AccountsDepartmentReportsList----
        //POST--Ended------AccountsDepartmentReportsList----

        //GET--Start------AccountsDepartmentReportsList----
        //This Method use for Account Office Reports daily/Monthly/Yearly Error List for DGM office 
        public IActionResult DgmAccountsDepartmentReportsListE()
        {
            return View();
        }
        //GET--Ended------AccountsDepartmentReportsList----
        //POST--Start------AccountsDepartmentReportsList----
        //POST--Ended------AccountsDepartmentReportsList----
        public async Task<IActionResult> SendMonthlyClosingReportToGmOffice(int id)
        {

            var report = await _db.MonthlyClosingReports.FindAsync(id);
            if (report == null)
            {
                return RedirectToAction("DgmAccountsDepartmentReportsList");
            }

            try
            {
                report.Status = "3";
                _db.Entry(report).State = EntityState.Modified;
                await _db.SaveChangesAsync();
                _notyf.Success("Report successfully sent to G.M office");
                return RedirectToAction("DgmAccountsDepartmentReportsList");
            }
            catch (DbUpdateException /* ex */)
            {
                return RedirectToAction("DgmAccountsDepartmentReportsList");
            }
       
        }
        public async Task<IActionResult> SendMeezanBankIncomeExpenseReportToAccountErrorList(int id)
        {
            var report = await _db.MeezanBankMonthlyIncomeExpenseReports.FindAsync(id);
            if (report == null)
            {
                return RedirectToAction("DgmAccountsDepartmentReportsList");
            }

            try
            {
                report.Status = "5";
                _db.Entry(report).State = EntityState.Modified;
                await _db.SaveChangesAsync();
                _notyf.Success("Report successfully sent to Account error list");
                return RedirectToAction("DgmAccountsDepartmentReportsList");
            }
            catch (DbUpdateException /* ex */)
            {
                return RedirectToAction("DgmAccountsDepartmentReportsList");
            }
        }
        public async Task<IActionResult> SendMonthlyClosingReportToAccountErrorList(int id)
        {
            var report = await _db.MonthlyClosingReports.FindAsync(id);
            if (report == null)
            {
                return RedirectToAction("DgmAccountsDepartmentReportsList");
            }

            try
            {
                report.Status = "5";
                _db.Entry(report).State = EntityState.Modified;
                await _db.SaveChangesAsync();
                _notyf.Success("Report successfully sent to Account error list");
                return RedirectToAction("DgmAccountsDepartmentReportsList");
            }
            catch (DbUpdateException /* ex */)
            {
                return RedirectToAction("DgmAccountsDepartmentReportsList");
            }
           

        }

        #region MONTHLY CLOSING REPORT
        public IActionResult EditMonthlyClosingReport(int id, bool IsEdit)
        {
            //var model = new MonthlyClosingReport
            //{
            //    ValueDate = System.Convert.ToDateTime(DateTime.Now.ToString("MM-dd-yyyy"))
            //};
            var model = _db.MonthlyClosingReports.Where(x => x.Id == id).Select(c => new MonthlyClosingReport()
            {
                ValueDate = Convert.ToDateTime(c.ValueDate.ToString("MM-dd-yyyy")),
                SignAManager = c.SignAManager,
                AManagerRemarks = c.AManagerRemarks,
                DelProduction = c.DelProduction,
                SignDgm = c.SignDgm,
                DgmRemarks = c.DgmRemarks,
                Month = c.Month,
                Year = c.Year,
                Status = c.Status
            }).FirstOrDefault();
            ViewBag.EditStatus = IsEdit;
            //model.ValueDate= System.Convert.ToDateTime(model.ValueDate.ToShortDateString());
            return View(model);
        }
        [HttpPost]
        public ActionResult EditMonthlyClosingReport(MonthlyClosingReport model)
        {
            if (!ModelState.IsValid)
                return View(model);
            _db.Entry(model).State = EntityState.Modified;
            _db.SaveChanges();
            _notyf.Success("Edited successfully");

            return RedirectToAction("DgmAccountsDepartmentReportsList");
        }

        public async Task<IActionResult> DeleteMonthlyClosingReport(int id)
        {

            var report = await _db.MonthlyClosingReports.FindAsync(id);
            if (report == null)
            {
                return RedirectToAction("DgmAccountsDepartmentReportsList");
            }

            try
            {
                report.DelProduction = 0;
                _db.Entry(report).State = EntityState.Modified;
                await _db.SaveChangesAsync();
                _notyf.Success("Deleted successfully");
                return RedirectToAction("DgmAccountsDepartmentReportsList");
            }
            catch (DbUpdateException /* ex */)
            {
                return RedirectToAction("DgmAccountsDepartmentReportsList");
            }
        }
        #endregion


        #region MEEZAN BANK INCOME/EXPENCE REPORT
        public IActionResult EditMeezanBankIncomeExpenseReport(int id, bool IsEdit)
        {
            var model = _db.MeezanBankMonthlyIncomeExpenseReports.Where(x => x.Id == id).FirstOrDefault();
            if (model != null)
            {
                model.Images = _db.MeezanBankMonthlyIncomeExpenseReportImages.Where(x => x.MeezanBankMonthlyIncomeExpenseReportId == model.Id).
                    Select(x => x.Filepath).ToList();
            }
            ViewBag.EditStatus = IsEdit;
            return View(model);
        }
        [HttpPost]
        public ActionResult EditMeezanBankIncomeExpenseReport(MeezanBankMonthlyIncomeExpenseReport model)
        {
            if (!ModelState.IsValid)
                return View(model);
            _db.Entry(model).State = EntityState.Modified;
            _db.SaveChanges();
            _notyf.Success("Edited successfully");

            return RedirectToAction("DgmAccountsDepartmentReportsList");
        }
        public async Task<IActionResult> DeleteMeezanBankIncomeExpenseReport(int id)
        {

            var report = await _db.MeezanBankMonthlyIncomeExpenseReports.FindAsync(id);
            if (report == null)
            {
                return RedirectToAction("DgmAccountsDepartmentReportsList");
            }

            try
            {
                report.DelProduction = 0;
                _db.Entry(report).State = EntityState.Modified;
                await _db.SaveChangesAsync();
                _notyf.Success("Deleted successfully");
                return RedirectToAction("DgmAccountsDepartmentReportsList");
            }
            catch (DbUpdateException /* ex */)
            {
                return RedirectToAction("DgmAccountsDepartmentReportsList");
            }
        }
        public async Task<IActionResult> SendMeezanBankIncomeExpenseReportToGmOffice(int id)
        {
            var report = await _db.MeezanBankMonthlyIncomeExpenseReports.FindAsync(id);
            if (report == null)
            {
                return RedirectToAction("DgmAccountsDepartmentReportsList");
            }

            try
            {
                report.Status = "3";
                _db.Entry(report).State = EntityState.Modified;
                await _db.SaveChangesAsync();
                _notyf.Success("Report successfully sent to G.M office");
                return RedirectToAction("DgmAccountsDepartmentReportsList");
            }
            catch (DbUpdateException /* ex */)
            {
                return RedirectToAction("DgmAccountsDepartmentReportsList");
            }
        }
        #endregion

    }

}
