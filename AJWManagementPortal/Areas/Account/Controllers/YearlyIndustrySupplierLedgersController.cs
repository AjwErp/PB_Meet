using AJWManagementPortal.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Account.Controllers
{
    //This Controller for::Yearly Industry Supplier Ledger for Account Office::
    [Area("Account")]
    public class YearlyIndustrySupplierLedgersController : Controller
    {
        private readonly ApplicationDbContext _db;
        //private readonly IWebHostEnvironment _iwebhost;
        //IWebHostEnvironment iwebhost
        //                _iwebhost = iwebhost;

        public YearlyIndustrySupplierLedgersController(ApplicationDbContext db)
        {
            _db = db;

        }
        //-----start------Industry Supplier Ledgers Book-------------Subledger------=-------------------------------------- 
        //GET- for  YearlyIndustrySupplierLedgerBookList
        public IActionResult YearlyIndustrySupplierLedgerBookList()
        {
            return View();
        }
        //GET- for  YearlyIndustrySupplierLedgerBookList ended
        //POST- for  YearlyIndustrySupplierLedgerBookList 
        //POST- for  YearlyIndustrySupplierLedgerBookList ended
        ////GET - for YearlyIndustrySupplierLedgerBookList
        //GET----1----YearlyRafiqIronMianChannu---start---  
        public IActionResult YearlyRafiqIronMianChannu()
        {
            return View();
        }
        //GET----1----YearlyRafiqIronMianChannu---ended---
        //POST----1----YearlyRafiqIronMianChannu---start---
        //POST----1----YearlyRafiqIronMianChannu---ended---

        //GET----2----YearlySalamatPaintHouseLedger---start---  
        public IActionResult YearlySalamatPaintHouseLedger()
        {
            return View();
        }
        //GET----2----YearlySalamatPaintHouseLedger---ended---
        //POST----2----YearlySalamatPaintHouseLedger---start---
        //POST----2----YearlySalamatPaintHouseLedger---ended---

        //GET----3----YearlyBhuttaAgroHardwareMianChannuLedger---start---  
        public IActionResult YearlyBhuttaAgroHardwareMianChannuLedger()
        {
            return View();
        }
        //GET----3----YearlyBhuttaAgroHardwareMianChannuLedger---ended---
        //POST----3----YearlyBhuttaAgroHardwareMianChannuLedger---start---
        //POST----3----YearlyBhuttaAgroHardwareMianChannuLedger---ended---

        //GET----4----YearlyNadeemJawaidBearingMianChannuLedger---start---  
        public IActionResult YearlyNadeemJawaidBearingMianChannuLedger()
        {
            return View();
        }
        //GET----4----YearlyNadeemJawaidBearingMianChannuLedger---ended---
        //POST----4----YearlyNadeemJawaidBearingMianChannuLedger---start---
        //POST----4----YearlyNadeemJawaidBearingMianChannuLedger---ended---

        //GET----5----YearlyAlisanitaryStoreMianChannuLedger---start---  
        public IActionResult YearlyAlisanitaryStoreMianChannuLedger()
        {
            return View();
        }
        //GET----5----YearlyAlisanitaryStoreMianChannuLedger---ended---
        //POST----5----YearlyAlisanitaryStoreMianChannuLedger---start---
        //POST----5----YearlyAlisanitaryStoreMianChannuLedger---ended---

        //GET----6----YearlyRoobaDigitalMianChannuLedger---start---  
        public IActionResult YearlyRoobaDigitalMianChannuLedger()
        {
            return View();
        }
        //GET----6----YearlyRoobaDigitalMianChannuLedger---ended---
        //POST----6----YearlyRoobaDigitalMianChannuLedger---start---
        //POST----6----YearlyRoobaDigitalMianChannuLedger---ended---

        //GET----7----YearlySaeedElectricStoreMianChannuLedger---start---  
        public IActionResult YearlySaeedElectricStoreMianChannuLedger()
        {
            return View();
        }
        //GET----7----YearlySaeedElectricStoreMianChannuLedger---ended---
        //POST----7----YearlySaeedElectricStoreMianChannuLedger---start---
        //POST----7----YearlySaeedElectricStoreMianChannuLedger---ended---

        //GET----8----YearlyAyoubPetroliumServiceTulambaLedger---start---  
        public IActionResult YearlyAyoubPetroliumServiceTulambaLedger()
        {
            return View();
        }
        //GET----8----YearlyAyoubPetroliumServiceTulambaLedger---ended---
        //POST----8----YearlyAyoubPetroliumServiceTulambaLedger---start---
        //POST----8----YearlyAyoubPetroliumServiceTulambaLedger---ended---

        //GET----9----YearlySadiqAluminiumMakdoomPurLedger---start---  
        public IActionResult YearlySadiqAluminiumMakdoomPurLedger()
        {
            return View();
        }
        //GET----9----YearlySadiqAluminiumMakdoomPurLedger---ended---
        //POST----9----YearlySadiqAluminiumMakdoomPurLedger---start---
        //POST----9----YearlySadiqAluminiumMakdoomPurLedger---ended---

        //GET----10----YearlyKhursheedIronStoreMianChannuLedger---start---  
        public IActionResult YearlyKhursheedIronStoreMianChannuLedger()
        {
            return View();
        }
        //GET----10----YearlyKhursheedIronStoreMianChannuLedger---ended---
        //POST----10----YearlyKhursheedIronStoreMianChannuLedger---start---
        //POST----10----YearlyKhursheedIronStoreMianChannuLedger---ended---

        //GET----11----YearlyMughalIronStoreTulambaLedger---start---  
        public IActionResult YearlyMughalIronStoreTulambaLedger()
        {
            return View();
        }
        //GET----11----YearlyMughalIronStoreTulambaLedger---ended---
        //POST----11----YearlyMughalIronStoreTulambaLedger---start---
        //POST----11----YearlyMughalIronStoreTulambaLedger---ended---

        //GET----12----YearlyTariqAutosTulambaLedger---start---  
        public IActionResult YearlyTariqAutosTulambaLedger()
        {
            return View();
        }
        //GET----12----YearlyTariqAutosTulambaLedger---ended---
        //POST----12----YearlyTariqAutosTulambaLedger---start---
        //POST----12----YearlyTariqAutosTulambaLedger---ended---

        //GET----13----YearlyLiveUpWaterSupplyTulambaLedger---start---  
        public IActionResult YearlyLiveUpWaterSupplyTulambaLedger()
        {
            return View();
        }
        //GET----13----YearlyLiveUpWaterSupplyTulambaLedger---ended---
        //POST----13----YearlyLiveUpWaterSupplyTulambaLedger---start---
        //POST----13----YearlyLiveUpWaterSupplyTulambaLedger---ended---

        //GET----14----YearlyMughalInteriorsCNCPlasmaMachineLedger---start---  
        public IActionResult YearlyMughalInteriorsCNCPlasmaMachineLedger()
        {
            return View();
        }
        //GET----14----YearlyMughalInteriorsCNCPlasmaMachineLedger---ended---
        //POST----14----YearlyMughalInteriorsCNCPlasmaMachineLedger---start---
        //POST----14----YearlyMughalInteriorsCNCPlasmaMachineLedger---ended---

        //GET----15----YearlyAsiaCollingCenterLedger---start---  
        public IActionResult YearlyAsiaCollingCenterLedger()
        {
            return View();
        }
        //GET----15----YearlyAsiaCollingCenterLedger---ended---
        //POST----15----YearlyAsiaCollingCenterLedger---start---
        //POST----15----YearlyAsiaCollingCenterLedger---ended---

        //GET----16----YearlyMarkzadabLedger---start---  
        public IActionResult YearlyMarkzadabLedger()
        {
            return View();
        }
        //GET----16----YearlyMarkzadabLedger---ended---
        //POST----16----YearlyMarkzadabLedger---start---
        //POST----16----YearlyMarkzadabLedger---ended---

        //GET----17----YearlyLuckyAutosLedger---start---  
        public IActionResult YearlyLuckyAutosLedger()
        {
            return View();
        }
        //GET----17----YearlyLuckyAutosLedger---ended---
        //POST----17----YearlyLuckyAutosLedger---start---
        //POST----17----YearlyLuckyAutosLedger---ended---

        //GET----18----YearlyGillaniShoppingCenterLedger---start---  
        public IActionResult YearlyGillaniShoppingCenterLedger()
        {
            return View();
        }
        //GET----18----YearlyGillaniShoppingCenterLedger---ended---
        //POST----18----YearlyGillaniShoppingCenterLedger---start---
        //POST----18----YearlyGillaniShoppingCenterLedger---ended---
        //-----Ended------Industry Supplier Ledgers Book-------------Subledger------=-------------------------------------- 

    }
}
