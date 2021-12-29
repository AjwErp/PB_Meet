using AJWManagementPortal.Data;
using AJWManagementPortal.Models;
using Microsoft.AspNetCore.Http;
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
    public class MeezanController : Controller
    {
        private readonly ApplicationDbContext _context;
        // GET: MeezanController

        public MeezanController(ApplicationDbContext context)
        {
            _context = context;
        }

        public ActionResult Index()
        {
            return View(_context.MeezanBankIEReports.ToList());
        }

        public ActionResult IndexByDate(String id, String hide)
        {
            if (id == null)
            {
                return NotFound();
            }
            id = id.Replace("-", "/");
            DateTime dateTime10 = DateTime.Parse(id);

            ViewBag.hide = hide;

            return View("Index", _context.MeezanBankIEReports.
                Where(z => z.ValueDate <= dateTime10)
                .ToList());
        }


        // GET: MeezanController/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var meezan = await _context.MeezanBankIEReports
                .FirstOrDefaultAsync(m => m.Id == id);
            if (meezan == null)
            {
                return NotFound();
            }

            return View(meezan);
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
        public async Task<IActionResult> Create([Bind("Id,ValueDate,Description,ValueDate,CDO,Debit,Cradit,Balance,Imgceo,Imggm,Imgdgm,Imgam")] MeezanBankIEReport meezan)
        {
            if (ModelState.IsValid)
            {
                _context.Add(meezan);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(meezan);
        }

        // GET: MeezanController/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var meezan = await _context.MeezanBankIEReports.FindAsync(id);
            if (meezan == null)
            {
                return NotFound();
            }
            return View(meezan);
        }

        // POST: MeezanController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ValueDate,Description,ValueDate,CDO,Debit,Cradit,Balance,Imgceo,Imggm,Imgdgm,Imgam")] MeezanBankIEReport meezan)
        {
            if (id != meezan.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(meezan);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!meezanExists(meezan.Id))
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
            return View(meezan);
        }

        // GET: MeezanController/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var meezan = await _context.MeezanBankIEReports
                .FirstOrDefaultAsync(m => m.Id == id);
            if (meezan == null)
            {
                return NotFound();
            }

            return View(meezan);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var meezan = await _context.MeezanBankIEReports.FindAsync(id);
            _context.MeezanBankIEReports.Remove(meezan);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool meezanExists(int id)
        {
            return _context.MeezanBankIEReports.Any(e => e.Id == id);
        }



        public JsonResult InsertCustomers(List<MeezanBankIEReport> data)
        {

            ////Check for NULL.
            if (data == null)
            {
                data = new List<MeezanBankIEReport>();
            }

            //List<int> intersection = trans.aDailyCashes.Cast<int>().Intersect(data.Cast<int>()).ToList();
            var list3 = _context.MeezanBankIEReports.ToList().Except(data).ToList();
            //Loop and insert records.
            foreach (MeezanBankIEReport customer in list3)
            {
                _context.MeezanBankIEReports.Remove(customer);
            }

            foreach (MeezanBankIEReport customer in data)
            {
                _context.MeezanBankIEReports.Add(customer);
            }

            int insertedRecords = _context.SaveChanges();
            return Json(insertedRecords);

        }

        public IActionResult MeezanbankReportList()
        {
            var distinctList = _context.MeezanBankIEReports.ToList().GroupBy(elem => elem.ValueDate).Select(group => group.First()); ;

            return View(distinctList);

        }

        public async Task<IActionResult> DeleteByDate(String id, String redirect)
        {
            //id = id.Replace("-", "/");
            _context.MeezanBankIEReports.RemoveRange(_context.MeezanBankIEReports.ToList().Where(x => x.ValueDate.Date.ToString("dd-MM-yyyy") == id));
            _context.SaveChanges();
            var distinctList = _context.MeezanBankIEReports.ToList().GroupBy(elem => elem.ValueDate).Select(group => group.First()); ;

            return View(redirect, distinctList);
        }



        // GET: aDailyCashes/Create
        public IActionResult CreateMeezanVoucher(String id)
        {
            DateTime today = DateTime.Today;

            if (id == null)
            {
                id = today.ToString("yyyy-MM-dd");
                //return NotFound();
            }
            id = id.Replace("-", "/");
            DateTime dateTime10 = DateTime.Parse(id);

            ViewBag.Data = _context.MeezanBankIEReports.
                Where(z => z.ValueDate == dateTime10)
                .ToList();

            return View();

            
        }

        // POST: aDailyCashes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateMeezanVoucher([Bind("dateTime,checkNumber,amount,purpose,description")] MeezanBankIEVoucher meezan)
        {
            if (ModelState.IsValid)
            {
                _context.Add(meezan);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(CreateMeezanVoucher));
            }

            return View(meezan);
        }

        public ActionResult IndexMeezanVoucher()
        {
            var distinctList = _context.MeezanBankIEVouchers.ToList().GroupBy(elem => elem.dateTime).Select(group => group.First()); ;
            return View(distinctList);
        }

    }
}
