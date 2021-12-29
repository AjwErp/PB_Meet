using AJWManagementPortal.Data;
using AJWManagementPortal.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Ceo.Controllers
{
    //This Controller for AJW Portal All department Reports List for ::CEO Office Varification::

    [Area("Ceo")]
    public class CeoAllDepartmentReportsController : Controller
    {
        //here we create constrauctor of DB class
        private readonly ApplicationDbContext _db;
        public CeoAllDepartmentReportsController(ApplicationDbContext db)
        {
            _db = db;
        }
        //GET--Start---gm---CeoCeoDepartmentReportsList----
        public IActionResult CeoCeoDepartmentReportsList()
        {
            return View();
        }
        //GET--Ended---gm---CeoCeoDepartmentReportsList----
        //POST--Start--gm----CeoCeoDepartmentReportsList----
        //POST--Ended--gm----CeoCeoDepartmentReportsList----

        //GET--Start---Account---AccountsBankCheckApprovalVoucherList----
        public IActionResult AccountsBankCheckApprovalVoucherList()
        {
            ViewBag.hide = false;
            return View(_db.MeezanBankIEVouchers.Where(q=>q.DelCeo!=0 && q.Status=="4").ToList().GroupBy(elem => elem.dateTime).Select(group => group.First()));
        }
        //GET--Ended---Account---AccountsBankCheckApprovalVoucherList----
        //POST--Start--Account----AccountsBankCheckApprovalVoucherList----
        //POST--Ended--Account----AccountsBankCheckApprovalVoucherList----
        //--------------------------------Technical Staff Worjk Plan---Start------------------------
        public IActionResult SendToProductionOffice(string remarks)
        {
            List<TechnicalStaffWorkPlan> data = new List<TechnicalStaffWorkPlan>();
            data = _db.TechnicalStaffWorkPlans.Where(i => i.Remarks.Equals(remarks)).ToList();

            foreach (TechnicalStaffWorkPlan technical in data)
            {
                technical.Status = "3";
                technical.DelProduction = 1;
                technical.DelRepo = 1;
                var current = _db.TechnicalStaffWorkPlans.Find(technical.Id);
                if (current != null)
                {
                    _db.Entry(current).CurrentValues.SetValues(technical);
                }

                _db.SaveChanges();
            }
            return RedirectToAction("CeoProductionDepartmentReportsList", _db.TechnicalStaffWorkPlans.ToList());
            //return View("AjwTechnicalStaffWorkPlanList", _db.TechnicalStaffWorkPlans.ToList());
        } //--------------------------------Technical Staff Worjk Plan---Start------------------------
        public IActionResult SendToAccountOffice(string remarks)
        {
            remarks = remarks.Replace("-", "/");
            List<MeezanBankIEVoucher> data = new List<MeezanBankIEVoucher>();
            DateTime dateTime10 = DateTime.Parse(remarks);
            data = _db.MeezanBankIEVouchers.Where(i => i.dateTime.Equals(dateTime10)).ToList();

            foreach (MeezanBankIEVoucher technical in data)
            {
                technical.DelCeo = 1;
                technical.DelGm = 1;
                technical.Status = "5";
                technical.DelRepo = 1;
                var current = _db.MeezanBankIEVouchers.Find(technical.Id);
                if (current != null)
                {
                    _db.Entry(current).CurrentValues.SetValues(technical);
                }

                _db.SaveChanges();
            }
            return RedirectToAction("AccountsBankCheckApprovalVoucherList", _db.MeezanBankIEVouchers.Where(q=>q.DelCeo!=0).ToList());
            //return View("AjwTechnicalStaffWorkPlanList", _db.TechnicalStaffWorkPlans.ToList());
        }
        //--------------------------
        public IActionResult SendToProductionRepositoryT(string remarks)
        {
            List<TechnicalStaffWorkPlan> data = new List<TechnicalStaffWorkPlan>();
            data = _db.TechnicalStaffWorkPlans.Where(i => i.Remarks.Equals(remarks)).ToList();

            foreach (TechnicalStaffWorkPlan technical in data)
            {
                technical.Status = "3";
                technical.DelProduction = 1;
                technical.DelRepo = 1;
                var current = _db.TechnicalStaffWorkPlans.Find(technical.Id);
                if (current != null)
                {
                    _db.Entry(current).CurrentValues.SetValues(technical);
                }
                _db.SaveChanges();
            }
            return RedirectToAction("CeoProductionDepartmentReportsList", _db.TechnicalStaffWorkPlans.ToList());
            //return View("AjwTechnicalStaffWorkPlanList", _db.TechnicalStaffWorkPlans.ToList());
        }

        //--------------------------
        //GET--Start---gm---CeoProductionDepartmentReportsList----
        public IActionResult CeoProductionDepartmentReportsList()
        {

            //var distinctList = _db.ManagementStaffWorkPlans.Where(i => i.DelCeoMP != 0 && Convert.ToInt32(i.MPStatus) >= 2).ToList().GroupBy(x => new { x.MPTitle, x.MPDate }).Distinct().Select(group => group.First()); ;
            ////var distinctList = _db.TechnicalStaffWorkPlans.Where(i => i.DelCeo != 0 && Convert.ToInt32(i.Status) >= 2).ToList().GroupBy(x => new { x.Title, x.Date, x.Remarks }).Distinct().Select(group => group.First()); ;
            //return View(distinctList);
            DTechnicalPlanPP TP = new DTechnicalPlanPP();
            TP.PlanM = _db.ManagementStaffWorkPlans.Where(i => i.DelCeoMP != 0 && Convert.ToInt32(i.MPStatus) >= 2).ToList().GroupBy(x => new { x.MPTitle, x.MPDate }).Distinct().Select(group => group.First());
            TP.PlanT = _db.TechnicalStaffWorkPlans.Where(i => i.DelCeo != 0 && Convert.ToInt32(i.Status) >= 2).ToList().GroupBy(x => new { x.Title, x.Date, x.Remarks }).Distinct().Select(group => group.First());

            return View(TP);
        }
        //GET--Ended---gm---CeoProductionDepartmentReportsList----
        //POST--Start--gm----CeoProductionDepartmentReportsList----
        //POST--Ended--gm----CeoProductionDepartmentReportsList----

        public async Task<IActionResult> CeoAjwTechnicalStaffWorkPlan()
        {
            return View();
        }
        public async Task<IActionResult> CeoEditAjwTechnicalStaffWorkPlan(string remarks)
        {
            ViewBag.remarks = remarks;
            var technicalList = _db.TechnicalStaffWorkPlans.Where(r => r.Remarks.Equals(remarks) && r.DelCeo != 0 && Convert.ToInt32(r.Status) >= 2).ToList();
            return View(technicalList);
        }

        public async Task<IActionResult> CeoDeleteAjwTechnicalStaffWorkPlan(String remarks)
        {
            //id = id.Replace("-", "/");
            //_db.TechnicalStaffWorkPlans.RemoveRange(_db.TechnicalStaffWorkPlans.ToList().Where(x => x.Remarks.Equals(remarks)));
            //_db.SaveChanges();
            //return View("AjwTechnicalStaffWorkPlanList", _db.TechnicalStaffWorkPlans.ToList());
            List<TechnicalStaffWorkPlan> data = new List<TechnicalStaffWorkPlan>();
            data = _db.TechnicalStaffWorkPlans.Where(i => i.Remarks.Equals(remarks)).ToList();

            foreach (TechnicalStaffWorkPlan technical in data)
            {
                technical.DelCeo = 0;
                var current = _db.TechnicalStaffWorkPlans.Find(technical.Id);
                if (current != null)
                {
                    _db.Entry(current).CurrentValues.SetValues(technical);
                }

                _db.SaveChanges();
            }
            return RedirectToAction("CeoProductionDepartmentReportsList", _db.TechnicalStaffWorkPlans.ToList());
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
                //tSWorkPlan.DelGm = 1;
                tSWorkPlan.DelCeo = 1;
                _db.TechnicalStaffWorkPlans.Add(tSWorkPlan);
            }


            int insertedRecords = _db.SaveChanges();
            return Json(insertedRecords);

        }
        //-------------------------------Technical Staff Work Plan-----------------End--------------------------
        //--------------------------------Management Staff Work Plan------------------start------------------------
      //--------------------
        public IActionResult SendToProductionRepository(string date)
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
            return RedirectToAction("CeoProductionDepartmentReportsList", _db.ManagementStaffWorkPlans.ToList());
            //return View("AjwTechnicalStaffWorkPlanList", _db.TechnicalStaffWorkPlans.ToList());
        }
        //--------------------------
        public async Task<IActionResult> CeoAjwManagementStaffWorkPlan()
        {
            return View();
        }
        //------------------------
        public async Task<IActionResult> CeoEditAjwManagementStaffWorkPlan(string date)
        {
            ViewBag.date = date;
            var managementList = _db.ManagementStaffWorkPlans.Where(r => r.MPDate.Equals(date) && r.DelCeoMP != 0 && Convert.ToInt32(r.MPStatus) >= 2).ToList();
            return View(managementList);
        }
        //-------------------------
        public async Task<IActionResult> CeoDeleteAjwManagementStaffWorkPlan(String date)
        {
            //id = id.Replace("-", "/");
            //_db.TechnicalStaffWorkPlans.RemoveRange(_db.TechnicalStaffWorkPlans.ToList().Where(x => x.Remarks.Equals(remarks)));
            //_db.SaveChanges();
            //return View("AjwTechnicalStaffWorkPlanList", _db.TechnicalStaffWorkPlans.ToList());
            List<ManagementStaffWorkPlan> data = new List<ManagementStaffWorkPlan>();
            data = _db.ManagementStaffWorkPlans.Where(i => i.MPDate.Equals(date)).ToList();

            foreach (ManagementStaffWorkPlan management in data)
            {
                management.DelCeoMP = 0;
                var current = _db.TechnicalStaffWorkPlans.Find(management.Id);
                if (current != null)
                {
                    _db.Entry(current).CurrentValues.SetValues(management);
                }

                _db.SaveChanges();
            }
            return RedirectToAction("CeoProductionDepartmentReportsList", _db.ManagementStaffWorkPlans.ToList());
        }


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
                technical.DelCeo = 0;
                var current = _db.MeezanBankIEVouchers.Find(technical.Id);
                if (current != null)
                {
                    _db.Entry(current).CurrentValues.SetValues(technical);
                }

                _db.SaveChanges();
            }
            return RedirectToAction("CeoProductionDepartmentReportsList");
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
        //---------------------------------
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
                //tSWorkPlan.DelGm = 1;
                mSWorkPlan.DelCeoMP = 1;
                _db.ManagementStaffWorkPlans.Add(mSWorkPlan);
            }


            int insertedRecords = _db.SaveChanges();
            return Json(insertedRecords);

        }
        //-----------------------------Management Staff Work Plan-----------------End----------------------------

    }
}
