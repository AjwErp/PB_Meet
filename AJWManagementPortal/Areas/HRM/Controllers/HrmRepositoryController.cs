using AJWManagementPortal.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.HRM.Controllers
{[Area("Hrm")]

//This Controller for ::HRM office Reports Repository::
    public class HrmRepositoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        //private readonly IWebHostEnvironment _iwebhost;
        //IWebHostEnvironment iwebhost
        //                _iwebhost = iwebhost;

        public HrmRepositoryController(ApplicationDbContext db)
        {
            _db = db;

        }
        public IActionResult DailyMonthlyYearlyAuditHrmReportsListRepository()
        {
            return View();
        }

        //Repository for ProductionDailyReportRepository  list
    }
}
