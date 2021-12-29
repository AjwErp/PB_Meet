using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Sale.Controllers
{
    [Area("Sale")]
    public class SaleSupportGuideController : Controller
    {
        //GET -start- for SaleLawBookList
        public IActionResult SaleLawBookList()
        {
            return View();
        }
        //GET -ended- for SaleLawBookList
        //POST -start- for SaleLawBookList
        //POST -ended- for SaleLawBookList

        //GET -start- for SaleLawBook
        public IActionResult SaleLawBook()
        {
            return View();
        }
        //GET -ended- for SaleLawBook
        //POST -start- for SaleLawBook
        //POST -ended- for SaleLawBook

        //GET -start- for  SaleUserGuide
        public IActionResult SaleUserGuide()
        {
            return View();
        }
        //GET -ended- for SaleUserGuide
        //POST -ended- for SaleUserGuide
        //POST -ended- for SaleUserGuide
    }
}
