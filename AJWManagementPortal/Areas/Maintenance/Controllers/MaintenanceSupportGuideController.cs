using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Maintenance.Controllers
{ [Area("Maintenance")]
    public class MaintenanceSupportGuideController : Controller
    {
        //GET -start- for MaintenanceLawBookList
        public IActionResult MaintenanceLawBookList()
        {
            return View();
        }
        //GET -ended- for MaintenanceLawBookList
        //POST -start- for MaintenanceLawBookList
        //POST -ended- for MaintenanceLawBookList

        //GET -start- for MaintenanceLawBook
        public IActionResult MaintenanceLawBook()
        {
            return View();
        }
        //GET -ended- for MaintenanceLawBook
        //POST -start- for MaintenanceLawBook
        //POST -ended- for MaintenanceLawBook

        //GET -start- for  MaintenanceUserGuide
        public IActionResult MaintenanceUserGuide()
        {
            return View();
        }
        //GET -ended- for MaintenanceUserGuide
        //POST -ended- for MaintenanceUserGuide
        //POST -ended- for MaintenanceUserGuide
    }
}
