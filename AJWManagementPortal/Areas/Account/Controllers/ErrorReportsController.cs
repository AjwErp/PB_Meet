using AJWManagementPortal.Data;
using AJWManagementPortal.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Account.Controllers
{ [Area("Account")]
    public class ErrorReportsController : Controller
    {
        private readonly ApplicationDbContext _db;
        public ErrorReportsController(ApplicationDbContext db)
        {
            _db = db;

        }
        public IActionResult AccountsErrorReportsList()
        {
            IEnumerable<aDailyCash> a = _db.aDailyCashes.Where(i => i.DelProduction != 0 && Convert.ToInt32(i.Status) == 5).ToList().GroupBy(elem => elem.ValueDate).Select(group => group.First());
            IEnumerable<MeezanBankIEReport> a1 = _db.MeezanBankIEReports.Where(i => i.DelProduction != 0 && Convert.ToInt32(i.Status) == 5).ToList().GroupBy(elem => elem.ValueDate).Select(group => group.First());
            IEnumerable<DailySuppliersCashTransactionReport> a2 = _db.dailySuppliers.Where(i => i.DelProduction != 0 && Convert.ToInt32(i.Status) == 5).ToList().GroupBy(elem => elem.ValueDate).Select(group => group.First());
            DailyMeezan meezan = new DailyMeezan();
            meezan.aDailyCashes = a;
            meezan.Bank = a1;
            meezan.dSuppliers = a2;
            return View(meezan);
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
    }
}
