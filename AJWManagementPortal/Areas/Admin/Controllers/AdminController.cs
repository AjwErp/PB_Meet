using AJWManagementPortal.Data;
using AJWManagementPortal.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Admin.Controllers
{
    //This Controller For ::Admin Office Dashboard::
    [Area("Admin")]
    //[Authorize(Roles = SD.ManagerUser)]
    public class AdminController : Controller
    {
        //here we create constrauctor of DB class
        private readonly ApplicationDbContext _db;
        private readonly IWebHostEnvironment _iwebhost;

        public AdminController(ApplicationDbContext db, IWebHostEnvironment iwebhost)
        {
            _db = db;
            _iwebhost = iwebhost;

        }

        //action for admin Dashboard Page 
        public IActionResult AdminDashboard()
        {
            return View();
        }
   
        //GET for AllDepartment action Page
        public IActionResult AllDepartment()
        {
            return View();
        }
      
       
  
      
      
      

        
       
       


    }
}
