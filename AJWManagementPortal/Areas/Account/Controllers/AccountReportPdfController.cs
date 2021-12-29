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

namespace AJWManagementPortal.Areas.Account.Controllers
{
    //This Controller for ::Account Office PDF file uploading pannel & Pdf file uploading List::
    [Area("Account")]
    public class AccountReportPdfController : Controller
    {
        private readonly ApplicationDbContext _db;
        //private readonly IWebHostEnvironment _iwebhost;
        //IWebHostEnvironment iwebhost
        //                _iwebhost = iwebhost;

        public AccountReportPdfController(ApplicationDbContext db)
        {
            _db = db;

        }
        //--------------------------start------------Accounts PDF Form Operations------------------
        private async Task<AccountsFileUploadViewModel> LoadAllFiles()
        {
            var viewModel = new AccountsFileUploadViewModel();
            viewModel.AccountsFilesOnDatabase = await _db.AccountsFilesOnDatabase.ToListAsync();
            viewModel.AccountsFilesOnFileSystem = await _db.AccountsFilesOnFileSystem.ToListAsync();
            return viewModel;
        }
        //GET --for AccountsPdfReports-- start
        public async Task<IActionResult> AccountsPdfReportsAsync()
        {
            var fileuploadViewModel = await LoadAllFiles();
            ViewBag.Message = TempData["Message"];
            return View(fileuploadViewModel);
        }
        //GET --for AccountsPdfReports-- ended
        //POST --for AccountsPdfReports-- start
        //POST --for AccountsPdfReports-- ended

        //--3---GET for BankCheckApprovalVoucherPdf Account Report --PDF--  
        public async Task<IActionResult> BankCheckApprovalVoucherPdf()
        {
            return View();
        }
        //-GET ended  for BankCheckApprovalVoucherPdf Account Report --PDF--  
        //-POST ended  for BankCheckApprovalVoucherPdf Account Report --PDF--  
        //-POST ended  for BankCheckApprovalVoucherPdf Account Report --PDF--

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
                    var fileModel = new AccountsFileOnFileSystem
                    {
                        CreatedOn = DateTime.UtcNow,
                        FileType = file.ContentType,
                        Extension = extension,
                        Name = fileName,
                        Description = description,
                        FilePath = filePath
                    };
                    _db.AccountsFilesOnFileSystem.Add(fileModel);
                    _db.SaveChanges();
                }
            }
            TempData["Message"] = "Accounts :File successfully uploaded to File System.";
            return RedirectToAction("BankCheckApprovalVoucherPdf");
        }

        //Method UploadToDatabase-------------------------------------
        [HttpPost]
        public async Task<IActionResult> UploadToDatabase(List<IFormFile> files, string description)
        {
            foreach (var file in files)
            {
                var fileName = Path.GetFileNameWithoutExtension(file.FileName);
                var extension = Path.GetExtension(file.FileName);
                var fileModel = new AccountsFileOnDatabaseModel
                {
                    CreatedOn = DateTime.Now,
                    FileType = file.ContentType,
                    Extension = extension,
                    Name = fileName,
                    Description = description
                };
                var fileModelDms = new AccountsFileOnDatabaseDmsModel
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
                _db.AccountsFilesOnDatabase.Add(fileModel);
                _db.AccountsFilesOnDatabaseDms.Add(fileModelDms);
                _db.SaveChanges();
            }
            TempData["Message"] = "Accounts :File successfully uploaded to Database";
            return RedirectToAction("AccountsPdfReports");
        }
        //DownloadFileFromDatabase-----------------------------------
        public async Task<IActionResult> DownloadFileFromDatabase(int id)
        {

            var file = await _db.AccountsFilesOnDatabase.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (file == null) return null;
            return File(file.Data, file.FileType, file.Name + file.Extension);
        }
        //Method for DownloadFileFromFileSystem-------------------------------------

        public async Task<IActionResult> DownloadFileFromFileSystem(int id)
        {
            var file = await _db.AccountsFilesOnFileSystem.Where(x => x.Id == id).FirstOrDefaultAsync();
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
            var file = await _db.AccountsFilesOnFileSystem.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (file == null) return null;
            if (System.IO.File.Exists(file.FilePath))
            {
                System.IO.File.Delete(file.FilePath);
            }
            _db.AccountsFilesOnFileSystem.Remove(file);
            _db.SaveChanges();
            TempData["Message"] = $"Removed {file.Name + file.Extension} successfully :Accounts: from File System.";
            return RedirectToAction("BankCheckApprovalVoucherPdf");
        }

        //Method for DeleteFileFromDatabase--------------------------

        public async Task<IActionResult> DeleteFileFromDatabase(int id)
        {

            var file = await _db.AccountsFilesOnDatabase.Where(x => x.Id == id).FirstOrDefaultAsync();
            _db.AccountsFilesOnDatabase.Remove(file);
            _db.SaveChanges();
            TempData["Message"] = $"Removed {file.Name + file.Extension} successfully :Delete: from Database.";
            return RedirectToAction("AccountsPdfReports");
        }

        //--------------------------Ended------------Accounts PDF Form Operations------------------

        //-------start------01---------------

        //1---GET for Daily Account Report --PDF--  
        public IActionResult DailyReportPdf()
        {
            return View();
        }
        //-GET ended  for Daily Account Report --PDF--  
        //-POST ended  for Daily Account Report --PDF--  
        //-POST ended  for Daily Account Report --PDF--  


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


     


        //-------------------------Ended----------------------

    }
}
