using AJWManagementPortal.Data;
using AJWManagementPortal.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Dgm.Controllers
{ 
    //This Controller refer to ::DGM Office Repository::
    [Area("Dgm")]
    public class DGMRepositoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        //private readonly IWebHostEnvironment _iwebhost;
        //IWebHostEnvironment iwebhost
        //                _iwebhost = iwebhost;

        public DGMRepositoryController(ApplicationDbContext db)
        {
            _db = db;

        }
        public IActionResult DailyMonthlyYearlyAuditDgmReportsListRepository()
        {
            IEnumerable<aDailyCash> a = _db.aDailyCashes.Where(i => i.DelCeo != 0 && Convert.ToInt32(i.Status) == 6).ToList().GroupBy(elem => elem.ValueDate).Select(group => group.First());
            return View(a);
        }

       
    }
}
