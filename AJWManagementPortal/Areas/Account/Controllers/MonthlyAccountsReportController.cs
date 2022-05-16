using AJWManagementPortal.Data;
using AJWManagementPortal.Extensions.IRepository;
using AJWManagementPortal.Helpers;
using AJWManagementPortal.Models;
using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
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
        private readonly IHostingEnvironment _env;
        private readonly IMonthlyIncomeExpenseInternalAccountReportRepository _monthlyIncomeExpenseInternalAccountReportRepository;
        private readonly ITrialBalanceAccountOfficeRepository _trialBalanceAccountOfficeRepository;

        private string meezanBankIncomeExportReportFileUploadFolder = "Reports/MezaanBankIncomeExportReport/";

        //This is referance for ApplicationDB || NotifyAlertService || HostingEnvironment 
        public MonthlyAccountsReportController(ApplicationDbContext db, INotyfService notyf, IHostingEnvironment env, IMonthlyIncomeExpenseInternalAccountReportRepository monthlyIncomeExpenseInternalAccountReportRepository, ITrialBalanceAccountOfficeRepository trialBalanceAccountOfficeRepository)
        {
            this._db = db;
            this._monthlyIncomeExpenseInternalAccountReportRepository = monthlyIncomeExpenseInternalAccountReportRepository;
            this._trialBalanceAccountOfficeRepository = trialBalanceAccountOfficeRepository;
            this._notyf = notyf;
            this._env = env;
        }

        //GET --Title Page---for MonthlyClosingReportTitlePage--start---1---
        public IActionResult MonthlyClosingReportTitlePage()
        {
            return View();
        }
        //GET --Title Page---for MonthlyClosingReportTitlePage--ended
        //POST --Title Page--for MonthlyClosingReportTitlePage--start
        //GET ---Title Page--for MonthlyClosingReportTitlePage--ended

        //GET --02 Sheet |Monthly Closing Report Account Office|-
        //--for Monthly Meezan Bank Income/Expense Monthly Report--start---2-----
        public IActionResult MeezanBankIncomeExpenseMonthlyreport()
        {
            var model = new MeezanBankMonthlyIncomeExpenseReport
            {
                ValueDate = Convert.ToDateTime(DateTime.Now.ToString("MM-dd-yyyy"))
            };
            return View(model);
        }

        //GET --02 Sheet |Monthly Closing Report Account Office|-
        //-POST-For Meezan Bank Income/Expense Monthly report----2------
        [HttpPost]
        public IActionResult MeezanBankIncomeExpenseMonthlyreport(MeezanBankMonthlyIncomeExpenseReport model)
        {
            //--for Supporting Documents as a image file
            var uploadedFile = new List<string>();
            if (!string.IsNullOrEmpty(HttpContext.Session.GetString("UploadedFile")))
            {
                uploadedFile = JsonConvert.DeserializeObject<List<string>>(HttpContext.Session.GetString("UploadedFile"));
                model.Images = uploadedFile;
            }

            if (!ModelState.IsValid)
                return View(model);

            if (model.Images.Count > 20)
            {
                _notyf.Information("Images cannot be more than 20");
                return View(model);
            }
            //---same date report condition if or else
            var reportExist = _db.MeezanBankMonthlyIncomeExpenseReports.Where(x => x.Month == model.ValueDate.Month && x.Year == model.ValueDate.Year);
            if (reportExist.Any())
            {
                _notyf.Information("Report already exist for month of " + model.ValueDate.ToString("MMMM"));
                return View(model);
            }
            //3333
            model.DelProduction = 1;
            model.Month = model.ValueDate.Month;
            model.Year = model.ValueDate.Year;
            _db.MeezanBankMonthlyIncomeExpenseReports.Add(model);
            int result = _db.SaveChanges();
            if (result > 0)
            {
                if (uploadedFile.Count > 0)
                {
                    var images = new List<MeezanBankMonthlyIncomeExpenseReportImage>();
                    foreach (var item in uploadedFile)
                    {
                        var image = new MeezanBankMonthlyIncomeExpenseReportImage
                        {
                            MeezanBankMonthlyIncomeExpenseReportId = model.Id,
                            Filepath = item
                        };
                        images.Add(image);
                    }
                    _db.MeezanBankMonthlyIncomeExpenseReportImages.AddRange(images);
                    _db.SaveChanges();
                    HttpContext.Session.Remove("UploadedFile");
                }
            }
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

        //GET----5--for Monthly Income/Expence Internal Account--start----3-


        public IActionResult MonthlyIncomeExpenceInternalAccount()
        {
            return View();
        }

        public JsonResult InsertMonthlyIncomeExpenseAccountReport(MonthlyIncomeExpenceInternalAccountReport data)
        {
            bool result = false;
            int response = 0;

            result = _monthlyIncomeExpenseInternalAccountReportRepository.SaveMonthlyIncomeExpenseInternalAccount(data);

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

        public IActionResult EditMonthlyIncomeExpenceInternalAccountReport(int id, bool IsEdit)
        {
            var model = _db.MonthlyIncomeExpenceInternalAccountReport.Where(x => x.Id == id).FirstOrDefault();

            ViewBag.EditStatus = IsEdit;
            return View(model);
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
            List<TrialBalanceAccountOffice> trans = new List<TrialBalanceAccountOffice>();

            return View(trans);
        }

        public JsonResult InsertTrialBalanceAccountOffice(List<TrialBalanceAccountOffice> data)
        {
            bool result = false;
            int response = 0;
            int key = 0;
            List<TrialBalanceAccountOffice> trialBalanceAccountOffices = new List<TrialBalanceAccountOffice>();
            var trialBalance = _db.TrialBalanceAccountOffice.FirstOrDefault();

            if (trialBalance != null)
            {
                var keyValue = _db.TrialBalanceAccountOffice.Select(x => x.KeyValue).LastOrDefault();
                if (keyValue != null || keyValue != 0)
                {
                    key = 1;
                }
                else
                {
                    key = Convert.ToInt32(keyValue) + 1;
                }
            }
            else
            {
                key = 1;
            }

            foreach (var value in data)
            {
                TrialBalanceAccountOffice balanceAccountOffice = new TrialBalanceAccountOffice();

                balanceAccountOffice.SelectedDate = value.SelectedDate;
                balanceAccountOffice.KeyValue = key;
                balanceAccountOffice.Credit = value.Credit;
                balanceAccountOffice.Debit = value.Debit;
                balanceAccountOffice.Page = value.Page;
                balanceAccountOffice.Description = value.Description;
                balanceAccountOffice.AMSignature = value.AMSignature;
                balanceAccountOffice.AMRemark = value.AMRemark;
                balanceAccountOffice.DGMSignature = value.DGMSignature;
                balanceAccountOffice.DGMRemark = value.DGMRemark;
                balanceAccountOffice.GMSignature = value.GMSignature;
                balanceAccountOffice.GMRemark = value.GMRemark;
                balanceAccountOffice.CreatedDate = DateTime.Now;
                trialBalanceAccountOffices.Add(balanceAccountOffice);
            }

            result = _trialBalanceAccountOfficeRepository.SaveTrialBalanceAccountOffice(trialBalanceAccountOffices);

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

        public IActionResult EditTrialBalanceAccountOfficeReport(int id, bool IsEdit)
        {
            var model = _db.TrialBalanceAccountOffice.Where(x => x.KeyValue == id).ToList();

            ViewBag.EditStatus = IsEdit;
            return View(model);
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

        #region MONTHLY CLOSING REPORT
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
            //If Same Date Sheet Already Exist then Display Message for dont Create Same Date Sheet
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
            _notyf.Information("Report successfully added for month" + model.ValueDate.ToString("MMMM"));
            return RedirectToAction("AccountsMonthlyYearlyReports", "AccountsMonthlyYearly");
        }



        public IActionResult EditMonthlyClosingReport(int id, bool IsEdit)
        {
            var model = _db.MonthlyClosingReports.Where(x => x.Id == id).Select(c => new MonthlyClosingReport()
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
        public ActionResult EditMonthlyClosingReport(MonthlyClosingReport model)
        {
            if (!ModelState.IsValid)
                return View(model);
            _db.Entry(model).State = EntityState.Modified;
            _db.SaveChanges();
            _notyf.Success("Edited successfully");

            return RedirectToAction("AccountsMonthlyYearlyReports", "AccountsMonthlyYearly");
        }

        public async Task<IActionResult> DeleteMonthlyClosingReport(int id)
        {

            var report = await _db.MonthlyClosingReports.FindAsync(id);
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
                return RedirectToAction("EditMeezanBankIncomeExpenseReport", new { id = model.Id, IsEdit = true });

            var reportExist = _db.MeezanBankMonthlyIncomeExpenseReports.Where(x => x.Month == model.ValueDate.Month && x.Year == model.ValueDate.Year).AsNoTracking().FirstOrDefault();
            if (reportExist != null && reportExist.Id != model.Id)
            {
                _notyf.Information("Report already exist for month of " + model.ValueDate.ToString("MMMM"));
                return RedirectToAction("EditMeezanBankIncomeExpenseReport", new { id = model.Id, IsEdit = true });
            }

            _db.Entry(model).State = EntityState.Modified;
            int result = _db.SaveChanges();
            if (result > 0)
            {
                var uploadedFile = new List<string>();
                if (!string.IsNullOrEmpty(HttpContext.Session.GetString("UploadedFile")))
                {
                    uploadedFile = JsonConvert.DeserializeObject<List<string>>(HttpContext.Session.GetString("UploadedFile"));
                }
                if (uploadedFile.Count > 0)
                {
                    var images = new List<MeezanBankMonthlyIncomeExpenseReportImage>();
                    foreach (var item in uploadedFile)
                    {
                        var image = new MeezanBankMonthlyIncomeExpenseReportImage
                        {
                            MeezanBankMonthlyIncomeExpenseReportId = model.Id,
                            Filepath = item
                        };
                        images.Add(image);
                    }
                    _db.MeezanBankMonthlyIncomeExpenseReportImages.AddRange(images);
                    _db.SaveChanges();
                    HttpContext.Session.Remove("UploadedFile");
                }
            }
            _notyf.Success("Edited successfully");

            return RedirectToAction("AccountsMonthlyYearlyReports", "AccountsMonthlyYearly");
        }
        public async Task<IActionResult> DeleteMeezanBankIncomeExpenseReport(int id)
        {

            var report = await _db.MeezanBankMonthlyIncomeExpenseReports.FindAsync(id);
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

        [HttpPost]
        public async Task<ActionResult> UploadFiles(List<IFormFile> files)
        {
            var functional = new Functional();
            var fileUploaded = await functional.UploadMultipleFile(files, _env, meezanBankIncomeExportReportFileUploadFolder);
            if (fileUploaded.Count > 0)
            {
                //TempData["UploadedFile"] = fileUploaded;
                //TempData.Peek("UploadedFile");
                HttpContext.Session.SetString("UploadedFile", JsonConvert.SerializeObject(fileUploaded));
            }
            var a = 0;
            return Json(new { images = fileUploaded });
        }

        #endregion
    }
}