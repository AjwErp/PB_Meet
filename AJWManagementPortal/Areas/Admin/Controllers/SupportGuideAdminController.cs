using AJWManagementPortal.Models;
using AJWManagementPortal.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DinkToPdf.Contracts;
using DinkToPdf;
using AJWManagementPortal.Utility;
using System.IO;

namespace AJWManagementPortal.Areas.Admin.Controllers
{
    //This Controller For ::All Department Support Guide + Law Book + Law Book List::

    [Area("Admin")]
    public class SupportGuideAdminController : Controller
    {
        private readonly ApplicationDbContext _context;
        private IConverter _converter;

        public SupportGuideAdminController(ApplicationDbContext context, IConverter converter)
        {
            _context = context;
            _converter = converter;
        }
        public async Task<IActionResult> AdminLawBookList()
        {
            var distinctList = _context.LawBooks.ToList().GroupBy(x => new {x.department, x.Date, x.title }).Distinct().Select(group => group.First()); ;
            return View( distinctList);
        }
        public async Task<IActionResult> AdminLawBook(string id,string title,string date)
        {
            ViewBag.Id = id;
            ViewBag.title = title;
            ViewBag.dept = title;
            return View(await _context.LawBooks.Where(i=>i.title.Equals(title) && i.Date.Equals(date) && i.department.Equals(id)).ToListAsync());
        }
        public async Task<IActionResult> AddLawBook(string id,string title)
        {
            ViewBag.Id = id;
            ViewBag.title = title;
            return View();
        }


        public async Task<IActionResult> DeleteLawBook(String id, String title)
        {
            //id = id.Replace("-", "/");
            _context.LawBooks.RemoveRange(_context.LawBooks.ToList().Where(x => x.department == id));
            _context.SaveChanges();
            return View("AdminLawBookList",_context.LawBooks.ToList());
        }



        public JsonResult InsertLawBooks(List<LawBook> data,String title,String Dept)
        {

            ////Check for NULL.
            if (data == null)
            {
                data = new List<LawBook>();
            }

            List<LawBook> lawbooks = new List<LawBook>();
            lawbooks = _context.LawBooks.Where(i=>i.department.Equals(Dept)).ToList();
            //List<int> intersection = trans.aDailyCashes.Cast<int>().Intersect(data.Cast<int>()).ToList();
            var list3 = lawbooks.Except(data).ToList();
            var length = _context.LawBooks.Where(i => i.title.Contains(title)).Select(i => i.department).Distinct().Count();
            //Loop and insert records.

            foreach (LawBook lawbook in list3)
            {
                lawbook.department = Dept;
                lawbook.title = title;
                _context.LawBooks.Remove(lawbook);
            }


            foreach (LawBook lawbook in data)
            {
                if (lawbook.lawDescription != "" && lawbook.pageNumber != "" && lawbook.previousPageNumber != "" && lawbook.previousEditNumber != "" && lawbook.editNumber != "")
                {
                    if (String.IsNullOrEmpty(Dept))
                    {
                        string lengthValue = Convert.ToString(length + 1);
                        lawbook.department = title + lengthValue;
                    }
                    else
                    {
                        lawbook.department = Dept;

                    }

                    lawbook.title = title;
                    DateTime now = DateTime.Now;
                    string date = now.GetDateTimeFormats('d')[0];
                    lawbook.Date = date;
                    _context.LawBooks.Add(lawbook);
                }
            }

            int insertedRecords = _context.SaveChanges();
            return Json(insertedRecords);

        }





        public IActionResult AdminUserGuide()
        {
            return View();
        }


        //-----This Method Refer to the PDF File Download from ::Admin Law Book Pannel::
        [HttpGet]
        public IActionResult AdminLawBookListCreatePDF(string id, string title, string date)
        {
            var globalSettings = new GlobalSettings
            {
                ColorMode = ColorMode.Color,
                Orientation = Orientation.Portrait,
                PaperSize = PaperKind.A4,
                Margins = new MarginSettings { Top = 10 },
                DocumentTitle = "PDF Report",
                Out = @"C:\PDFCreator\Employee_Report.pdf"
            };
            var objectSettings = new ObjectSettings
            {
                PagesCount = true,
                HtmlContent = AdminLawBookTemplateGenerator.GetHTMLString(id,title,date),
                WebSettings = { DefaultEncoding = "utf-8", UserStyleSheet = Path.Combine(Directory.GetCurrentDirectory(), "assets", "styles.css") },
                HeaderSettings = { FontName = "Arial", FontSize = 9, Right = "Page [page] of [toPage]", Line = true },
                FooterSettings = { FontName = "Arial", FontSize = 9, Line = true, Center = "Report Footer" }
            };
            var pdf = new HtmlToPdfDocument()
            {
                GlobalSettings = globalSettings,
                Objects = { objectSettings }
            };
            _converter.Convert(pdf);
            return Ok("Successfully created PDF document.");
        }
    }
}
