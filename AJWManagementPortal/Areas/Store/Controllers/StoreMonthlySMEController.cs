using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Store.Controllers
{ [Area("Store")]
    public class StoreMonthlySMEController : Controller
    {
        //GET : This method used for Monthly Scrabe/Material/Electric Report List
        public IActionResult MonthlySMEReportList()
        {
            return View();
        }
        //GET : This method used for Monthly Scrabe/Material/Electric Report List
        //POST : This method used for Monthly Scrabe/Material/Electric Report List
        //POST : This method used for Monthly Scrabe/Material/Electric Report List

    }
}
