using AJWManagementPortal.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AJWManagementPortal.Models;
namespace AJWManagementPortal.Areas.Account.Controllers
{
    //This Controller for ::Bank Reports for Account Office::
    [Area("Account")]
    public class BankController : Controller
    {
        private readonly ApplicationDbContext _db;
        //private readonly IWebHostEnvironment _iwebhost;
        //IWebHostEnvironment iwebhost
        //                _iwebhost = iwebhost;

        public BankController(ApplicationDbContext db)
        {
            _db = db;

        }
        //GET--MeezanBankAccountReportsList--start---
        public IActionResult MeezanBankAccountReportsList()
        {
            return View();
        }
        //GET--for MeezanBankAccountReportsList---ended---
        //POST--for MeezanBankAccountReportsList---Start---
        //POST--for MeezanBankAccountReportsList---ended----

        //GET--BOPBankAccountReportsList--start--
        public IActionResult BOPBankAccountReportsList()
        {
            return View();
        }
        //GET--for BOPBankAccountReportsList---ended---
        //POST--for BOPBankAccountReportsList---Start---
        //POST--for BOPBankAccountReportsList---ended----


        //GET--for BankCheckApprovelVoucherList---start--
        public IActionResult BankCheckApprovelVoucherList()
        {
            return View(_db.MeezanBankIEVouchers.Where(q=>q.DelProduction !=0).ToList().GroupBy(elem => elem.dateTime).Select(group => group.First()));
        }
        //GET--for BankCheckApprovelVoucherList---ended---
        //POST--for BankCheckApprovelVoucherList--start---
        //POST--for BankCheckApprovelVoucherList---ended--

        //GET--for Bank Check Approvel Voucher---start---
        public IActionResult BankCheckApprovelVoucher()
        {
            ViewBag.hide = false;
            MeezanBankIEVoucher report = new MeezanBankIEVoucher();
            return View(report);
        }

        public IActionResult BankCheckApprovelVoucher2(String Id, String hide)
        {
            ViewBag.hide = false;
            Id = Id.Replace("-", "/");
            DateTime dateTime10 = DateTime.Parse(Id);
            return View("BankCheckApprovelVoucher", _db.MeezanBankIEVouchers.Where(q => q.dateTime.Equals(dateTime10) && q.DelProduction != 0).ToList());
        }

        //GET--for Bank Check Approvel Voucher---ended---
        //POST--for Bank Check Approvel Voucher---start---
        //POST--for Bank Check Approvel Voucher--ended---
       

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

            ViewBag.Data1 = _db.MeezanBankIEVouchers.Where(z => z.dateTime <= dateTime10 ).ToList();
            ViewBag.hide = false;

            return View("BankCheckApprovelVoucher");


        }

        public IActionResult SendToAccountOffice(string remarks)
        {
            remarks = remarks.Replace("-", "/");
            List<MeezanBankIEVoucher> data = new List<MeezanBankIEVoucher>();
            DateTime dateTime10 = DateTime.Parse(remarks);
            data = _db.MeezanBankIEVouchers.Where(i => i.dateTime.Equals(dateTime10)).ToList();

            foreach (MeezanBankIEVoucher technical in data)
            {
                technical.DelCeo = 1;
                technical.Status = "4";
                technical.DelRepo = 1;
                var current = _db.MeezanBankIEVouchers.Find(technical.Id);
                if (current != null)
                {
                    _db.Entry(current).CurrentValues.SetValues(technical);
                }

                _db.SaveChanges();
            }
            return RedirectToAction("BankCheckApprovelVoucherList", _db.MeezanBankIEVouchers.Where(q => q.DelProduction != 0).ToList());
            //return View("AjwTechnicalStaffWorkPlanList", _db.TechnicalStaffWorkPlans.ToList());
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
            meezan.Status = "3";
            meezan.DelProduction = 1;
            meezan.DelCeo = 1;
            meezan.Remarks = "";
            _db.Add(meezan);
            await _db.SaveChangesAsync();
            //return RedirectToAction(nameof(DailyMeezanBankVoucherReport));



            ViewBag.Data = _db.MeezanBankIEReports.
                Where(z => z.ValueDate <= dateTime10)
                .ToList();

            ViewBag.Data1 = _db.MeezanBankIEVouchers.Where(z => z.dateTime <= dateTime10 && z.Status =="3").ToList();
            ViewBag.hide = false;
            return View("BankCheckApprovelVoucher", meezan);
        }
        [HttpGet]
        public async Task<IActionResult> BankCheckApprovelVoucherCreate()
        {
            return View();
        }
            [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> BankCheckApprovelVoucherCreate(MeezanBankIEVoucher meezan, string id)
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
            meezan.Status = "3";
            meezan.DelProduction = 1;
            meezan.DelCeo = 1;
            meezan.Remarks = "";
            _db.Add(meezan);
            await _db.SaveChangesAsync();
            //return RedirectToAction(nameof(DailyMeezanBankVoucherReport));



            ViewBag.Data = _db.MeezanBankIEReports.
                Where(z => z.ValueDate <= dateTime10)
                .ToList();

            ViewBag.Data1 = _db.MeezanBankIEVouchers.Where(z => z.dateTime <= dateTime10 && z.Status =="3").ToList();
            ViewBag.hide = false;
            return View("BankCheckApprovelVoucherCreate", meezan);
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
                technical.DelProduction = 0;
                var current = _db.MeezanBankIEVouchers.Find(technical.Id);
                if (current != null)
                {
                    _db.Entry(current).CurrentValues.SetValues(technical);
                }

                _db.SaveChanges();
            }
            return RedirectToAction("BankCheckApprovelVoucherList");
        }


    }
}
