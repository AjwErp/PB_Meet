using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Ppc.Controllers
{ [Area("Ppc")]
    public class PpcSupportGuideController : Controller
    {
        //GET -start- for PpcLawBookList
        public IActionResult PpcLawBookList()
        {
            return View();
        }
        //GET -ended- for PpcLawBookList
        //POST -start- for PpcLawBookList
        //POST -ended- for PpcLawBookList

        //GET -start- for PpcLawBook
        public IActionResult PpcLawBook()
        {
            return View();
        }
        //GET -ended- for PpcLawBook
        //POST -start- for PpcLawBook
        //POST -ended- for PpcLawBook

        //GET -start- for  PpcUserGuide
        public IActionResult PpcUserGuide()
        {
            return View();
        }
        //GET -ended- for PpcUserGuide
        //POST -ended- for PpcUserGuide
        //POST -ended- for PpcUserGuide
    }
}
