using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Account.Controllers
{ [Area("Account")]
    public class DCCSupplierController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
