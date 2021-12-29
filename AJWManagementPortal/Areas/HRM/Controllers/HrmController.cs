using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.HRM.Controllers
{[Area("Hrm")]

//Tis Controller for ::HRM Department Dashboard::
    public class HrmController : Controller
    {
        //---GET :--Start------ProductionDashboard-----------1------   
        public IActionResult HrmDashboard()
        {
            return View();
        }
        //---GET :--Start------ProductionDashboard-----------1------
        //---POST :--Start------ProductionDashboard-----------1------
        //---POST :--Start------ProductionDashboard-----------1------
    }
}
