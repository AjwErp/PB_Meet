using AJWManagementPortal.Data;
using AJWManagementPortal.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Dms.Controllers
{ 
    //This Controller for ::DMS Department Support Guide +User guide +Law Book+ Law Book List+::

    [Area("Dms")]
    public class SupportGuideDmsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SupportGuideDmsController(ApplicationDbContext context)
        {
            _context = context;
        }
     
        //GET--Start---1---DmsLawBookList----start-----
        public async Task<IActionResult> DmsLawBookList()
        {
            var distinctList = _context.LawBooks.ToList().Where(a => a.title.StartsWith("DMS")).GroupBy(x => new { x.department, x.title }).Select(group => group.First()); ;
            return View(distinctList);
        }
        //GET--Ended---1---DmsLawBookList-----ended----
        //POST--Start---1---DmsLawBookList----start----
        //POST--Ended---1---DmsLawBookList----ended----

        //GET--Start---2---UserGuideDms----start-----
        //This Method for 
        public async Task<IActionResult> DmsLawBook(string id, string title, string date)
        {
            ViewBag.Id = id;
            ViewBag.title = title;
            ViewBag.dept = title;
            return View(await _context.LawBooks.Where(i => i.department.Equals(id)).ToListAsync());
        }
        //GET--Ended---2---UserGuideDms-----ended----
        //POST--Start---2---UserGuideDms----start----
        //POST--Ended---2---UserGuideDms----ended----

        //This Method for 
        public async Task<IActionResult> AddLawBook(string id, string title)
        {
            ViewBag.Id = id;
            ViewBag.title = title;
            return View();
        }
        
        //This Method for 
        public async Task<IActionResult> DeleteLawBook(String id, String title)
        {
            //id = id.Replace("-", "/");
            _context.LawBooks.RemoveRange(_context.LawBooks.ToList().Where(x => x.title == title));
            _context.SaveChanges();
            return View("DmsLawBookList", _context.LawBooks.ToList());
        }

        //This Method for 
        public JsonResult InsertLawBooks(List<LawBook> data, String title, String Dept)
        {

            ////Check for NULL.
            if (data == null)
            {
                data = new List<LawBook>();
            }
            List<LawBook> lawbooks = new List<LawBook>();
            lawbooks = _context.LawBooks.Where(i => i.title.Equals(title)).ToList();
            //List<int> intersection = trans.aDailyCashes.Cast<int>().Intersect(data.Cast<int>()).ToList();
            var list3 = lawbooks.Except(data).ToList();
            //Loop and insert records.
            foreach (LawBook lawbook in list3)
            {
                lawbook.department = title;
                lawbook.title = title;
                _context.LawBooks.Remove(lawbook);
            }

            foreach (LawBook lawbook in data)
            {
                lawbook.department = title;
                lawbook.title = title;
                _context.LawBooks.Add(lawbook);
            }

            int insertedRecords = _context.SaveChanges();
            return Json(insertedRecords);

        }

        //This Method for 
        public JsonResult InsertLawBook(List<LawBook> data, String title, String Dept)
        {

            ////Check for NULL.
            if (data == null)
            {
                data = new List<LawBook>();
            }
            foreach (LawBook lawbook in data)
            {
                lawbook.department = title;
                lawbook.title = title;
                DateTime now = DateTime.Now;
                string date = now.GetDateTimeFormats('d')[0];
                lawbook.Date = date;
                _context.LawBooks.Add(lawbook);
            }

            int insertedRecords = _context.SaveChanges();
            return Json(insertedRecords);

        }

        //GET--Start---2---UserGuideDms----start-----
        //This Method for 
        public IActionResult DmsUserGuide()
        {
            return View();
        }
        //GET--Ended---2---UserGuideDms-----ended----
        //POST--Start---2---UserGuideDms----start----
        //POST--Ended---2---UserGuideDms----ended----

       
    }
}
