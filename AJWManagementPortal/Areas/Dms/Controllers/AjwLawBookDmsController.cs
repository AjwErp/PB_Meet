using AJWManagementPortal.Data;
using AJWManagementPortal.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Dms.Controllers
{
    //This controller for AJW Law Book DMS all Law books save here as a DMS
    [Area("Dms")]
    public class AjwLawBookDmsController : Controller
    {
        //GET --for AjwLawBookDms----ended----
        private readonly ApplicationDbContext _db;

        public AjwLawBookDmsController(ApplicationDbContext db)
        {
            _db = db;

        }
        public async Task<IActionResult> AjwLawBookDmsAsync()
        {
            var fileuploadViewModel = await LoadAllFiles();
            ViewBag.Message = TempData["Message"];
            return View(fileuploadViewModel);
        }


        private async Task<FileUploadViewModel> LoadAllFiles()
        {
            var viewModel = new FileUploadViewModel();
            viewModel.FilesOnDatabaseDms = await _db.FilesOnDatabaseDms.ToListAsync();
            viewModel.FilesOnFileSystem = await _db.FilesOnFileSystem.ToListAsync();
            return viewModel;
        }

        public async Task<IActionResult> DownloadFileFromDatabase(int id)
        {

            var file = await _db.FilesOnDatabaseDms.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (file == null) return null;
            return File(file.Data, file.FileType, file.Name + file.Extension);
        }

        public async Task<IActionResult> DeleteFileFromDatabase(int id)
        {

            var file = await _db.FilesOnDatabaseDms.Where(x => x.Id == id).FirstOrDefaultAsync();
            _db.FilesOnDatabaseDms.Remove(file);
            _db.SaveChanges();
            TempData["Message"] = $"Removed {file.Name + file.Extension} successfully from Database.";
            return RedirectToAction("AjwLawBookDms");
        }
        //GET --for AjwLawBookDms----ended----
        //POST --for AjwLawBookDms----Start----
        //POST --for AjwLawBookDms----ended----
    }
}
