using AJWManagementPortal.Data;
using AJWManagementPortal.Models;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using System.Web;
using Microsoft.EntityFrameworkCore;
using AspNetCoreHero.ToastNotification.Abstractions;
using AJWManagementPortal.ViewModels;

namespace AJWManagementPortal.Areas.Account.Controllers
{
    [Area("Account")]
    public class ErrorReportsController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly INotyfService _notyf;

        public ErrorReportsController(ApplicationDbContext db, INotyfService notyf)
        {
            _db = db;
            _notyf = notyf;


        }
        public async Task<IActionResult> AccountsErrorReportsList()
        {
            DailyMeezan model = new DailyMeezan();

            IEnumerable<aDailyCash> dailycash = _db.aDailyCashes.Where(i => i.DelProduction != 0 && Convert.ToInt32(i.Status) == 5).ToList().GroupBy(elem => elem.ValueDate).Select(group => group.First());
            IEnumerable<MeezanBankIEVoucher> a1 = _db.MeezanBankIEVouchers.Where(i => i.DelProduction != 0 && Convert.ToInt32(i.Status) == 4).ToList().GroupBy(elem => elem.dateTime).Select(group => group.First());

            IEnumerable<MeezanBankIEReport> a2 = _db.MeezanBankIEReports.Where(i => i.DelProduction != 0 && Convert.ToInt32(i.Status) == 5).ToList().GroupBy(elem => elem.ValueDate).Select(group => group.First());
            IEnumerable<DailySuppliersCashTransactionReport> a3 = _db.dailySuppliers.Where(i => i.DelProduction != 0 && Convert.ToInt32(i.Status) == 5).ToList().GroupBy(elem => elem.ValueDate).Select(group => group.First());
            IEnumerable<MonthlyClosingReport> monthlyClosingReports = _db.MonthlyClosingReports.Where(i => i.DelProduction != 0 && Convert.ToInt32(i.Status) == 5).ToList();
            var monthlyClosingReport = await (from a in _db.MonthlyClosingReports
                                              where (a.DelProduction != 0 && (Convert.ToInt32(a.Status) == 5))
                                              select new MonthlyAcountReportsViewModel
                                              {
                                                  Id = a.Id,
                                                  Date = a.ValueDate,
                                                  IsMonthlyClosingReportAccountsError = true,
                                                  Title = "Monthly Accounts Report"
                                              }).ToListAsync();
            var meezanBankMonthlyIncomeExpenseReports = await (from a in _db.MeezanBankMonthlyIncomeExpenseReports
                                                               where (a.DelProduction != 0 && (Convert.ToInt32(a.Status) == 5))
                                                               select new MonthlyAcountReportsViewModel
                                                               {
                                                                   Id = a.Id,
                                                                   Date = a.ValueDate,
                                                                   IsMeezanBankIncomeExpenseReportAccountsError = true,
                                                                   Title = "Meezan Bank Monthly Income/Expence Report"
                                                               }).ToListAsync();
            model.MonthlyAcountReportsViewModel = monthlyClosingReport.Union(meezanBankMonthlyIncomeExpenseReports).OrderBy(x => x.Date);
            model.aDailyCashes = dailycash;
            model.BankVo = a1;

            model.Bank = a2;
            model.dSuppliers = a3;
            return View(model);
        }

        public async Task<IActionResult> DeleteSheet(String remarks)
        {
            remarks = remarks.Replace("-", "/");
            //_db.TechnicalStaffWorkPlans.RemoveRange(_db.TechnicalStaffWorkPlans.ToList().Where(x => x.Remarks.Equals(remarks)));
            //_db.SaveChanges();
            //return View("AjwTechnicalStaffWorkPlanList", _db.TechnicalStaffWorkPlans.ToList());
            List<aDailyCash> data = new List<aDailyCash>();
            DateTime dateTime10 = DateTime.Parse(remarks);
            data = _db.aDailyCashes.Where(i => i.ValueDate.Equals(dateTime10)).ToList();

            foreach (aDailyCash technical in data)
            {
                technical.Status = "1";
                var current = _db.aDailyCashes.Find(technical.Id);
                if (current != null)
                {
                    _db.Entry(current).CurrentValues.SetValues(technical);
                }

                _db.SaveChanges();
            }
            return RedirectToAction("AccountsErrorReportsList");
        }

