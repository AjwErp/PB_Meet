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

namespace AJWManagementPortal.Areas.Gm.Controllers
{
    //This Controller for ::Daily Reports for Account office::
    [Area("Gm")]
    public class DailyAccountReportController : Controller
    {
        TransAndBank trans = new TransAndBank();
        private readonly ApplicationDbContext _db;
        DailyTransactionReportM DTReport = new DailyTransactionReportM();
        //private readonly IWebHostEnvironment _iwebhost;
        //IWebHostEnvironment iwebhost
        //                _iwebhost = iwebhost;

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
                Where(z => z.ValueDate <= dateTime10 && z.DelGm !=0 && (Convert.ToInt32(z.Status) >= 2 && Convert.ToInt32(z.Status) <= 3))
                .ToList();

            return View("DailyContinueReport", trans);
        }

        public async Task<IActionResult> Index()
        {
            DateTime today = DateTime.Today;
            trans.aDailyCashes = _db.aDailyCashes.
                Where(z => z.ValueDate <= today && z.DelGm != 0 && (Convert.ToInt32(z.Status) >= 2 && Convert.ToInt32(z.Status) <= 3))
                .ToList();
            trans.date = today;
            List<aDailyCash> a = new List<aDailyCash>();
            trans.aDailyCashes = a;
            return View(trans);
        }


        public async Task<IActionResult> DeleteSheet(String remarks)
        {
            remarks = remarks.Replace("-", "/");
            //_db.TechnicalStaffWorkPlans.RemoveRange(_db.TechnicalStaffWorkPlans.ToList().Where(x => x.Remarks.Equals(remarks)));
            //_db.SaveChanges();
            //return View("AjwTechnicalStaffWorkPlanList", _db.TechnicalStaffWorkPlans.ToList());
            List<aDailyCash> data = new List<aDailyCash>();
            DateTime dateTime10 = DateTime.Parse(remarks);
            data = _db.aDailyCashes.Where(i => i.ValueDate.Equals(dateTime10) && i.DelGm != 0 && (Convert.ToInt32(i.Status) >= 2 && Convert.ToInt32(i.Status) <= 3)).ToList();

            foreach (aDailyCash technical in data)
            {
                technical.DelGm = 0;
                var current = _db.aDailyCashes.Find(technical.Id);
                if (current != null)
                {
                    _db.Entry(current).CurrentValues.SetValues(technical);
                }

                _db.SaveChanges();
            }
            return RedirectToAction("AllDailyAccountsReports");
        }

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
                technical.DelGm = 0;
                var current = _db.dailySuppliers.Find(technical.Id);
                if (current != null)
                {
                    _db.Entry(current).CurrentValues.SetValues(technical);
                }

