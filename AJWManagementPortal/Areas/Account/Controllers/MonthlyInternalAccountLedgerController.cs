using AJWManagementPortal.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Account.Controllers
{

    //This Controller for ::Monthly Internal Account Ledger for Account Office::

    [Area("Account")]
    public class MonthlyInternalAccountLedgerController : Controller
    {
        private readonly ApplicationDbContext _db;
        //private readonly IWebHostEnvironment _iwebhost;
        //IWebHostEnvironment iwebhost
        //                _iwebhost = iwebhost;

        public MonthlyInternalAccountLedgerController(ApplicationDbContext db)
        {
            _db = db;

        }
        //GET -- MonthlyInternalAccountLedgerBookList List
        public IActionResult MonthlyInternalAccountLedgerBookList()
        {
            return View();
        }
        //GET -- MonthlyInternalAccountLedgerBookList List ended
        //POST -- MonthlyInternalAccountLedgerBookList List
        //POST -- MonthlyInternalAccountLedgerBookList List ended
        //GET - for InternalAccountLedgerBook
        //-----start------Internal Account Ledger Book-------------subledger------=-------------------------------------- 

        //GET----1----MonthlyMeezanBankAccountLedger---start---  
        public IActionResult MonthlyMeezanBankAccountLedger()
        {
            return View();
        }
        //GET----1----MonthlyMeezanBankAccountLedger---ended---
        //POST----1----MonthlyMeezanBankAccountLedger---start---
        //POST----1----MonthlyMeezanBankAccountLedger---ended---

        //GET----2----MonthlyPunjabBankAccountLedger---start---  
        public IActionResult MonthlyPunjabBankAccountLedger()
        {
            return View();
        }
        //GET----2----MonthlyPunjabBankAccountLedger---ended---
        //POST----2----MonthlyPunjabBankAccountLedger---start---
        //POST----2----MonthlyPunjabBankAccountLedger---ended---

        //GET----3----PettyCashAccount---start---  
        public IActionResult MonthlyPettyCashAccountLedger()
        {
            return View();
        }
        //GET----3----PettyCashAccount---ended---
        //POST----3----PettyCashAccount---start---
        //POST----3----PettyCashAccount---ended---

        //GET----4----MonthlyIndustryMobileBalanceLedger---start---  
        public IActionResult MonthlyIndustryMobileBalanceLedger()
        {
            return View();
        }
        //GET----4----MonthlyIndustryMobileBalanceLedger---ended---
        //POST----4----MonthlyIndustryMobileBalanceLedger---start---
        //POST----4----MonthlyIndustryMobileBalanceLedger---ended---

        //GET----5----MonthlyAsimShabSpecialBudgetLedger---start---  
        public IActionResult MonthlyAsimShabSpecialBudgetLedger()
        {
            return View();
        }
        //GET----5----MonthlyAsimShabSpecialBudgetLedger---ended---
        //POST----5----MonthlyAsimShabSpecialBudgetLedger---start---
        //POST----5----MonthlyAsimShabSpecialBudgetLedger---ended---

        //GET----6----MonthlyEmployeeMonthlySalaryBankAccountLedger---start---  
        public IActionResult MonthlyEmployeeMonthlySalaryBankAccountLedger()
        {
            return View();
        }
        //GET----6----MonthlyEmployeeMonthlySalaryBankAccountLedger---ended---
        //POST----6----MonthlyEmployeeMonthlySalaryBankAccountLedger---start---
        //POST----6----MonthlyEmployeeMonthlySalaryBankAccountLedger---ended---

        //GET----7----MonthlyEmployeeMonthlySalaryInternalAccountLedger---start---  
        public IActionResult MonthlyEmployeeMonthlySalaryInternalAccountLedger()
        {
            return View();
        }
        //GET----7----MonthlyEmployeeMonthlySalaryInternalAccountLedger---ended---
        //POST----7----MonthlyEmployeeMonthlySalaryInternalAccountLedger---start---
        //POST----7----MonthlyEmployeeMonthlySalaryInternalAccountLedger---ended---

        //GET----8----MonthlySocialSecurityFeeLedger---start---  
        public IActionResult MonthlySocialSecurityFeeLedger()
        {
            return View();
        }
        //GET----8----MonthlySocialSecurityFeeLedger---ended---
        //POST----8----MonthlySocialSecurityFeeLedger---start---
        //POST----8----MonthlySocialSecurityFeeLedger---ended---

        //GET----9----MonthlyEOBIMonthlyFeeLedger---start---  
        public IActionResult MonthlyEOBIMonthlyFeeLedger()
        {
            return View();
        }
        //GET----9----MonthlyEOBIMonthlyFeeLedger---ended---
        //POST----9----MonthlyEOBIMonthlyFeeLedger---start---
        //POST----9----MonthlyEOBIMonthlyFeeLedger---ended---

        //GET----10----MonthlyIndustryInternetPackageLedger---start---  
        public IActionResult MonthlyIndustryInternetPackageLedger()
        {
            return View();
        }
        //GET----10----MonthlyIndustryInternetPackageLedger---ended---
        //POST----10----MonthlyIndustryInternetPackageLedger---start---
        //POST----10----MonthlyIndustryInternetPackageLedger---ended---

        //GET----11----MonthlyIndustryMotorcycleServiceLedger---start---  
        public IActionResult MonthlyIndustryMotorcycleServiceLedger()
        {
            return View();
        }
        //GET----11----MonthlyIndustryMotorcycleServiceLedger---ended---
        //POST----11----MonthlyIndustryMotorcycleServiceLedger---start---
        //POST----11----MonthlyIndustryMotorcycleServiceLedger---ended---

        //GET----12----MonthlyElectricMaterialLedger---start---  
        public IActionResult MonthlyElectricMaterialLedger()
        {
            return View();
        }
        //GET----12----MonthlyElectricMaterialLedger---ended---
        //POST----12----MonthlyElectricMaterialLedger---start---
        //POST----12----MonthlyElectricMaterialLedger---ended---

        //GET----13----MonthlyAccessoryMaterialLedger---start---  
        public IActionResult MonthlyAccessoryMaterialLedger()
        {
            return View();
        }
        //GET----13----MonthlyAccessoryMaterialLedger---ended---
        //POST----13----MonthlyAccessoryMaterialLedger---start---
        //POST----13----MonthlyAccessoryMaterialLedger---ended---

        //GET----13----MonthlyToolsMaterialLedger---start---  
        public IActionResult MonthlyToolsMaterialLedger()
        {
            return View();
        }
        //GET----13----MonthlyToolsMaterialLedger---ended---
        //POST----13----MonthlyToolsMaterialLedger---start---
        //POST----13----MonthlyToolsMaterialLedger---ended---

        //GET----14----MonthlyStationaryMaterialLedger---start---  
        public IActionResult MonthlyStationaryMaterialLedger()
        {
            return View();
        }
        //GET----14----MonthlyStationaryMaterialLedger---ended---
        //POST----14----MonthlyStationaryMaterialLedger---start---
        //POST----14----MonthlyStationaryMaterialLedger---ended---

        //GET----15----MonthlyStoreMaterialLedger---start---  
        public IActionResult MonthlyStoreMaterialLedger()
        {
            return View();
        }
        //GET----15----MonthlyStoreMaterialLedger---ended---
        //POST----15----MonthlyStoreMaterialLedger---start---
        //POST----15----MonthlyStoreMaterialLedger---ended---

        //GET----16----MonthlyCivilWorkMaterialLedger---start---  
        public IActionResult MonthlyCivilWorkMaterialLedger()
        {
            return View();
        }
        //GET----16----MonthlyCivilWorkMaterialLedger---ended---
        //POST----16----MonthlyCivilWorkMaterialLedger---start---
        //POST----16----MonthlyCivilWorkMaterialLedger---ended---

        //GET----17----MonthlyIndustryMilkBillLedger---start---  
        public IActionResult MonthlyIndustryMilkBillLedger()
        {
            return View();
        }
        //GET----17----MonthlyIndustryMilkBillLedger---ended---
        //POST----17----MonthlyIndustryMilkBillLedger---start---
        //POST----17----MonthlyIndustryMilkBillLedger---ended---

        //GET----18----IndustryElectricBill---start---  
        public IActionResult MonthlyIndustryElectricBillLedger()
        {
            return View();
        }
        //GET----18----MonthlyIndustryElectricBillLedger---ended---
        //POST----18----MonthlyIndustryElectricBillLedger---start---
        //POST----18----MonthlyIndustryElectricBillLedger---ended---

        //GET----19----MonthlyTransportationLedger---start---  
        public IActionResult MonthlyTransportationLedger()
        {
            return View();
        }
        //GET----19----MonthlyTransportationLedger---ended---
        //POST----19----MonthlyTransportationLedger---start---
        //POST----19----MonthlyTransportationLedger---ended---

        //GET----20----MonthlyStaffAdvanceLedger---start---  
        public IActionResult MonthlyStaffAdvanceLedger()
        {
            return View();
        }
        //GET----20----MonthlyStaffAdvanceLedger---ended---
        //POST----20----MonthlyStaffAdvanceLedger---start---
        //POST----20----MonthlyStaffAdvanceLedger---ended---

        //GET----21----MonthlyStaffLoanLedger---start---  
        public IActionResult MonthlyStaffLoanLedger()
        {
            return View();
        }
        //GET----21----MonthlyStaffLoanLedger---ended---
        //POST----21----MonthlyStaffLoanLedger---start---
        //POST----21----MonthlyStaffLoanLedger---ended---

        //GET----22----MonthlyAccessoryRepairingLedger---start---  
        public IActionResult MonthlyAccessoryRepairingLedger()
        {
            return View();
        }
        //GET----22----MonthlyAccessoryRepairingLedger---ended---
        //POST----22----MonthlyAccessoryRepairingLedger---start---
        //POST----22----MonthlyAccessoryRepairingLedger---ended---

        //GET----23----MonthlyMazdoriiLabourLedger---start---  
        public IActionResult MonthlyLabourWagesLedger()
        {
            return View();
        }
        //GET----23----MonthlyMazdoriiLabourLedger---ended---
        //POST----23----MonthlyMazdoriiLabourLedger---start---
        //POST----23----MonthlyMazdoriiLabourLedger---ended---

        //GET----24----MonthlyMutfarriqLedger---start---  
        public IActionResult MonthlyMutfarriqLedger()
        {
            return View();
        }
        //GET----24----MonthlyMutfarriqLedger---ended---
        //POST----24----MonthlyMutfarriqLedger---start---
        //POST----24----MonthlyMutfarriqLedger---ended---

        //GET----25----MonthlyInternalAccountClosingBalanceReceiptLedger---start---  
        public IActionResult MonthlyInternalAccountClosingBalanceReceiptLedger()
        {
            return View();
        }
        //GET----25----MonthlyInternalAccountClosingBalanceReceiptLedger---ended---
        //POST----25----MonthlyInternalAccountClosingBalanceReceiptLedger---start---
        //POST----25----MonthlyInternalAccountClosingBalanceReceiptLedger---ended---

        //GET----26----MonthlyClosingBalanceAddBankLedger---start---  
        public IActionResult MonthlyClosingBalanceAddBankLedger()
        {
            return View();
        }
        //GET----26----MonthlyClosingBalanceAddBankLedger---ended---
        //POST----26----MonthlyClosingBalanceAddBankLedger---start---
        //POST----26----MonthlyClosingBalanceAddBankLedger---ended---

        //GET----27----MonthlyIndustryKitchenMaterialLedger---start---  
        public IActionResult MonthlyIndustryKitchenMaterialLedger()
        {
            return View();
        }
        //GET----27----MonthlyIndustryKitchenMaterialLedger---ended---
        //POST----27----MonthlyIndustryKitchenMaterialLedger---start---
        //POST----27----MonthlyIndustryKitchenMaterialLedger---ended---

        //GET----28----MonthlyPettyCashExpenseInternalAccountLedger---start---  
        public IActionResult MonthlyPettyCashExpenseInternalAccountLedger()
        {
            return View();
        }
        //GET----28----MonthlyPettyCashExpenseInternalAccountLedger---ended---
        //POST----28----MonthlyPettyCashExpenseInternalAccountLedger---start---
        //POST----28----MonthlyPettyCashExpenseInternalAccountLedger---ended---

        //GET----29----MonthlyGatePassExpenseLedger---start---  
        public IActionResult MonthlyGatePassExpenseLedger()
        {
            return View();
        }
        //GET----29----MonthlyGatePassExpenseLedger---ended---
        //POST----29----MonthlyGatePassExpenseLedger---start---
        //POST----29----MonthlyGatePassExpenseLedger---ended---

        //GET----30----MonthlyClosingCashInHandLedger---start---  
        public IActionResult MonthlyClosingCashInHandLedger()
        {
            return View();
        }
        //GET----30----MonthlyClosingCashInHandLedger---ended---
        //POST----30----MonthlyClosingCashInHandLedger---start---
        //POST----30----MonthlyClosingCashInHandLedger---ended---

        //GET----31----MonthlyIndustryAutoRikshaServiceLedger---start---  
        public IActionResult MonthlyIndustryAutoRikshaServiceLedger()
        {
            return View();
        }
        //GET----31----MonthlyIndustryAutoRikshaServiceLedger---ended---
        //POST----31----MonthlyIndustryAutoRikshaServiceLedger---start---
        //POST----31----MonthlyIndustryAutoRikshaServiceLedger---ended---

        //-------Ended----------Internal Account Ledger Book------subledger------=--------------------------------------  

    }
}


