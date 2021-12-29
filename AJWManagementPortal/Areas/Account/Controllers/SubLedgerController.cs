using AJWManagementPortal.Data;
using AJWManagementPortal.Models;
using AJWManagementPortal.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Account.Controllers
{
    //This Controller for::SubLedgers for Account Office::
    [Area("Account")]
    public class SubLedgerController : Controller
    {
        private readonly ApplicationDbContext _db;

        [TempData]
        public string StatusMessage { get; set; }

        public SubLedgerController(ApplicationDbContext db)
        {
            _db = db;
        }

        //Get INDEX
        public async Task<IActionResult> Index()
        {
            var subLedgeries = await _db.SubLedgers.Include(s => s.Ledger).ToListAsync();
            return View(subLedgeries);
        }

        //GET - CREATE
        public async Task<IActionResult> Create()
        {
            SubLedgerAndLedgerViewModel model = new SubLedgerAndLedgerViewModel()
            {
                LedgerList = await _db.Ledgers.ToListAsync(),
                SubLedger = new Models.SubLedger(),
                SubLedgerList = await _db.SubLedgers.OrderBy(p => p.Name).Select(p => p.Name).Distinct().ToListAsync()
            };

            return View(model);
        }

        //POST - CREATE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(SubLedgerAndLedgerViewModel model)
        {
            if (ModelState.IsValid)
            {
                var doesSubLedgerExists = _db.SubLedgers.Include(s => s.Ledger).Where(s => s.Name == model.SubLedger.Name && s.Ledger.Id == model.SubLedger.LedgerId);

                if (doesSubLedgerExists.Count() > 0)
                {
                    //Error
                    StatusMessage = "Error : Sub Ledger exists under " + doesSubLedgerExists.First().Ledger.LedgerName + " ledger. Please use another name.";
                }
                else
                {
                    _db.SubLedgers.Add(model.SubLedger);
                    await _db.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }
            SubLedgerAndLedgerViewModel modelVM = new SubLedgerAndLedgerViewModel()
            {
                LedgerList = await _db.Ledgers.ToListAsync(),
                SubLedger = model.SubLedger,
                SubLedgerList = await _db.SubLedgers.OrderBy(p => p.Name).Select(p => p.Name).ToListAsync(),
                StatusMessage = StatusMessage
            };
            return View(modelVM);
        }


        [ActionName("GetSubLedger")]
        public async Task<IActionResult> GetSubLedger(int id)
        {
            List<SubLedger> subLedgeries = new List<SubLedger>();

            subLedgeries = await (from subLedger in _db.SubLedgers
                                  where subLedger.LedgerId == id
                                  select subLedger).ToListAsync();

            return Json(new SelectList(subLedgeries, "LedgerId", "Name"));
      
        }


        //GET - EDIT action subledger form
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subLedger = await _db.SubLedgers.SingleOrDefaultAsync(m => m.Id == id);

            if (subLedger == null)
            {
                return NotFound();
            }

            SubLedgerAndLedgerViewModel model = new SubLedgerAndLedgerViewModel()
            {
                LedgerList = await _db.Ledgers.ToListAsync(),
                SubLedger = subLedger,
                SubLedgerList = await _db.SubLedgers.OrderBy(p => p.Name).Select(p => p.Name).Distinct().ToListAsync()
            };

            return View(model);
        }

        //POST - EDIT
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(SubLedgerAndLedgerViewModel model)
        {
            if (ModelState.IsValid)
            {
                var doesSubLedgerExists = _db.SubLedgers.Include(s => s.Ledger).Where(s => s.Name == model.SubLedger.Name && s.Ledger.Id == model.SubLedger.LedgerId);

                if (doesSubLedgerExists.Count() > 0)
                {
                    //Error
                    StatusMessage = "Error : Sub Ledger exists under " + doesSubLedgerExists.First().Ledger.LedgerName + " ledger. Please use another name.";
                }
                else
                {
                    var subCatFromDb = await _db.SubLedgers.FindAsync(model.SubLedger.LedgerId);
                    subCatFromDb.Name = model.SubLedger.Name;

                    await _db.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }
            SubLedgerAndLedgerViewModel modelVM = new SubLedgerAndLedgerViewModel()
            {
                LedgerList = await _db.Ledgers.ToListAsync(),
                SubLedger = model.SubLedger,
                SubLedgerList = await _db.SubLedgers.OrderBy(p => p.Name).Select(p => p.Name).ToListAsync(),
                StatusMessage = StatusMessage
            };
            //modelVM.SubCategory.Id = id;
            return View(modelVM);
        }

        //GET Details
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var subLedger = await _db.SubLedgers.Include(s => s.Ledger).SingleOrDefaultAsync(m => m.Id == id);
            if (subLedger == null)
            {
                return NotFound();
            }

            return View(subLedger);
        }

        //GET Delete
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var subLedger = await _db.SubLedgers.Include(s => s.Ledger).SingleOrDefaultAsync(m => m.Id == id);
            if (subLedger == null)
            {
                return NotFound();
            }

            return View(subLedger);
        }

        //POST Delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var subLedger = await _db.SubLedgers.SingleOrDefaultAsync(m => m.Id == id);
            _db.SubLedgers.Remove(subLedger);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }

    }
}
