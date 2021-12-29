using AJWManagementPortal.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Gm.Controllers
{
    //This Controller refer to ::All Department Law Books List for GM office::
    
    [Area("Gm")]
    public class GmAllDepatLawBookController : Controller
    {
        private readonly ILogger<GmAllDepatLawBookController> _logger;
        private readonly ApplicationDbContext _db;
        //private readonly IWebHostEnvironment _iwebhost;
        public GmAllDepatLawBookController(ILogger<GmAllDepatLawBookController> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _db = db;
            //_iwebhost = iwebhost;
        }
        //This Method for All Department Law Books List for GM office


        //This Method for All Department Law Books List for GM office
        public IActionResult GmAllDepatLawBook()
        {
            ViewBag.GmAllDepatLawBook = _db.LawBooks.ToList();

            return View();
        }
    }
}
