using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.HRM.Controllers
{ [Area("HRM")]
    public class HrmErrorReportController : Controller
    {
        public IActionResult HrmErrorReportList()
        {
            return View();
        }
    }
}
