using AJWManagementPortal.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Ceo.Controllers
{
    //This Controller for AJW ALl Department Law Books List for ::CEO Offcie::
    [Area("Ceo")]
    public class CeoAllDepatLawBookController : Controller
    {

        private readonly ILogger<CeoAllDepatLawBookController> _logger;
        private readonly ApplicationDbContext _db;
        //private readonly IWebHostEnvironment _iwebhost;
        public CeoAllDepatLawBookController(ILogger<CeoAllDepatLawBookController> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _db = db;
            //_iwebhost = iwebhost;
        }


        //This Method refer to All department Law Book List
        public IActionResult CeoAllDepatLawBook()
        {
            ViewBag.CeoAllDepatLawBook = _db.LawBooks.ToList();

            return View();
        }
    }
}
