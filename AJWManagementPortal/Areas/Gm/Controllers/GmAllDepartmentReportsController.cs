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

namespace AJWManagementPortal.Areas.Gm.Controllers
{
    //This Controller refer to ::All Department Reports for GM Office::
    [Area("Gm")]
    public class GmAllDepartmentReportsController : Controller
    { //here we create constrauctor of DB class
        private readonly ApplicationDbContext _db;
        private readonly INotyfService _notyf;

        public GmAllDepartmentReportsController(ApplicationDbContext db ,INotyfService notyf)
        {
            _db = db;
            _notyf = notyf;
        }
        //GET--Start---gm---GmAccountsDepartmentReportsList----
        public async Task<IActionResult> GmAccountsDepartmentReportsList()
        {
            //var model = new GmAccountsDepartmentReportsListViewModel();
            //model.MonthlyClosingReport = _db.MonthlyClosingReports.Where(i => i.DelProduction != 0 && (Convert.ToInt32(i.Status) == 3)).ToList();
            //return View(model);

            var model = new GmAccountsDepartmentReportsListViewModel();
            var monthlyClosingReport = await(from a in _db.MonthlyClosingReports
                                             where (a.DelProduction != 0 && (Convert.ToInt32(a.Status) > 1) && (Convert.ToInt32(a.Status) <= 4))
                                             select new MonthlyAcountReportsViewModel
                                             {
                                                 Id = a.Id,
                                                 Date = a.ValueDate,
                                                 IsMonthlyClosingReportGm = true,
                                                 Title = "Monthly Accounts Report"
                                             }).ToListAsync();
            var meezanBankMonthlyIncomeExpenseReports = await(from a in _db.MeezanBankMonthlyIncomeExpenseReports
                                                             where (a.DelProduction != 0 && (Convert.ToInt32(a.Status) > 1) && (Convert.ToInt32(a.Status) <= 4))
                                                              select new MonthlyAcountReportsViewModel
                                                              {
                                                                  Id = a.Id,
                                                                  Date = a.ValueDate,
                                                                  IsMeezanBankIncomeExpenseReportGm = true,
                                                                  Title = "Meezan Bank Monthly Income/Expence Report"
                                                              }).ToListAsync();
            model.MonthlyAcountReportsViewModel = monthlyClosingReport.Union(meezanBankMonthlyIncomeExpenseReports).OrderBy(x => x.Date);
            return View(model);
        }
        //GET--Ended---gm---GmAccountsDepartmentReportsList----
        //POST--Start--gm----GmAccountsDepartmentReportsList----
        //POST--Ended--gm----GmAccountsDepartmentReportsList----

        //GET--Start---gm---GmAccountsDepartmentReportsList----
        public IActionResult GmAccountsDepartmentReportsListE()
        {
            return View();
        }
        //GET--Ended---gm---GmAccountsDepartmentReportsList----
        //POST--Start--gm----GmAccountsDepartmentReportsList----
        //POST--Ended--gm----GmAccountsDepartmentReportsList----

