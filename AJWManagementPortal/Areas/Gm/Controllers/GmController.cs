using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Gm.Controllers
{
    //This Controller For ::GM Office Dashboard cards/boxes:::
    [Area("Gm")]
    public class GmController : Controller
    {

        //This Method refer to GM Office Dashboard
        public IActionResult GmDashboard()
        {
            return View();
        }
       

    }
}
