using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Dgm.Controllers
{
    //This Controller refer to the :::DGM office Daily Plan List::
    [Area("Dgm")]
    public class DgmDailyPlanController : Controller
    {

        //Get--Start---DgmManagementDailyPlanList --refer to the list for Daily Plans
        public IActionResult DgmManagementDailyPlanList()
        {
            return View();
        }
        //Get--ended---DgmManagementDailyPlanList 
        //POSt--Start---DgmManagementDailyPlanList 
        //POSt--ended---DgmManagementDailyPlanList 

        //Get--Start---DgmTechnicalDailyPlanList --refer to the list for Daily Plans
        public IActionResult DgmTechnicalDailyPlanList()
        {
            return View();
        }
        //Get--ended---DgmTechnicalDailyPlanList 
        //POSt--Start---DgmTechnicalDailyPlanList 
        //POSt--ended---DgmTechnicalDailyPlanList 
    }
}