                _db.SaveChanges();
            }
            return RedirectToAction("AllDailyAccountsReports");
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
                technical.DelGm = 0;
                var current = _db.MeezanBankIEReports.Find(technical.Id);
                if (current != null)
                {
                    _db.Entry(current).CurrentValues.SetValues(technical);
                }

                _db.SaveChanges();
            }
            return RedirectToAction("AllDailyAccountsReports");
        }
        public async Task<IActionResult> DeleteByDate(String id, String redirect)
        {
            //id = id.Replace("-", "/");
            _db.aDailyCashes.RemoveRange(_db.aDailyCashes.ToList().Where(x => x.ValueDate.Date.ToString("dd-MM-yyyy") == id));
            _db.SaveChanges();
            var distinctList = _db.aDailyCashes.ToList().GroupBy(elem => elem.ValueDate).Select(group => group.First()); ;

            return View(redirect, distinctList);
        }

        //Get -1 for Daily Continue Report
        public IActionResult DailyContinueReport()
        {
            DateTime today = DateTime.Today;
            //trans.aDailyCashes = _db.aDailyCashes.
            //    Where(z => z.ValueDate <= today && z.DelGm != 0 && (Convert.ToInt32(z.Status) >= 2 && Convert.ToInt32(z.Status) <= 3))
            //    .ToList();
            trans.date = today;
            return View("DailyContinueReport2", trans);
        }
        //---1-Get-ended - for Daily Continue Report
        //POST -1 for Daily Continue Report
        //---1-POST-ended - for Daily Continue Report

        public async Task<IActionResult> TransactionSheet(String id, String hide)
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
                Where(z => z.ValueDate <= dateTime10 && z.DelGm != 0 && (Convert.ToInt32(z.Status) >= 2 && Convert.ToInt32(z.Status) <= 3))
                .ToList();

            return View("DailyTransactionReport", trans);
        }

        public async Task<IActionResult> TransactionSheet2()
        {
            DateTime today = DateTime.Today;
            trans.aDailyCashes = _db.aDailyCashes.
                Where(z => (z.ValueDate <= today || z.lnClearedAmount != 0) && z.DelGm != 0 && (Convert.ToInt32(z.Status) >= 2 && Convert.ToInt32(z.Status) <= 3))
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
            return View(_db.MeezanBankIEReports.Where(q => q.DelGm != 0).ToList());
        }//Get -3 for Daily Meezan bank income/Expence Report
        public IActionResult DailyMeezanBankIEReport2(String Id, String hide)
        {
            Id = Id.Replace("-", "/");
            DateTime dateTime10 = DateTime.Parse(Id);
            return View("DailyMeezanBankIEReport", _db.MeezanBankIEReports.Where(q => q.ValueDate.Equals(dateTime10) && q.DelGm != 0).ToList());
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
                Where(z => z.ValueDate <= dateTime10 && z.DelGm != 0)
                .ToList();
            return View("DailyGeneralLedgerReport", trans);
        }

        public IActionResult DailyGeneralLedgerReport2()
        {
            DateTime today = DateTime.Today;
            trans.aDailyCashes = _db.aDailyCashes.
                Where(z => (z.ValueDate <= today || z.lnClearedAmount != 0) && z.DelGm != 0)
                .ToList();
            trans.date = today;
            return View("DailyGeneralLedgerReport", trans);
        }
        //---9-Get-ended - for Daily Geneeral Ledger  Report
        //POST -9 for Daily Geneeral Ledger  Report
        //---9-POST-ended - for Daily Geneeral Ledger  Report
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
                Where(z => z.ValueDate == dateTime10 && z.DelGm != 0)
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
        public IActionResult AllDailyAccountsReports()
        {
            DailyMeezan dM = new DailyMeezan();
            dM.aDailyCashes = _db.aDailyCashes.Where(i => i.DelGm != 0 && (Convert.ToInt32(i.Status) >= 2 && Convert.ToInt32(i.Status) <= 3)).ToList().GroupBy(elem => elem.ValueDate).Select(group => group.First()); ;
            dM.Bank = _db.MeezanBankIEReports.Where(i => i.DelGm != 0 && (Convert.ToInt32(i.Status) >= 2 && Convert.ToInt32(i.Status) <= 3)).ToList().GroupBy(elem => elem.ValueDate).Select(group => group.First()); ;
            dM.BankVo = _db.MeezanBankIEVouchers.ToList().GroupBy(elem => elem.dateTime).Select(group => group.First());
            dM.dSuppliers = _db.dailySuppliers.Where(i => i.DelGm != 0 && (Convert.ToInt32(i.Status) >= 2 && Convert.ToInt32(i.Status) <= 3)).ToList().GroupBy(elem => elem.ValueDate).Select(group => group.First()); ;
            return View(dM);
        }

        public IActionResult DailyContinueReportList()
        {
            var distinctList = _db.aDailyCashes.ToList().GroupBy(elem => elem.ValueDate).Select(group => group.First()); ;
            return View(distinctList);

        }
        //ended daily continue report list
        //Daily Transaction Report List
        public IActionResult DailyTransactionReportList()
        {
            var distinctList = _db.aDailyCashes.ToList().GroupBy(elem => elem.ValueDate).Select(group => group.First()); ;
            return View(distinctList);

        }
        //ended Daily Transaction Report List
        //DailyMeezanbankReportList
        public IActionResult DailyMeezanbankReportList()
        {
            return View();

        }
        //ended DailyMeezanbankReportList
        //DailyMeezanbankVoucherList
        public IActionResult DailyMeezanbankVoucherList()
        {
            return View();

        }
        //ended DailyMeezanbankVoucherList

        //DailyCashClosingReportList
        public IActionResult DailyCashClosingReportList()
        {
            var distinctList = _db.aDailyCashes.ToList().GroupBy(elem => elem.ValueDate).Select(group => group.First()); ;
            return View(distinctList);
        }
        //ended DailyCashClosingReportList
        //DailyCashClosingReportList
        public IActionResult DailySupplierReportList()
        {
            return View();

        }
        //ended DailyCashClosingReportList

        //DailyCashClosingVoucherList
        public IActionResult DailyCashClosingVoucherList()
        {
            var distinctList = _db.aDailyCashes.ToList().GroupBy(elem => elem.ValueDate).Select(group => group.First()); ;
            return View(distinctList);
        }
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
                Where(z => z.ValueDate <= dateTime10 && z.DelGm != 0 && (Convert.ToInt32(z.Status) >= 2 && Convert.ToInt32(z.Status) <= 3))
                .ToList();
            trans.images = _db.Images.Where(x => x.CreatedOn == dateTime10).ToList();

            return View("DailyClosingVoucherReport", trans);
        }

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


        public async Task<IActionResult> closingVoucher()
        {
            DateTime today = DateTime.Today;
            trans.date = today;
            trans.aDailyCashes = _db.aDailyCashes.
                Where(z => (z.ValueDate <= today || z.lnClearedAmount != 0) && z.DelGm != 0 && (Convert.ToInt32(z.Status) >= 2 && Convert.ToInt32(z.Status) <= 3))
                .ToList();
            return View("DailyClosingVoucherReport", trans);
        }




        public async Task<IActionResult> BankIndex()
        {
            TransAndBank trans = new TransAndBank();
            DateTime today = DateTime.Today;
            trans.Bank1 = _db.bankBalane.ToList();
            trans.aDailyCashes = _db.aDailyCashes.ToList();
            trans.date = today;
            return View("DailyCashClosingReport", trans);
        }

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
                Where(z => z.ValueDate <= dateTime10 && z.DelGm != 0 && (Convert.ToInt32(z.Status) >= 2 && Convert.ToInt32(z.Status) <= 3))
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

        // GET: BankBalanes/Create
        public IActionResult BankCreate()
        {
            return View();
        }

        // POST: BankBalanes/Create
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

        // GET: BankBalanes/Edit/5
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

        // GET: BankBalanes/Delete/5
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

        // POST: BankBalanes/Delete/5
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


        public IActionResult SendToDgmOffice(string remarks)
        {
            remarks = remarks.Replace("-", "/");
            //_db.TechnicalStaffWorkPlans.RemoveRange(_db.TechnicalStaffWorkPlans.ToList().Where(x => x.Remarks.Equals(remarks)));
            //_db.SaveChanges();
            //return View("AjwTechnicalStaffWorkPlanList", _db.TechnicalStaffWorkPlans.ToList());
            List<aDailyCash> data = new List<aDailyCash>();
            DateTime dateTime10 = DateTime.Parse(remarks);
            data = _db.aDailyCashes.Where(i => i.ValueDate.Equals(dateTime10) && i.DelGm!= 0 && (Convert.ToInt32(i.Status) >= 2 && Convert.ToInt32(i.Status) <= 3)).ToList();

            foreach (aDailyCash technical in data)
            {
                technical.Status = "6";
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



        public IActionResult SendToAccountOffice(string remarks)
        {
            remarks = remarks.Replace("-", "/");
            //_db.TechnicalStaffWorkPlans.RemoveRange(_db.TechnicalStaffWorkPlans.ToList().Where(x => x.Remarks.Equals(remarks)));
            //_db.SaveChanges();
            //return View("AjwTechnicalStaffWorkPlanList", _db.TechnicalStaffWorkPlans.ToList());
            List<aDailyCash> data = new List<aDailyCash>();
            DateTime dateTime10 = DateTime.Parse(remarks);
            data = _db.aDailyCashes.Where(i => i.ValueDate.Equals(dateTime10) && i.DelGm != 0 && (Convert.ToInt32(i.Status) >= 2 && Convert.ToInt32(i.Status) <= 3)).ToList();

            foreach (aDailyCash technical in data)
            {
                technical.Status = "5";
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



        public IActionResult SendToAccountOfficeSupplier(string remarks)
        {
            remarks = remarks.Replace("-", "/");
            //_db.TechnicalStaffWorkPlans.RemoveRange(_db.TechnicalStaffWorkPlans.ToList().Where(x => x.Remarks.Equals(remarks)));
            //_db.SaveChanges();
            //return View("AjwTechnicalStaffWorkPlanList", _db.TechnicalStaffWorkPlans.ToList());
            List<DailySuppliersCashTransactionReport> data = new List<DailySuppliersCashTransactionReport>();
            DateTime dateTime10 = DateTime.Parse(remarks);
            data = _db.dailySuppliers.Where(i => i.ValueDate.Equals(dateTime10) && i.DelGm != 0 && (Convert.ToInt32(i.Status) >= 2 && Convert.ToInt32(i.Status) <= 3)).ToList();

            foreach (DailySuppliersCashTransactionReport technical in data)
            {
                technical.Status = "5";
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



        public IActionResult SendToAccountOfficeBank(string remarks)
        {
            remarks = remarks.Replace("-", "/");
            //_db.TechnicalStaffWorkPlans.RemoveRange(_db.TechnicalStaffWorkPlans.ToList().Where(x => x.Remarks.Equals(remarks)));
            //_db.SaveChanges();
            //return View("AjwTechnicalStaffWorkPlanList", _db.TechnicalStaffWorkPlans.ToList());
            List<MeezanBankIEReport> data = new List<MeezanBankIEReport>();
            DateTime dateTime10 = DateTime.Parse(remarks);
            data = _db.MeezanBankIEReports.Where(i => i.ValueDate.Equals(dateTime10) && i.DelGm != 0 && (Convert.ToInt32(i.Status) >= 2 && Convert.ToInt32(i.Status) <= 3)).ToList();

            foreach (MeezanBankIEReport technical in data)
            {
                technical.Status = "5";
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

        public IActionResult SendToGmOfficeSuppliers(string remarks)
        {
            remarks = remarks.Replace("-", "/");
            //_db.TechnicalStaffWorkPlans.RemoveRange(_db.TechnicalStaffWorkPlans.ToList().Where(x => x.Remarks.Equals(remarks)));
            //_db.SaveChanges();
            //return View("AjwTechnicalStaffWorkPlanList", _db.TechnicalStaffWorkPlans.ToList());
            List<DailySuppliersCashTransactionReport> data = new List<DailySuppliersCashTransactionReport>();
            DateTime dateTime10 = DateTime.Parse(remarks);
            data = _db.dailySuppliers.Where(i => i.ValueDate.Equals(dateTime10) && i.DelGm!= 0 && (Convert.ToInt32(i.Status) >= 2 && Convert.ToInt32(i.Status) <= 3)).ToList();

            foreach (DailySuppliersCashTransactionReport technical in data)
            {
                technical.Status = "2";
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


        public IActionResult SendToGmOfficeBank(string remarks)
        {
            remarks = remarks.Replace("-", "/");
            //_db.TechnicalStaffWorkPlans.RemoveRange(_db.TechnicalStaffWorkPlans.ToList().Where(x => x.Remarks.Equals(remarks)));
            //_db.SaveChanges();
            //return View("AjwTechnicalStaffWorkPlanList", _db.TechnicalStaffWorkPlans.ToList());
            List<MeezanBankIEReport> data = new List<MeezanBankIEReport>();
            DateTime dateTime10 = DateTime.Parse(remarks);
            data = _db.MeezanBankIEReports.Where(i => i.ValueDate.Equals(dateTime10) && i.DelGm != 0).ToList();

            foreach (MeezanBankIEReport technical in data)
            {
                technical.Status = "2";
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

            trans.aDailyCashes = _db.aDailyCashes.Where(z => z.ValueDate == dateTime10 || (z.ValueDate < dateTime10 && z.lnClearedAmount != 0) && z.DelGm!= 0 && (Convert.ToInt32(z.Status) >= 2 && Convert.ToInt32(z.Status) <= 3)).ToList();
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

            trans.aDailyCashes = _db.aDailyCashes.Where(z => z.ValueDate == dateTime10 || (z.ValueDate < dateTime10 && z.lnClearedAmount != 0) && z.DelGm!= 0 && (Convert.ToInt32(z.Status) >= 2 && Convert.ToInt32(z.Status) <= 3)).ToList();
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

            trans.suppliers = _db.dailySuppliers.Where(z => z.ValueDate == dateTime10 || (z.ValueDate < dateTime10) && z.DelGm != 0).ToList();
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

            trans.suppliers = _db.dailySuppliers.Where(z => z.ValueDate == dateTime10 || (z.ValueDate < dateTime10) && z.DelGm != 0).ToList();
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
                _db.MeezanBankIEReports.Add(customer);
            }

            int insertedRecords = _db.SaveChanges();
            return Json(insertedRecords);

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

            ViewBag.Data1 = _db.MeezanBankIEVouchers.Where(z => z.dateTime <= dateTime10).ToList();

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

            meezan.description = "";
            meezan.Title = "";
            meezan.Status = "";
            meezan.SignGM = "";
            meezan.SignCeo = "";
            meezan.Remarks = "";
            meezan.GMRemarks = "";
            meezan.dateTime = dateTime10;
            meezan.CeoRemarks = "";
            _db.Add(meezan);
            await _db.SaveChangesAsync();
            //return RedirectToAction(nameof(DailyMeezanBankVoucherReport));



            ViewBag.Data = _db.MeezanBankIEReports.
                Where(z => z.ValueDate <= dateTime10)
                .ToList();

            ViewBag.Data1 = _db.MeezanBankIEVouchers.Where(z => z.dateTime <= dateTime10).ToList();

            return View(meezan);
        }

        public ActionResult IndexMeezanVoucher()
        {
            var distinctList = _db.MeezanBankIEVouchers.ToList().GroupBy(elem => elem.dateTime).Select(group => group.First()); ;
            return View(distinctList);
        }




    }
}
