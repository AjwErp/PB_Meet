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
    //This Controller refer to ::DGM Office Notice Board List::
    [Area("Dgm")]
    public class DgmNoticeBoardListController : Controller
    {
        private readonly ILogger<DgmNoticeBoardListController> _logger;
        private readonly ApplicationDbContext _db;
        private readonly IWebHostEnvironment _iwebhost;
        public DgmNoticeBoardListController(ILogger<DgmNoticeBoardListController> logger, ApplicationDbContext db, IWebHostEnvironment iwebhost)
        {
            _logger = logger;
            _db = db;
            _iwebhost = iwebhost;
        }

        //Get--Start---DgmNoticeBoardList---------------- 
        public IActionResult DgmNoticeBoardList()
        {
            ViewBag.DgmNoticeBoardList = _db.AJWNoticeBoardHrms.ToList();

            return View();
        }
        //Get--ended---DgmNoticeBoardList------------- 
        //POSt--Start---DgmNoticeBoardList-------------- 
        //POSt--ended---DgmNoticeBoardList---------------- 
    }
}