        //---------------------------------------------------------------------------------
        //GET--Start---gm---GmDgmDepartmentReportsList----
        public IActionResult GmDgmDepartmentReportsList()
        {
            return View();
        }
        //GET--Ended---gm---GmDgmDepartmentReportsList----
        //POST--Start--gm----GmDgmDepartmentReportsList----
        //POST--Ended--gm----GmDgmDepartmentReportsList----
        //------------------------------------------Technical Staff Work Plan-----------start---------------
        public IActionResult SendToProductionOffice(string remarks)
        {
            List<TechnicalStaffWorkPlan> data = new List<TechnicalStaffWorkPlan>();
            data = _db.TechnicalStaffWorkPlans.Where(i => i.Remarks.Equals(remarks)).ToList();

            foreach (TechnicalStaffWorkPlan technical in data)
            {
                technical.Status = "3";
                technical.DelRepo = 1;
                var current = _db.TechnicalStaffWorkPlans.Find(technical.Id);
                if (current != null)
                {
                    _db.Entry(current).CurrentValues.SetValues(technical);
                }

                _db.SaveChanges();
            }
            return RedirectToAction("GmProductionDepartmentReportsList", _db.TechnicalStaffWorkPlans.ToList());
            //return View("AjwTechnicalStaffWorkPlanList", _db.TechnicalStaffWorkPlans.ToList());
        }
        public IActionResult SendToCeoOffice(string remarks)
        {
            List<TechnicalStaffWorkPlan> data = new List<TechnicalStaffWorkPlan>();
            data = _db.TechnicalStaffWorkPlans.Where(i => i.Remarks.Equals(remarks)).ToList();

            foreach (TechnicalStaffWorkPlan technical in data)
            {
                technical.Status = "2";
                technical.DelCeo = 1;
                var current = _db.TechnicalStaffWorkPlans.Find(technical.Id);
                if (current != null)
                {
                    _db.Entry(current).CurrentValues.SetValues(technical);
                }

                _db.SaveChanges();
            }
            return RedirectToAction("GmProductionDepartmentReportsList", _db.TechnicalStaffWorkPlans.ToList());
            //return View("AjwTechnicalStaffWorkPlanList", _db.TechnicalStaffWorkPlans.ToList());
        }
       
        //GET for AjwTechnicalStaffWorkPlan

        //public IActionResult GmAjwTechnicalStaffWorkPlanList()
        //{
        //    var distinctList = _db.TechnicalStaffWorkPlans.Where(i => i.DelProduction != 0).ToList().GroupBy(x => new { x.Title, x.Date, x.Remarks }).Distinct().Select(group => group.First()); ;

        //    return View(distinctList);
        //}
        //GET--Start---gm---GmProductionDepartmentReportsList----
        public IActionResult GmProductionDepartmentReportsList()
        {
        
            DTechnicalPlanPP TP = new DTechnicalPlanPP();
            TP.PlanM = _db.ManagementStaffWorkPlans.Where(i => i.DelGmMP != 0 && Convert.ToInt32(i.MPStatus) >= 1).ToList().GroupBy(x => new { x.MPTitle, x.MPDate }).Distinct().Select(group => group.First());
             TP.PlanT = _db.TechnicalStaffWorkPlans.Where(i => i.DelGm != 0 && Convert.ToInt32(i.Status) >= 1).ToList().GroupBy(x => new { x.Title, x.Date, x.Remarks }).Distinct().Select(group => group.First());

            return View(TP);
        }
        //GET--Ended---gm---GmProductionDepartmentReportsList----
        //POST--Start--gm----GmProductionDepartmentReportsList----
        //POST--Ended--gm----GmProductionDepartmentReportsList----
        public async Task<IActionResult> GmAjwTechnicalStaffWorkPlan()
        {
            return View();
        }
        public async Task<IActionResult> GmEditAjwTechnicalStaffWorkPlan(string remarks)
        {
            ViewBag.remarks = remarks;
            var technicalList = _db.TechnicalStaffWorkPlans.Where(r => r.Remarks.Equals(remarks) && r.DelGm != 0 && Convert.ToInt32(r.Status) >= 1).ToList();
            return View(technicalList);
        }

        public async Task<IActionResult> GmDeleteAjwTechnicalStaffWorkPlan(String remarks)
        {
            //id = id.Replace("-", "/");
            //_db.TechnicalStaffWorkPlans.RemoveRange(_db.TechnicalStaffWorkPlans.ToList().Where(x => x.Remarks.Equals(remarks)));
            //_db.SaveChanges();
            //return View("AjwTechnicalStaffWorkPlanList", _db.TechnicalStaffWorkPlans.ToList());
            List<TechnicalStaffWorkPlan> data = new List<TechnicalStaffWorkPlan>();
            data = _db.TechnicalStaffWorkPlans.Where(i => i.Remarks.Equals(remarks)).ToList();

            foreach (TechnicalStaffWorkPlan technical in data)
            {
                technical.DelGm = 0;
                var current = _db.TechnicalStaffWorkPlans.Find(technical.Id);
                if (current != null)
                {
                    _db.Entry(current).CurrentValues.SetValues(technical);
                }

                _db.SaveChanges();
            }
            return RedirectToAction("GmProductionDepartmentReportsList", _db.TechnicalStaffWorkPlans.ToList());
        }


