using AJWManagementPortal.Data;
using AJWManagementPortal.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AJWManagementPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Sheets.Controllers
{
    [Area("Sheets")]

    public class aDailyCashesController : Controller
    {   
        private readonly ApplicationDbContext _context;
        TransAndBank trans = new TransAndBank();


        public aDailyCashesController(ApplicationDbContext context)
        {
            _context = context;
            trans.Bank1 = _context.bankBalane.ToList();
            trans.Bank2 = _context.MeezanBankIEReports.ToList();
        }

        // GET: aDailyCashes
        public async Task<IActionResult> IndexByName(String id,String hide)
        {
            trans.hide = Boolean.Parse(hide);
            if (id == null)
            {
                return NotFound();
            }
            id = id.Replace("-", "/");
            DateTime dateTime10 = DateTime.Parse(id);
            trans.date = dateTime10;
            trans.aDailyCashes = _context.aDailyCashes.
                Where(z => z.ValueDate <= dateTime10)
                .ToList();

            return View("Index", trans);
        }

        public async Task<IActionResult> Index()
        {
            DateTime today = DateTime.Today;
            trans.aDailyCashes = _context.aDailyCashes.
                Where(z => z.ValueDate <= today)
                .ToList();
            trans.date = today;
            return View(trans);
        }


        public async Task<IActionResult> tranSheet(String id,String hide)
        {
            if (id == null)
            {
                return NotFound();
            }
            trans.hide = Boolean.Parse(hide);
            id = id.Replace("-", "/");
            DateTime dateTime10 = DateTime.Parse(id);
            trans.date = dateTime10;
            trans.aDailyCashes = _context.aDailyCashes.
                Where(z => z.ValueDate <= dateTime10)
                .ToList();

            return View("transSheet", trans);
        }

        public async Task<IActionResult> transSheet()
        {
            DateTime today = DateTime.Today;
            trans.aDailyCashes = _context.aDailyCashes.
                Where(z => z.ValueDate <= today || z.lnClearedAmount != 0)
                .ToList();
            trans.date = today;
            return View(trans);
        }

        public async Task<IActionResult> BankBalance()
        {
            return View(trans);
        }

        public async Task<IActionResult> closngVoucher(String id,String hide)
        {
            trans.hide = Boolean.Parse(hide);
            if (id == null)
            {
                return NotFound();
            }
            id = id.Replace("-", "/");
            DateTime dateTime10 = DateTime.Parse(id);
            trans.date = dateTime10;
            trans.aDailyCashes = _context.aDailyCashes.
                Where(z => z.ValueDate <= dateTime10)
                .ToList();

            return View("closingVoucher", trans);
        }

        public async Task<IActionResult> closingVoucher()
        {
            DateTime today = DateTime.Today;
            trans.date = today;
            trans.aDailyCashes = _context.aDailyCashes.
                Where(z => z.ValueDate <= today || z.lnClearedAmount != 0)
                .ToList();
            return View(trans);
        }



        // GET: aDailyCashes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aDailyCash = await _context.aDailyCashes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (aDailyCash == null)
            {
                return NotFound();
            }

            return View(aDailyCash);
        }

        // GET: aDailyCashes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: aDailyCashes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Description,ValueDate,paidAmount,clearedAmount,lnClearedAmount,remainingGained,surplus,purchaser,income")] aDailyCash aDailyCash)
        {
            if (ModelState.IsValid)
            {
                _context.Add(aDailyCash);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(aDailyCash);
        }

        // GET: aDailyCashes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aDailyCash = await _context.aDailyCashes.FindAsync(id);
            if (aDailyCash == null)
            {
                return NotFound();
            }
            return View(aDailyCash);
        }

        // POST: aDailyCashes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Description,ValueDate,paidAmount,clearedAmount,lnClearedAmount,remainingGained,surplus,purchaser,income")] aDailyCash aDailyCash)
        {
            if (id != aDailyCash.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(aDailyCash);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!aDailyCashExists(aDailyCash.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(aDailyCash);
        }

        // GET: aDailyCashes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aDailyCash = await _context.aDailyCashes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (aDailyCash == null)
            {
                return NotFound();
            }

            return View(aDailyCash);
        }

        // POST: aDailyCashes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var aDailyCash = await _context.aDailyCashes.FindAsync(id);
            _context.aDailyCashes.Remove(aDailyCash);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool aDailyCashExists(int id)
        {
            return _context.aDailyCashes.Any(e => e.Id == id);
        }


        public JsonResult InsertCustomers(List<aDailyCash> data, DateTime id)
        {

            //Truncate Table to delete all old records.
            //_context.Database.ExecuteSqlCommand("TRUNCATE TABLE [aDailyCashes]");
            String dat = id.Date.ToString("dd-MM-yyyy");
            //id = id.Replace("-", "/");
            //DateTime dateTime10 = DateTime.Parse(id);
            DateTime dateTime10 = id;
            trans.date = dateTime10;

            ////Check for NULL.
            if (data == null)
            {
                data = new List<aDailyCash>();
            }

            trans.aDailyCashes = _context.aDailyCashes.Where(z => z.ValueDate == dateTime10 || (z.ValueDate < dateTime10 && z.lnClearedAmount != 0)).ToList();
            //List<int> intersection = trans.aDailyCashes.Cast<int>().Intersect(data.Cast<int>()).ToList();
            var list3 = trans.aDailyCashes.Except(data).ToList();
            //Loop and insert records.
            foreach (aDailyCash customer in list3)
            {
                _context.aDailyCashes.Remove(customer);
            }

            foreach (aDailyCash customer in data)
            {
                _context.aDailyCashes.Add(customer);
            }

            int insertedRecords = _context.SaveChanges();
            return Json(insertedRecords);

        }

        public async Task<IActionResult> sheetList()
        {
            return View(_context.aDailyCashes.Select(a => a.ValueDate).Distinct().ToList());
        }

        public async Task<IActionResult> tranSheetList()
        {
            return View(_context.aDailyCashes.Select(a => a.ValueDate).Distinct().ToList());
        }

        //BankBalane
        // GET: BankBalanes
        public async Task<IActionResult> BnkIndex(String id,String hide)
        {
            trans.hide = Boolean.Parse(hide);
            if (id == null)
            {
                return NotFound();
            }
            id = id.Replace("-", "/");
            DateTime dateTime10 = DateTime.Parse(id);
            trans.date = dateTime10;
            trans.Bank2 = _context.MeezanBankIEReports.ToList();
            trans.aDailyCashes = _context.aDailyCashes.
                Where(z => z.ValueDate <= dateTime10)
                .ToList();

            return View("BankIndex", trans);
        }

        public async Task<IActionResult> BankIndex()
        {
            TransAndBank trans = new TransAndBank();
            DateTime today = DateTime.Today;
            trans.Bank1 = _context.bankBalane.ToList();
            trans.aDailyCashes = _context.aDailyCashes.ToList();
            trans.date = today;
            return View(trans);
        }

        // GET: BankBalanes/Details/5
        public async Task<IActionResult> BankDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bankBalane = await _context.bankBalane
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
                _context.Add(bankBalane);
                await _context.SaveChangesAsync();
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

            var bankBalane = await _context.bankBalane.FindAsync(id);
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
                    _context.Update(bankBalane);
                    await _context.SaveChangesAsync();
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

            var bankBalane = await _context.bankBalane
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
            var bankBalane = await _context.bankBalane.FindAsync(id);
            _context.bankBalane.Remove(bankBalane);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(BankIndex));
        }

        private bool BankBalaneExists(int id)
        {
            return _context.bankBalane.Any(e => e.Id == id);
        }
        //here we add method for Meezan bank income/expence report
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
        //ended Meezan bank incoem/expence report voucher
        //daily continue report list
        public IActionResult DailyContinueReportList()
        {
            var distinctList = _context.aDailyCashes.ToList().GroupBy(elem => elem.ValueDate).Select(group => group.First()); ;
            return View(distinctList);

        }
        //ended daily continue report list
        //Daily Transaction Report List
        public IActionResult DailyTransactionReportList()
        {
            var distinctList = _context.aDailyCashes.ToList().GroupBy(elem => elem.ValueDate).Select(group => group.First()); ;
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
            var distinctList = _context.aDailyCashes.ToList().GroupBy(elem => elem.ValueDate).Select(group => group.First()); ;
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
            var distinctList = _context.aDailyCashes.ToList().GroupBy(elem => elem.ValueDate).Select(group => group.First()); ;
            return View(distinctList);
        }
        //ended DailyCashClosingVoucherList

        public async Task<IActionResult> DeleteByDate(String id, String redirect)
        {
            //id = id.Replace("-", "/");
            _context.aDailyCashes.RemoveRange(_context.aDailyCashes.ToList().Where(x => x.ValueDate.Date.ToString("dd-MM-yyyy") == id));
            _context.SaveChanges();
            var distinctList = _context.aDailyCashes.ToList().GroupBy(elem => elem.ValueDate).Select(group => group.First()); ;

            return View(redirect,distinctList);
        }


        
    }
}
