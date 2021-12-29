using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Accessory.Controllers
{ [Area("Accessory")]
    public class AccessorySupportGuideController : Controller
    {
        //GET -start- for AccessoryLawBookList
        public IActionResult AccessoryLawBookList()
        {
            return View();
        }
        //GET -ended- for AccessoryLawBookList
        //POST -start- for AccessoryLawBookList
        //POST -ended- for AccessoryLawBookList


        //GET -start- for AccessoryLawBook
        public IActionResult AccessoryLawBook()
        {
            return View();
        }
        //GET -ended- for AccessoryLawBook
        //POST -start- for AccessoryLawBook
        //POST -ended- for AccessoryLawBook

        //GET -start- for AccessoryUserGuide Book
        public IActionResult AccessoryUserGuide()
        {
            return View();
        }
        //GET -ended- for AccessoryUserGuide Guide Book
        //POST -ended- for AccessoryUserGuide
        //POST -ended- for AccessoryUserGuide
    }
}
