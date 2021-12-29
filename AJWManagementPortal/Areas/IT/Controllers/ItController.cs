using AJWManagementPortal.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.IT.Controllers
{ [Area("IT")]
    public class ItController : Controller
    {
        private readonly ApplicationDbContext _db;
        //private readonly IWebHostEnvironment _iwebhost;
        //IWebHostEnvironment iwebhost
        //                _iwebhost = iwebhost;

        public ItController(ApplicationDbContext db)
        {
            _db = db;

        }
        //action for Dashboard  Page 
        public IActionResult ItDashboard()
        {
            return View();
        }
    }
}
