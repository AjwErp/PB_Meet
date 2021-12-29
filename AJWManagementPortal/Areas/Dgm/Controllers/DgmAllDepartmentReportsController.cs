using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Dgm.Controllers
{ 
    //This Controller control & Refer to ::All Department Reports List for DGM Office:: 

    [Area("Dgm")]
    public class DgmAllDepartmentReportsController : Controller
    {

        //GET--Start------AccountsDepartmentReportsList----
        //This Method use for Account Office Reports daily/Monthly/Yearly Reporsitory List for DGM office 
        public IActionResult DgmAccountsDepartmentReportsList()
        {
            return View();
        }
        //GET--Ended------AccountsDepartmentReportsList----
        //POST--Start------AccountsDepartmentReportsList----
        //POST--Ended------AccountsDepartmentReportsList----

        //GET--Start------AccountsDepartmentReportsList----
        //This Method use for Account Office Reports daily/Monthly/Yearly Error List for DGM office 
        public IActionResult DgmAccountsDepartmentReportsListE()
        {
            return View();
        }
        //GET--Ended------AccountsDepartmentReportsList----
        //POST--Start------AccountsDepartmentReportsList----
        //POST--Ended------AccountsDepartmentReportsList----
    }
}
