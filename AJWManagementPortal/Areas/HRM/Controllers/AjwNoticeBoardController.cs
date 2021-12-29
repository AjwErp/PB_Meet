using AJWManagementPortal.Data;
using AJWManagementPortal.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.HRM.Controllers
{[Area("Hrm")]

//This Controller for AJW NoticeBoard ::HRM Department::
    public class AjwNoticeBoardController : Controller
    {
        //here we create constrauctor of DB class
        private readonly ApplicationDbContext _db;
        public AjwNoticeBoardController(ApplicationDbContext db)
        {
            _db = db;
        }
         //Get for Noticb board action Method
        public async Task<IActionResult> Index()
        {
            //var result = _db.Noticb.ToList();
            //return View(result);
            return View(await _db.AJWNoticeBoardHrms.ToListAsync());
        }
        //Get for Noticb board action method
        public IActionResult Create()
        {
            return View();
        }
        //POST for Noticb board action method
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create(AJWNoticeBoardHrm ajwnoticeboard)
        {
            if (ModelState.IsValid)
            {
                //if valid
                //here we add the data by this 
                _db.AJWNoticeBoardHrms.Add(ajwnoticeboard);
                //here we save data in database 
                await _db.SaveChangesAsync();

                //after add and save ,we redirect to index 
                return RedirectToAction(nameof(Index));
            }
            return View(ajwnoticeboard);
            //return RedirectToAction("Index");
        }
        //GET - EDIT Noticb board
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var ajwnoticeboard = await _db.AJWNoticeBoardHrms.FindAsync(id);
            if (ajwnoticeboard == null)
            {
                return NotFound();
            }
            return View(ajwnoticeboard);

        }
        //POST - Edit for Noticb Board action Method

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(AJWNoticeBoardHrm ajwnoticeboard)
        {
            if (ModelState.IsValid)
            {
                _db.Update(ajwnoticeboard);
                await _db.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            return View(ajwnoticeboard);
        }
        //GET - DELETE for Noticb Board action Method
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var ajwnoticeboard = await _db.AJWNoticeBoardHrms.FindAsync(id);
            if (ajwnoticeboard == null)
            {
                return NotFound();
            }
            return View(ajwnoticeboard);
        }
        //POST  - Delete for Noticb Board Action Method
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            var ajwnoticeboard = await _db.AJWNoticeBoardHrms.FindAsync(id);

            if (ajwnoticeboard == null)
            {
                return View();
            }
            _db.AJWNoticeBoardHrms.Remove(ajwnoticeboard);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        //GET - DETAILS for Noticb BOard action Method
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ajwnoticeboard = await _db.AJWNoticeBoardHrms.FindAsync(id);
            if (ajwnoticeboard == null)
            {
                return NotFound();
            }

            return View(ajwnoticeboard);
        }
        //GET - for Noticb board view on other view page by Noticb Board ActionMetjod
        public async Task<IActionResult> NoticBoardViews(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ajwnoticeboard = await _db.AJWNoticeBoardHrms.FindAsync(id);
            if (ajwnoticeboard == null)
            {
                return NotFound();
            }

            return View(ajwnoticeboard);
        }
    }
}
