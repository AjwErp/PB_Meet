using AJWManagementPortal.Data;
using AJWManagementPortal.Models;
using AJWManagementPortal.Utility;
using AJWManagementPortal.ViewModels;
using AspNetCoreHero.ToastNotification.Abstractions;
using DinkToPdf;
using DinkToPdf.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Account.Controllers
{
    //This Controller for ::All reports of account repository::
    [Area("Account")]
    public class RepositoryController : Controller
    {
        private IConverter _converter;
        private readonly ApplicationDbContext _db;
        private readonly INotyfService _notyf;

        //private readonly IWebHostEnvironment _iwebhost;
        //IWebHostEnvironment iwebhost
        //                _iwebhost = iwebhost;

        public RepositoryController(ApplicationDbContext db, IConverter converter, INotyfService notyf)
        {
            _db = db;
            _converter = converter;
            _notyf = notyf;


        }
        //GET---DailyMonthlyYearlyAuditAccountsReportsListRepository--Start--
        public async Task<IActionResult> DailyMonthlyYearlyAuditAccountsReportsListRepository()
        {
            DailyMeezan model = new DailyMeezan();

            IEnumerable<aDailyCash> dailycash = _db.aDailyCashes.Where(i => i.DelProduction != 0 && Convert.ToInt32(i.Status) == 4).ToList().GroupBy(elem => elem.ValueDate).Select(group => group.First());
            IEnumerable<MeezanBankIEVoucher> a1 = _db.MeezanBankIEVouchers.Where(i => i.DelProduction != 0 && Convert.ToInt32(i.Status) == 4).ToList().GroupBy(elem => elem.dateTime).Select(group => group.First());
            IEnumerable<MeezanBankIEReport> a2 = _db.MeezanBankIEReports.Where(i => i.DelProduction != 0 && Convert.ToInt32(i.Status) == 4).ToList().GroupBy(elem => elem.ValueDate).Select(group => group.First());
            IEnumerable<DailySuppliersCashTransactionReport> a3 = _db.dailySuppliers.Where(i => i.DelProduction != 0 && Convert.ToInt32(i.Status) == 4).ToList().GroupBy(elem => elem.ValueDate).Select(group => group.First());
            IEnumerable<MonthlyClosingReport> a4 = _db.MonthlyClosingReports.Where(i => i.DelProduction != 0 && Convert.ToInt32(i.Status) == 4).ToList().GroupBy(elem => elem.ValueDate).Select(group => group.First());
            var monthlyClosingReport = await (from a in _db.MonthlyClosingReports
                                              where (a.DelProduction != 0 && (Convert.ToInt32(a.Status) == 4))
                                              select new MonthlyAcountReportsViewModel
                                              {
                                                  Id = a.Id,
                                                  Date = a.ValueDate,
                                                  IsMonthlyClosingReportAccounts = true,
                                                  Title = "Monthly Accounts Report"
                                              }).ToListAsync();
            var meezanBankMonthlyIncomeExpenseReports = await (from a in _db.MeezanBankMonthlyIncomeExpenseReports
                                                               where (a.DelProduction != 0 && (Convert.ToInt32(a.Status) == 4))
                                                               select new MonthlyAcountReportsViewModel
                                                               {
                                                                   Id = a.Id,
                                                                   Date = a.ValueDate,
                                                                   IsMeezanBankIncomeExpenseReportAccounts = true,
                                                                   Title = "Meezan Bank Monthly Income/Expence Report"
                                                               }).ToListAsync();
            model.MonthlyAcountReportsViewModel = monthlyClosingReport.Union(meezanBankMonthlyIncomeExpenseReports).OrderBy(x => x.Date);
            model.aDailyCashes = dailycash;
            model.BankVo = a1;
            model.Bank = a2;
            model.dSuppliers = a3;
            return View(model);
        }
        //GET---DailyMonthlyYearlyAuditAccountsReportsListRepository--ended--
        //POST---DailyMonthlyYearlyAuditAccountsReportsListRepository--Start--
        //POST---DailyMonthlyYearlyAuditAccountsReportsListRepository--ended--
        public async Task<IActionResult> DeleteMeezanVSheet(String remarks)
        {
            remarks = remarks.Replace("-", "/");
            //_db.TechnicalStaffWorkPlans.RemoveRange(_db.TechnicalStaffWorkPlans.ToList().Where(x => x.Remarks.Equals(remarks)));
            //_db.SaveChanges();
            //return View("AjwTechnicalStaffWorkPlanList", _db.TechnicalStaffWorkPlans.ToList());
            List<MeezanBankIEVoucher> data = new List<MeezanBankIEVoucher>();
            DateTime dateTime10 = DateTime.Parse(remarks);
            data = _db.MeezanBankIEVouchers.Where(i => i.dateTime.Equals(dateTime10)).ToList();

            foreach (MeezanBankIEVoucher technical in data)
            {
                technical.DelGm = 0;
                var current = _db.MeezanBankIEVouchers.Find(technical.Id);
                if (current != null)
                {
                    _db.Entry(current).CurrentValues.SetValues(technical);
                }

                _db.SaveChanges();
            }
            return RedirectToAction("BankCheckApprovelVoucherList");
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
            return RedirectToAction("DailyMonthlyYearlyAuditAccountsReportsListRepository");
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
            return RedirectToAction("DailyMonthlyYearlyAuditAccountsReportsListRepository");
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
            return RedirectToAction("DailyMonthlyYearlyAuditAccountsReportsListRepository");
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

        //[HttpGet]
        //public IActionResult DailyMeezanBankVoucherReport(String id)
        //{
        //    DateTime today = DateTime.Today;

        //    if (id == null)
        //    {
        //        id = today.ToString("yyyy-MM-dd");
        //        //return NotFound();
        //    }
        //    id = id.Replace("-", "/");
        //    DateTime dateTime10 = DateTime.Parse(id);

        //    ViewBag.Data = _db.MeezanBankIEReports.
        //        Where(z => z.ValueDate <= dateTime10)
        //        .ToList();

        //    ViewBag.Data1 = _db.MeezanBankIEVouchers.Where(z => z.dateTime <= dateTime10 && z.DelGm != 0).ToList();
        //    ViewBag.hide = false;

        //    return View("BankCheckApprovelVoucher");


        //}


        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DailyMeezanBankVoucherReport(MeezanBankIEVoucher meezan, string id)
        //{
        //    DateTime today = DateTime.Today;

        //    if (id == null)
        //    {
        //        id = today.ToString("yyyy-MM-dd");
        //        //return NotFound();
        //    }
        //    id = id.Replace("-", "/");
        //    DateTime dateTime10 = DateTime.Parse(id);

        //    meezan.Title = "";
        //    meezan.Status = "5";
        //    meezan.DelProduction = 1;
        //    meezan.DelCeo = 1;
        //    meezan.DelGm = 1;
        //    meezan.Remarks = "";
        //    _db.Add(meezan);
        //    await _db.SaveChangesAsync();
        //    //return RedirectToAction(nameof(DailyMeezanBankVoucherReport));



        //    ViewBag.Data = _db.MeezanBankIEReports.
        //        Where(z => z.ValueDate <= dateTime10)
        //        .ToList();

        //    ViewBag.Data1 = _db.MeezanBankIEVouchers.Where(z => z.dateTime <= dateTime10 && z.Status == "3").ToList();
        //    ViewBag.hide = false;
        //    return View("BankCheckApprovelVoucher", meezan);
        //}
        ////Repository for Daily cash continues report list
        //public IActionResult DailyReportRepository()
        //{
        //    return View();
        //}
        ////Repository for Daily cash continues report list
        ////Monthly Accounts report repository
        //public IActionResult MonthlyReportRepository()
        //{
        //    return View();
        //}
        ////Monthly Accounts report repository
        ////Yearly report Repository List
        //public IActionResult YearlyReportRepository()
        //{
        //    return View();
        //}
        ////Yearly report Repository List

        ////Yearly report Repository List
        //public IActionResult AccountsAuditReportsRepository()
        //{
        //    return View();
        //}
        ////Yearly report Repository List
        ///
        //--------------------------
        //-----This Method Refer to the PDF File Download from ::Production Repository pannel::
        [HttpGet]
        public IActionResult CreatePDF()
        {
            var globalSettings = new GlobalSettings
            {
                ColorMode = ColorMode.Color,
                Orientation = Orientation.Portrait,
                PaperSize = PaperKind.A4,
                Margins = new MarginSettings { Top = 10 },
                DocumentTitle = "PDF Report",
                Out = @"C:\PDFCreator\Employee_Report.pdf"
            };
            var objectSettings = new ObjectSettings
            {
                PagesCount = true,
                HtmlContent = TemplateGenerator.GetHTMLString(),
                WebSettings = { DefaultEncoding = "utf-8", UserStyleSheet = Path.Combine(Directory.GetCurrentDirectory(), "assets", "styles.css") },
                HeaderSettings = { FontName = "Arial", FontSize = 9, Right = "Page [page] of [toPage]", Line = true },
                FooterSettings = { FontName = "Arial", FontSize = 9, Line = true, Center = "Report Footer" }
            };
            var pdf = new HtmlToPdfDocument()
            {
                GlobalSettings = globalSettings,
                Objects = { objectSettings }
            };
            _converter.Convert(pdf);
            return Ok("Successfully created PDF document.");
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

        public async Task<IActionResult> DeleteMonthlyClosingReportAccountOffice(int id)
        {

            var report = await _db.MonthlyClosingReports.FindAsync(id);
            if (report == null)
            {
                return RedirectToAction("DailyMonthlyYearlyAuditAccountsReportsListRepository");
            }

            try
            {
                report.DelProduction = 0;
                _db.Entry(report).State = EntityState.Modified;
                await _db.SaveChangesAsync();
                _notyf.Success("Deleted successfully");
                return RedirectToAction("DailyMonthlyYearlyAuditAccountsReportsListRepository");
            }
            catch (DbUpdateException /* ex */)
            {
                return RedirectToAction("DailyMonthlyYearlyAuditAccountsReportsListRepository");
            }
        }
        public async Task<IActionResult> DeleteMeezanBankIncomeExpenseReport(int id)
        {

            var report = await _db.MeezanBankMonthlyIncomeExpenseReports.FindAsync(id);
            if (report == null)
            {
                return RedirectToAction("DailyMonthlyYearlyAuditAccountsReportsListRepository");
            }

            try
            {
                report.DelProduction = 0;
                _db.Entry(report).State = EntityState.Modified;
                await _db.SaveChangesAsync();
                _notyf.Success("Deleted successfully");
                return RedirectToAction("DailyMonthlyYearlyAuditAccountsReportsListRepository");
            }
            catch (DbUpdateException /* ex */)
            {
                return RedirectToAction("DailyMonthlyYearlyAuditAccountsReportsListRepository");
            }
        }



        //----------------
    }
}