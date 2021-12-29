using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Production.Controllers
{ [Area("Production")]
    public class ProductionErrorReportController : Controller
    {
        public IActionResult ProductionErrorReportList()
        {
            return View();
        }
    }
}
