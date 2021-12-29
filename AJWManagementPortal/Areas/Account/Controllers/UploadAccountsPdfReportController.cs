using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Account.Controllers
{[Area("Account")]
    public class UploadAccountsPdfReportController : Controller
    {
        //GET--Start----UploadPdfReport----
        public IActionResult UploadPdfReport()
        {
            return View();
        }
        //GET--Ended----UploadPdfReport----
        //POST--Start----UploadPdfReport----
        //POST--Ended----UploadPdfReport----

    }
}
