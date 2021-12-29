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

namespace AJWManagementPortal.Areas.Production.Controllers
{[Area("Production")]

//This Controller refer to PDF File Upload Panel::Production Pdf File::
    public class ProductionPdfReportController : Controller
    {
        private readonly ApplicationDbContext _db;
        //private readonly IWebHostEnvironment _iwebhost;
        //IWebHostEnvironment iwebhost
        //                _iwebhost = iwebhost;

        public ProductionPdfReportController(ApplicationDbContext db)
        {
            _db = db;

        }
        //This Method for File Loading-----------------

        private async Task<ProductionFileUploadViewModel> LoadAllFiles()
        {
            var viewModel = new ProductionFileUploadViewModel();
            viewModel.ProductionFilesOnDatabase = await _db.ProductionFilesOnDatabase.ToListAsync();
            viewModel.ProductionFilesOnFileSystem = await _db.ProductionFilesOnFileSystem.ToListAsync();
            return viewModel;
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

        //-------start------01---------------
        //1---GET for ProductionDailyManagementStaffWorkPlanPdf --PDF--  
        public IActionResult ProductionPdfForm()
        {
            return View();
        }
        //-GET ended  for ProductionDailyManagementStaffWorkPlanPdf --PDF--  
        //-POST ended  for ProductionDailyManagementStaffWorkPlanPdf --PDF--  
        //-POST ended  for ProductionDailyManagementStaffWorkPlanPdf --PDF--  


        //1---GET for ProductionDailyManagementStaffWorkPlanPdf --PDF--  
        public IActionResult ProductionDailyManagementStaffWorkPlanPdf()
        {
            return View();
        }
        //-GET ended  for ProductionDailyManagementStaffWorkPlanPdf --PDF--  
        //-POST ended  for ProductionDailyManagementStaffWorkPlanPdf --PDF--  
        //-POST ended  for ProductionDailyManagementStaffWorkPlanPdf --PDF--  

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
                    var fileModel = new ProductionFileOnFileSystem
                    {
                        CreatedOn = DateTime.UtcNow,
                        FileType = file.ContentType,
                        Extension = extension,
                        Name = fileName,
                        Description = description,
                        FilePath = filePath
                    };
                    _db.ProductionFilesOnFileSystem.Add(fileModel);
                    _db.SaveChanges();
                }
            }
            TempData["Message"] = "Production :File successfully uploaded to File System.";
            return RedirectToAction("ProductionDailyTechnicalStaffWorkPlan");
        }

        //Method UploadToDatabase-------------------------------------
        [HttpPost]
        public async Task<IActionResult> UploadToDatabase(List<IFormFile> files, string description,string type,DateTime date)
        {
            foreach (var file in files)
            {
                var fileName = Path.GetFileNameWithoutExtension(file.FileName);
                var extension = Path.GetExtension(file.FileName);
                var fileModel = new ProductionFileOnDatabaseModel
                {
                    CreatedOn = DateTime.Now,
                    FileType = file.ContentType,
                    Extension = extension,
                    Name = fileName,
                    Description = description,
                    Type = type,
                    Date = date
                };
                var fileModelDms = new ProductionFileOnDatabaseDmsModel
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
                _db.ProductionFilesOnDatabase.Add(fileModel);
                _db.ProductionFilesOnDatabaseDms.Add(fileModelDms);
                _db.SaveChanges();
            }
            TempData["Message"] = "Production :File successfully uploaded to Database";
            return RedirectToAction("ProductionPdfReports");
        }
        //DownloadFileFromDatabase-----------------------------------
        public async Task<IActionResult> DownloadFileFromDatabase(int id)
        {

            var file = await _db.ProductionFilesOnDatabase.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (file == null) return null;
            return File(file.Data, file.FileType, file.Name + file.Extension);
        }
        //Method for DownloadFileFromFileSystem-------------------------------------

        public async Task<IActionResult> DownloadFileFromFileSystem(int id)
        {
            var file = await _db.ProductionFilesOnFileSystem.Where(x => x.Id == id).FirstOrDefaultAsync();
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
            var file = await _db.ProductionFilesOnFileSystem.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (file == null) return null;
            if (System.IO.File.Exists(file.FilePath))
            {
                System.IO.File.Delete(file.FilePath);
            }
            _db.ProductionFilesOnFileSystem.Remove(file);
            _db.SaveChanges();
            TempData["Message"] = $"Removed {file.Name + file.Extension} successfully :Production: from File System.";
            return RedirectToAction("ProductionDailyTechnicalStaffWorkPlan");
        }

        //Method for DeleteFileFromDatabase--------------------------

        public async Task<IActionResult> DeleteFileFromDatabase(int id)
        {

            var file = await _db.ProductionFilesOnDatabase.Where(x => x.Id == id).FirstOrDefaultAsync();
            _db.ProductionFilesOnDatabase.Remove(file);
            _db.SaveChanges();
            TempData["Message"] = $"Removed {file.Name + file.Extension} successfully :Delete: from Database.";
            return RedirectToAction("ProductionPdfReports");
        }


        //----------------------------File Uploading on system + Database + DMS--------------------------------------------------------

        //1---GET for Daily Production Report --PDF--  
        public IActionResult ProductionDailyReportPdf()
        {
            return View();
        }
        //-GET ended  for Daily Production Report --PDF--  
        //-POST ended  for Daily Production Report --PDF--  
        //-POST ended  for Daily Production Report --PDF--  

       

        //2---GET for Monthly Production Report --PDF--  
        public IActionResult ProductionMonthlyReportPdf()
        {
            return View();
        }
        //-GET ended  for Monthly Production Report --PDF--  
        //-POST ended  for Monthly Production Report --PDF--  
        //-POST ended  for Monthly Production Report --PDF--  


        //--3---GET for Yearly Production Report --PDF--  
        public IActionResult ProductionYearlyReportPdf()
        {
            return View();
        }
        //-GET ended  for Yearly Production Report --PDF--  
        //-POST ended  for Yearly Production Report --PDF--  
        //-POST ended  for Yearly Production Report --PDF--  

        //--3---GET for AuditReportPdf Production Report --PDF--  
        public IActionResult ProductionAuditReportPdf()
        {
            return View();
        }
        //-GET ended  for AuditReportPdf Production Report --PDF--  
        //-POST ended  for AuditReportPdf Production Report --PDF--  
        //-POST ended  for AuditReportPdf Production Report --PDF--  


        //-------------------------Ended----------------------
    }
}
