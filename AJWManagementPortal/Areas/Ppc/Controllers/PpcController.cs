using AJWManagementPortal.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Ppc.Controllers
{ [Area("Ppc")]
    public class PpcController : Controller
    {
        private readonly ApplicationDbContext _db;
        //private readonly IWebHostEnvironment _iwebhost;
        //IWebHostEnvironment iwebhost
        //                _iwebhost = iwebhost;

        public PpcController(ApplicationDbContext db)
        {
            _db = db;

        }
        //action for Dashboard  Page 
        public IActionResult PpcDashboard()
        {
            return View();
        }
    }
}
