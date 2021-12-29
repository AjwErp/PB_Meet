using AJWManagementPortal.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Account.Controllers
{
    
    //This Controller for ::Monthly Industry Supplier Ledger for Account Office::
    [Area("Account")]
    public class MonthlyIndustrySupplierLedgersController : Controller
    {
        private readonly ApplicationDbContext _db;
        //private readonly IWebHostEnvironment _iwebhost;
        //IWebHostEnvironment iwebhost
        //                _iwebhost = iwebhost;

        public MonthlyIndustrySupplierLedgersController(ApplicationDbContext db)
        {
            _db = db;

        }
        //-----start------Industry Supplier Ledgers Book-------------Subledger------=-------------------------------------- 
        //GET- for  MonthlyIndustrySupplierLedgerBookList
        public IActionResult MonthlyIndustrySupplierLedgerBookList()
        {
            return View();
        }
        //GET- for  MonthlyIndustrySupplierLedgerBookList ended
        //POST- for  MonthlyIndustrySupplierLedgerBookList 
        //POST- for  MonthlyIndustrySupplierLedgerBookList ended
        ////GET - for MonthlyIndustrySupplierLedgerBookList
        //GET----1----MonthlyRafiqIronMianChannu---start---  
        public IActionResult MonthlyRafiqIronMianChannu()
        {
            return View();
        }
        //GET----1----MonthlyRafiqIronMianChannu---ended---
        //POST----1----MonthlyRafiqIronMianChannu---start---
        //POST----1----MonthlyRafiqIronMianChannu---ended---

        //GET----2----MonthlySalamatPaintHouseLedger---start---  
        public IActionResult MonthlySalamatPaintHouseLedger()
        {
            return View();
        }
        //GET----2----MonthlySalamatPaintHouseLedger---ended---
        //POST----2----MonthlySalamatPaintHouseLedger---start---
        //POST----2----MonthlySalamatPaintHouseLedger---ended---

        //GET----3----MonthlyBhuttaAgroHardwareMianChannuLedger---start---  
        public IActionResult MonthlyBhuttaAgroHardwareMianChannuLedger()
        {
            return View();
        }
        //GET----3----MonthlyBhuttaAgroHardwareMianChannuLedger---ended---
        //POST----3----MonthlyBhuttaAgroHardwareMianChannuLedger---start---
        //POST----3----MonthlyBhuttaAgroHardwareMianChannuLedger---ended---

        //GET----4----MonthlyNadeemJawaidBearingMianChannuLedger---start---  
        public IActionResult MonthlyNadeemJawaidBearingMianChannuLedger()
        {
            return View();
        }
        //GET----4----MonthlyNadeemJawaidBearingMianChannuLedger---ended---
        //POST----4----MonthlyNadeemJawaidBearingMianChannuLedger---start---
        //POST----4----MonthlyNadeemJawaidBearingMianChannuLedger---ended---

        //GET----5----MonthlyAlisanitaryStoreMianChannuLedger---start---  
        public IActionResult MonthlyAlisanitaryStoreMianChannuLedger()
        {
            return View();
        }
        //GET----5----MonthlyAlisanitaryStoreMianChannuLedger---ended---
        //POST----5----MonthlyAlisanitaryStoreMianChannuLedger---start---
        //POST----5----MonthlyAlisanitaryStoreMianChannuLedger---ended---

        //GET----6----MonthlyRoobaDigitalMianChannuLedger---start---  
        public IActionResult MonthlyRoobaDigitalMianChannuLedger()
        {
            return View();
        }
        //GET----6----MonthlyRoobaDigitalMianChannuLedger---ended---
        //POST----6----MonthlyRoobaDigitalMianChannuLedger---start---
        //POST----6----MonthlyRoobaDigitalMianChannuLedger---ended---

        //GET----7----MonthlySaeedElectricStoreMianChannuLedger---start---  
        public IActionResult MonthlySaeedElectricStoreMianChannuLedger()
        {
            return View();
        }
        //GET----7----MonthlySaeedElectricStoreMianChannuLedger---ended---
        //POST----7----MonthlySaeedElectricStoreMianChannuLedger---start---
        //POST----7----MonthlySaeedElectricStoreMianChannuLedger---ended---

        //GET----8----MonthlyAyoubPetroliumServiceTulambaLedger---start---  
        public IActionResult MonthlyAyoubPetroliumServiceTulambaLedger()
        {
            return View();
        }
        //GET----8----MonthlyAyoubPetroliumServiceTulambaLedger---ended---
        //POST----8----MonthlyAyoubPetroliumServiceTulambaLedger---start---
        //POST----8----MonthlyAyoubPetroliumServiceTulambaLedger---ended---

        //GET----9----MonthlySadiqAluminiumMakdoomPurLedger---start---  
        public IActionResult MonthlySadiqAluminiumMakdoomPurLedger()
        {
            return View();
        }
        //GET----9----MonthlySadiqAluminiumMakdoomPurLedger---ended---
        //POST----9----MonthlySadiqAluminiumMakdoomPurLedger---start---
        //POST----9----MonthlySadiqAluminiumMakdoomPurLedger---ended---

        //GET----10----MonthlyKhursheedIronStoreMianChannuLedger---start---  
        public IActionResult MonthlyKhursheedIronStoreMianChannuLedger()
        {
            return View();
        }
        //GET----10----MonthlyKhursheedIronStoreMianChannuLedger---ended---
        //POST----10----MonthlyKhursheedIronStoreMianChannuLedger---start---
        //POST----10----MonthlyKhursheedIronStoreMianChannuLedger---ended---

        //GET----11----MonthlyMughalIronStoreTulambaLedger---start---  
        public IActionResult MonthlyMughalIronStoreTulambaLedger()
        {
            return View();
        }
        //GET----11----MonthlyMughalIronStoreTulambaLedger---ended---
        //POST----11----MonthlyMughalIronStoreTulambaLedger---start---
        //POST----11----MonthlyMughalIronStoreTulambaLedger---ended---

        //GET----12----MonthlyTariqAutosTulambaLedger---start---  
        public IActionResult MonthlyTariqAutosTulambaLedger()
        {
            return View();
        }
        //GET----12----MonthlyTariqAutosTulambaLedger---ended---
        //POST----12----MonthlyTariqAutosTulambaLedger---start---
        //POST----12----MonthlyTariqAutosTulambaLedger---ended---

        //GET----13----MonthlyLiveUpWaterSupplyTulambaLedger---start---  
        public IActionResult MonthlyLiveUpWaterSupplyTulambaLedger()
        {
            return View();
        }
        //GET----13----MonthlyLiveUpWaterSupplyTulambaLedger---ended---
        //POST----13----MonthlyLiveUpWaterSupplyTulambaLedger---start---
        //POST----13----MonthlyLiveUpWaterSupplyTulambaLedger---ended---

        //GET----14----MonthlyMughalInteriorsCNCPlasmaMachineLedger---start---  
        public IActionResult MonthlyMughalInteriorsCNCPlasmaMachineLedger()
        {
            return View();
        }
        //GET----14----MonthlyMughalInteriorsCNCPlasmaMachineLedger---ended---
        //POST----14----MonthlyMughalInteriorsCNCPlasmaMachineLedger---start---
        //POST----14----MonthlyMughalInteriorsCNCPlasmaMachineLedger---ended---

        //GET----15----MonthlyAsiaCollingCenterLedger---start---  
        public IActionResult MonthlyAsiaCollingCenterLedger()
        {
            return View();
        }
        //GET----15----MonthlyAsiaCollingCenterLedger---ended---
        //POST----15----MonthlyAsiaCollingCenterLedger---start---
        //POST----15----MonthlyAsiaCollingCenterLedger---ended---

        //GET----16----MonthlyMarkzadabLedger---start---  
        public IActionResult MonthlyMarkzadabLedger()
        {
            return View();
        }
        //GET----16----MonthlyMarkzadabLedger---ended---
        //POST----16----MonthlyMarkzadabLedger---start---
        //POST----16----MonthlyMarkzadabLedger---ended---

        //GET----17----MonthlyLuckyAutosLedger---start---  
        public IActionResult MonthlyLuckyAutosLedger()
        {
            return View();
        }
        //GET----17----MonthlyLuckyAutosLedger---ended---
        //POST----17----MonthlyLuckyAutosLedger---start---
        //POST----17----MonthlyLuckyAutosLedger---ended---

        //GET----17----MonthlyLuckyAutosLedger---start---  
        public IActionResult MonthlyGillaniShopingCenterLedger()
        {
            return View();
        }
        //GET----17----MonthlyLuckyAutosLedger---ended---
        //POST----17----MonthlyLuckyAutosLedger---start---
        //POST----17----MonthlyLuckyAutosLedger---ended---
        //-----Ended------Industry Supplier Ledgers Book-------------Subledger------=-------------------------------------- 

    }
}
