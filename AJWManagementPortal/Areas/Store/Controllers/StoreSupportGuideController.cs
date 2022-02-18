using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Store.Controllers
{
    [Area("Store")]
    public class StoreSupportGuideController : Controller
    {
        //GET -start- for StoreLawBookList
        public IActionResult StoreLawBookList()
        {
            return View();
        }
        //GET -ended- for StoreLawBookList
        //POST -start- for StoreLawBookList
        //POST -ended- for StoreLawBookList

        //GET -start- for StoreLawBook
        public IActionResult StoreLawBook()
        {
            return View();
        }
        //GET -ended- for StoreLawBook
        //POST -start- for StoreLawBook
        //POST -ended- for StoreLawBook

        //GET -start- for  StoreUserGuide
        public IActionResult StoreUserGuide()
        {
            return View();
        }
        //GET -ended- for StoreUserGuide
        //POST -ended- for StoreUserGuide
        //POST -ended- for StoreUserGuide
    }
}
