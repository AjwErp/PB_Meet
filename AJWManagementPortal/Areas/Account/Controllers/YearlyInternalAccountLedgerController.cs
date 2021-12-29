using AJWManagementPortal.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Account.Controllers
{
    //This Controller for::Yearly Internal Account Ledger Reports For Account Office::
    [Area("Account")]
    public class YearlyInternalAccountLedgerController : Controller
    {
        private readonly ApplicationDbContext _db;
        //private readonly IWebHostEnvironment _iwebhost;
        //IWebHostEnvironment iwebhost
        //                _iwebhost = iwebhost;
        public YearlyInternalAccountLedgerController(ApplicationDbContext db)
        {
            _db = db;

        }
        //GET -- YearlyInternalAccountLedgerBookList List
        public IActionResult YearlyInternalAccountLedgerBookList()
        {
            return View();
        }
        //GET -- YearlyInternalAccountLedgerBookList List ended
        //POST -- YearlyInternalAccountLedgerBookList List
        //POST -- YearlyInternalAccountLedgerBookList List ended
        //GET - for InternalAccountLedgerBook
        //-----start------Internal Account Ledger Book-------------subledger------=-------------------------------------- 

        //GET----1----YearlyMeezanBankAccountLedger---start---  
        public IActionResult YearlyMeezanBankAccountLedger()
        {
            return View();
        }
        //GET----1----YearlyMeezanBankAccountLedger---ended---
        //POST----1----YearlyMeezanBankAccountLedger---start---
        //POST----1----YearlyMeezanBankAccountLedger---ended---

        //GET----2----YearlyPunjabBankAccountLedger---start---  
        public IActionResult YearlyPunjabBankAccountLedger()
        {
            return View();
        }
        //GET----2----YearlyPunjabBankAccountLedger---ended---
        //POST----2----YearlyPunjabBankAccountLedger---start---
        //POST----2----YearlyPunjabBankAccountLedger---ended---

        //GET----3----YearlyPettyCashAccountLedger---start---  
        public IActionResult YearlyPettyCashAccountLedger()
        {
            return View();
        }
        //GET----3----YearlyPettyCashAccountLedger---ended---
        //POST----3----YearlyPettyCashAccountLedger---start---
        //POST----3----YearlyPettyCashAccountLedger---ended---

        //GET----4----YearlyIndustryMobileBalanceLedger---start---  
        public IActionResult YearlyIndustryMobileBalanceLedger()
        {
            return View();
        }
        //GET----4----YearlyIndustryMobileBalanceLedger---ended---
        //POST----4----YearlyIndustryMobileBalanceLedger---start---
        //POST----4----YearlyIndustryMobileBalanceLedger---ended---

        //GET----5----YearlyAsimShabSpecialBudgetLedger---start---  
        public IActionResult YearlyAsimShabSpecialBudgetLedger()
        {
            return View();
        }
        //GET----5----YearlyAsimShabSpecialBudgetLedger---ended---
        //POST----5----YearlyAsimShabSpecialBudgetLedger---start---
        //POST----5----YearlyAsimShabSpecialBudgetLedger---ended---

        //GET----6----YearlyEmployeeMonthlySalaryBankAccountLedger---start---  
        public IActionResult YearlyEmployeeMonthlySalaryBankAccountLedger()
        {
            return View();
        }
        //GET----6----YearlyEmployeeMonthlySalaryBankAccountLedger---ended---
        //POST----6----YearlyEmployeeMonthlySalaryBankAccountLedger---start---
        //POST----6----YearlyEmployeeMonthlySalaryBankAccountLedger---ended---

        //GET----7----YearlyEmployeeMonthlySalaryInternalAccountLedger---start---  
        public IActionResult YearlyEmployeeMonthlySalaryInternalAccountLedger()
        {
            return View();
        }
        //GET----7----YearlyEmployeeMonthlySalaryInternalAccountLedger---ended---
        //POST----7----YearlyEmployeeMonthlySalaryInternalAccountLedger---start---
        //POST----7----YearlyEmployeeMonthlySalaryInternalAccountLedger---ended---

        //GET----8----YearlySocialSecurityFeeLedger---start---  
        public IActionResult YearlySocialSecurityFeeLedger()
        {
            return View();
        }
        //GET----8----YearlySocialSecurityFeeLedger---ended---
        //POST----8----YearlySocialSecurityFeeLedger---start---
        //POST----8----YearlySocialSecurityFeeLedger---ended---

        //GET----9----YearlyEOBIMonthlyFeeLedger---start---  
        public IActionResult YearlyEOBIMonthlyFeeLedger()
        {
            return View();
        }
        //GET----9----YearlyEOBIMonthlyFeeLedger---ended---
        //POST----9----YearlyEOBIMonthlyFeeLedger---start---
        //POST----9----YearlyEOBIMonthlyFeeLedger---ended---

        //GET----10----YearlyIndustryInternetPackageLedger---start---  
        public IActionResult YearlyIndustryInternetPackageLedger()
        {
            return View();
        }
        //GET----10----YearlyIndustryInternetPackageLedger---ended---
        //POST----10----YearlyIndustryInternetPackageLedger---start---
        //POST----10----YearlyIndustryInternetPackageLedger---ended---

        //GET----11----YearlyIndustryMotorcycleServiceLedger---start---  
        public IActionResult YearlyIndustryMotorcycleServiceLedger()
        {
            return View();
        }
        //GET----11----YearlyIndustryMotorcycleServiceLedger---ended---
        //POST----11----YearlyIndustryMotorcycleServiceLedger---start---
        //POST----11----YearlyIndustryMotorcycleServiceLedger---ended---

        //GET----12----YearlyElectricMaterialLedger---start---  
        public IActionResult YearlyElectricMaterialLedger()
        {
            return View();
        }
        //GET----12----YearlyElectricMaterialLedger---ended---
        //POST----12----YearlyElectricMaterialLedger---start---
        //POST----12----YearlyElectricMaterialLedger---ended---

        //GET----13----YearlyAccessoryMaterialLedger---start---  
        public IActionResult YearlyAccessoryMaterialLedger()
        {
            return View();
        }
        //GET----13----YearlyAccessoryMaterialLedger---ended---
        //POST----13----YearlyAccessoryMaterialLedger---start---
        //POST----13----YearlyAccessoryMaterialLedger---ended---

        //GET----13----YearlyToolsMaterialLedger---start---  
        public IActionResult YearlyToolsMaterialLedger()
        {
            return View();
        }
        //GET----13----YearlyToolsMaterialLedger---ended---
        //POST----13----YearlyToolsMaterialLedger---start---
        //POST----13----YearlyToolsMaterialLedger---ended---

        //GET----14----YearlyStationaryMaterialLedger---start---  
        public IActionResult YearlyStationaryMaterialLedger()
        {
            return View();
        }
        //GET----14----YearlyStationaryMaterialLedger---ended---
        //POST----14----YearlyStationaryMaterialLedger---start---
        //POST----14----YearlyStationaryMaterialLedger---ended---

        //GET----15----YearlyStoreMaterialLedger---start---  
        public IActionResult YearlyStoreMaterialLedger()
        {
            return View();
        }
        //GET----15----YearlyStoreMaterialLedger---ended---
        //POST----15----YearlyStoreMaterialLedger---start---
        //POST----15----YearlyStoreMaterialLedger---ended---

        //GET----16----YearlyCivilWorkMaterialLedger---start---  
        public IActionResult YearlyCivilWorkMaterialLedger()
        {
            return View();
        }
        //GET----16----YearlyCivilWorkMaterialLedger---ended---
        //POST----16----YearlyCivilWorkMaterialLedger---start---
        //POST----16----YearlyCivilWorkMaterialLedger---ended---

        //GET----17----YearlyIndustryMilkBillLedger---start---  
        public IActionResult YearlyIndustryMilkBillLedger()
        {
            return View();
        }
        //GET----17----YearlyIndustryMilkBillLedger---ended---
        //POST----17----YearlyIndustryMilkBillLedger---start---
        //POST----17----YearlyIndustryMilkBillLedger---ended---

        //GET----18----YearlyIndustryElectricBillLedger---start---  
        public IActionResult YearlyIndustryElectricBillLedger()
        {
            return View();
        }
        //GET----18----YearlyIndustryElectricBillLedger---ended---
        //POST----18----YearlyIndustryElectricBillLedger---start---
        //POST----18----YearlyIndustryElectricBillLedger---ended---

        //GET----19----YearlyTransportationLedger---start---  
        public IActionResult YearlyTransportationLedger()
        {
            return View();
        }
        //GET----19----YearlyTransportationLedger---ended---
        //POST----19----YearlyTransportationLedger---start---
        //POST----19----YearlyTransportationLedger---ended---

        //GET----20----YearlyStaffAdvanceLedger---start---  
        public IActionResult YearlyStaffAdvanceLedger()
        {
            return View();
        }
        //GET----20----YearlyStaffAdvanceLedger---ended---
        //POST----20----YearlyStaffAdvanceLedger---start---
        //POST----20----YearlyStaffAdvanceLedger---ended---

        //GET----21----YearlyStaffLoanLedger---start---  
        public IActionResult YearlyStaffLoanLedger()
        {
            return View();
        }
        //GET----21----YearlyStaffLoanLedger---ended---
        //POST----21----YearlyStaffLoanLedger---start---
        //POST----21----YearlyStaffLoanLedger---ended---

        //GET----22----YearlyAccessoryRepairingLedger---start---  
        public IActionResult YearlyAccessoryRepairingLedger()
        {
            return View();
        }
        //GET----22----YearlyAccessoryRepairingLedger---ended---
        //POST----22----YearlyAccessoryRepairingLedger---start---
        //POST----22----YearlyAccessoryRepairingLedger---ended---

        //GET----23----YearlyMazdoriiLabourLedger---start---  
        public IActionResult YearlyLabourWagesLedger()
        {
            return View();
        }
        //GET----23----YearlyMazdoriiLabourLedger---ended---
        //POST----23----YearlyMazdoriiLabourLedger---start---
        //POST----23----YearlyMazdoriiLabourLedger---ended---

        //GET----24----YearlyMutfarriqLedger---start---  
        public IActionResult YearlyMutfarriqLedger()
        {
            return View();
        }
        //GET----24----YearlyMutfarriqLedger---ended---
        //POST----24----YearlyMutfarriqLedger---start---
        //POST----24----YearlyMutfarriqLedger---ended---

        //GET----25----YearlyInternalAccountClosingBalanceReceiptLedger---start---  
        public IActionResult YearlyInternalAccountClosingBalanceReceiptLedger()
        {
            return View();
        }
        //GET----25----YearlyInternalAccountClosingBalanceReceiptLedger---ended---
        //POST----25----YearlyInternalAccountClosingBalanceReceiptLedger---start---
        //POST----25----YearlyInternalAccountClosingBalanceReceiptLedger---ended---

        //GET----26----YearlyClosingBalanceAddBankLedger---start---  
        public IActionResult YearlyClosingBalanceAddBankLedger()
        {
            return View();
        }
        //GET----26----YearlyClosingBalanceAddBankLedger---ended---
        //POST----26----YearlyClosingBalanceAddBankLedger---start---
        //POST----26----YearlyClosingBalanceAddBankLedger---ended---

        //GET----27----YearlyIndustryKitchenMaterialLedger---start---  
        public IActionResult YearlyIndustryKitchenMaterialLedger()
        {
            return View();
        }
        //GET----27----YearlyIndustryKitchenMaterialLedger---ended---
        //POST----27----YearlyIndustryKitchenMaterialLedger---start---
        //POST----27----YearlyIndustryKitchenMaterialLedger---ended---

        //GET----28----YearlyPettyCashExpenseInternalAccountLedger---start---  
        public IActionResult YearlyPettyCashExpenseInternalAccountLedger()
        {
            return View();
        }
        //GET----28----YearlyPettyCashExpenseInternalAccountLedger---ended---
        //POST----28----YearlyPettyCashExpenseInternalAccountLedger---start---
        //POST----28----YearlyPettyCashExpenseInternalAccountLedger---ended---

        //GET----29----YearlyGatePassExpenseLedger---start---  
        public IActionResult YearlyGatePassExpenseLedger()
        {
            return View();
        }
        //GET----29----YearlyGatePassExpenseLedger---ended---
        //POST----29----YearlyGatePassExpenseLedger---start---
        //POST----29----YearlyGatePassExpenseLedger---ended---

        //GET----30----YearlyClosingCashInHandLedger---start---  
        public IActionResult YearlyClosingCashInHandLedger()
        {
            return View();
        }
        //GET----30----YearlyClosingCashInHandLedger---ended---
        //POST----30----YearlyClosingCashInHandLedger---start---
        //POST----30----YearlyClosingCashInHandLedger---ended---

        //GET----31----YearlyIndustryAutoRikshaServiceLedger---start---  
        public IActionResult YearlyIndustryAutoRikshaServiceLedger()
        {
            return View();
        }
        //GET----31----YearlyIndustryAutoRikshaServiceLedger---ended---
        //POST----31----YearlyIndustryAutoRikshaServiceLedger---start---
        //POST----31----YearlyIndustryAutoRikshaServiceLedger---ended---

        //-------Ended----------Internal Account Ledger Book------subledger------=--------------------------------------  

    }
}
