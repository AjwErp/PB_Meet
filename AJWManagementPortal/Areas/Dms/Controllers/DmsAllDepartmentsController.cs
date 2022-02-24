using AJWManagementPortal.Data;
using AJWManagementPortal.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Dms.Controllers
{ [Area("Dms")]

//This Controller for AJW All Department Reports ::DMS::s

    public class DmsAllDepartmentsController : Controller
    {
        private readonly ApplicationDbContext _db;

        public DmsAllDepartmentsController(ApplicationDbContext db)
        {
            _db = db;

        }
        //-----------------------Start-----------------------------Accounts Department PDF Form Operations------------------------------

        //GET--Start---1---DmsAccountsDepartment----start-----
        public async Task<IActionResult> DmsAccountsDepartmentAsync()
    {
            var fileuploadViewModel = await AccountsLoadAllFiles();
            ViewBag.Message = TempData["Message"];
            return View(fileuploadViewModel);
        }
        //GET--Ended---1---DmsAccountsDepartment-----ended----
        //POST--Start---1---DmsAccountsDepartment----start----
        //POST--Ended---1---DmsAccountsDepartment----ended----
        //Loadfiles from system----------
        private async Task<AccountsFileUploadViewModel> AccountsLoadAllFiles()
        {
            var viewModel = new AccountsFileUploadViewModel();
            viewModel.AccountsFilesOnDatabaseDms = await _db.AccountsFilesOnDatabaseDms.ToListAsync();
            viewModel.AccountsFilesOnFileSystem = await _db.AccountsFilesOnFileSystem.ToListAsync();
            return viewModel;
        }

        // Download File From Databbase--------------
        public async Task<IActionResult> AccountsDownloadFileFromDatabase(int id)
        {

            var file = await _db.AccountsFilesOnDatabaseDms.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (file == null) return null;
            return File(file.Data, file.FileType, file.Name + file.Extension);
        }

        // Delete File From Database-------------------
        public async Task<IActionResult> AccountsDeleteFileFromDatabase(int id)
        {

            var file = await _db.AccountsFilesOnDatabaseDms.Where(x => x.Id == id).FirstOrDefaultAsync();
            _db.AccountsFilesOnDatabaseDms.Remove(file);
            _db.SaveChanges();
            TempData["Message"] = $"Removed {file.Name + file.Extension} successfully :Accounts: from Database.";
            return RedirectToAction("DmsAccountsDepartment");
        }
        //-----------------------Start-----------------------------Accounts Department PDF Form Operations------------------------------

        //-----------------------Start-----------------------------DGM Department PDF Form Operations------------------------------
        //GET--Start---2---DmsDgmDepartment----start-----
        public async Task<IActionResult> DmsDgmDepartmentAsync()
        {
            var fileuploadViewModel = await DgmLoadAllFiles();
            ViewBag.Message = TempData["Message"];
            return View(fileuploadViewModel);
        }
        //GET--Ended---2---DmsDgmDepartment-----ended----
        //POST--Start---2---DmsDgmDepartment----start----
        //POST--Ended---2---DmsDgmDepartment----ended----
        //Loadfiles from system----------
        private async Task<DgmFileUploadViewModel> DgmLoadAllFiles()
        {
            var viewModel = new DgmFileUploadViewModel();
            viewModel.DgmFilesOnDatabaseDms = await _db.DgmFilesOnDatabaseDms.ToListAsync();
            viewModel.DgmFilesOnFileSystem = await _db.DgmFilesOnFileSystem.ToListAsync();
            return viewModel;
        }

        // Download File From Databbase--------------
        public async Task<IActionResult> DgmDownloadFileFromDatabase(int id)
        {

            var file = await _db.DgmFilesOnDatabaseDms.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (file == null) return null;
            return File(file.Data, file.FileType, file.Name + file.Extension);
        }

        // Delete File From Database-------------------
        public async Task<IActionResult> DgmDeleteFileFromDatabase(int id)
        {

            var file = await _db.DgmFilesOnDatabaseDms.Where(x => x.Id == id).FirstOrDefaultAsync();
            _db.DgmFilesOnDatabaseDms.Remove(file);
            _db.SaveChanges();
            TempData["Message"] = $"Removed {file.Name + file.Extension} successfully :DGM: from Database.";
            return RedirectToAction("DmsDgmDepartment");
        }
        //-----------------------Start-----------------------------DGM Department PDF Form Operations------------------------------

        //GET--Start---3---DmsGmDepartment----start-----
        public IActionResult DmsGmDepartment()
        {
            return View();
        }
        //GET--Ended---3---DmsGmDepartment-----ended----
        //POST--Start---3---DmsGmDepartment----start----
        //POST--Ended---3---DmsGmDepartment----ended----

        //GET--Start---4---DmsCeoDepartment----start-----
        public IActionResult DmsCeoDepartment()
        {
            return View();
        }
        //GET--Ended---4---DmsCeoDepartment-----ended----
        //POST--Start---4---DmsCeoDepartment----start----
        //POST--Ended---4---DmsCeoDepartment----ended----
        //---------------------------------------------Production Department------------Start-----------------------------
        //GET--Start---4---DmsProductionDepartment----start-----
        public async Task<IActionResult> DmsProductionDepartmentAsync()
        {
            var fileuploadViewModel = await LoadAllFiles();
            ViewBag.Message = TempData["Message"];
            return View(fileuploadViewModel);
        }
        //Loadfiles from system----------
        private async Task<ProductionFileUploadViewModel> LoadAllFiles()
        {
            var viewModel = new ProductionFileUploadViewModel();
            viewModel.ProductionFilesOnDatabaseDms = await _db.ProductionFilesOnDatabaseDms.ToListAsync();
            viewModel.ProductionFilesOnFileSystem = await _db.ProductionFilesOnFileSystem.ToListAsync();
            return viewModel;
        }

        // Download File From Databbase--------------
        public async Task<IActionResult> DownloadFileFromDatabase(int id)
        {

            var file = await _db.ProductionFilesOnDatabaseDms.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (file == null) return null;
            return File(file.Data, file.FileType, file.Name + file.Extension);
        }

        // Delete File From Database-------------------
        public async Task<IActionResult> DeleteFileFromDatabase(int id)
        {

            var file = await _db.ProductionFilesOnDatabaseDms.Where(x => x.Id == id).FirstOrDefaultAsync();
            _db.ProductionFilesOnDatabaseDms.Remove(file);
            _db.SaveChanges();
            TempData["Message"] = $"Removed {file.Name + file.Extension} successfully :Production: from Database.";
            return RedirectToAction("DmsProductionDepartment");
        }
        //---------------------------------------------Production Department-------------------Ended----------------------

        //GET--Start---5---DmsAdminDepartment----start-----
        public IActionResult DmsAdminDepartment()
        {
            return View();
        }
        //GET--Ended---5---DmsAdminDepartment-----ended----
        //POST--Start---5---DmsAdminDepartment----start----
        //POST--Ended---5---DmsAdminDepartment----ended----

        //GET--Start---6---DmsHrmDepartment----start-----
        public IActionResult DmsHrmDepartment()
        {
            return View();
        }
        //GET--Ended---6---DmsHrmDepartment-----ended----
        //POST--Start---6---DmsHrmDepartment----start----
        //POST--Ended---6---DmsHrmDepartment----ended----

        //---------------------------------------------Store Department-------------------Start----------------------
        //GET--Start---6---DmsStoreDepartment----start-----
        //public async Task<IActionResult> DmsStoreDepartmentAsync()
        //{
        //    var fileuploadViewModel = await StoreLoadAllFiles();
        //    ViewBag.Message = TempData["Message"];
        //    return View(fileuploadViewModel);
        //}
        //GET--Ended---6---DmsStoreDepartment-----ended----
        //POST--Start---6---DmsStoreDepartment----start----
        //POST--Ended---6---DmsStoreDepartment----ended----
        //Loadfiles from system----------
        //private async Task<StoreFileUploadViewModel> StoreLoadAllFiles()
        //{
        //    var viewModel = new StoreFileUploadViewModel();
        //    viewModel.StoreFilesOnDatabaseDms = await _db.StoreFilesOnDatabaseDms.ToListAsync();
        //    viewModel.StoreFilesOnFileSystem = await _db.StoreFilesOnFileSystem.ToListAsync();
        //    return viewModel;
        //}
        // Download File From Databbase--------------
        //public async Task<IActionResult> StoreDownloadFileFromDatabase(int id)
        //{

        //    var file = await _db.StoreFilesOnDatabaseDms.Where(x => x.Id == id).FirstOrDefaultAsync();
        //    if (file == null) return null;
        //    return File(file.Data, file.FileType, file.Name + file.Extension);
        //}

        // Delete File From Database-------------------
        //public async Task<IActionResult> StoreDeleteFileFromDatabase(int id)
        //{

        //    var file = await _db.StoreFilesOnDatabaseDms.Where(x => x.Id == id).FirstOrDefaultAsync();
        //    _db.StoreFilesOnDatabaseDms.Remove(file);
        //    _db.SaveChanges();
        //    TempData["Message"] = $"Removed {file.Name + file.Extension} successfully :Store: from Database.";
        //    return RedirectToAction("DmsStoreDepartment");
        //}
        //---------------------------------------------Store Department-------------------Ended----------------------

    }
   
}
