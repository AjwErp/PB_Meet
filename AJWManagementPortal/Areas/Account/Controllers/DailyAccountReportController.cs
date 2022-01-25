using AJWManagementPortal.Data;
using AJWManagementPortal.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Account.Controllers
{
    //This Controller for ::Daily Reports for Account office::
    [Area("Account")]
    public class DailyAccountReportController : Controller
    {
        //Referance from TransAndBank sheet of the Trans Bank
        TransAndBank trans = new TransAndBank();
        //Referance for Application DB
        private readonly ApplicationDbContext _db;
        //Referance from TransAndBank of the DailyTransactionReportM  
        DailyTransactionReportM DTReport = new DailyTransactionReportM();
        //private readonly IWebHostEnvironment _iwebhost;
        //IWebHostEnvironment iwebhost
        //                _iwebhost = iwebhost;
        // Referance for BankBalalcne + MeeznBankIEReports in DailyAccountReportController
        public DailyAccountReportController(ApplicationDbContext db)
        {
            _db = db;
            trans.Bank1 = _db.bankBalane.ToList();
            trans.Bank2 = _db.MeezanBankIEReports.ToList();
        }

        //GET--start---for All Daily Accounts Reports----- 

        //GET--ended---for All Daily Accounts Reports----- 
        //POST--ended---for All Daily Accounts Reports----- 
        //POST--ended---for All Daily Accounts Reports----- 


        ////GET- for index method
        //public IActionResult Index()
        //{
        //    return View();
        //} 
        //ended--GET- for index method
        //POST- for index method
        //ended--POST- for index method

        //Method for :Daily Continue Report 
        public async Task<IActionResult> IndexByName(String id, String hide)
        {
            trans.hide = Boolean.Parse(hide);
            if (id == null)
            {
                return NotFound();
            }
            id = id.Replace("-", "/");
            DateTime dateTime10 = DateTime.Parse(id);
            trans.date = dateTime10;
            trans.aDailyCashes = _db.aDailyCashes.
                Where(z => z.ValueDate <= dateTime10 && z.DelProduction != 0)
                .ToList();

            return View("DailyContinueReport", trans);
        }
        public async Task<IActionResult> IndexByNameRepository(String id, String hide)
        {
            trans.hide = Boolean.Parse(hide);
            if (id == null)
            {
                return NotFound();
            }
            id = id.Replace("-", "/");
            DateTime dateTime10 = DateTime.Parse(id);
            trans.date = dateTime10;
            trans.aDailyCashes = _db.aDailyCashes.
                Where(z => z.ValueDate <= dateTime10 && z.DelProduction != 0)
                .ToList();

            return View("IndexByNameRepository", trans);
        }
        // Method For :Daily Continue Sheet 
        public async Task<IActionResult> Index()
        {
            DateTime today = DateTime.Today;
            trans.aDailyCashes = _db.aDailyCashes.
                Where(z => z.ValueDate <= today && z.DelProduction != 0)
                .ToList();
            trans.date = today;
            List<aDailyCash> a = new List<aDailyCash>();
            trans.aDailyCashes = a;
            return View(trans);
        }

        // Method for :Delete Sheet of :Daily Continue Sheet
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
                technical.DelProduction = 0;
                var current = _db.aDailyCashes.Find(technical.Id);
                if (current != null)
                {
                    _db.Entry(current).CurrentValues.SetValues(technical);
                }

                _db.SaveChanges();
            }
            return RedirectToAction("AllDailyAccountsReports");
        }
        // Method for :Daily Supplier Sheet
        public async Task<IActionResult> DeleteSuppliersSheet(String remarks)
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
                technical.DelProduction = 0;
                var current = _db.dailySuppliers.Find(technical.Id);
                if (current != null)
                {
                    _db.Entry(current).CurrentValues.SetValues(technical);
                }

                _db.SaveChanges();
            }
            return RedirectToAction("AllDailyAccountsReports");
        }

        // Method For Delete of :Daily Meezan Bank IE Report
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
                technical.DelProduction = 0;
                var current = _db.MeezanBankIEReports.Find(technical.Id);
                if (current != null)
                {
                    _db.Entry(current).CurrentValues.SetValues(technical);
                }

                _db.SaveChanges();
            }
            return RedirectToAction("AllDailyAccountsReports");
        }

        //Method for Delete Sheet in AllDailyAccountsReport List Page
        public async Task<IActionResult> DeleteByDate(String id, String redirect)
        {
            //id = id.Replace("-", "/");
            _db.aDailyCashes.RemoveRange(_db.aDailyCashes.ToList().Where(x => x.ValueDate.Date.ToString("dd-MM-yyyy") == id));
            _db.SaveChanges();
            var distinctList = _db.aDailyCashes.ToList().GroupBy(elem => elem.ValueDate).Select(group => group.First()); ;

            return View(redirect, distinctList);
        }

        //Get for :Daily Continue Report
        public IActionResult DailyContinueReport()
        {
            DateTime today = DateTime.Today;
            //trans.aDailyCashes = _db.aDailyCashes.
            //    Where(z => z.ValueDate <= today && z.DelProduction != 0)
            //    .ToList();
            trans.date = today;
            return View("DailyContinueReport2", trans);
        }
        //---1-Get-ended - for Daily Continue Report
        //POST -1 for Daily Continue Report
        //---1-POST-ended - for Daily Continue Report

        //Method for :Daily Transaction Report in All Daily Accounts Report
        public async Task<IActionResult> TransactionSheet(String id, String hide)
        {
            if (id == null)
            {
                return NotFound();
            }
            //trans.hide = Boolean.Parse(hide);
            trans.hide = Boolean.Parse(hide);
            id = id.Replace("-", "/");
            DateTime dateTime10 = DateTime.Parse(id);
            trans.date = dateTime10;
            trans.aDailyCashes = _db.aDailyCashes.
                Where(z => z.ValueDate <= dateTime10 && z.DelProduction != 0)
                .ToList();

            return View("DailyTransactionReport", trans);
        }
        //Method for :Daily Transaction Report in All Daily Accounts Report
        public async Task<IActionResult> TransactionSheet2()
        {
            DateTime today = DateTime.Today;
            trans.aDailyCashes = _db.aDailyCashes.
                Where(z => (z.ValueDate <= today || z.lnClearedAmount != 0) && z.DelProduction != 0)
                .ToList();
            trans.date = today;
            return View("DailyTransactionReport", trans);
        }



        //Get -2 for Daily Transaction Report
        public IActionResult DailyTransactionReport()
        {
            return View();
        }
        //--2-Get-ended - for Daily Transaction Report
        //POST -2 for Daily Transaction Report
        //--2-POST-ended - for Daily Transaction Report

        //Get -3 for Daily Meezan bank income/Expence Report
        public IActionResult DailyMeezanBankIEReport()
        {
            ViewBag.hide = false;
            return View(_db.MeezanBankIEReports.Where(q => q.DelProduction != 0).ToList());
        }//Get -3 for Daily Meezan bank income/Expence Report
        public IActionResult DailyMeezanBankIEReport2(String Id, String hide)
        {
            ViewBag.hide = false;
            Id = Id.Replace("-", "/");
            DateTime dateTime10 = DateTime.Parse(Id);
            return View("DailyMeezanBankIEReport", _db.MeezanBankIEReports.Where(q => q.ValueDate.Equals(dateTime10) && q.DelProduction != 0).ToList());
        }
        //--3-Get-ended - for Daily Meezan bank income/Expence Report
        //POST -3 for Daily Meezan bank income/Expence Report
        //--3-POST-ended - for Daily Meezan bank income/Expence Report

        //Get -4 for Daily Punjab bank income/Expence Report
        public IActionResult DailyPunjabBankIEReport()
        {
            return View();
        }
        //--4-Get-ended - for Daily Punjab bank income/Expence Report
        //POST -4 for Daily Punjab bank income/Expence Report
        //--4-POST-ended - for Daily Punjab bank income/Expence Report     

        //Get -5 for Daily Cash closing Report
        public IActionResult DailyCashClosingReport()
        {
            return View();
        }
        //---5-Get-ended - for Daily Cash closing Report
        //POST -5 for Daily Cash closing Report
        //-POST--5-Get-ended - for Daily Cash closing Report      

        //Get -6 for Daily Meezan bank voucher Report
        public IActionResult DailyMeezanBankVoucherReport()
        {
            return View();
        }
        //---6-Get-ended - for Daily Meezan bank voucherReport
        //POST -6 for Daily Meezan bank voucher Report
        //-POST--6-Get-ended - for Daily Meezan bank voucherReport     

        //Get -7 for Daily Punjab bank voucher Report
        public IActionResult DailyPunjabBankVoucherReport()
        {
            return View();
        }
        //--7--Get-ended - for Daily Punjab bank voucherReport
        //POST -7 for Daily Punjab bank voucher Report
        //-POST-7--Get-ended - for Daily Punjab bank voucherReport      

        //Get -8 for Daily closing voucher Report
        public IActionResult DailyClosingVoucherReport()
        {
            return View();
        }
        //----Get-ended - for Daily closing voucher Report
        //POST -8 for Daily closing voucher Report
        //----POST-ended - for Daily closing voucher Report     

        //Get -9 for :Daily Geneeral Ledger  Report
        public IActionResult DailyGeneralLedgerReport(String id, String hide)
        {
            if (id == null)
            {
                return NotFound();
            }
            trans.hide = Boolean.Parse(hide);
            id = id.Replace("-", "/");
            DateTime dateTime10 = DateTime.Parse(id);
            trans.date = dateTime10;
            trans.aDailyCashes = _db.aDailyCashes.
                Where(z => z.ValueDate <= dateTime10 && z.DelProduction != 0)
                .ToList();
            return View("DailyGeneralLedgerReport", trans);
        }
        // Method For :Daily General Ledger Report
        public IActionResult DailyGeneralLedgerReport2()
        {
            DateTime today = DateTime.Today;
            trans.aDailyCashes = _db.aDailyCashes.
                Where(z => (z.ValueDate <= today || z.lnClearedAmount != 0) && z.DelProduction != 0)
                .ToList();
            trans.date = today;
            return View("DailyGeneralLedgerReport", trans);
        }
        //---9-Get-ended - for Daily Geneeral Ledger  Report
        //POST -9 for Daily Geneeral Ledger  Report
        //---9-POST-ended - for Daily Geneeral Ledger  Report

        //Get -9 for DailySuppliersCashTransactionReport
        public IActionResult DailySuppliersCashTransactionReport2(String id, String hide)
        {
            trans.hide = Boolean.Parse(hide);
            if (id == null)
            {
                return NotFound();
            }
            id = id.Replace("-", "/");
            DateTime dateTime10 = DateTime.Parse(id);
            trans.date = dateTime10;
            trans.suppliers = _db.dailySuppliers.
                Where(z => z.ValueDate == dateTime10 && z.DelProduction != 0)
                .ToList();

            return View("DailySuppliersCashTransactionReport", trans);
        }
        //Get -9 for DailySuppliersCashTransactionReport
        public IActionResult DailySuppliersCashTransactionReport()
        {
            DateTime today = DateTime.Today;
            trans.date = today;
            trans.suppliers = new List<DailySuppliersCashTransactionReport>();
            return View(trans);
        }
        //---9-Get-ended - for DailySuppliersCashTransactionReport
        //POST -9 for DailySuppliersCashTransactionReport
        //---9-POST-ended - for DailySuppliersCashTransactionReport

        //Method in :AllDailyAccountsReport for All Daily Accounts Reports Referance 
        public IActionResult AllDailyAccountsReports()
        {
            DailyMeezan dM = new DailyMeezan();
            dM.aDailyCashes = _db.aDailyCashes.Where(i => i.DelProduction != 0).ToList().GroupBy(elem => elem.ValueDate).Select(group => group.First()); ;
            dM.Bank = _db.MeezanBankIEReports.Where(i => i.DelProduction != 0).ToList().GroupBy(elem => elem.ValueDate).Select(group => group.First()); ;
            dM.BankVo = _db.MeezanBankIEVouchers.ToList().GroupBy(elem => elem.dateTime).Select(group => group.First());
            dM.dSuppliers = _db.dailySuppliers.Where(i => i.DelProduction != 0).ToList().GroupBy(elem => elem.ValueDate).Select(group => group.First()); ;

            return View(dM);
        }
        //Method for :Daily Continue Report List
        public IActionResult DailyContinueReportList()
        {
            var distinctList = _db.aDailyCashes.ToList().GroupBy(elem => elem.ValueDate).Select(group => group.First()); ;
            return View(distinctList);

        }

        //Method for :Daily Transaction Report List
        public IActionResult DailyTransactionReportList()
        {
            var distinctList = _db.aDailyCashes.ToList().GroupBy(elem => elem.ValueDate).Select(group => group.First()); ;
            return View(distinctList);

        }

        //Method for :DailyMeezanbankReportList
        public IActionResult DailyMeezanbankReportList()
        {
            return View();

        }

        //Method for :DailyMeezanbankVoucherList
        public IActionResult DailyMeezanbankVoucherList()
        {
            return View();

        }


        //Method for :DailyCashClosingReportList
        public IActionResult DailyCashClosingReportList()
        {
            var distinctList = _db.aDailyCashes.ToList().GroupBy(elem => elem.ValueDate).Select(group => group.First()); ;
            return View(distinctList);
        }

        //Method for :DailySupplierReportList
        public IActionResult DailySupplierReportList()
        {
            return View();

        }

        //Method for :DailyCashClosingVoucherList
        public IActionResult DailyCashClosingVoucherList()
        {
            var distinctList = _db.aDailyCashes.ToList().GroupBy(elem => elem.ValueDate).Select(group => group.First()); ;
            return View(distinctList);
        }

        //GET -- Method for :Daily Cash Closing Voucher Report
        [HttpGet]
        public async Task<IActionResult> closngVoucher(String id, String hide)
        {
            trans.hide = Boolean.Parse(hide);
            if (id == null)
            {
                return NotFound();
            }
            id = id.Replace("-", "/");
            DateTime dateTime10 = DateTime.Parse(id);
            trans.date = dateTime10;
            trans.aDailyCashes = _db.aDailyCashes.
                Where(z => z.ValueDate <= dateTime10 && z.DelProduction != 0)
                .ToList();
            trans.images = _db.Images.Where(x => x.CreatedOn == dateTime10).ToList();
            return View("DailyClosingVoucherReport", trans);
        }

        //POST -- Method for :Daily Cash Closing Voucher Report
        [HttpPost]
        public IActionResult closngVoucher(List<IFormFile> files, String id)
        {
            id = id.Replace("-", "/");
            DateTime dateTime10 = DateTime.Parse(id);

            long size = files.Sum(f => f.Length);


            if (files != null)
            {
                foreach (var formFile in files)
                {
                    if (formFile.Length > 0)
                    {
                        //Getting FileName
                        var fileName = Path.GetFileName(formFile.FileName);
                        //Getting file Extension
                        var fileExtension = Path.GetExtension(fileName);
                        // concatenating  FileName + FileExtension
                        var newFileName = String.Concat(Convert.ToString(Guid.NewGuid()), fileExtension);

                        var objfiles = new Image()
                        {
                            Id = 0,
                            Name = newFileName,
                            FileType = fileExtension,
                            CreatedOn = dateTime10
                        };

                        using (var target = new MemoryStream())
                        {
                            formFile.CopyTo(target);
                            objfiles.DataFiles = target.ToArray();
                        }

                        _db.Images.Add(objfiles);
                        _db.SaveChanges();

                    }
                }
            }
            return RedirectToAction("AllDailyAccountsReports");
        }
        //Async -- Method for :Daily Cash Closing Voucher Report
        public async Task<IActionResult> closingVoucher()
        {
            DateTime today = DateTime.Today;
            trans.date = today;
            trans.aDailyCashes = _db.aDailyCashes.
                Where(z => (z.ValueDate <= today || z.lnClearedAmount != 0) && z.DelProduction != 0)
                .ToList();
            return View("DailyClosingVoucherReport", trans);
        }
        //GET -- Method For :External(Ledger) Fields in :Daily Cash Closing Report
        [HttpGet]
        public IActionResult DCCSupplierC()
        {
            return View();
        }
        //POST -- Method For :External(Ledger) Fields in :Daily Cash Closing Report
        [HttpPost]
        public IActionResult DCCSupplierC(DCashClosingSupplierLedger employeeEntities, DateTime DateDCCS, float Credit, float Debit, float TotalBillPay, float TotalBill, float TotalCash)
        {
            employeeEntities.DateDCCS = DateDCCS;
            employeeEntities.Credit = Credit;
            employeeEntities.Debit = Debit;
            employeeEntities.TotalBillPay = TotalBillPay;
            employeeEntities.TotalBill = TotalBill;
            employeeEntities.TotalCash = TotalCash;


            _db.DCashClosingSupplierLedgers.Add(employeeEntities);
            _db.SaveChanges();
            return RedirectToAction("AllDailyAccountsReports");


        }

        //Async -- Method for :Daily Continue Report (BankIndex--Name)
        public async Task<IActionResult> BankIndex()
        {
            TransAndBank trans = new TransAndBank();
            DateTime today = DateTime.Today;
            trans.Bank1 = _db.bankBalane.ToList();
            trans.aDailyCashes = _db.aDailyCashes.ToList();
            trans.date = today;
            return View("DailyCashClosingReport", trans);
        }

        //Async -- Method for :Daily Continue Report (BankIndex--Name)
        public async Task<IActionResult> BnkIndex(String id, String hide)
        {
            trans.hide = Boolean.Parse(hide);
            if (id == null)
            {
                return NotFound();
            }
            id = id.Replace("-", "/");
            DateTime dateTime10 = DateTime.Parse(id);
            trans.date = dateTime10;
            trans.Bank2 = _db.MeezanBankIEReports.ToList();

            trans.aDailyCashes = _db.aDailyCashes.
                Where(z => z.ValueDate <= dateTime10 && z.DelProduction != 0)
                .ToList();
            trans.DCCSupplier = _db.DCashClosingSupplierLedgers.Where(z => z.DateDCCS <= dateTime10)
                .ToList();
            return View("DailyCashClosingReport", trans);
        }
        // GET: BankBalanes/Details/5
        public async Task<IActionResult> BankDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bankBalane = await _db.bankBalane
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bankBalane == null)
            {
                return NotFound();
            }

            return View(bankBalane);
        }

        // GET: BankBalances/Create
        public IActionResult BankCreate()
        {
            return View();
        }

        // POST: BankBalances/New sheet Create file---
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> BankCreate([Bind("Id,BankBalance,deposit,transaction,tax,closingBankBalance,BankName")] BankBalane bankBalane)
        {
            if (ModelState.IsValid)
            {
                _db.Add(bankBalane);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(BankIndex));
            }
            return View();
        }

        // GET: BankBalanes/Edit file/5
        public async Task<IActionResult> BankEdit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bankBalane = await _db.bankBalane.FindAsync(id);
            if (bankBalane == null)
            {
                return NotFound();
            }
            return View(bankBalane);
        }

        // POST: BankBalanes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> BankEdit(int id, [Bind("Id,BankBalance,deposit,transaction,tax,closingBankBalance,BankName")] BankBalane bankBalane)
        {
            if (id != bankBalane.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _db.Update(bankBalane);
                    await _db.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BankBalaneExists(bankBalane.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(BankIndex));
            }
            return View(bankBalane);
        }

        // GET: BankBalanes/Delete file/5
        public async Task<IActionResult> BankDelete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bankBalane = await _db.bankBalane
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bankBalane == null)
            {
                return NotFound();
            }

            return View(bankBalane);
        }

        // POST: BankBalanes/Delete file confirmd/5
        [HttpPost, ActionName("BankDelete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> BankDeleteConfirmed(int id)
        {
            var bankBalane = await _db.bankBalane.FindAsync(id);
            _db.bankBalane.Remove(bankBalane);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(BankIndex));
        }

        private bool BankBalaneExists(int id)
        {
            return _db.bankBalane.Any(e => e.Id == id);
        }

        public IActionResult MeezanbankIEReport()
        {
            return View();

        }
        //ended Meezan bank incoem/expence report

        //here we add method for Meezan bank income/expence report voucher
        public IActionResult MeezanbankIEReportVoucher()
        {
            return View();

        }
        //ended Meezan bank incoem/expence report voucher
        //here Daily supplier report 
        public IActionResult DailySupplierReport()
        {
            return View();

        }
        //ended Daily supplier report
        public IActionResult Table()
        {
            return View();

        }

        // Method For :All Accounts Daily File Sending To :Send ToDgmOffice:
        public IActionResult SendToDgmOffice(string remarks)
        {
            remarks = remarks.Replace("-", "/");
            //_db.TechnicalStaffWorkPlans.RemoveRange(_db.TechnicalStaffWorkPlans.ToList().Where(x => x.Remarks.Equals(remarks)));
            //_db.SaveChanges();
            //return View("AjwTechnicalStaffWorkPlanList", _db.TechnicalStaffWorkPlans.ToList());
            List<aDailyCash> data = new List<aDailyCash>();
            DateTime dateTime10 = DateTime.Parse(remarks);
            data = _db.aDailyCashes.Where(i => i.ValueDate.Equals(dateTime10) && i.DelProduction != 0).ToList();

            foreach (aDailyCash technical in data)
            {
                technical.Status = "1";
                technical.DelCeo = 1;
                var current = _db.aDailyCashes.Find(technical.Id);
                if (current != null)
                {
                    _db.Entry(current).CurrentValues.SetValues(technical);
                }

                _db.SaveChanges();
            }
            return RedirectToAction("AllDailyAccountsReports");
            //return View("AjwTechnicalStaffWorkPlanList", _db.TechnicalStaffWorkPlans.ToList());
        }


        // Method for :File Sending : Daily Meezan Bank IE Report Send To DGM Office
        public IActionResult SendToDgmOfficeMeezan(string remarks)
        {
            remarks = remarks.Replace("-", "/");
            //_db.TechnicalStaffWorkPlans.RemoveRange(_db.TechnicalStaffWorkPlans.ToList().Where(x => x.Remarks.Equals(remarks)));
            //_db.SaveChanges();
            //return View("AjwTechnicalStaffWorkPlanList", _db.TechnicalStaffWorkPlans.ToList());
            List<MeezanBankIEReport> data = new List<MeezanBankIEReport>();
            DateTime dateTime10 = DateTime.Parse(remarks);
            data = _db.MeezanBankIEReports.Where(i => i.ValueDate.Equals(dateTime10) && i.DelProduction != 0).ToList();

            foreach (MeezanBankIEReport technical in data)
            {
                technical.Status = "1";
                technical.DelCeo = 1;
                var current = _db.MeezanBankIEReports.Find(technical.Id);
                if (current != null)
                {
                    _db.Entry(current).CurrentValues.SetValues(technical);
                }

                _db.SaveChanges();
            }
            return RedirectToAction("AllDailyAccountsReports");
            //return View("AjwTechnicalStaffWorkPlanList", _db.TechnicalStaffWorkPlans.ToList());
        }

        // Method For :File Sending : Daily Supplier Report To DGM Office
        public IActionResult SendToDgmOfficeSupplier(string remarks)
        {
            remarks = remarks.Replace("-", "/");
            //_db.TechnicalStaffWorkPlans.RemoveRange(_db.TechnicalStaffWorkPlans.ToList().Where(x => x.Remarks.Equals(remarks)));
            //_db.SaveChanges();
            //return View("AjwTechnicalStaffWorkPlanList", _db.TechnicalStaffWorkPlans.ToList());
            List<DailySuppliersCashTransactionReport> data = new List<DailySuppliersCashTransactionReport>();
            DateTime dateTime10 = DateTime.Parse(remarks);
            data = _db.dailySuppliers.Where(i => i.ValueDate.Equals(dateTime10) && i.DelProduction != 0).ToList();

            foreach (DailySuppliersCashTransactionReport technical in data)
            {
                technical.Status = "1";
                technical.DelGm = 1;
                technical.DelProduction = 1;
                technical.DelCeo = 1;
                var current = _db.dailySuppliers.Find(technical.Id);
                if (current != null)
                {
                    _db.Entry(current).CurrentValues.SetValues(technical);
                }

                _db.SaveChanges();
            }
            return RedirectToAction("AllDailyAccountsReports");
            //return View("AjwTechnicalStaffWorkPlanList", _db.TechnicalStaffWorkPlans.ToList());
        }

        // Method For :File Sending to DGM Office for Meezan Bank IE Report:
        public IActionResult SendToDgmOfficeBank(string remarks)
        {
            remarks = remarks.Replace("-", "/");
            //_db.TechnicalStaffWorkPlans.RemoveRange(_db.TechnicalStaffWorkPlans.ToList().Where(x => x.Remarks.Equals(remarks)));
            //_db.SaveChanges();
            //return View("AjwTechnicalStaffWorkPlanList", _db.TechnicalStaffWorkPlans.ToList());
            List<MeezanBankIEReport> data = new List<MeezanBankIEReport>();
            DateTime dateTime10 = DateTime.Parse(remarks);
            data = _db.MeezanBankIEReports.Where(i => i.ValueDate.Equals(dateTime10) && i.DelProduction != 0).ToList();

            foreach (MeezanBankIEReport technical in data)
            {
                technical.Status = "1";
                technical.DelGm = 1;
                var current = _db.MeezanBankIEReports.Find(technical.Id);
                if (current != null)
                {
                    _db.Entry(current).CurrentValues.SetValues(technical);
                }

                _db.SaveChanges();
            }
            return RedirectToAction("AllDailyAccountsReports");
            //return View("AjwTechnicalStaffWorkPlanList", _db.TechnicalStaffWorkPlans.ToList());
        }

        public IActionResult SendToDgmOfficeBank1(string remarks)
        {
            remarks = remarks.Replace("-", "/");
            //_db.TechnicalStaffWorkPlans.RemoveRange(_db.TechnicalStaffWorkPlans.ToList().Where(x => x.Remarks.Equals(remarks)));
            //_db.SaveChanges();
            //return View("AjwTechnicalStaffWorkPlanList", _db.TechnicalStaffWorkPlans.ToList());
            List<MeezanBankIEReport> data = new List<MeezanBankIEReport>();
            DateTime dateTime10 = DateTime.Parse(remarks);
            data = _db.MeezanBankIEReports.Where(i => i.ValueDate.Equals(dateTime10) && i.DelProduction != 0).ToList();

            foreach (MeezanBankIEReport technical in data)
            {
                technical.Status = "10";
                var current = _db.MeezanBankIEReports.Find(technical.Id);
                if (current != null)
                {
                    _db.Entry(current).CurrentValues.SetValues(technical);
                }

                _db.SaveChanges();
            }
            return RedirectToAction("AllDailyAccountsReports");
            //return View("AjwTechnicalStaffWorkPlanList", _db.TechnicalStaffWorkPlans.ToList());
        }

        //Method for :Inserting Data on Daily Accounts Report:
        public JsonResult InsertCustomers1(List<aDailyCash> data, String id)
        {

            //Truncate Table to delete all old records.
            //_db.Database.ExecuteSqlCommand("TRUNCATE TABLE [aDailyCashes]");
            //String dat = id.Date.ToString("dd-MM-yyyy");
            id = id.Replace("-", "/");
            DateTime dateTime10 = DateTime.Parse(id);
            //DateTime dateTime10 = id;
            trans.date = dateTime10;

            ////Check for NULL.
            if (data == null)
            {
                data = new List<aDailyCash>();
            }

            trans.aDailyCashes = _db.aDailyCashes.Where(z => z.ValueDate == dateTime10 || (z.ValueDate < dateTime10 && z.lnClearedAmount != 0) && z.DelProduction != 0).ToList();
            //List<int> intersection = trans.aDailyCashes.Cast<int>().Intersect(data.Cast<int>()).ToList();
            var list3 = trans.aDailyCashes.Except(data).ToList();
            //Loop and insert records.

            foreach (aDailyCash customer in data)
            {
                customer.DelProduction = 1;
                customer.DelGm = 1;
                customer.DelCeo = 1;
                _db.aDailyCashes.Add(customer);
            }

            int insertedRecords = _db.SaveChanges();
            return Json(insertedRecords);

        }


        //Method for :Inserting Data on Daily Accounts Report:
        public JsonResult InsertCustomers(List<aDailyCash> data, String id)
        {

            //Truncate Table to delete all old records.
            //_db.Database.ExecuteSqlCommand("TRUNCATE TABLE [aDailyCashes]");
            //String dat = id.Date.ToString("dd-MM-yyyy");
            id = id.Replace("-", "/");
            DateTime dateTime10 = DateTime.Parse(id);
            //DateTime dateTime10 = id;
            trans.date = dateTime10;

            ////Check for NULL.
            if (data == null)
            {
                data = new List<aDailyCash>();
            }

            trans.aDailyCashes = _db.aDailyCashes.Where(z => z.ValueDate == dateTime10 || (z.ValueDate < dateTime10 && z.lnClearedAmount != 0) && z.DelProduction != 0).ToList();
            //List<int> intersection = trans.aDailyCashes.Cast<int>().Intersect(data.Cast<int>()).ToList();
            var list3 = trans.aDailyCashes.Except(data).ToList();
            //Loop and insert records.
            foreach (aDailyCash customer in list3)
            {
                _db.aDailyCashes.Remove(customer);
            }

            foreach (aDailyCash customer in data)
            {
                customer.DelProduction = 1;
                customer.DelGm = 1;
                customer.DelCeo = 1;
                _db.aDailyCashes.Add(customer);
            }

            int insertedRecords = _db.SaveChanges();
            return Json(insertedRecords);

        }

        //Method for :Inserting Data On Daily General Ledger Report:
        public IActionResult InsertGeneralLedger(List<aDailyCash> data, String id)
        {
            //_db.TechnicalStaffWorkPlans.RemoveRange(_db.TechnicalStaffWorkPlans.ToList().Where(x => x.Remarks.Equals(remarks)));
            //_db.SaveChanges();
            //return View("AjwTechnicalStaffWorkPlanList", _db.TechnicalStaffWorkPlans.ToList());

            foreach (aDailyCash technical in data)
            {
                var current = _db.aDailyCashes.Find(technical.Id);
                current.LedgerType = technical.LedgerType;
                if (current != null)
                {
                    _db.Entry(current).CurrentValues.SetValues(current);
                }

                _db.SaveChanges();
            }
            return RedirectToAction("AllDailyAccountsReports");


        }


        public JsonResult InsertSuppliers1(List<DailySuppliersCashTransactionReport> data, String id)
        {

            //Truncate Table to delete all old records.
            //_db.Database.ExecuteSqlCommand("TRUNCATE TABLE [aDailyCashes]");
            //String dat = id.Date.ToString("dd-MM-yyyy");
            id = id.Replace("-", "/");
            DateTime dateTime10 = DateTime.Parse(id);
            //DateTime dateTime10 = id;
            trans.date = dateTime10;

            ////Check for NULL.
            if (data == null)
            {
                data = new List<DailySuppliersCashTransactionReport>();
            }

            trans.suppliers = _db.dailySuppliers.Where(z => z.ValueDate == dateTime10 || (z.ValueDate < dateTime10) && z.DelProduction != 0).ToList();
            //List<int> intersection = trans.aDailyCashes.Cast<int>().Intersect(data.Cast<int>()).ToList();
            var list3 = trans.suppliers.Except(data).ToList();
            //Loop and insert records.

            foreach (DailySuppliersCashTransactionReport customer in data)
            {
                customer.DelProduction = 1;
                customer.DelGm = 1;
                customer.DelCeo = 1;
                _db.dailySuppliers.Add(customer);
            }

            int insertedRecords = _db.SaveChanges();
            return Json(insertedRecords);

        }



        public JsonResult InsertSuppliers(List<DailySuppliersCashTransactionReport> data, String id)
        {

            //Truncate Table to delete all old records.
            //_db.Database.ExecuteSqlCommand("TRUNCATE TABLE [aDailyCashes]");
            //String dat = id.Date.ToString("dd-MM-yyyy");
            id = id.Replace("-", "/");
            DateTime dateTime10 = DateTime.Parse(id);
            //DateTime dateTime10 = id;
            trans.date = dateTime10;

            ////Check for NULL.
            if (data == null)
            {
                data = new List<DailySuppliersCashTransactionReport>();
            }

            trans.suppliers = _db.dailySuppliers.Where(z => z.ValueDate == dateTime10 || (z.ValueDate < dateTime10) && z.DelProduction != 0).ToList();
            //List<int> intersection = trans.aDailyCashes.Cast<int>().Intersect(data.Cast<int>()).ToList();
            var list3 = trans.suppliers.Except(data).ToList();
            //Loop and insert records.
            foreach (DailySuppliersCashTransactionReport customer in list3)
            {
                _db.dailySuppliers.Remove(customer);
            }

            foreach (DailySuppliersCashTransactionReport customer in data)
            {
                customer.DelProduction = 1;
                customer.DelGm = 1;
                customer.DelCeo = 1;
                _db.dailySuppliers.Add(customer);
            }

            int insertedRecords = _db.SaveChanges();
            return Json(insertedRecords);

        }



        public JsonResult InsertMeezan(List<MeezanBankIEReport> data)
        {

            ////Check for NULL.
            if (data == null)
            {
                data = new List<MeezanBankIEReport>();
            }
            DateTime id = new DateTime();
            foreach (MeezanBankIEReport meezan in data)
            {
                id = meezan.ValueDate;
            }
            //List<int> intersection = trans.aDailyCashes.Cast<int>().Intersect(data.Cast<int>()).ToList();
            var list3 = _db.MeezanBankIEReports.Where(z => z.ValueDate == id).ToList().Except(data).ToList();
            //Loop and insert records.
            foreach (MeezanBankIEReport customer in list3)
            {
                _db.MeezanBankIEReports.Remove(customer);
            }

            foreach (MeezanBankIEReport customer in data)
            {
                customer.DelProduction = 1;
                customer.DelGm = 1;
                customer.DelCeo = 1;
                customer.Status = "1";
                _db.MeezanBankIEReports.Add(customer);
            }

            int insertedRecords = _db.SaveChanges();
            return Json(insertedRecords);

        }


        // GET: Method for :Daily Meezan Bank Voucher Report:
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

        // POST: Method for :Daily Meezan Bank Voucher Report:
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
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

        // Method for :: Meezan Bank IE Voucher Report in Account Office
        public ActionResult IndexMeezanVoucher()
        {
            var distinctList = _db.MeezanBankIEVouchers.ToList().GroupBy(elem => elem.dateTime).Select(group => group.First()); ;
            return View(distinctList);
        }

    }
}
