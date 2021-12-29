using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Ceo.Controllers
{ 
    //This Controller for AWJ Daily Plans List For Ceo Offcie
    [Area("Ceo")]
    public class CeoDailyPlanController : Controller
    {
        //Get--Start---CeoManagementDailyPlanList --refer to the list for Daily Plans
        public IActionResult CeoManagementDailyPlanList()
        {
            return View();
        }
        //Get--ended---CeoManagementDailyPlanList 
        //POSt--Start---CeoManagementDailyPlanList 
        //POSt--ended---CeoManagementDailyPlanList 

        //Get--Start---CeoTechnicalDailyPlanList --refer to the list for Daily Plans
        public IActionResult CeoTechnicalDailyPlanList()
        {
            return View();
        }
        //Get--ended---CeoTechnicalDailyPlanList 
        //POSt--Start---CeoTechnicalDailyPlanList 
        //POSt--ended---CeoTechnicalDailyPlanList 
    }
}
