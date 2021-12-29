using AJWManagementPortal.Data;
using AJWManagementPortal.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Gm.Controllers
{
    //This Controller for ::GM Office Support Guide::Law Book + LAw Book List + User Guide::
    [Area("Gm")]
    public class GmSupportGuideController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GmSupportGuideController(ApplicationDbContext context)
        {
            _context = context;
        }

        //GET -start- for GmLawBookList
        public async Task<IActionResult> GmLawBookList()
        {
            var distinctList = _context.LawBooks.ToList().Where(a => a.title.StartsWith("GM")).GroupBy(x => new { x.department, x.title }).Select(group => group.First()); ;
            return View(distinctList);
        }
        //GET -ended- for GmLawBookList
        //POST -start- for GmLawBookList
        //POST -ended- for GmLawBookList
 
        //GET -start- for GM LAW Book
        public async Task<IActionResult> GmLawBook(string id, string title, string date)
        {
            ViewBag.Id = id;
            ViewBag.title = title;
            ViewBag.dept = title;
            return View(await _context.LawBooks.Where(i => i.department.Equals(id)).ToListAsync());
        }
        //GET -ended- for GM LAW Book
        //POST -start- for GM LAW Book
        //POST -ended- for GM LAW Book
        public async Task<IActionResult> AddLawBook(string id, string title)
        {
            ViewBag.Id = id;
            ViewBag.title = title;
            return View();
        }

        //This Method Refer to
        public async Task<IActionResult> DeleteLawBook(String id, String title)
        {
            //id = id.Replace("-", "/");
            _context.LawBooks.RemoveRange(_context.LawBooks.ToList().Where(x => x.title == title));
            _context.SaveChanges();
            return View("GmLawBookList", _context.LawBooks.ToList());
        }

        //This Method Refer to

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

        //This Method Refer to

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
        //GET -start- for GM User Guide Book
        public IActionResult GmUserGuide()
        {
            return View();
        }
        //GET -ended- for GM User Guide Book
        //POST -ended- for GM User Guide Book
        //POST -ended- for GM User Guide Book
    }
}
