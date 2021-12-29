using AJWManagementPortal.Data;
using AJWManagementPortal.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Production.Controllers
{[Area("Production")]
    public class AjwAllDailyPlanController : Controller
    {
        //This Controller Refer to AJW All Daily Plan Technical/Management Staff Work Plan ::Production Office::

        //here we create constrauctor of DB class
        private readonly ApplicationDbContext _db;
        public AjwAllDailyPlanController(ApplicationDbContext db)
        {
            _db = db;
        }
        //This Method Refer to File Sending To GM Office
        public IActionResult SendToGmOffice(string remarks)
        {
            List<TechnicalStaffWorkPlan> data = new List<TechnicalStaffWorkPlan>();
            data = _db.TechnicalStaffWorkPlans.Where(i => i.Remarks.Equals(remarks)).ToList();

            foreach (TechnicalStaffWorkPlan technical in data)
            {
                technical.Status = "2";
                technical.DelGm = 1;
                var current = _db.TechnicalStaffWorkPlans.Find(technical.Id);
                if (current != null)
                {
                    _db.Entry(current).CurrentValues.SetValues(technical);
                }

                _db.SaveChanges();
            }
            return RedirectToAction("AjwTechnicalStaffWorkPlanList", _db.TechnicalStaffWorkPlans.ToList());
            //return View("AjwTechnicalStaffWorkPlanList", _db.TechnicalStaffWorkPlans.ToList());
        }

       

        //--------------Start---------------------AJW Techinal Staff Working Plan-----------------------
        //GET for AjwTechnicalStaffWorkPlan
        
        public IActionResult AjwTechnicalStaffWorkPlanList()
        {
            var distinctList = _db.TechnicalStaffWorkPlans.Where(i => i.DelProduction != 0).ToList().GroupBy(x => new { x.Title, x.Date, x.Remarks }).Distinct().Select(group => group.First()); ;

            return View(distinctList);
        }
        //-----------------------------------AJW Techinal Staff Working Plan------------------End-------

        public async Task<IActionResult> AjwTechnicalStaffWorkPlan()
        {
            return View();
        }
        public async Task<IActionResult> EditAjwTechnicalStaffWorkPlan(string remarks)
        {
            ViewBag.remarks =remarks;
            var technicalList = _db.TechnicalStaffWorkPlans.Where(r => r.Remarks.Equals(remarks)&& r.DelProduction != 0).ToList();
            return View(technicalList);
        }

        public async Task<IActionResult> DeleteAjwTechnicalStaffWorkPlan(String remarks)
        {
            //id = id.Replace("-", "/");
            //_db.TechnicalStaffWorkPlans.RemoveRange(_db.TechnicalStaffWorkPlans.ToList().Where(x => x.Remarks.Equals(remarks)));
            //_db.SaveChanges();
            //return View("AjwTechnicalStaffWorkPlanList", _db.TechnicalStaffWorkPlans.ToList());
            List<TechnicalStaffWorkPlan> data = new List<TechnicalStaffWorkPlan>();
            data = _db.TechnicalStaffWorkPlans.Where(i => i.Remarks.Equals(remarks)).ToList();

            foreach (TechnicalStaffWorkPlan technical in data)
            {
                technical.DelProduction=0;
                var current = _db.TechnicalStaffWorkPlans.Find(technical.Id);
                if (current != null)
                {
                    _db.Entry(current).CurrentValues.SetValues(technical);
                }

                _db.SaveChanges();
            }
            return RedirectToAction("AjwTechnicalStaffWorkPlanList", _db.TechnicalStaffWorkPlans.ToList());
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
                tSWorkPlan.DelProduction = 1;
                tSWorkPlan.DelGm = 1;
                tSWorkPlan.DelCeo = 1;
                    _db.TechnicalStaffWorkPlans.Add(tSWorkPlan);
                }
            

            int insertedRecords = _db.SaveChanges();
            return Json(insertedRecords);

        }

        //--------------Start---------------------AJW MAnagement Staff Working Plan---------------------
        //This Method Refer to File Sending To GM Office
        public IActionResult SendToGmOfficeMP(string date)
        {
            List<ManagementStaffWorkPlan> data = new List<ManagementStaffWorkPlan>();
            data = _db.ManagementStaffWorkPlans.Where(i => i.MPDate.Equals(date)).ToList();

            foreach (ManagementStaffWorkPlan management in data)
            {
                management.MPStatus = "2";
                management.DelGmMP = 1;
                var current = _db.ManagementStaffWorkPlans.Find(management.Id);
                if (current != null)
                {
                    _db.Entry(current).CurrentValues.SetValues(management);
                }

                _db.SaveChanges();
            }
            return RedirectToAction("AjwManagementStaffWorkPlanList", _db.ManagementStaffWorkPlans.ToList());
            //return View("AjwTechnicalStaffWorkPlanList", _db.TechnicalStaffWorkPlans.ToList());
        }

        public IActionResult AjwManagementStaffWorkPlanList()
        {
            var distinctList = _db.ManagementStaffWorkPlans.Where(i => i.DelProductionMP != 0).ToList().GroupBy(x => new { x.MPTitle, x.MPDate }).Distinct().Select(group => group.First()); ;

            return View(distinctList);

        }
        ////GET for AjwManagementStaffWorkPlan
        public IActionResult AjwManagementStaffWorkPlan()
        {
            return View();
        }

        public async Task<IActionResult> EditAjwManagementStaffWorkPlanMP(string date)
        {
            ViewBag.date = date;
            var managementList = _db.ManagementStaffWorkPlans.Where(r => r.MPDate.Equals(date) && r.DelProductionMP != 0).ToList();
            return View(managementList);
        }

        public async Task<IActionResult> DeleteAjwManagementStaffWorkPlanMP(String date)
        {
            //id = id.Replace("-", "/");
            //_db.TechnicalStaffWorkPlans.RemoveRange(_db.TechnicalStaffWorkPlans.ToList().Where(x => x.Remarks.Equals(remarks)));
            //_db.SaveChanges();
            //return View("AjwTechnicalStaffWorkPlanList", _db.TechnicalStaffWorkPlans.ToList());
            List<ManagementStaffWorkPlan> data = new List<ManagementStaffWorkPlan>();
            data = _db.ManagementStaffWorkPlans.Where(i => i.MPDate.Equals(date)).ToList();

            foreach (ManagementStaffWorkPlan management in data)
            {
                management.DelProductionMP = 0;
                var current = _db.ManagementStaffWorkPlans.Find(management.Id);
                if (current != null)
                {
                    _db.Entry(current).CurrentValues.SetValues(management);
                }

                _db.SaveChanges();
            }
            return RedirectToAction("AjwManagementStaffWorkPlanList", _db.ManagementStaffWorkPlans.ToList());
        }


        public JsonResult InsertManagementStaffWorkPlans(List<ManagementStaffWorkPlan> data, String date)
        {

            ////Check for NULL.
            if (data == null)
            {
                data = new List<ManagementStaffWorkPlan>();
            }

            List<ManagementStaffWorkPlan> ManagementStaffWorkPlans = new List<ManagementStaffWorkPlan>();
            ManagementStaffWorkPlans = _db.ManagementStaffWorkPlans.Where(i => i.MPDate.Equals(date)).ToList();
            //List<int> intersection = trans.aDailyCashes.Cast<int>().Intersect(data.Cast<int>()).ToList();
            var list3 = ManagementStaffWorkPlans.Except(data).ToList();
            var length = _db.ManagementStaffWorkPlans.Where(i => i.MPDate.Equals(date)).Select(i => i.MPDate).Distinct().Count();
            //Loop and insert records.

            foreach (ManagementStaffWorkPlan tSWorkPlan in list3)
            {
                tSWorkPlan.MPDate = date;
                _db.ManagementStaffWorkPlans.Remove(tSWorkPlan);
            }


            foreach (ManagementStaffWorkPlan tSWorkPlan in data)
            {
                //tSWorkPlan.Remarks = remarks;
                DateTime now = DateTime.Now;
                string date1 = now.GetDateTimeFormats('d')[0];
                tSWorkPlan.MPDate = date1;
                tSWorkPlan.DelProductionMP = 1;
                tSWorkPlan.DelGmMP = 1;
                tSWorkPlan.DelCeoMP = 1;
                _db.ManagementStaffWorkPlans.Add(tSWorkPlan);
            }

            int insertedRecords = _db.SaveChanges();
            return Json(insertedRecords);

        }

        //-----------------------------------AJW MAnagement Staff Working Plan------------------End-----
    }
}
