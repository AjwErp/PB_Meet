using AJWManagementPortal.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Account.Controllers
{
    //This Controller for ::Account Office Audit Reports::
    [Area("Account")]
    public class AuditController : Controller
    {
        private readonly ApplicationDbContext _db;
        //private readonly IWebHostEnvironment _iwebhost;
        //IWebHostEnvironment iwebhost
        //                _iwebhost = iwebhost;

        public AuditController(ApplicationDbContext db)
        {
            _db = db;

        }
        public IActionResult AccountsAuditReportsList()
        {
            return View();
        }
        //Audit Report List 6month
        public IActionResult AuditReportsixRepository()
        {
            return View();
        }
        //Audit Report List 6month
        //Audit Report List 12month
        public IActionResult AuditReportYearlyRepository()
        {
            return View();
        }
        //Audit Report List 12month
    }
}
