using AJWManagementPortal.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Account.Controllers
{ [Area("Account")]
    public class NoticePopupController : Controller
    {
        private readonly ILogger<NoticePopupController> _logger;
        private readonly ApplicationDbContext _db;
        private readonly IWebHostEnvironment _iwebhost;
        public NoticePopupController(ILogger<NoticePopupController> logger, ApplicationDbContext db, IWebHostEnvironment iwebhost)
        {
            _logger = logger;
            _db = db;
            _iwebhost = iwebhost;
        }


        public IActionResult NoticePopup()
        {
            ViewBag.Home = _db.AJWNoticeBoardHrms.ToList();
            return View();
        }
    }
}
