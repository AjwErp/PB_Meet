using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Store.Controllers
{ [Area("Store")]
    public class StoreReportsRepositoryController : Controller
    {
        //GET : This method used for Success/Repository Reports List
        public IActionResult StoreReportsRepositoryList()
        {
            return View();
        }
        //GET : This method used for Success/Repository Reports List
        //POST : This method used for Success/Repository Reports List
        //POST : This method used for Success/Repository Reports List

    }
}
