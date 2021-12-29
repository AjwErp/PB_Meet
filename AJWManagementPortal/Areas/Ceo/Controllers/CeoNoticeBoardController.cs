using AJWManagementPortal.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Ceo.Controllers
{
    //This Controller for ::Notice Board List For CEO Officee List::
    [Area("Ceo")]
    public class CeoNoticeBoardController : Controller
    {
        private readonly ILogger<CeoNoticeBoardController> _logger;
        private readonly ApplicationDbContext _db;
        private readonly IWebHostEnvironment _iwebhost;
        public CeoNoticeBoardController(ILogger<CeoNoticeBoardController> logger, ApplicationDbContext db, IWebHostEnvironment iwebhost)
        {
            _logger = logger;
            _db = db;
            _iwebhost = iwebhost;
        }

        public IActionResult CeoNoticeBoardList()
        {
            ViewBag.CeoNoticeBoard = _db.AJWNoticeBoardHrms.ToList();

            return View();
        }
        //Get--ended---CeoNoticeBoardList------------- 
        //POSt--Start---CeoNoticeBoardList-------------- 
        //POSt--ended---CeoNoticeBoardList---------------- 
    }
}
