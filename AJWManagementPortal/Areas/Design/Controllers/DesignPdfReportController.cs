using AJWManagementPortal.Data;
using AJWManagementPortal.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Design.Controllers
{[Area("Design")]
    public class DesignPdfReportController : Controller
    {
        private readonly ApplicationDbContext _db;
        //private readonly IWebHostEnvironment _iwebhost;
        //IWebHostEnvironment iwebhost
        //                _iwebhost = iwebhost;

        public DesignPdfReportController(ApplicationDbContext db)
        {
            _db = db;

        }
        //This Method for File Loading-----------------

        private async Task<DesignFileUploadViewModel> LoadAllFiles()
        {
            var viewModel = new DesignFileUploadViewModel();
            viewModel.DesignFilesOnDatabase = await _db.DesignFilesOnDatabase.ToListAsync();
            viewModel.DesignFilesOnFileSystem = await _db.DesignFilesOnFileSystem.ToListAsync();
            return viewModel;
        }

        //GET --for DesignPdfReports-- start
        public async Task<IActionResult> DesignPdfReportListAsync()
        {
            var fileuploadViewModel = await LoadAllFiles();
            ViewBag.Message = TempData["Message"];
            return View(fileuploadViewModel);
        }
        //GET --for ProductionPdfReports-- start
        //public IActionResult DesignPdfReports()
        //{
        //    return View();
        //}
        public async Task<IActionResult> DesignPdfReportsAsync()
        {
            var fileuploadViewModel = await LoadAllFiles();
            ViewBag.Message = TempData["Message"];
            return View(fileuploadViewModel);
        }
        //GET --for ProductionPdfReports-- start
        public async Task<IActionResult> ProductionPdfReportsAsync()
        {
            var fileuploadViewModel = await LoadAllFiles();
            ViewBag.Message = TempData["Message"];
            return View(fileuploadViewModel);
        }
        //GET --for ProductionPdfReports-- ended
        //POST --for ProductionPdfReports-- start
        //POST --for ProductionPdfReports-- ended
        //GET --for ProductionPdfReports-- ended
        //POST --for ProductionPdfReports-- start
        //POST --for ProductionPdfReports-- ended
        //public async Task<IActionResult> DesignPdfReportListAsync()
        //{
        //    var fileuploadViewModel = await LoadAllFiles();
        //    ViewBag.Message = TempData["Message"];
        //    return View(fileuploadViewModel);
        //}
        //GET --for DesignPdfReports-- ended
        //POST --for DesignPdfReports-- start
        //POST --for DesignPdfReports-- ended

        //-------start------01---------------
        //1---GET for DesignDailyManagementStaffWorkPlanPdf --PDF--  
        public IActionResult DesignPdfForm()
        {
            return View();
        }
        //-GET ended  for DesignDailyManagementStaffWorkPlanPdf --PDF--  
        //-POST ended  for DesignDailyManagementStaffWorkPlanPdf --PDF--  
        //-POST ended  for DesignDailyManagementStaffWorkPlanPdf --PDF--  


        //1---GET for DesignPdfUploadReport --PDF--  
        public IActionResult DesignPdfUploadReport()
        {
            return View();
        }
        //-GET ended  for DesignPdfUploadReport --PDF--  
        //-POST ended  for DesignPdfUploadReport --PDF--  
        //-POST ended  for DesignPdfUploadReport --PDF--  

        //1---GET for  ProductionDailyTechnicalStaffWorkPlanPdf --PDF--  
        public async Task<IActionResult> ProductionDailyTechnicalStaffWorkPlanPdf()
        {
            return View();
        }
        //-GET ended  for ProductionDailyTechnicalStaffWorkPlanPdf --PDF--  
        //-POST ended  for ProductionDailyTechnicalStaffWorkPlanPdf --PDF--  
        //-POST ended  for ProductionDailyTechnicalStaffWorkPlanPdf --PDF--
        // UploadToFileSystem-------------------------------------------------
        [HttpPost]
        public async Task<IActionResult> UploadToFileSystem(List<IFormFile> files, string description)
        {
            foreach (var file in files)
            {
                var basePath = Path.Combine(Directory.GetCurrentDirectory() + "\\Files\\");
                bool basePathExists = System.IO.Directory.Exists(basePath);
                if (!basePathExists) Directory.CreateDirectory(basePath);
                var fileName = Path.GetFileNameWithoutExtension(file.FileName);
                var filePath = Path.Combine(basePath, file.FileName);
                var extension = Path.GetExtension(file.FileName);
                if (!System.IO.File.Exists(filePath))
                {
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }
                    var fileModel = new DesignFileOnFileSystem
                    {
                        CreatedOn = DateTime.UtcNow,
                        FileType = file.ContentType,
                        Extension = extension,
                        Name = fileName,
                        Description = description,
                        FilePath = filePath
                    };
                    _db.DesignFilesOnFileSystem.Add(fileModel);
                    _db.SaveChanges();
                }
            }
            TempData["Message"] = "Design :File successfully uploaded to File System.";
            return RedirectToAction("DesignPdfUploadReport");
        }

        //Method UploadToDatabase-------------------------------------
        [HttpPost]
        public async Task<IActionResult> UploadToDatabase(List<IFormFile> files, string description, string type, DateTime date)
        {
            foreach (var file in files)
            {
                var fileName = Path.GetFileNameWithoutExtension(file.FileName);
                var extension = Path.GetExtension(file.FileName);
                var fileModel = new DesignFileOnDatabaseModel
                {
                    CreatedOn = DateTime.Now,
                    FileType = file.ContentType,
                    Extension = extension,
                    Name = fileName,
                    Description = description,
                    Type = type,
                    Date = date
                };
                var fileModelDms = new DesignFileOnDatabaseDmsModel
                {
                    CreatedOn = DateTime.Now,
                    FileType = file.ContentType,
                    Extension = extension,
                    Name = fileName,
                    Description = description,
                    Type = type,
                    Date = date
                };
                using (var dataStream = new MemoryStream())
                {
                    await file.CopyToAsync(dataStream);
                    fileModel.Data = dataStream.ToArray();
                    fileModelDms.Data = dataStream.ToArray();
                }
                _db.DesignFilesOnDatabase.Add(fileModel);
                _db.DesignFilesOnDatabaseDms.Add(fileModelDms);
                _db.SaveChanges();
            }
            TempData["Message"] = "Design :File successfully uploaded to Database";
            return RedirectToAction("DesignPdfReportList");
        }
        //DownloadFileFromDatabase-----------------------------------
        public async Task<IActionResult> DownloadFileFromDatabase(int id)
        {

            var file = await _db.DesignFilesOnDatabase.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (file == null) return null;
            return File(file.Data, file.FileType, file.Name + file.Extension);
        }
        //Method for DownloadFileFromFileSystem-------------------------------------

        public async Task<IActionResult> DownloadFileFromFileSystem(int id)
        {
            var file = await _db.DesignFilesOnFileSystem.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (file == null) return null;
            var memory = new MemoryStream();
            using (var stream = new FileStream(file.FilePath, FileMode.Open))
            {
                await stream.CopyToAsync(memory);
            }
            memory.Position = 0;
            return File(memory, file.FileType, file.Name + file.Extension);
        }

        //Method for DeleteFileFromFileSystem--------------------------

        public async Task<IActionResult> DeleteFileFromFileSystem(int id)
        {
            var file = await _db.DesignFilesOnFileSystem.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (file == null) return null;
            if (System.IO.File.Exists(file.FilePath))
            {
                System.IO.File.Delete(file.FilePath);
            }
            _db.DesignFilesOnFileSystem.Remove(file);
            _db.SaveChanges();
            TempData["Message"] = $"Removed {file.Name + file.Extension} successfully :Design: from File System.";
            return RedirectToAction("DesignPdfReportList");
        }

        //Method for DeleteFileFromDatabase--------------------------

        public async Task<IActionResult> DeleteFileFromDatabase(int id)
        {

            var file = await _db.DesignFilesOnDatabase.Where(x => x.Id == id).FirstOrDefaultAsync();
            _db.DesignFilesOnDatabase.Remove(file);
            _db.SaveChanges();
            TempData["Message"] = $"Removed {file.Name + file.Extension} successfully :Delete: from Database.";
            return RedirectToAction("DesignPdfReportList");
        }


        //----------------------------File Uploading on system + Database + DMS--------------------------------------------------------

        



       


       
       

        //-------------------------Ended----------------------
    }
}
