using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Dgm.Controllers
{ 
    //This Controller Refer to the ::DGM Office Dashboard::

    [Area("Dgm")]
    public class DgmController : Controller
    {
        //This Method for DGM Office Dashboard 
        public IActionResult DgmDashboard()
        {
            return View();
        }
      
    }
}
