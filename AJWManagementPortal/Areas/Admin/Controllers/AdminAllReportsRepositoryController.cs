using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Admin.Controllers
{ 
    //This Controller For ::Admin office All Reports Repository:: 
    [Area("Admin")]
    public class AdminAllReportsRepositoryController : Controller
    {

        //--GET--for AdminAllReportsRepository----
        public IActionResult AdminAllReportsRepository()
        {
            return View();
        }
        //--GET--for AdminAllReportsRepository----

    }
}