        public async Task<IActionResult> DeleteMeezanSheet(String remarks)
        {
            remarks = remarks.Replace("-", "/");
            //_db.TechnicalStaffWorkPlans.RemoveRange(_db.TechnicalStaffWorkPlans.ToList().Where(x => x.Remarks.Equals(remarks)));
            //_db.SaveChanges();
            //return View("AjwTechnicalStaffWorkPlanList", _db.TechnicalStaffWorkPlans.ToList());
            List<MeezanBankIEReport> data = new List<MeezanBankIEReport>();
            DateTime dateTime10 = DateTime.Parse(remarks);
            data = _db.MeezanBankIEReports.Where(i => i.ValueDate.Equals(dateTime10)).ToList();

            foreach (MeezanBankIEReport technical in data)
            {
                technical.Status = "1";
                var current = _db.aDailyCashes.Find(technical.Id);
                if (current != null)
                {
                    _db.Entry(current).CurrentValues.SetValues(technical);
                }

                _db.SaveChanges();
            }
            return RedirectToAction("AccountsErrorReportsList");
        }



        public async Task<IActionResult> DeleteSupplierSheet(String remarks)
        {
            remarks = remarks.Replace("-", "/");
            //_db.TechnicalStaffWorkPlans.RemoveRange(_db.TechnicalStaffWorkPlans.ToList().Where(x => x.Remarks.Equals(remarks)));
            //_db.SaveChanges();
            //return View("AjwTechnicalStaffWorkPlanList", _db.TechnicalStaffWorkPlans.ToList());
            List<DailySuppliersCashTransactionReport> data = new List<DailySuppliersCashTransactionReport>();
            DateTime dateTime10 = DateTime.Parse(remarks);
            data = _db.dailySuppliers.Where(i => i.ValueDate.Equals(dateTime10)).ToList();

            foreach (DailySuppliersCashTransactionReport technical in data)
            {
                technical.Status = "1";
                var current = _db.dailySuppliers.Find(technical.Id);
                if (current != null)
                {
                    _db.Entry(current).CurrentValues.SetValues(technical);
                }

                _db.SaveChanges();
            }
            return RedirectToAction("AccountsErrorReportsList");
        }
        //public async Task<IActionResult> SendMonthlyClosingReportToDgmOffice(int id)
        //{
        //    var report = await _db.MonthlyClosingReports.FindAsync(id);
        //    if (report == null)
        //    {
        //        return RedirectToAction("AccountsErrorReportsList");
        //    }

        //    try
        //    {
        //        report.Status = "1";
        //        _db.Entry(report).State = EntityState.Modified;
        //        await _db.SaveChangesAsync();
        //        _notyf.Success("Report successfully sent to D.G.M office");
        //        return RedirectToAction("AccountsErrorReportsList");
        //    }
        //    catch (DbUpdateException /* ex */)
        //    {
        //        return RedirectToAction("AccountsErrorReportsList");
        //    }

