using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Store.Controllers
{ [Area("Store")]
    public class RequisitionLedgerController : Controller
    {
        public IActionResult MaterialRequisitionLedger()
        {
            return View();
        }

        public IActionResult ElectricRequisitionLedger()
        {
            return View();
        }
    }
}
