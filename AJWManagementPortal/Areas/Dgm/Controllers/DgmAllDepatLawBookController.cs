using AJWManagementPortal.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Dgm.Controllers
{
    //This controller for All Department Law Books List for ::DGM Offcie::
    [Area("Dgm")]
    public class DgmAllDepatLawBookController : Controller
    {
        private readonly ILogger<DgmAllDepatLawBookController> _logger;
        private readonly ApplicationDbContext _db;
        private readonly IWebHostEnvironment _iwebhost;
        public DgmAllDepatLawBookController(ILogger<DgmAllDepatLawBookController> logger, ApplicationDbContext db, IWebHostEnvironment iwebhost)
        {
            _logger = logger;
            _db = db;
            _iwebhost = iwebhost;
        }

        public IActionResult DgmAllDepatLawBook()
        {
            ViewBag.DgmAllDepartmentLawBook = _db.LawBooks.ToList();

            return View();
        }
    }
}
