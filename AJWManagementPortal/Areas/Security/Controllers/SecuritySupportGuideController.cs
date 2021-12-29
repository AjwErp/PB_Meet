using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Security.Controllers
{
    [Area("Security")]
    public class SecuritySupportGuideController : Controller
    {
        //GET -start- for SecurityLawBookList
        public IActionResult SecurityLawBookList()
        {
            return View();
        }
        //GET -ended- for SecurityLawBookList
        //POST -start- for SecurityLawBookList
        //POST -ended- for SecurityLawBookList

        //GET -start- for SecurityLawBook
        public IActionResult SecurityLawBook()
        {
            return View();
        }
        //GET -ended- for SecurityLawBook
        //POST -start- for SecurityLawBook
        //POST -ended- for SecurityLawBook

        //GET -start- for  SecurityUserGuide
        public IActionResult SecurityUserGuide()
        {
            return View();
        }
        //GET -ended- for SecurityUserGuide
        //POST -ended- for SecurityUserGuide
        //POST -ended- for SecurityUserGuide
    }
}
