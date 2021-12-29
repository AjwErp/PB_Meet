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

//This Controller for ::HRM Support Guide +USer Guide+ LAw Book+ Law Book List+::
    public class HrmSupportGuideController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HrmSupportGuideController(ApplicationDbContext context)
        {
            _context = context;
        }
   
        //GET -start- for HrmLawBookList
        public async Task<IActionResult> HrmLawBookList()
        {
            var distinctList = _context.LawBooks.ToList().Where(a => a.title.StartsWith("HRM")).GroupBy(x => new { x.department, x.title }).Select(group => group.First()); ;
            return View(distinctList);
        }
        //GET -ended- for HrmLawBookList
        //POST -start- for HrmLawBookList
        //POST -ended- for HrmLawBookList
   

        //GET -start- for Hrm LAW Book
        public async Task<IActionResult> HrmLawBook(string id, string title, string date)
        {
             ViewBag.Id = id;
            ViewBag.title = title;
            ViewBag.dept = title;
            return View(await _context.LawBooks.Where(i => i.department.Equals(id)).ToListAsync());
        }
        //GET -ended- for Hrm LAW Book
        //POST -start- for Hrm LAW Book
        //POST -ended- for Hrm LAW Book
        public async Task<IActionResult> AddLawBook(string id, string title)
        {
            ViewBag.Id = id;
            ViewBag.title = title;
            return View();
        }
        public async Task<IActionResult> DeleteLawBook(String id, String title)
        {
            //id = id.Replace("-", "/");
            _context.LawBooks.RemoveRange(_context.LawBooks.ToList().Where(x => x.title == title));
            _context.SaveChanges();
            return View("HrmLawBookList", _context.LawBooks.ToList());
        }

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

        //GET -start- for Hrm User Guide Book
        public IActionResult HrmUserGuide()
        {
            return View();
        }
        //GET -ended- for Hrm User Guide Book
        //POST -ended- for Hrm User Guide Book
        //POST -ended- for Hrm User Guide Book
    }
}
