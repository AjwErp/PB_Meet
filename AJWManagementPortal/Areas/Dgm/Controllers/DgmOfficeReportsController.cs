using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Dgm.Controllers
{ 
    //This Controller refer to ::DGM Office Reports for CEO Office::
    [Area("Dgm")]
    public class DgmOfficeReportsController : Controller
    {
        //GET--Start--1---All-DGMOfficeReports----List--
        public IActionResult DgmOfficeReports()
        {
            return View();
        }
        //GET--Ended--1--DGMOfficeReports---List---
        //POST--Start--1--DGMOfficeReports---List---
        //POST--Ended-1---DGMOfficeReports---List---
//-------------------------------------------------------------------------------------------------------------
        //GET--Start----2--AllDepartmentDailyReportByDgmtoCeo----List--
        public IActionResult AllDepartmentDailyReportByDgmtoCeo()
        {
            return View();
        }
        //GET--Ended--2-----AllDepartmentDailyReportByDgmtoCeo---List---
        //POST--Start-----2--AllDepartmentDailyReportByDgmtoCeo---List---
        //POST--Ended-----2-AllDepartmentDailyReportByDgmtoCeo---List---
//---------------------------------------------------------------------------------------------------------------
        //GET--Start----3--AllDepartmentMonthlyReportByDgmtoCeo----List--
        public IActionResult AllDepartmentMonthlyReportByDgmtoCeo()
        {
            return View();
        }
        //GET--Ended--3-----AllDepartmentMonthlyReportByDgmtoCeo---List---
        //POST--Start-----3--AllDepartmentMonthlyReportByDgmtoCeo---List---
        //POST--Ended-----3-AllDepartmentMonthlyReportByDgmtoCeo---List---
        //---------------------------------------------------------------------------------------------------------------
        //GET--Start----4--AllDepartmentYearlyReportByDgmtoCeo----List--
        public IActionResult AllDepartmentYearlyReportByDgmtoCeo()
        {
            return View();
        }
        //GET--Ended--4-----AllDepartmentYearlyReportByDgmtoCeo---List---
        //POST--Start-----4--AllDepartmentYearlyReportByDgmtoCeo---List---
        //POST--Ended-----4---AllDepartmentYearlyReportByDgmtoCeo---List---
        //---------------------------------------------------------------------------------------------------------------
        //GET--Start----5--AllDepartmentAuditReportByDgmtoCeo----List--
        public IActionResult AllDepartmentAuditReportByDgmtoCeo()
        {
            return View();
        }
        //GET--Ended--5-----AllDepartmentAuditReportByDgmtoCeo---List---
        //POST--Start-----5--AllDepartmentAuditReportByDgmtoCeo---List---
        //POST--Ended-----5---AllDepartmentAuditReportByDgmtoCeo---List---
    }
}
