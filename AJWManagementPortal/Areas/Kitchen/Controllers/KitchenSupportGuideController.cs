using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Kitchen.Controllers
{[Area("Kitchen")]
    public class KitchenSupportGuideController : Controller
    {

        //GET -start- for KitchenLawBookList
        public IActionResult KitchenLawBookList()
        {
            return View();
        }
        //GET -ended- for KitchenLawBookList
        //POST -start- for KitchenLawBookList
        //POST -ended- for KitchenLawBookList

        //GET -start- for KitchenLawBook
        public IActionResult KitchenLawBook()
        {
            return View();
        }
        //GET -ended- for KitchenLawBook
        //POST -start- for KitchenLawBook
        //POST -ended- for KitchenLawBook

        //GET -start- for  KitchenUserGuide
        public IActionResult KitchenUserGuide()
        {
            return View();
        }
        //GET -ended- for KitchenUserGuide
        //POST -ended- for KitchenUserGuide
        //POST -ended- for KitchenUserGuide
    }
}
