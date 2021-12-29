using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Meeting.Controllers
{ [Area("Meeting")]
    public class MeetingSupportGuideController : Controller
    {
        //GET -start- for MeetingLawBookList
        public IActionResult MeetingLawBookList()
        {
            return View();
        }
        //GET -ended- for MeetingLawBookList
        //POST -start- for MeetingLawBookList
        //POST -ended- for MeetingLawBookList

        //GET -start- for MeetingLawBook
        public IActionResult MeetingLawBook()
        {
            return View();
        }
        //GET -ended- for MeetingLawBook
        //POST -start- for MeetingLawBook
        //POST -ended- for MeetingLawBook

        //GET -start- for  MeetingUserGuide
        public IActionResult MeetingUserGuide()
        {
            return View();
        }
        //GET -ended- for MeetingUserGuide
        //POST -ended- for MeetingUserGuide
        //POST -ended- for MeetingUserGuide
    }
}
