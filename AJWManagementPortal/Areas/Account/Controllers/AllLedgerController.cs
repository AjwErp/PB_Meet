using AJWManagementPortal.Data;
using AJWManagementPortal.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Account.Controllers
{ 
    //This Controller for ::Account Office Ledgers & SubLedger Reports::
    [Area("Account")]
    public class AllLedgerController : Controller
    {
            //create ApplicationDbContext constructor
            private readonly ApplicationDbContext _db;

            public AllLedgerController(ApplicationDbContext db)
            {
                _db = db;
            }

        //GET Index for All Ledgers
        public async Task<IActionResult> Index()
        {
            return View(await _db.Ledgers.ToListAsync());
        }
        //GET - CREATE
            public IActionResult Create()
        {
            return View();
        }


        //POST - CREATE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Ledger ledger)
        {
            if (ModelState.IsValid)
            {
                //if valid
                _db.Ledgers.Add(ledger);
                await _db.SaveChangesAsync();

                return RedirectToAction(nameof(Index));

            }
            return View(ledger);
        }
        //GET - EDIT
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var ledger = await _db.Ledgers.FindAsync(id);
            if (ledger == null)
            {
                return NotFound();
            }
            return View(ledger);

        }
        //POST Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Ledger ledger)
        {
            if (ModelState.IsValid)
            {
                _db.Update(ledger);
                await _db.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            return View(ledger);
        }
        //GET - DELETE
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var ledger = await _db.Ledgers.FindAsync(id);
            if (ledger == null)
            {
                return NotFound();
            }
            return View(ledger);
        }
        //POST Delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            var ledger = await _db.Ledgers.FindAsync(id);

            if (ledger == null)
            {
                return View();
            }
            _db.Ledgers.Remove(ledger);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        //GET - DETAILS
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ledger = await _db.Ledgers.FindAsync(id);
            if (ledger == null)
            {
                return NotFound();
            }

            return View(ledger);
        }


    }
    }

