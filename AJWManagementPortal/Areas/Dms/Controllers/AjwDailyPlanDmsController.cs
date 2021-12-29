using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Dms.Controllers
{ [Area("Dms")]

//This Controller For AJW All Daily Plans DMS ::DMS List ::
    public class AjwDailyPlanDmsController : Controller
    {

        //GET --for AjwNoticeBoardDms----start----

        public IActionResult AjwDailyPlanDms()
        {
            return View();
        }
        //GET --for AjwNoticeBoardDms----ended----
        //POST --for AjwNoticeBoardDms----Start----
        //POST --for AjwNoticeBoardDms----ended----
    }
}
