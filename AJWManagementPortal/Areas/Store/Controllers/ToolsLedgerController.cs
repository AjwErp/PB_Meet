using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Store.Controllers
{ [Area("Store")]
    public class ToolsLedgerController : Controller
    {
        public IActionResult StockToolsLedger()
        {
            return View();
        }

        public IActionResult VehicleToolsInOutLedger()
        {
            return View();
        }

        public IActionResult DailyToolsInOutLedger()
        {
            return View();
        }
    }
}
