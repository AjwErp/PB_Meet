using AJWManagementPortal.Data;
using AJWManagementPortal.Models;
using AJWManagementPortal.ViewModels;
using Microsoft.AspNetCore.Mvc;
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
        public DgmAllDepartmentReportsController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult DgmAccountsDepartmentReportsList()
        {
            var model = new DgmAccountsDepartmentReportsListViewModel();
            model.MonthlyClosingReport = _db.MonthlyClosingReports.Where(i => (Convert.ToInt32(i.Status) >= 1 && Convert.ToInt32(i.Status) <= 3)).ToList();
            return View(model);
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
        public IActionResult SendMonthlyClosingReportToGmOffice(string remarks)
        {
            remarks = remarks.Replace("-", "/");
            List<MonthlyClosingReport> data = new List<MonthlyClosingReport>();
            DateTime dateTime10 = DateTime.Parse(remarks);
            data = _db.MonthlyClosingReports.Where(i => i.ValueDate.Equals(dateTime10) && (Convert.ToInt32(i.Status) >= 1 && Convert.ToInt32(i.Status) <= 3)).ToList();

            foreach (MonthlyClosingReport technical in data)
            {
                technical.Status = "3";
                var current = _db.MonthlyClosingReports.Find(technical.Id);
                if (current != null)
                {
                    _db.Entry(current).CurrentValues.SetValues(technical);
                }

                _db.SaveChanges();
            }
            return RedirectToAction("DgmAccountsDepartmentReportsList");
        }
        public IActionResult SendMonthlyClosingReportToAccountErrorList(string remarks)
        {
            remarks = remarks.Replace("-", "/");
            List<MonthlyClosingReport> data = new List<MonthlyClosingReport>();
            DateTime dateTime10 = DateTime.Parse(remarks);
            data = _db.MonthlyClosingReports.Where(i => i.ValueDate.Equals(dateTime10) && (Convert.ToInt32(i.Status) >= 1 && Convert.ToInt32(i.Status) <= 3)).ToList();

            foreach (MonthlyClosingReport technical in data)
            {
                technical.Status = "5";
                var current = _db.MonthlyClosingReports.Find(technical.Id);
                if (current != null)
                {
                    _db.Entry(current).CurrentValues.SetValues(technical);
                }

                _db.SaveChanges();
            }
            return RedirectToAction("DgmAccountsDepartmentReportsList");
        }
    }
}
