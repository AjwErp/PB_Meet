using AJWManagementPortal.Data;
using AJWManagementPortal.Models;
using AJWManagementPortal.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Dms.Controllers
{
    //This Controller for ::DMS Dashboard::
    [Area("Dms")]
    public class DmsController : Controller
    {
     
        private readonly ApplicationDbContext _context;
        //GET --Dashboard DMS
        public DmsController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult DmsDashboard()
        {

            //Here we show total no of file in AJW All Law Books List,we show number on Dashboard
            int Hrmlength = _context.HrmFilesOnDatabaseDms.Distinct().Count();
            int  length = _context.FilesOnDatabaseDms.Distinct().Count();
            int Accountslength = _context.AccountsFilesOnDatabaseDms.Distinct().Count();
            int Productionlength = _context.ProductionFilesOnDatabaseDms.Where(q=>q.Type.Equals("Technical")).Distinct().Count();
            DmsDashboardViewModel dms = new DmsDashboardViewModel();
            dms.length = length;
            dms.Hrmlength = Hrmlength;
            dms.Accountslength = Accountslength;
            dms.Productionlength = Productionlength;
            return View(dms);
        }
    }
}
