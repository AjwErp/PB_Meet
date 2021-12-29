using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Design.Controllers
{[Area("Design")]
    public class DesignSupportGuideController : Controller
    {
        //GET -start- for DesignLawBookList
        public IActionResult DesignLawBookList()
        {
            return View();
        }
        //GET -ended- for DesignLawBookList
        //POST -start- for DesignLawBookList
        //POST -ended- for DesignLawBookList

        //GET -start- for DesignLawBook
        public IActionResult DesignLawBook()
        {
            return View();
        }
        //GET -ended- for DesignLawBook
        //POST -start- for DesignLawBook
        //POST -ended- for DesignLawBook

        //GET -start- for  DesignUserGuide
        public IActionResult DesignUserGuide()
        {
            return View();
        }
        //GET -ended- for DesignUserGuide
        //POST -ended- for DesignUserGuide
        //POST -ended- for DesignUserGuide
    }
}
