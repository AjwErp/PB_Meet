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

namespace AJWManagementPortal.Areas.Admin.Controllers
{
    //This Controller For ::Admin Office PDF File Uploading Pannel & PDF File List::
    [Area("Admin")]
    public class AdminPdfReportController : Controller
    {
        private readonly ApplicationDbContext _db;
        //private readonly IWebHostEnvironment _iwebhost;
        //IWebHostEnvironment iwebhost
        //                _iwebhost = iwebhost;

        public AdminPdfReportController(ApplicationDbContext db)
        {
            _db = db;

        }
        //This Method for file uploding by PDF form this loadfile method
        private async Task<FileUploadViewModel> LoadAllFiles()
        {
            var viewModel = new FileUploadViewModel();
            viewModel.FilesOnDatabase = await _db.FilesOnDatabase.ToListAsync();
            viewModel.FilesOnFileSystem = await _db.FilesOnFileSystem.ToListAsync();
            return viewModel;
        }
        //GET --for AdminPdfReports-- start
        public async Task<IActionResult> AdminPdfReportsAsync()
        {
            var fileuploadViewModel = await LoadAllFiles();
            ViewBag.Message = TempData["Message"];
            return View(fileuploadViewModel);
        }
        //public async Task<IActionResult> AccountsPdfReportsAsync()
        //{
        //    var fileuploadViewModel = await LoadAllFiles();
        //    ViewBag.Message = TempData["Message"];
        //    return View(fileuploadViewModel);
        //}
        //GET --for AdminPdfReports-- ended
        //POST --for AdminPdfReports-- start
        //POST --for AdminPdfReports-- ended

        //-------start------01---------------

        //public async Task<IActionResult> BankCheckApprovalVoucherPdf()
        //{
        //    return View();
        //}
        //1---GET for AjwLawBookPdf --PDF--  
        public async Task<IActionResult> AjwLawBookPdf()
        {
            return View();
        }

        //-GET ended  for AjwLawBookPdf --PDF--  
        //-POST ended  for AjwLawBookPdf --PDF--  
        //-POST ended  for AjwLawBookPdf --PDF--  

        // UploadToFileSystem-------
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
                    var fileModel = new FileOnFileSystem
                    {
                        CreatedOn = DateTime.UtcNow,
                        FileType = file.ContentType,
                        Extension = extension,
                        Name = fileName,
                        Description = description,
                        FilePath = filePath
                    };
                    _db.FilesOnFileSystem.Add(fileModel);
                    _db.SaveChanges();
                }
            }
            TempData["Message"] = "File successfully uploaded to File System.";
            return RedirectToAction("AjwLawBookPdf");
        }
        //Method UploadToDatabase----
        [HttpPost]
        public async Task<IActionResult> UploadToDatabase(List<IFormFile> files, string description)
        {
            foreach (var file in files)
            {
                var fileName = Path.GetFileNameWithoutExtension(file.FileName);
                var extension = Path.GetExtension(file.FileName);
                var fileModel = new FileOnDatabaseModel
                {
                    CreatedOn = DateTime.Now,
                    FileType = file.ContentType,
                    Extension = extension,
                    Name = fileName,
                    Description = description
                };
                var fileModelDms = new FileOnDatabaseDmsModel
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
                _db.FilesOnDatabase.Add(fileModel);
                _db.FilesOnDatabaseDms.Add(fileModelDms);
                _db.SaveChanges();
            }
            TempData["Message"] = "File successfully uploaded to Database";
            return RedirectToAction("AjwLawBookPdf");
        }
        //DownloadFileFromDatabase------
        public async Task<IActionResult> DownloadFileFromDatabase(int id)
        {

            var file = await _db.FilesOnDatabase.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (file == null) return null;
            return File(file.Data, file.FileType, file.Name + file.Extension);
        }
        //Method for DownloadFileFromFileSystem----
        public async Task<IActionResult> DownloadFileFromFileSystem(int id)
        {
            var file = await _db.FilesOnFileSystem.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (file == null) return null;
            var memory = new MemoryStream();
            using (var stream = new FileStream(file.FilePath, FileMode.Open))
            {
                await stream.CopyToAsync(memory);
            }
            memory.Position = 0;
            return File(memory, file.FileType, file.Name + file.Extension);
        }
        //Method for DeleteFileFromFileSystem----
        public async Task<IActionResult> DeleteFileFromFileSystem(int id)
        {
            var file = await _db.FilesOnFileSystem.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (file == null) return null;
            if (System.IO.File.Exists(file.FilePath))
            {
                System.IO.File.Delete(file.FilePath);
            }
            _db.FilesOnFileSystem.Remove(file);
            _db.SaveChanges();
            TempData["Message"] = $"Removed {file.Name + file.Extension} successfully from File System.";
            return RedirectToAction("AjwLawBookPdf");
        }
        //Method for DeleteFileFromDatabase---
        public async Task<IActionResult> DeleteFileFromDatabase(int id)
        {

            var file = await _db.FilesOnDatabase.Where(x => x.Id == id).FirstOrDefaultAsync();
            _db.FilesOnDatabase.Remove(file);
            _db.SaveChanges();
            TempData["Message"] = $"Removed {file.Name + file.Extension} successfully from Database.";
            return RedirectToAction("AdminPdfReports");
        }

        //2---GET for Monthly Account Report --PDF--  
        public IActionResult MonthlyReportPdf()
        {
            return View();
        }
        //-GET ended  for Monthly Account Report --PDF--  
        //-POST ended  for Monthly Account Report --PDF--  
        //-POST ended  for Monthly Account Report --PDF--  


        //--3---GET for Yearly Account Report --PDF--  
        public IActionResult YearlyReportPdf()
        {
            return View();
        }
        //-GET ended  for Yearly Account Report --PDF--  
        //-POST ended  for Yearly Account Report --PDF--  
        //-POST ended  for Yearly Account Report --PDF--  

        //--3---GET for AuditReportPdf Account Report --PDF--  
        public IActionResult AuditReportPdf()
        {
            return View();
        }
        //-GET ended  for AuditReportPdf Account Report --PDF--  
        //-POST ended  for AuditReportPdf Account Report --PDF--  
        //-POST ended  for AuditReportPdf Account Report --PDF--  


        //--3---GET for BankCheckApprovalVoucherPdf Account Report --PDF--  
        public IActionResult BankCheckApprovalVoucherPdf()
        {
            return View();
        }
        //-GET ended  for BankCheckApprovalVoucherPdf Account Report --PDF--  
        //-POST ended  for BankCheckApprovalVoucherPdf Account Report --PDF--  
        //-POST ended  for BankCheckApprovalVoucherPdf Account Report --PDF--


        //-------------------------Ended----------------------
    }
}
