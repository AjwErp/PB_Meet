using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Store.Controllers
{[Area("Store")]
    public class StoreMonthlyAllDepartmentReportController : Controller
    {
         //Get : This Method for just All Department Reports
        public IActionResult StoreMonthlyAllDepartmentReportList()
        {
            return View();
        }
        //Get : This Method for just All Department Reports
        //POST : This Method for just All Department Reports
        //POST : This Method for just All Department Reports

        //Get : This Method for just All Department Electric Reports
        public IActionResult StoreMonthlyAllDepartmentElectricReportList()
        {
            return View();
        }
        //Get : This Method for just All Department Electric Reports
        //POST : This Method for just All Department Electric Reports
        //POST : This Method for just All Department Electric Reports
    }
}
