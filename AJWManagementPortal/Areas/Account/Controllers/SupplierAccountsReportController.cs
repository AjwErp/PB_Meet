using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Account.Controllers
{
    //This Controller for ::All Supplier Reports For Account Office::
    [Area("Account")]
    public class SupplierAccountsReportController : Controller
    {

        //GET-- for AccountsSupplierAllReport-----start--------
        public IActionResult AccountsSupplierAllReport()
        {
            return View();
        }
        //GET-- for AccountsSupplierAllReport------ended-------
        //POST-- for AccountsSupplierAllReport------start-------
        //POST-- for AccountsSupplierAllReport------ended-------

        //GET-- for AccountsSupplierAllReport------sart-------

        public IActionResult DailySupplierAccountsReport()
        {
            return View();
        }
        //GET-- for DailySupplierAccountsReport Ended

        //GET-- for MonthlySupplierAccountsReport
        public IActionResult MonthlySupplierAccountsReport()
        {
            return View();
        }
        //GET-- for MonthlySupplierAccountsReport Ended

        //GET-- for YearlySupplierAccountsReport
        public IActionResult YearlySupplierAccountsReport()
        {
            return View();
        }
        //GET-- for YearlySupplierAccountsReport Ended
    }
}
