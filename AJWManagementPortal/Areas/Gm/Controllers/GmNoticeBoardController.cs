using AJWManagementPortal.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Gm.Controllers
{
    //This Controller For AJW Notice Board List for ::GM Office::
    [Area("Gm")]
    public class GmNoticeBoardController : Controller
    {
        private readonly ILogger<GmNoticeBoardController> _logger;
        private readonly ApplicationDbContext _db;
        private readonly IWebHostEnvironment _iwebhost;
        public GmNoticeBoardController(ILogger<GmNoticeBoardController> logger, ApplicationDbContext db, IWebHostEnvironment iwebhost)
        {
            _logger = logger;
            _db = db;
            _iwebhost = iwebhost;
        }

        public IActionResult GmNoticeBoardList()
        {
            ViewBag.GmNoticeBoard = _db.AJWNoticeBoardHrms.ToList();

            return View();
        }
        //Get--ended---DgmNoticeBoardList------------- 
        //POSt--Start---DgmNoticeBoardList-------------- 
        //POSt--ended---DgmNoticeBoardList---------------- 
    }
}
