using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Production.Controllers
{[Area("Production")]

//This Controller refer to Productio Office Dashboard---
    public class ProductionController : Controller
    {
        //---GET :--Start------ProductionDashboard-----------1------   
        public IActionResult ProductionDashboard()
        {
            return View();
        }
        //---GET :--Start------ProductionDashboard-----------1------
        //---POST :--Start------ProductionDashboard-----------1------
        //---POST :--Start------ProductionDashboard-----------1------
    }
}
