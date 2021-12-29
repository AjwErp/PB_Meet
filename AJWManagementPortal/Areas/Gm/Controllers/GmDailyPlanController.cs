using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Gm.Controllers
{
    //This Controller For AJW Daily Plan List For ::GM Office:::
    
    [Area("Gm")]
    public class GmDailyPlanController : Controller
    {
        //Get--Start---GmManagementDailyPlanList --refer to the list for Daily Plans
        public IActionResult GmManagementDailyPlanList()
        {
            return View();
        }
        //Get--ended---GmManagementDailyPlanList 
        //POSt--Start---GmManagementDailyPlanList 
        //POSt--ended---GmManagementDailyPlanList 

        //Get--Start---GmTechnicalDailyPlanList --refer to the list for Daily Plans
        public IActionResult GmTechnicalDailyPlanList()
        {
            return View();
        }
        //Get--ended---GmTechnicalDailyPlanList 
        //POSt--Start---GmTechnicalDailyPlanList 
        //POSt--ended---GmTechnicalDailyPlanList 
    }
}
