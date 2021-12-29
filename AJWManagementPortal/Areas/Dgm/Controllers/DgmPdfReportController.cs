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

namespace AJWManagementPortal.Areas.Dgm.Controllers
{
    //This Controller refer to ::DGM PDF file upload Report Pannel::  
    
    [Area("Dgm")]
    public class DgmPdfReportController : Controller
    {
        private readonly ApplicationDbContext _db;
        //private readonly IWebHostEnvironment _iwebhost;
        //IWebHostEnvironment iwebhost
        //                _iwebhost = iwebhost;

        public DgmPdfReportController(ApplicationDbContext db)
        {
            _db = db;
        }
        //-------------------------------------------------------DGM Daily Pdf Report-----------------------------
        //This Method for File Loading----------------
        private async Task<DgmFileUploadViewModel> LoadAllFiles()
        {
            var viewModel = new DgmFileUploadViewModel();
            viewModel.DgmFilesOnDatabase = await _db.DgmFilesOnDatabase.ToListAsync();
            viewModel.DgmFilesOnFileSystem = await _db.DgmFilesOnFileSystem.ToListAsync();
            return viewModel;
        }
        //GET---DgmPdfReportList---start-----
        public async Task<IActionResult> DgmPdfReportListAsync()
        {
            var fileuploadViewModel = await LoadAllFiles();
            ViewBag.Message = TempData["Message"];
            return View(fileuploadViewModel);
        }
        //GET---DgmPdfReportList---ended-----
        //POST---DgmPdfReportList---start-----
        //POST---DgmPdfReportList---edned-----

        //GET--DgmDailyPdfReport---start
        public async Task<IActionResult> DgmDailyPdfReport()
        {
            return View();
        }
        //GET---DgmDailyPdfReport---ended-----
        //POST---DgmDailyPdfReport---start-----
        //POST---DgmDailyPdfReport---edned-----
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
                    var fileModel = new DgmFileOnFileSystem
                    {
                        CreatedOn = DateTime.UtcNow,
                        FileType = file.ContentType,
                        Extension = extension,
                        Name = fileName,
                        Description = description,
                        FilePath = filePath
                    };
                    _db.DgmFilesOnFileSystem.Add(fileModel);
                    _db.SaveChanges();
                }
            }
            TempData["Message"] = "DGM :File successfully uploaded to File System.";
            return RedirectToAction("DgmDailyPdfReport");
        }

        //Method UploadToDatabase-------------------------------------
        [HttpPost]
        public async Task<IActionResult> UploadToDatabase(List<IFormFile> files, string description)
        {
            foreach (var file in files)
            {
                var fileName = Path.GetFileNameWithoutExtension(file.FileName);
                var extension = Path.GetExtension(file.FileName);
                var fileModel = new DgmFileOnDatabaseModel
                {
                    CreatedOn = DateTime.Now,
                    FileType = file.ContentType,
                    Extension = extension,
                    Name = fileName,
                    Description = description
                };
                var fileModelDms = new DgmFileOnDatabaseDmsModel
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
                _db.DgmFilesOnDatabase.Add(fileModel);
                _db.DgmFilesOnDatabaseDms.Add(fileModelDms);
                _db.SaveChanges();
            }
            TempData["Message"] = "DGM :File successfully uploaded to Database";
            return RedirectToAction("DgmPdfReportList");
        }
        //DownloadFileFromDatabase-----------------------------------
        public async Task<IActionResult> DownloadFileFromDatabase(int id)
        {

            var file = await _db.DgmFilesOnDatabase.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (file == null) return null;
            return File(file.Data, file.FileType, file.Name + file.Extension);
        }
        //Method for DownloadFileFromFileSystem-------------------------------------

        public async Task<IActionResult> DownloadFileFromFileSystem(int id)
        {
            var file = await _db.DgmFilesOnFileSystem.Where(x => x.Id == id).FirstOrDefaultAsync();
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
            var file = await _db.DgmFilesOnFileSystem.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (file == null) return null;
            if (System.IO.File.Exists(file.FilePath))
            {
                System.IO.File.Delete(file.FilePath);
            }
            _db.DgmFilesOnFileSystem.Remove(file);
            _db.SaveChanges();
            TempData["Message"] = $"Removed {file.Name + file.Extension} successfully :DGM: from File System.";
            return RedirectToAction("DgmDailyPdfReport");
        }

        //Method for DeleteFileFromDatabase--------------------------

        public async Task<IActionResult> DeleteFileFromDatabase(int id)
        {

            var file = await _db.DgmFilesOnDatabase.Where(x => x.Id == id).FirstOrDefaultAsync();
            _db.DgmFilesOnDatabase.Remove(file);
            _db.SaveChanges();
            TempData["Message"] = $"Removed {file.Name + file.Extension} successfully :Delete: from Database.";
            return RedirectToAction("DgmPdfReportList");
        }
//-------------------------------------DGM Daily Pdf Form---------------------------------------------------------------
        //GET ---DgmMonthlyPdfReport---Start
        public IActionResult DgmMonthlyPdfReport()
        {
            return View();
        }
        //GET---DgmMonthlyPdfReport---ended-----
        //POST---DgmMonthlyPdfReport---start-----
        //POST---DgmMonthlyPdfReport---edned-----

        //GET ---DgmYearlyPdfReport---start---
        public IActionResult DgmYearlyPdfReport()
        {
            return View();
        }
        //GET---DgmYearlyPdfReport---ended-----
        //POST---DgmYearlyPdfReport---start-----
        //POST---DgmYearlyPdfReport---edned-----
    }

}
