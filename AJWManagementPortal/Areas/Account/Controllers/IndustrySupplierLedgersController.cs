using AJWManagementPortal.Data;
using AJWManagementPortal.Extensions.IRepository;
using AJWManagementPortal.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Account.Controllers
{
    //This Controoler For ::Industry Supplier Ledger for Account Office::
    [Area("Account")]
    public class IndustrySupplierLedgersController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly IYearlyIndustrySupplierLedgerRepository _yearlyIndustrySupplierLedgerRepository;
        private readonly IMonthlyIndustrySupplierLedgerRepository _monthlyIndustrySupplierLedgerRepository;

        public IndustrySupplierLedgersController(ApplicationDbContext db, IYearlyIndustrySupplierLedgerRepository yearlyIndustrySupplierLedgerRepository, IMonthlyIndustrySupplierLedgerRepository monthlyIndustrySupplierLedgerRepository)
        {
            this._db = db;
            this._yearlyIndustrySupplierLedgerRepository = yearlyIndustrySupplierLedgerRepository;
            this._monthlyIndustrySupplierLedgerRepository = monthlyIndustrySupplierLedgerRepository;
        }

        public IActionResult IndustrySupplierLedgerBookList()
        {
            var monthlyIndustrySupplierLedgerList = _monthlyIndustrySupplierLedgerRepository.GetMonthlyIndustrySupplierLedgerType();
            var yearlyIndustrySupplierLedgerList = _yearlyIndustrySupplierLedgerRepository.GetYearlyIndustrySupplierLedger();

            ViewBag.MonthlyIndustrySupplierLedgerList = new SelectList(monthlyIndustrySupplierLedgerList, "Id", "LedgerName");
            ViewBag.YearlyIndustrySupplierLedgerList = new SelectList(yearlyIndustrySupplierLedgerList, "Id", "LedgerName");

            var monthlyList = _monthlyIndustrySupplierLedgerRepository.GetMonthlyIndustrySupplierLedgerBooks();
            return View(new IndustrySupplierLedgerBookViewModel
            {
                monthlyIndustrySupplierLedgers = monthlyList,
                yearlyIndustrySupplierLedgers = yearlyIndustrySupplierLedgerList
            });
        }
        //GET- for  IndustrySupplierLedgerBook ended
        //POST- for  IndustrySupplierLedgerBook 
        //POST- for  IndustrySupplierLedgerBook ended
        ////GET - for IndustrySupplierLedgerBook
        //GET----1----RafiqIronMianChannu---start---  
        public IActionResult RafiqIronMianChannu()
        {
            return View();
        }
        //GET----1----RafiqIronMianChannu---ended---
        //POST----1----RafiqIronMianChannu---start---
        //POST----1----RafiqIronMianChannu---ended---

        //GET----2----SalamatPaintHouse---start---  
        public IActionResult SalamatPaintHouseLedger()
        {
            return View();
        }
        //GET----2----SalamatPaintHouse---ended---
        //POST----2----SalamatPaintHouse---start---
        //POST----2----SalamatPaintHouse---ended---

        //GET----3----BhuttaAgroHardwareMianChannu---start---  
        public IActionResult BhuttaAgroHardwareMianChannuLedger()
        {
            return View();
        }
        //GET----3----BhuttaAgroHardwareMianChannu---ended---
        //POST----3----BhuttaAgroHardwareMianChannu---start---
        //POST----3----BhuttaAgroHardwareMianChannu---ended---

        //GET----4----NadeemJawaidBearingMianChannu---start---  
        public IActionResult NadeemJawaidBearingMianChannuLedger()
        {
            return View();
        }
        //GET----4----NadeemJawaidBearingMianChannu---ended---
        //POST----4----NadeemJawaidBearingMianChannu---start---
        //POST----4----NadeemJawaidBearingMianChannu---ended---

        //GET----5----AliSanitaryStoreMianChannu---start---  
        public IActionResult AlisanitaryStoreMianChannuLedger()
        {
            return View();
        }
        //GET----5----AliSanitaryStoreMianChannu---ended---
        //POST----5----AliSanitaryStoreMianChannu---start---
        //POST----5----AliSanitaryStoreMianChannu---ended---

        //GET----6----RoobaDigitalMianChannu---start---  
        public IActionResult RoobaDigitalMianChannuLedger()
        {
            return View();
        }
        //GET----6----RoobaDigitalMianChannu---ended---
        //POST----6----RoobaDigitalMianChannu---start---
        //POST----6----RoobaDigitalMianChannu---ended---

        //GET----7----SaeedElectricStoreMianChannu---start---  
        public IActionResult SaeedElectricStoreMianChannuLedger()
        {
            return View();
        }
        //GET----7----SaeedElectricStoreMianChannu---ended---
        //POST----7----SaeedElectricStoreMianChannu---start---
        //POST----7----SaeedElectricStoreMianChannu---ended---

        //GET----8----AyoubPetroliumServiceTulamba---start---  
        public IActionResult AyoubPetroliumServiceTulambaLedger()
        {
            return View();
        }
        //GET----8----AyoubPetroliumServiceTulamba---ended---
        //POST----8----AyoubPetroliumServiceTulamba---start---
        //POST----8----AyoubPetroliumServiceTulamba---ended---

        //GET----9----SadiqAluminiumMakdoomPur---start---  
        public IActionResult SadiqAluminiumMakdoomPurLedger()
        {
            return View();
        }
        //GET----9----SadiqAluminiumMakdoomPur---ended---
        //POST----9----SadiqAluminiumMakdoomPur---start---
        //POST----9----SadiqAluminiumMakdoomPur---ended---

        //GET----10----KhursheedIronStoreMianChannu---start---  
        public IActionResult KhursheedIronStoreMianChannuLedger()
        {
            return View();
        }
        //GET----10----KhursheedIronStoreMianChannu---ended---
        //POST----10----KhursheedIronStoreMianChannu---start---
        //POST----10----KhursheedIronStoreMianChannu---ended---

        //GET----11----MughalIronStoreTulamba---start---  
        public IActionResult MughalIronStoreTulambaLedger()
        {
            return View();
        }
        //GET----11----MughalIronStoreTulamba---ended---
        //POST----11----MughalIronStoreTulamba---start---
        //POST----11----MughalIronStoreTulamba---ended---

        //GET----12----TariqAutosTulamba---start---  
        public IActionResult TariqAutosTulambaLedger()
        {
            return View();
        }
        //GET----12----TariqAutosTulamba---ended---
        //POST----12----TariqAutosTulamba---start---
        //POST----12----TariqAutosTulamba---ended---

        //GET----13----LiveUpWaterSupplyTulamba---start---  
        public IActionResult LiveUpWaterSupplyTulambaLedger()
        {
            return View();
        }
        //GET----13----LiveUpWaterSupplyTulamba---ended---
        //POST----13----LiveUpWaterSupplyTulamba---start---
        //POST----13----LiveUpWaterSupplyTulamba---ended---

        //GET----14----MughalInteriorsCNCPlasmaMachine---start---  
        public IActionResult MughalInteriorsCNCPlasmaMachineLedger()
        {
            return View();
        }
        //GET----14----MughalInteriorsCNCPlasmaMachine---ended---
        //POST----14----MughalInteriorsCNCPlasmaMachine---start---
        //POST----14----MughalInteriorsCNCPlasmaMachine---ended---

        //GET----15----AsiaCollingCenterLedger---start---  
        public IActionResult AsiaCollingCenterLedger()
        {
            return View();
        }
        //GET----15----AsiaCollingCenterLedger---ended---
        //POST----15----AsiaCollingCenterLedger---start---
        //POST----15----AsiaCollingCenterLedger---ended---

        //GET----16----MarkzadabLedger---start---  
        public IActionResult MarkzadabLedger()
        {
            return View();
        }
        //GET----16----MarkzadabLedger---ended---
        //POST----16----MarkzadabLedger---start---
        //POST----16----MarkzadabLedger---ended---

        //GET----17----LuckyAtosLedger---start---  
        public IActionResult LuckyAutosLedger()
        {
            return View();
        }
        //GET----17----LuckyAtosLedger---ended---
        //POST----17----LuckyAtosLedger---start---
        //POST----17----LuckyAtosLedger---ended---

        //GET----17----LuckyAtosLedger---start---  
        public IActionResult GillaniShopingCenter()
        {
            return View();
        }
        //GET----17----LuckyAtosLedger---ended---
        //POST----17----LuckyAtosLedger---start---
        //POST----17----LuckyAtosLedger---ended---
        //-----Ended------Industry Supplier Ledgers Book-------------Subledger------=-------------------------------------- 

    }
}