        public JsonResult InsertTechnicalStaffWorkPlans(List<TechnicalStaffWorkPlan> data, String remarks)
        {

            ////Check for NULL.
            if (data == null)
            {
                data = new List<TechnicalStaffWorkPlan>();
            }

            List<TechnicalStaffWorkPlan> TechnicalStaffWorkPlans = new List<TechnicalStaffWorkPlan>();
            TechnicalStaffWorkPlans = _db.TechnicalStaffWorkPlans.Where(i => i.Remarks.Equals(remarks)).ToList();
            //List<int> intersection = trans.aDailyCashes.Cast<int>().Intersect(data.Cast<int>()).ToList();
            var list3 = TechnicalStaffWorkPlans.Except(data).ToList();
            var length = _db.TechnicalStaffWorkPlans.Where(i => i.Remarks.Equals(remarks)).Select(i => i.Remarks).Distinct().Count();
            //Loop and insert records.

            foreach (TechnicalStaffWorkPlan tSWorkPlan in list3)
            {
                tSWorkPlan.Remarks = remarks;
                _db.TechnicalStaffWorkPlans.Remove(tSWorkPlan);
            }


            foreach (TechnicalStaffWorkPlan tSWorkPlan in data)
            {
                //tSWorkPlan.Remarks = remarks;
                DateTime now = DateTime.Now;
                string date = now.GetDateTimeFormats('d')[0];
                tSWorkPlan.Date = date;
                //tSWorkPlan.DelProduction = 1;
                tSWorkPlan.DelGm = 1;
                //tSWorkPlan.DelCeo = 1;
                _db.TechnicalStaffWorkPlans.Add(tSWorkPlan);
            }


            int insertedRecords = _db.SaveChanges();
            return Json(insertedRecords);

        }
        //------------------------------------------Technical Staff Work Plan--------------end------------
        //------------------------------------------Management Staff Work Plan--------------------------
        public IActionResult SendToProductionOfficeMP(string date)
        {
            List<ManagementStaffWorkPlan> data = new List<ManagementStaffWorkPlan>();
            data = _db.ManagementStaffWorkPlans.Where(i => i.MPDate.Equals(date)).ToList();

            foreach (ManagementStaffWorkPlan management in data)
            {
                management.MPStatus = "3";
                management.DelRepoMP = 1;
                var current = _db.ManagementStaffWorkPlans.Find(management.Id);
                if (current != null)
                {
                    _db.Entry(current).CurrentValues.SetValues(management);
                }

                _db.SaveChanges();
            }
            return RedirectToAction("GmProductionDepartmentReportsList", _db.ManagementStaffWorkPlans.ToList());
            //return View("AjwTechnicalStaffWorkPlanList", _db.TechnicalStaffWorkPlans.ToList());
        }
        public IActionResult SendToCeoOfficeMP(string date)
        {
            List<ManagementStaffWorkPlan> data = new List<ManagementStaffWorkPlan>();
            data = _db.ManagementStaffWorkPlans.Where(i => i.MPDate.Equals(date)).ToList();

            foreach (ManagementStaffWorkPlan management in data)
            {
                management.MPStatus = "2";
                management.DelCeoMP = 1;
                var current = _db.TechnicalStaffWorkPlans.Find(management.Id);
                if (current != null)
                {
                    _db.Entry(current).CurrentValues.SetValues(management);
                }

                _db.SaveChanges();
            }
            return RedirectToAction("GmProductionDepartmentReportsList", _db.ManagementStaffWorkPlans.ToList());
            //return View("AjwTechnicalStaffWorkPlanList", _db.TechnicalStaffWorkPlans.ToList());
        }

        //GET for AjwTechnicalStaffWorkPlan

