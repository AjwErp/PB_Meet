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

namespace AJWManagementPortal.Areas.HRM.Controllers
{ [Area("HRM")]

//This Controller for HRM Office PDF Report Pannel::PDF File Uploading::
    public class HrmPdfReportController : Controller
    {
        private readonly ApplicationDbContext _db;
        //private readonly IWebHostEnvironment _iwebhost;
        //IWebHostEnvironment iwebhost
        //                _iwebhost = iwebhost;

        public HrmPdfReportController(ApplicationDbContext db)
        {
            _db = db;

        }
        //This Method for File Loading-----------------

        private async Task<HrmFileUploadViewModel> LoadAllFiles()
        {
            var viewModel = new HrmFileUploadViewModel();
            viewModel.HrmFilesOnDatabase = await _db.HrmFilesOnDatabase.ToListAsync();
            viewModel.HrmFilesOnFileSystem = await _db.HrmFilesOnFileSystem.ToListAsync();
            return viewModel;
        }
        //GET --for HrmPdfReports-----------------------
        public async Task<IActionResult> HrmPdfReportsAsync()
        {
            var fileuploadViewModel = await LoadAllFiles();
            ViewBag.Message = TempData["Message"];
            return View(fileuploadViewModel);
        }
        //GET ----AjwNoticeBoardPdfReports----------------------------
        public async Task<IActionResult> AjwNoticeBoardPdfReports()
        {
            return View();
        }
        //GET --for HrmPdfReports-- ended
        //POST --for HrmPdfReports-- start
        //POST --for HrmPdfReports-- ended


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
                    var fileModel = new HrmFileOnFileSystem
                    {
                        CreatedOn = DateTime.UtcNow,
                        FileType = file.ContentType,
                        Extension = extension,
                        Name = fileName,
                        Description = description,
                        FilePath = filePath
                    };
                    _db.HrmFilesOnFileSystem.Add(fileModel);
                    _db.SaveChanges();
                }
            }
            TempData["Message"] = "HRM :File successfully uploaded to File System.";
            return RedirectToAction("AjwNoticeBoardPdfReports");
        }
        //Method UploadToDatabase-------------------------------------
        [HttpPost]
        public async Task<IActionResult> UploadToDatabase(List<IFormFile> files, string description)
        {
            foreach (var file in files)
            {
                var fileName = Path.GetFileNameWithoutExtension(file.FileName);
                var extension = Path.GetExtension(file.FileName);
                var fileModel = new HrmFileOnDatabaseModel
                {
                    CreatedOn = DateTime.Now,
                    FileType = file.ContentType,
                    Extension = extension,
                    Name = fileName,
                    Description = description
                };
                var fileModelDms = new HrmFileOnDatabaseDmsModel
                {
                    CreatedOn = DateTime.Now,
                    FileType = file.ContentType,
                    Extension = extension,
                    Name = fileName,
                    Description = description
                };
                using (var dataStream = new MemoryStream())
                {
                    await file.CopyToAsync(dataStream);
                    fileModel.Data = dataStream.ToArray();
                    fileModelDms.Data = dataStream.ToArray();
                }
                _db.HrmFilesOnDatabase.Add(fileModel);
                _db.HrmFilesOnDatabaseDms.Add(fileModelDms);
                _db.SaveChanges();
            }
            TempData["Message"] = "HRM :File successfully uploaded to Database";
            return RedirectToAction("HrmPdfReports");
        }
        //DownloadFileFromDatabase-----------------------------------
        public async Task<IActionResult> DownloadFileFromDatabase(int id)
        {

            var file = await _db.HrmFilesOnDatabase.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (file == null) return null;
            return File(file.Data, file.FileType, file.Name + file.Extension);
        }
        //Method for DownloadFileFromFileSystem-------------------------------------

        public async Task<IActionResult> DownloadFileFromFileSystem(int id)
        {
            var file = await _db.HrmFilesOnFileSystem.Where(x => x.Id == id).FirstOrDefaultAsync();
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
            var file = await _db.HrmFilesOnFileSystem.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (file == null) return null;
            if (System.IO.File.Exists(file.FilePath))
            {
                System.IO.File.Delete(file.FilePath);
            }
            _db.HrmFilesOnFileSystem.Remove(file);
            _db.SaveChanges();
            TempData["Message"] = $"Removed {file.Name + file.Extension} successfully :HRM: from File System.";
            return RedirectToAction("AjwNoticeBoardPdfReports");
        }

        //Method for DeleteFileFromDatabase--------------------------

        public async Task<IActionResult> DeleteFileFromDatabase(int id)
        {

            var file = await _db.HrmFilesOnDatabase.Where(x => x.Id == id).FirstOrDefaultAsync();
            _db.HrmFilesOnDatabase.Remove(file);
            _db.SaveChanges();
            TempData["Message"] = $"Removed {file.Name + file.Extension} successfully :HRM: from Database.";
            return RedirectToAction("HrmPdfReports");
        }


        //GET --for HrmPdfReports-- start
        //GET --for HrmPdfReports-- ended
        //POST --for HrmPdfReports-- start
        //POST --for HrmPdfReports-- ended

        //-------start------01---------------

        //1---GET for HrmDailyReportPdf --PDF--  
        public IActionResult HrmDailyReportPdf()
        {
            return View();
        }
        //-GET ended  for HrmDailyReportPdf --PDF--  
        //-POST ended  for HrmDailyReportPdf --PDF--  
        //-POST ended  for HrmDailyReportPdf --PDF--  


        //2---GET for HrmMonthlyReportPdf --PDF--  
        public IActionResult HrmMonthlyReportPdf()
        {
            return View();
        }
        //-GET ended  for HrmMonthlyReportPdf --PDF--  
        //-POST ended  for HrmMonthlyReportPdf --PDF--  
        //-POST ended  for HrmMonthlyReportPdf --PDF--  


        //--3---GET for HrmYearlyReportPdf --PDF--  
        public IActionResult HrmYearlyReportPdf()
        {
            return View();
        }
        //-GET ended  for HrmYearlyReportPdf --PDF--  
        //-POST ended  for HrmYearlyReportPdf --PDF--  
        //-POST ended  for HrmYearlyReportPdf --PDF--  

        //--3---GET for HrmAuditReportPdf --PDF--  
        public IActionResult HrmAuditReportPdf()
        {
            return View();
        }
        //-GET ended  for HrmAuditReportPdf --PDF--  
        //-POST ended  for HrmAuditReportPdft --PDF--  
        //-POST ended  for HrmAuditReportPdf --PDF--  


        //-------------------------Ended----------------------
    }
}
