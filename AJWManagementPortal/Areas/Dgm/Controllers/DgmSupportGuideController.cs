using AJWManagementPortal.Data;
using AJWManagementPortal.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Dgm.Controllers
{
    //This Controller Refer to ::DGM Office Support Guide +Law Book +Law Book List+ +User guide+::

    [Area("Dgm")]
    public class DgmSupportGuideController : Controller
    {
        //Reference for Application DB Class
        private readonly ApplicationDbContext _context;

        public DgmSupportGuideController(ApplicationDbContext context)
        {
            _context = context;
        }
       
        //GET -start- for DgmLawBookList
        public async Task<IActionResult> DgmLawBookList()
        {
            var distinctList = _context.LawBooks.ToList().Where(a => a.title.StartsWith("DGM")).GroupBy(x => new { x.department, x.title }).Select(group => group.First()); ;
            return View(distinctList);
        }
        //GET -ended- for DgmLawBookList
        //POST -start- for DgmLawBookList
        //POST -ended- for DgmLawBookList
        
        //GET -start- for DGM LAW Book
        public async Task<IActionResult> DgmLawBook(string id, string title, string date)
        {
            ViewBag.Id = id;
            ViewBag.title = title;
            ViewBag.dept = title;
            return View(await _context.LawBooks.Where(i => i.department.Equals(id)).ToListAsync());
        }
        //GET -ended- for DGM LAW Book
        //POST -start- for DGM LAW Book
        //POST -ended- for DGM LAW Book

        //Method for AddLawBook in List
        public async Task<IActionResult> AddLawBook(string id, string title)
        {
            ViewBag.Id = id;
            ViewBag.title = title;
            return View();
        }
        //Method for DeleteLawBooks from List
        public async Task<IActionResult> DeleteLawBook(String id, String title)
        {
            //id = id.Replace("-", "/");
            _context.LawBooks.RemoveRange(_context.LawBooks.ToList().Where(x => x.title == title));
            _context.SaveChanges();
            return View("DgmLawBookList", _context.LawBooks.ToList());
        }

        //Method For InsertLawBooks on Related Department but here we are in CEO Department
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

        //Method for InsertLawBook in CEO Department
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


        //GET -start- for DGM User Guide Book
        public IActionResult DgmUserGuide()
        {
            return View();
        }
        //GET -ended- for DGM User Guide Book
        //POST -ended- for DGM User Guide Book
        //POST -ended- for DGM User Guide Book
    }
}