        public IActionResult GmAjwManagementStaffWorkPlanList()
        {
            var distinctList = _db.ManagementStaffWorkPlans.Where(i => i.DelProductionMP != 0).ToList().GroupBy(x => new { x.MPTitle, x.MPDate }).Distinct().Select(group => group.First()); ;

            return View(distinctList);
        }
        //GET--Start---gm---GmProductionDepartmentReportsList----
        //public IActionResult GmProductionDepartmentReportsList()
        //{
        //    var distinctList = _db.ManagementStaffWorkPlans.Where(i => i.DelGmMP != 0 && Convert.ToInt32(i.MPStatus) >= 1).ToList().GroupBy(x => new { x.MPTitle, x.MPDate}).Distinct().Select(group => group.First());
        //    return View(distinctList);
        //}
        ////GET--Ended---gm---GmProductionDepartmentReportsList----
        //POST--Start--gm----GmProductionDepartmentReportsList----
        //POST--Ended--gm----GmProductionDepartmentReportsList----
        public async Task<IActionResult> GmAjwManagementStaffWorkPlan()
        {
            return View();
        }
        public async Task<IActionResult> GmEditAjwManagementStaffWorkPlan(string date)
        {
            ViewBag.date = date;
            var managementList = _db.ManagementStaffWorkPlans.Where(r => r.MPDate.Equals(date) && r.DelGmMP != 0 && Convert.ToInt32(r.MPStatus) >= 1).ToList();
            return View(managementList);
        }

        public async Task<IActionResult> GmDeleteAjwManagementStaffWorkPlan(String date)
        {
            //id = id.Replace("-", "/");
            //_db.TechnicalStaffWorkPlans.RemoveRange(_db.TechnicalStaffWorkPlans.ToList().Where(x => x.Remarks.Equals(remarks)));
            //_db.SaveChanges();
            //return View("AjwTechnicalStaffWorkPlanList", _db.TechnicalStaffWorkPlans.ToList());
            List<ManagementStaffWorkPlan> data = new List<ManagementStaffWorkPlan>();
            data = _db.ManagementStaffWorkPlans.Where(i => i.MPDate.Equals(date)).ToList();

            foreach (ManagementStaffWorkPlan management in data)
            {
                management.DelGmMP = 0;
                var current = _db.ManagementStaffWorkPlans.Find(management.Id);
                if (current != null)
                {
                    _db.Entry(current).CurrentValues.SetValues(management);
                }

                _db.SaveChanges();
            }
            return RedirectToAction("GmProductionDepartmentReportsList", _db.ManagementStaffWorkPlans.ToList());
        }


        public JsonResult InsertManagementStaffWorkPlans(List<ManagementStaffWorkPlan> data, String date)
        {

            ////Check for NULL.
            if (data == null)
            {
                data = new List<ManagementStaffWorkPlan>();
            }

            List<ManagementStaffWorkPlan> managementStaffWorkPlans = new List<ManagementStaffWorkPlan>();
            managementStaffWorkPlans = _db.ManagementStaffWorkPlans.Where(i => i.MPDate.Equals(date)).ToList();
            //List<int> intersection = trans.aDailyCashes.Cast<int>().Intersect(data.Cast<int>()).ToList();
            var list3 = managementStaffWorkPlans.Except(data).ToList();
            var length = _db.ManagementStaffWorkPlans.Where(i => i.MPDate.Equals(date)).Select(i => i.MPDate).Distinct().Count();
            //Loop and insert records.

            foreach (ManagementStaffWorkPlan mSWorkPlan in list3)
            {
                mSWorkPlan.MPDate = date;
                _db.ManagementStaffWorkPlans.Remove(mSWorkPlan);
            }


            foreach (ManagementStaffWorkPlan mSWorkPlan in data)
            {
                //tSWorkPlan.Remarks = remarks;
                DateTime now = DateTime.Now;
                string date1 = now.GetDateTimeFormats('d')[0];
                mSWorkPlan.MPDate = date;
                //tSWorkPlan.DelProduction = 1;
                mSWorkPlan.DelGmMP = 1;
                //tSWorkPlan.DelCeo = 1;
                _db.ManagementStaffWorkPlans.Add(mSWorkPlan);
            }


            int insertedRecords = _db.SaveChanges();
            return Json(insertedRecords);

        }
        //------------------------------------------Management Staff Work Plan--------------------------

