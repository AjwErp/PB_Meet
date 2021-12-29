using AJWManagementPortal.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Purchase.Controllers
{ [Area("Purchase")]
    public class PurchaseController : Controller
    {
        private readonly ApplicationDbContext _db;
        //private readonly IWebHostEnvironment _iwebhost;
        //IWebHostEnvironment iwebhost
        //                _iwebhost = iwebhost;

        public PurchaseController(ApplicationDbContext db)
        {
            _db = db;

        }
        //action for Dashboard  Page 
        public IActionResult PurchaseDashboard()
        {
            return View();
        }
    }
}
