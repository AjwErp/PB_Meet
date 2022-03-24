using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Store.Controllers
{ [Area("Store")]
    public class StoreYearlyReportController : Controller
    {
        public IActionResult StoreYearlyReportList()
        {
            return View();
        }
    }
}
