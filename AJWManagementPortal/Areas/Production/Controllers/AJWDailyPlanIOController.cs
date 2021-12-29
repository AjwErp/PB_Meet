using AJWManagementPortal.Data;
using AJWManagementPortal.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Production.Controllers
{   [Area("Production")]

//This Controller Refer To AJW Daily Plan In/Out ::Production Offcie::
    public class AJWDailyPlanIOController : Controller
    {
        //here we create constrauctor of DB class
        private readonly ApplicationDbContext _db;

        public AJWDailyPlanIOController(ApplicationDbContext db)
        {
            _db = db;

        }
        //Get for DailyPlaIn action method
        public IActionResult AJWDailyPlanIO()
        {
            return View();
        }
        //POST for Daily Plan In action method
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> AJWDailyPlanIO(AJWDailyPlanIO Dpin)
        {

            if (ModelState.IsValid)
            {
                //if valid
                //here we add the data by this 
                _db.AJWDailyPlanIOs.Add(Dpin);
                //here we save data in database 
                await _db.SaveChangesAsync();

                //after add and save ,we redirect to index 
                return RedirectToAction(nameof(AJWDailyPlanIOList));

            }
            return View(Dpin);
            //return RedirectToAction("Index");
        }
        //Post for DailyPlanInOut ended
        //CRUD Operation
        //GET - EDITDP Daily plan In
        public async Task<IActionResult> AJWEditDPIO(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var Dpin = await _db.AJWDailyPlanIOs.FindAsync(id);
            if (Dpin == null)
            {
                return NotFound();
            }
            return View(Dpin);

        }
        //POST - EditDP Daily plan In

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AJWEditDPIO(AJWDailyPlanIO Dpin)
        {
            if (ModelState.IsValid)
            {
                _db.Update(Dpin);
                await _db.SaveChangesAsync();

                return RedirectToAction(nameof(AJWDailyPlanIOList));
            }
            return View(Dpin);
        }
        //CRUD --Edit ended
        //GET - DELETE DPIO Daily Plan In
        public async Task<IActionResult> AJWDeleteDPIO(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var Dpin = await _db.AJWDailyPlanIOs.FindAsync(id);
            if (Dpin == null)
            {
                return NotFound();
            }
            return View(Dpin);
        }
        ////POST  - DeleteDP Daily Plan In
        [HttpPost, ActionName("AJWDeleteDPIO")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AJWDeleteConfirmedDPIO(int? id)
        {
            var Dpin = await _db.AJWDailyPlanIOs.FindAsync(id);

            if (Dpin == null)
            {
                return View();
            }
            _db.AJWDailyPlanIOs.Remove(Dpin);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(AJWDailyPlanIOList));
        }
        ////GET - DETAILSDP Daily Plan in
        public async Task<IActionResult> AJWDetailsDPIO(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Dpin = await _db.AJWDailyPlanIOs.FindAsync(id);
            if (Dpin == null)
            {
                return NotFound();
            }

            return View(Dpin);
        }
        ////GET for DailyPlanInOutList start
        public async Task<IActionResult> AJWDailyPlanIOList()
        {
            return View(await _db.AJWDailyPlanIOs.ToListAsync());
        }
        //GET for DailyPlanInOutList ended


       
    }

}