        public async Task<IActionResult> SendMonthlyClosingReportToAccountOffice(string remarks)
        {
            var currentMonthlyReportData = (dynamic)null;
            var currentMeezanBankIncomeExpenseReportData = (dynamic)null;
            remarks = remarks.Replace("-", "/");
            DateTime dateTime10 = DateTime.Parse(remarks);
            var monthlyReportData = _db.MonthlyClosingReports.Where(i => i.ValueDate.Equals(dateTime10) && i.DelProduction != 0).FirstOrDefault();
            if (monthlyReportData != null)
            {
                monthlyReportData.Status = "4";
                currentMonthlyReportData = await _db.MonthlyClosingReports.FindAsync(monthlyReportData.Id);

            }
            var meezanBankIncomeExpenseReportData = _db.MeezanBankMonthlyIncomeExpenseReports.Where(i => i.ValueDate.Equals(dateTime10) && i.DelProduction != 0).FirstOrDefault();
            if (meezanBankIncomeExpenseReportData != null)
            {
                meezanBankIncomeExpenseReportData.Status = "4";
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
            _notyf.Success("Report successfully sent to Account office");
            return RedirectToAction("GmAccountsDepartmentReportsList");

        }
        #region MONTHLY CLOSING REPORT

        public IActionResult EditMonthlyClosingReport(int id, bool IsEdit)
        {
            //var model = new MonthlyClosingReport
            //{
            //    ValueDate = System.Convert.ToDateTime(DateTime.Now.ToString("MM-dd-yyyy"))
            //};
            var model = _db.MonthlyClosingReports.Where(x => x.Id == id).FirstOrDefault();
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
            return RedirectToAction("GmAccountsDepartmentReportsList");
        }

        public async Task<IActionResult> DeleteMonthlyClosingReport(int id)
        {

            var report = await _db.MonthlyClosingReports.FindAsync(id);
            if (report == null)
            {
                return RedirectToAction("GmAccountsDepartmentReportsList");
            }

            try
            {
                report.DelProduction = 0;
                _db.Entry(report).State = EntityState.Modified;
                await _db.SaveChangesAsync();
                _notyf.Success("Deleted successfully");
                return RedirectToAction("GmAccountsDepartmentReportsList");
            }
            catch (DbUpdateException /* ex */)
            {
                return RedirectToAction("GmAccountsDepartmentReportsList");
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

            return RedirectToAction("GmAccountsDepartmentReportsList");
        }
        public async Task<IActionResult> DeleteMeezanBankIncomeExpenseReport(int id)
        {

            var report = await _db.MeezanBankMonthlyIncomeExpenseReports.FindAsync(id);
            if (report == null)
            {
                return RedirectToAction("GmAccountsDepartmentReportsList");
            }

            try
            {
                report.DelProduction = 0;
                _db.Entry(report).State = EntityState.Modified;
                await _db.SaveChangesAsync();
                _notyf.Success("Deleted successfully");
                return RedirectToAction("GmAccountsDepartmentReportsList");
            }
            catch (DbUpdateException /* ex */)
            {
                return RedirectToAction("GmAccountsDepartmentReportsList");
            }
        }
        //public async Task<IActionResult> SendMeezanBankIncomeExpenseReportToAccountOffice(int id)
        //{
        //    var report = await _db.MeezanBankMonthlyIncomeExpenseReports.FindAsync(id);
        //    if (report == null)
        //    {
        //        return RedirectToAction("GmAccountsDepartmentReportsList");
        //    }

        //    try
        //    {
        //        report.Status = "4";
        //        _db.Entry(report).State = EntityState.Modified;
        //        await _db.SaveChangesAsync();
        //        _notyf.Success("Report successfully sent to Account office");
        //        return RedirectToAction("GmAccountsDepartmentReportsList");
        //    }
        //    catch (DbUpdateException /* ex */)
        //    {
        //        return RedirectToAction("GmAccountsDepartmentReportsList");
        //    }
        //}
        #endregion

    }
}





