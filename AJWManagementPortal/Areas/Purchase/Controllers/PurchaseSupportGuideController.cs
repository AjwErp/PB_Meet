using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Purchase.Controllers
{ [Area("Purchase")]
    public class PurchaseSupportGuideController : Controller
    {
        //GET -start- for PurchaseLawBookList
        public IActionResult PurchaseLawBookList()
        {
            return View();
        }
        //GET -ended- for PurchaseLawBookList
        //POST -start- for PurchaseLawBookList
        //POST -ended- for PurchaseLawBookList

        //GET -start- for PurchaseLawBook
        public IActionResult PurchaseLawBook()
        {
            return View();
        }
        //GET -ended- for PurchaseLawBook
        //POST -start- for PurchaseLawBook
        //POST -ended- for PurchaseLawBook

        //GET -start- for  PurchaseUserGuide
        public IActionResult PurchaseUserGuide()
        {
            return View();
        }
        //GET -ended- for PurchaseUserGuide
        //POST -ended- for PurchaseUserGuide
        //POST -ended- for PurchaseUserGuide
    }
}
