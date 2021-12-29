using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.IT.Controllers
{ [Area("It")]
    public class ItSupportGuideController : Controller
    {
        //GET -start- for ItLawBookList
        public IActionResult ItLawBookList()
        {
            return View();
        }
        //GET -ended- for ItLawBookList
        //POST -start- for ItLawBookList
        //POST -ended- for ItLawBookList

        //GET -start- for ItLawBook
        public IActionResult ItLawBook()
        {
            return View();
        }
        //GET -ended- for ItLawBook
        //POST -start- for ItLawBook
        //POST -ended- for ItLawBook

        //GET -start- for  ItUserGuide
        public IActionResult ItUserGuide()
        {
            return View();
        }
        //GET -ended- for ItUserGuide
        //POST -ended- for ItUserGuide
        //POST -ended- for ItUserGuide
    }
}
