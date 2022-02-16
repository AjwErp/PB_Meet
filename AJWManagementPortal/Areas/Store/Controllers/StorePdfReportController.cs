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

namespace AJWManagementPortal.Areas.Store.Controllers
{ [Area("Store")]
    public class StorePdfReportController : Controller
    {
        private readonly ApplicationDbContext _db;


        public StorePdfReportController(ApplicationDbContext db)
        {
            _db = db;

        }
        //This Method for File Loading-----------------
    
        private async Task<StoreFileUploadViewModel> LoadAllFiles()
        {
            var viewModel = new StoreFileUploadViewModel();
            viewModel.StoreFilesOnDatabase = await _db.StoreFilesOnDatabase.ToListAsync();
            viewModel.StoreFilesOnFileSystem = await _db.StoreFilesOnFileSystem.ToListAsync();
            return viewModel;
        }

        //GET --for StorePdfReports-- start
        public async Task<IActionResult> StorePdfReportsAsync()
        {

            var fileuploadViewModel = await LoadAllFiles();
            ViewBag.Message = TempData["Message"];
            return View(fileuploadViewModel);
        }
        //public async Task<IActionResult> StorePdfReportsAsync()
        //{
        //    var fileuploadViewModel = await LoadAllFiles();
        //    ViewBag.Message = TempData["Message"];
        //    return View(fileuploadViewModel);
        //}
        //GET --for StorePdfReports-- ended
        //POST --for StorePdfReports-- start
        //POST --for StorePdfReports-- ended
        //1---GET for StoreDailyManagementStaffWorkPlanPdf --PDF--  
        public IActionResult StorePdfForm()
        {
            return View();
        }
        //-GET ended  for StoreDailyManagementStaffWorkPlanPdf --PDF--  
        //-POST ended  for StoreDailyManagementStaffWorkPlanPdf --PDF--  
        //-POST ended  for StoreDailyManagementStaffWorkPlanPdf --PDF--  

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
                    var fileModel = new StoreFileOnFileSystem
                    {
                        CreatedOn = DateTime.UtcNow,
                        FileType = file.ContentType,
                        Extension = extension,
                        Name = fileName,
                        Description = description,
                        FilePath = filePath
                    };
                    _db.StoreFilesOnFileSystem.Add(fileModel);
                    _db.SaveChanges();
                }
            }
            TempData["Message"] = "Store :File successfully uploaded to File System.";
            return RedirectToAction("StorePdfReports");
        }
        //Method UploadToDatabase-------------------------------------
        [HttpPost]
        public async Task<IActionResult> UploadToDatabase(List<IFormFile> files, string description, string type, DateTime date)
        {
            foreach (var file in files)
            {
                var fileName = Path.GetFileNameWithoutExtension(file.FileName);
                var extension = Path.GetExtension(file.FileName);
                var fileModel = new StoreFileOnDatabaseModel
                {
                    CreatedOn = DateTime.Now,
                    FileType = file.ContentType,
                    Extension = extension,
                    Name = fileName,
                    Description = description,
                    Type = type,
                    Date = date
                };
                var fileModelDms = new StoreFileOnDatabaseDmsModel
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
                _db.StoreFilesOnDatabase.Add(fileModel);
                _db.StoreFilesOnDatabaseDms.Add(fileModelDms);
                _db.SaveChanges();
            }
            TempData["Message"] = "Store :File successfully uploaded to Database";
            return RedirectToAction("StorePdfReports");
        }
        //DownloadFileFromDatabase-----------------------------------
        public async Task<IActionResult> DownloadFileFromDatabase(int id)
        {

            var file = await _db.StoreFilesOnDatabase.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (file == null) return null;
            return File(file.Data, file.FileType, file.Name + file.Extension);
        }
        //Method for DownloadFileFromFileSystem-------------------------------------

        public async Task<IActionResult> DownloadFileFromFileSystem(int id)
        {
            var file = await _db.StoreFilesOnFileSystem.Where(x => x.Id == id).FirstOrDefaultAsync();
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
            var file = await _db.StoreFilesOnFileSystem.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (file == null) return null;
            if (System.IO.File.Exists(file.FilePath))
            {
                System.IO.File.Delete(file.FilePath);
            }
            _db.StoreFilesOnFileSystem.Remove(file);
            _db.SaveChanges();
            TempData["Message"] = $"Removed {file.Name + file.Extension} successfully :Store: from File System.";
            return RedirectToAction("StorePdfReports");
        }

        //Method for DeleteFileFromDatabase--------------------------

        public async Task<IActionResult> DeleteFileFromDatabase(int id)
        {

            var file = await _db.StoreFilesOnDatabase.Where(x => x.Id == id).FirstOrDefaultAsync();
            _db.StoreFilesOnDatabase.Remove(file);
            _db.SaveChanges();
            TempData["Message"] = $"Removed {file.Name + file.Extension} successfully :Delete: from Database.";
            return RedirectToAction("StorePdfReports");
        }
    }
}