        //}
        public async Task<IActionResult> SendMeezanBankIncomeExpenseReportToAccountErrorList(int id)
        {
            var report = await _db.MeezanBankMonthlyIncomeExpenseReports.FindAsync(id);
            if (report == null)
            {
                return RedirectToAction("AccountsErrorReportsList");
            }

            try
            {
                report.Status = "1";
                _db.Entry(report).State = EntityState.Modified;
                await _db.SaveChangesAsync();
                _notyf.Success("Report successfully sent to D.G.M office");
                return RedirectToAction("AccountsErrorReportsList");
            }
            catch (DbUpdateException /* ex */)
            {
                return RedirectToAction("AccountsErrorReportsList");
            }
        }




     
        private DataTable GetReportDetail(int Month, int Year)
        {
            var reportExist = _db.MonthlyClosingReports.Where(x => x.Month == Month && x.Year == Year).ToList();


            DataTable dtReport = new DataTable("MonthlyClosingReports");
            dtReport.Columns.AddRange(new DataColumn[2] { new DataColumn("SignAManager"),
                new DataColumn("AManagerRemarks")
            });

            foreach (var reportObj in reportExist)
            {
                dtReport.Rows.Add(reportObj.SignAManager, reportObj.AManagerRemarks);
            }

            return dtReport;
        }
        public IActionResult EditMonthlyClosingReport(int id, bool IsEdit)
        {

            var model = _db.MonthlyClosingReports.Where(x => x.Id == id).FirstOrDefault();
            ViewBag.EditStatus = IsEdit;
            return View(model);
        }
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
        public async Task<IActionResult> DeleteMonthlyClosingReportAccountErrorList(int id)
        {

            var report = await _db.MonthlyClosingReports.FindAsync(id);
            if (report == null)
            {
                return RedirectToAction("AccountsErrorReportsList");
            }

            try
            {
                report.DelProduction = 0;
                _db.Entry(report).State = EntityState.Modified;
                await _db.SaveChangesAsync();
                _notyf.Success("Deleted successfully");
                return RedirectToAction("AccountsErrorReportsList");
            }
            catch (DbUpdateException /* ex */)
            {
                return RedirectToAction("AccountsErrorReportsList");
            }
        }
        public async Task<IActionResult> DeleteMeezanBankIncomeExpenseReport(int id)
        {

            var report = await _db.MeezanBankMonthlyIncomeExpenseReports.FindAsync(id);
            if (report == null)
            {
                return RedirectToAction("AccountsErrorReportsList");
            }

            try
            {
                report.DelProduction = 0;
                _db.Entry(report).State = EntityState.Modified;
                await _db.SaveChangesAsync();
                _notyf.Success("Deleted successfully");
                return RedirectToAction("AccountsErrorReportsList");
            }
            catch (DbUpdateException /* ex */)
            {
                return RedirectToAction("AccountsErrorReportsList");
            }
        }

        //---------------------------------
        public IActionResult DailyMeezanBankVoucherReport()
        {
            return View();
        }
        // GET: aDailyCashes/Create
        [HttpGet]
        public IActionResult DailyMeezanBankVoucherReport(String id)
        {
            DateTime today = DateTime.Today;

            if (id == null)
            {
                id = today.ToString("yyyy-MM-dd");
                //return NotFound();
            }
            id = id.Replace("-", "/");
            DateTime dateTime10 = DateTime.Parse(id);

            ViewBag.Data = _db.MeezanBankIEReports.
                Where(z => z.ValueDate <= dateTime10)
                .ToList();

            ViewBag.Data1 = _db.MeezanBankIEVouchers.Where(z => z.dateTime <= dateTime10 && z.Status == "4").ToList();
            ViewBag.hide = false;

            return View();


        }

        // POST: aDailyCashes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DailyMeezanBankVoucherReport(MeezanBankIEVoucher meezan, string id)
        {
            DateTime today = DateTime.Today;

            if (id == null)
            {
                id = today.ToString("yyyy-MM-dd");
                //return NotFound();
            }
            id = id.Replace("-", "/");
            DateTime dateTime10 = DateTime.Parse(id);

            meezan.Title = "";
            meezan.Status = "4";
            meezan.DelProduction = 1;
            meezan.DelCeo = 1;
            meezan.Remarks = "";
            _db.Add(meezan);
            await _db.SaveChangesAsync();
            //return RedirectToAction(nameof(DailyMeezanBankVoucherReport));



            ViewBag.Data = _db.MeezanBankIEReports.
                Where(z => z.ValueDate <= dateTime10)
                .ToList();

            ViewBag.Data1 = _db.MeezanBankIEVouchers.Where(z => z.dateTime <= dateTime10 && z.Status == "4").ToList();
            ViewBag.hide = false;
            return View(meezan);
        }

        //---------------------------------

    }

}