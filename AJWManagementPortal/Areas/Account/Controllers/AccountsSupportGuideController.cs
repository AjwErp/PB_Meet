using AJWManagementPortal.Models;
using AJWManagementPortal.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Account.Controllers
{
    //This Controller for ::Account Office Support Guide Law book + Law Boook List+ User Guide::
    [Area("Account")]
    public class AccountsSupportGuideController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AccountsSupportGuideController(ApplicationDbContext context)
        {
            _context = context;
        }
        //GET -start- for AccountLawBookList
        public async Task<IActionResult> AccountsLawBookList()
        {
            var distinctList = _context.LawBooks.ToList().Where(a => a.title.StartsWith("ACCOUNTS")).GroupBy(x => new { x.department, x.title }).Select(group => group.First()); ;
            return View(distinctList);
        }
     

        //This Method refer to
        public async Task<IActionResult> AccountsLawBook(string id, string title, string date)
        {
            ViewBag.Id = id;
            ViewBag.title = title;
            ViewBag.dept = title;
            return View(await _context.LawBooks.Where(i => i.department.Equals(id)).ToListAsync());
        }
        //This Method refer to

        public async Task<IActionResult> AddLawBook(string id, string title)
        {
            ViewBag.Id = id;
            ViewBag.title = title;
            return View();
        }

        //This Method refer to

        public async Task<IActionResult> DeleteLawBook(String id, String title)
        {
            //id = id.Replace("-", "/");
            _context.LawBooks.RemoveRange(_context.LawBooks.ToList().Where(x => x.title == title));
            _context.SaveChanges();
            return View("AccountsLawBookList", _context.LawBooks.ToList());
        }
        //This Method refer to
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

        //This Method refer to

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

        public IActionResult AccountsUserGuide()
        {
            return View();
        }
    }
}

