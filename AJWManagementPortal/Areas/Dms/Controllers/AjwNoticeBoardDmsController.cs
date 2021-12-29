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
    //This Controller for AJW Notice Board DMS--All Notice board files save here
    [Area("Dms")]
    public class AjwNoticeBoardDmsController : Controller
    {
        private readonly ApplicationDbContext _db;

        public AjwNoticeBoardDmsController(ApplicationDbContext db)
        {
            _db = db;

        }
 
        //GET --for AjwNoticeBoardDms----start----
        public async Task<IActionResult> AjwNoticeBoardDmsAsync()
        {
            var fileuploadViewModel = await LoadAllFiles();
            ViewBag.Message = TempData["Message"];
            return View(fileuploadViewModel);
        }
        private async Task<HrmFileUploadViewModel> LoadAllFiles()
        {
            var viewModel = new HrmFileUploadViewModel();
            viewModel.HrmFilesOnDatabaseDms = await _db.HrmFilesOnDatabaseDms.ToListAsync();
            viewModel.HrmFilesOnFileSystem = await _db.HrmFilesOnFileSystem.ToListAsync();
            return viewModel;
        }

        public async Task<IActionResult> DownloadFileFromDatabase(int id)
        {

            var file = await _db.HrmFilesOnDatabaseDms.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (file == null) return null;
            return File(file.Data, file.FileType, file.Name + file.Extension);
        }

        public async Task<IActionResult> DeleteFileFromDatabase(int id)
        {

            var file = await _db.HrmFilesOnDatabaseDms.Where(x => x.Id == id).FirstOrDefaultAsync();
            _db.HrmFilesOnDatabaseDms.Remove(file);
            _db.SaveChanges();
            TempData["Message"] = $"Removed {file.Name + file.Extension} successfully :HRM: from Database.";
            return RedirectToAction("AjwNoticeBoardDms");
        }



    }
}
