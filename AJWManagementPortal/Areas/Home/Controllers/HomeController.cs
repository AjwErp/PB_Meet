using AJWManagementPortal.Data;
using AJWManagementPortal.Models;
using AJWManagementPortal.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AJWManagementPortal.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Controllers
{
    
    [Area("Home")]
    public class HomeController : Controller
    {
       
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _db;
        private readonly IWebHostEnvironment _iwebhost;
        public HomeController(ILogger<HomeController> logger, ApplicationDbContext db, IWebHostEnvironment iwebhost)
        {
            _logger = logger;
            _db = db;
            _iwebhost = iwebhost;
        }

        public IActionResult Index()
        {
            //var items = _db.Student.ToList();
            ViewBag.Home = _db.AJWNoticeBoardHrms.ToList();
            return View();
        }
        public IActionResult Create()
        {
           
            return View();
        }
        //[HttpPost]
        //public IActionResult Create(StudentViewModel vm)
        //{
        //    string stringFileName = UploadFile(vm);
        //    var student = new Student
        //    {
               
        //        Naem = vm.Naem,
        //        ProfileImage = stringFileName
        //    };
        //    //_db.Student.Add(student);
        //    _db.Student.Add(student);
        //    _db.SaveChanges();

        //    return RedirectToAction("Index");
        //}

        //private string UploadFile(StudentViewModel vm)
        //{
        //    string fileName = null;
        //    if (vm.ProfileImage != null) {
        //        string uploadDir = Path.Combine(_iwebhost.WebRootPath, "Image");
        //        fileName = Guid.NewGuid().ToString() + "-" + vm.ProfileImage.FileName;
        //        string filePath = Path.Combine(uploadDir,fileName);
        //        using (var fileStream = new FileStream(filePath,FileMode.Create))
        //        {
        //            vm.ProfileImage.CopyTo(fileStream);
        //        }
        //    }
        //    return fileName;
        //}

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
