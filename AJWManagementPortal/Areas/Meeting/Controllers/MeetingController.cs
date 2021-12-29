using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Meeting.Controllers
{
    [Area("Meeting")]
    public class MeetingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult MeetingDashboard()
        {
            return View();
        }
        //action for Dashboard Page 
      
        //action for Error Page 
        public IActionResult Error()
        {
            return View();
        }
        //end error page action
        //action for Calender Page 
        public IActionResult Calender()
        {
            return View();
        }
        //end Calender page action
        //action for Userprofile Page 
        public IActionResult UserProfile()
        {
            return View();
        }
        //action for Userprofile Page\

    }
}
