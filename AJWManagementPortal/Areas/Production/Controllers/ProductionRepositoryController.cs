using AJWManagementPortal.Data;
using AJWManagementPortal.Models;
using AJWManagementPortal.Utility;
using DinkToPdf;
using DinkToPdf.Contracts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Production.Controllers
{[Area("Production")]

    //This Controller refer to ::Production Office Repository::
    //Repository for ProductionAllReportsRepository  list
    //[Route("api/pdfcreator")]
    //[ApiController]
    public class ProductionRepositoryController : Controller
    {
        private IConverter _converter;
        private readonly ApplicationDbContext _db;
        //private readonly IWebHostEnvironment _iwebhost;
        //IWebHostEnvironment iwebhost
        //                _iwebhost = iwebhost;

        public ProductionRepositoryController(ApplicationDbContext db, IConverter converter)
        {
            _db = db;
            _converter = converter;


        }
        //public IActionResult GmProductionDepartmentReportsList()
        //{
        //    var distinctList = _db.TechnicalStaffWorkPlans.Where(i => i.DelGm != 0 && Convert.ToInt32(i.Status) >= 1).ToList().GroupBy(x => new { x.Title, x.Date, x.Remarks }).Distinct().Select(group => group.First());
        //    return View(distinctList);
        //}
        //------start-------------Technical Staff Work Plan---Production Repository--------------
        public IActionResult ProductionAllReportsRepository()

        {
            
            DTechnicalPlanPP TP = new DTechnicalPlanPP();
            TP.PlanM = _db.ManagementStaffWorkPlans.Where(i => i.DelRepoMP != 0 && Convert.ToInt32(i.MPStatus) >= 1).ToList().GroupBy(x => new { x.MPTitle, x.MPDate }).Distinct().Select(group => group.First());
            TP.PlanT = _db.TechnicalStaffWorkPlans.Where(i => i.DelRepo != 0 && Convert.ToInt32(i.Status) >= 1).ToList().GroupBy(x => new { x.Title, x.Date}).Distinct().Select(group => group.First());


            foreach (ManagementStaffWorkPlan a in TP.PlanM)
            {
                ViewBag.Date = a.MPDate;

            }
            foreach (TechnicalStaffWorkPlan a in TP.PlanT)
            {
                ViewBag.Date = a.Date;

            }
            return View(TP);
            //var distinctList = 
            
            //return View(distinctList);
        }
        //-----------
        public async Task<IActionResult> AjwTechnicalStaffWorkPlan()
        {
            return View();
        }
        //---------------------
        public async Task<IActionResult> EditAjwTechnicalStaffWorkPlan(string remarks)
        {
            ViewBag.remarks = remarks;
            var technicalList = _db.TechnicalStaffWorkPlans.Where(r => r.Remarks.Equals(remarks) && r.DelRepo != 0).ToList();
            return View( technicalList);
        }
        //-------------------

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
                technical.DelRepo = 0;
                var current = _db.TechnicalStaffWorkPlans.Find(technical.Id);
                if (current != null)
                {
                    _db.Entry(current).CurrentValues.SetValues(technical);
                }

                _db.SaveChanges();
            }
            return RedirectToAction("ProductionAllReportsRepository", _db.TechnicalStaffWorkPlans.ToList());
        }
        //-----------------


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
                tSWorkPlan.DelRepo = 1;
                //tSWorkPlan.DelGm = 1;
                //tSWorkPlan.DelCeo = 1;
                _db.TechnicalStaffWorkPlans.Add(tSWorkPlan);
            }


            int insertedRecords = _db.SaveChanges();
            return Json(insertedRecords);

        }
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
        //----------------
        //------End-------------Technical Staff Work Plan---Production Repository--------------
        //------start-------------Management Staff Work Plan---Production Repository--------------
        //-----------
        public async Task<IActionResult> AjwManagementStaffWorkPlan()
        {
            return View();
        }
        //---------------------
        public async Task<IActionResult> EditAjwManagementStaffWorkPlan(string date)
        {
            ViewBag.date = date;
            var managementList = _db.ManagementStaffWorkPlans.Where(r => r.MPDate.Equals(date) && r.DelRepoMP != 0).ToList();
            return View(managementList);
        }
        //----------------------
        public async Task<IActionResult> DeleteAjwManagementStaffWorkPlan(String date)
        {
            //id = id.Replace("-", "/");
            //_db.TechnicalStaffWorkPlans.RemoveRange(_db.TechnicalStaffWorkPlans.ToList().Where(x => x.Remarks.Equals(remarks)));
            //_db.SaveChanges();
            //return View("AjwTechnicalStaffWorkPlanList", _db.TechnicalStaffWorkPlans.ToList());
            List<ManagementStaffWorkPlan> data = new List<ManagementStaffWorkPlan>();
            data = _db.ManagementStaffWorkPlans.Where(i => i.MPDate.Equals(date)).ToList();

            foreach (ManagementStaffWorkPlan management in data)
            {
                management.DelRepoMP = 0;
                var current = _db.ManagementStaffWorkPlans.Find(management.Id);
                if (current != null)
                {
                    _db.Entry(current).CurrentValues.SetValues(management);
                }

                _db.SaveChanges();
            }
            return RedirectToAction("ProductionAllReportsRepository", _db.ManagementStaffWorkPlans.ToList());
        }
        //------------
        public JsonResult InsertManagementStaffWorkPlans(List<ManagementStaffWorkPlan> data, String date)
        {

            ////Check for NULL.
            if (data == null)
            {
                data = new List<ManagementStaffWorkPlan>();
            }

            List<ManagementStaffWorkPlan> ManagementStaffWorkPlan = new List<ManagementStaffWorkPlan>();
            ManagementStaffWorkPlan = _db.ManagementStaffWorkPlans.Where(i => i.MPDate.Equals(date)).ToList();
            var list3 = ManagementStaffWorkPlan.Except(data).ToList();
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
                mSWorkPlan.DelRepoMP = 1;
                //tSWorkPlan.DelGm = 1;
                //tSWorkPlan.DelCeo = 1;
                _db.ManagementStaffWorkPlans.Add(mSWorkPlan);
            }


            int insertedRecords = _db.SaveChanges();
            return Json(insertedRecords);

        }
        //-------------
        //-----This Method Refer to the PDF File Download from ::Production Repository pannel::
        [HttpGet]
        public IActionResult CreatePDFMP()
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
                HtmlContent = TemplateGeneratorMP.GetHTMLString(),
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
        //-----------------
        //------End-------------Management Staff Work Plan---Production Repository--------------


    }
}
