using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Store.Controllers
{
    [Area("Store")]
    public class MaterialLedgerController : Controller
    {
        public IActionResult MaterialStockLedgerList()
        {
            return View();
        }

        public IActionResult ElectricStockLedgerList()
        {
            return View();
        }
        public IActionResult VachicleMaterialStockLedgerList()
        {
            return View();
        }

        public IActionResult StockVoucherViaScrabLedgerList()
        {
            return View();
        }
    }
}
