using AJWManagementPortal.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Account.Controllers
{
    //This Controller For ::Internal Account Ledgers /Daily/Monthly/Yearly for Account Office::
    [Area("Account")]
    public class InternalAccountLedgersController : Controller
    {
        private readonly ApplicationDbContext _db;
        //private readonly IWebHostEnvironment _iwebhost;
        //IWebHostEnvironment iwebhost
        //                _iwebhost = iwebhost;

        public InternalAccountLedgersController(ApplicationDbContext db)
        {
            _db = db;

        }
        //GET -- InternalAccountLedgerBook List
        public IActionResult InternalAccountLedgerBookList()
        {
            return View();
        }
        //GET -- InternalAccountLedgerBook List ended
        //POST -- InternalAccountLedgerBook List
        //POST -- InternalAccountLedgerBook List ended

        //GET -- DailyInternalAccountLedgerBookList List
        public IActionResult DailyInternalAccountLedgerBook()
        {
            return View();
        }
        //GET -- DailyInternalAccountLedgerBookList List ended
        //POST -- DailyInternalAccountLedgerBookList List
        //POST -- DailyInternalAccountLedgerBookList List ended

        //-----start------Internal Account Ledger Book-------------subledger------=-------------------------------------- 

        //GET----1----MeezanBankAccount---start---  
        public IActionResult MeezanBankAccountLedger()
        {
            return View();
        }
        //GET----1----MeezanBankAccount---ended---
        //POST----1----MeezanBankAccount---start---
        //POST----1----MeezanBankAccount---ended---

        //GET----2----PunjabBankAccount---start---  
        public IActionResult PunjabBankAccountLedger()
        {
            return View();
        }
        //GET----2----PunjabBankAccount---ended---
        //POST----2----PunjabBankAccount---start---
        //POST----2----PunjabBankAccount---ended---

        //GET----3----PettyCashAccount---start---  
        public IActionResult PettyCashAccountLedger()
        {
            return View();
        }
        //GET----3----PettyCashAccount---ended---
        //POST----3----PettyCashAccount---start---
        //POST----3----PettyCashAccount---ended---

        //GET----4----IndustryMobileBalance---start---  
        public IActionResult IndustryMobileBalanceLedger()
        {
            return View();
        }
        //GET----4----IndustryMobileBalance---ended---
        //POST----4----IndustryMobileBalance---start---
        //POST----4----IndustryMobileBalance---ended---

        //GET----5----AsimShabSpecialBudget---start---  
        public IActionResult AsimShabSpecialBudgetLedger()
        {
            return View();
        }
        //GET----5----AsimShabSpecialBudget---ended---
        //POST----5----AsimShabSpecialBudget---start---
        //POST----5----AsimShabSpecialBudget---ended---

        //GET----6----EmployeeMonthlySalaryBankAccount---start---  
        public IActionResult EmployeeMonthlySalaryBankAccountLedger()
        {
            return View();
        }
        //GET----6----EmployeeMonthlySalaryBankAccount---ended---
        //POST----6----EmployeeMonthlySalaryBankAccount---start---
        //POST----6----EmployeeMonthlySalaryBankAccount---ended---

        //GET----7----EmployeeMonthlySalaryInternalAccount---start---  
        public IActionResult EmployeeMonthlySalaryInternalAccountLedger()
        {
            return View();
        }
        //GET----7----EmployeeMonthlySalaryInternalAccount---ended---
        //POST----7----EmployeeMonthlySalaryInternalAccount---start---
        //POST----7----EmployeeMonthlySalaryInternalAccount---ended---

        //GET----8----SocialSecurityFee---start---  
        public IActionResult SocialSecurityFeeLedger()
        {
            return View();
        }
        //GET----8----SocialSecurityFee---ended---
        //POST----8----SocialSecurityFee---start---
        //POST----8----SocialSecurityFee---ended---

        //GET----9----EOBIMonthlyFee---start---  
        public IActionResult EOBIMonthlyFeeLedger()
        {
            return View();
        }
        //GET----9----EOBIMonthlyFee---ended---
        //POST----9----EOBIMonthlyFee---start---
        //POST----9----EOBIMonthlyFee---ended---

        //GET----10----IndustryInternetPackage---start---  
        public IActionResult IndustryInternetPackageLedger()
        {
            return View();
        }
        //GET----10----IndustryInternetPackage---ended---
        //POST----10----IndustryInternetPackage---start---
        //POST----10----IndustryInternetPackage---ended---

        //GET----11----IndustryMotorcycleService---start---  
        public IActionResult IndustryMotorcycleServiceLedger()
        {
            return View();
        }
        //GET----11----IndustryMotorcycleService---ended---
        //POST----11----IndustryMotorcycleService---start---
        //POST----11----IndustryMotorcycleService---ended---

        //GET----12----ElectricMaterial---start---  
        public IActionResult ElectricMaterialLedger()
        {
            return View();
        }
        //GET----12----ElectricMaterial---ended---
        //POST----12----ElectricMaterial---start---
        //POST----12----ElectricMaterial---ended---

        //GET----13----AccessoryMaterial---start---  
        public IActionResult AccessoryMaterialLedger()
        {
            return View();
        }
        //GET----13----AccessoryMaterial---ended---
        //POST----13----AccessoryMaterial---start---
        //POST----13----AccessoryMaterial---ended---

        //GET----13----ToolsMaterialLedger---start---  
        public IActionResult ToolsMaterialLedger()
        {
            return View();
        }
        //GET----13----ToolsMaterialLedger---ended---
        //POST----13----ToolsMaterialLedger---start---
        //POST----13----ToolsMaterialLedger---ended---

        //GET----14----StationaryMaterial---start---  
        public IActionResult StationaryMaterialLedger()
        {
            return View();
        }
        //GET----14----StationaryMaterial---ended---
        //POST----14----StationaryMaterial---start---
        //POST----14----StationaryMaterial---ended---

        //GET----15----StoreMaterial---start---  
        public IActionResult StoreMaterialLedger()
        {
            return View();
        }
        //GET----15----StoreMaterial---ended---
        //POST----15----StoreMaterial---start---
        //POST----15----StoreMaterial---ended---

        //GET----16----CivlWorkMaterial---start---  
        public IActionResult CivlWorkMaterialLedger()
        {
            return View();
        }
        //GET----16----CivlWorkMaterial---ended---
        //POST----16----CivlWorkMaterial---start---
        //POST----16----CivlWorkMaterial---ended---

        //GET----17----IndustryMilkBill---start---  
        public IActionResult IndustryMilkBillLedger()
        {
            return View();
        }
        //GET----17----IndustryMilkBill---ended---
        //POST----17----IndustryMilkBill---start---
        //POST----17----IndustryMilkBill---ended---

        //GET----18----IndustryElectricBill---start---  
        public IActionResult IndustryElectricBillLedger()
        {
            return View();
        }
        //GET----18----IndustryElectricBill---ended---
        //POST----18----IndustryElectricBill---start---
        //POST----18----IndustryElectricBill---ended---

        //GET----19----Transportation---start---  
        public IActionResult TransportationLedger()
        {
            return View();
        }
        //GET----19----Transportation---ended---
        //POST----19----Transportation---start---
        //POST----19----Transportation---ended---

        //GET----20----StaffAdvance---start---  
        public IActionResult StaffAdvanceLedger()
        {
            return View();
        }
        //GET----20----StaffAdvance---ended---
        //POST----20----StaffAdvance---start---
        //POST----20----StaffAdvance---ended---

        //GET----21----StaffLoan---start---  
        public IActionResult StaffLoanLedger()
        {
            return View();
        }
        //GET----21----StaffLoan---ended---
        //POST----21----StaffLoan---start---
        //POST----21----StaffLoan---ended---

        //GET----22----AccessoryRepairing---start---  
        public IActionResult AccessoryRepairingLedger()
        {
            return View();
        }
        //GET----22----AccessoryRepairing---ended---
        //POST----22----AccessoryRepairing---start---
        //POST----22----AccessoryRepairing---ended---

        //GET----23----MazdoriiLabour---start---  
        public IActionResult LabourWagesLedger()
        {
            return View();
        }
        //GET----23----MazdoriiLabour---ended---
        //POST----23----MazdoriiLabour---start---
        //POST----23----MazdoriiLabour---ended---

        //GET----24----Mutfarriq---start---  
        public IActionResult MutfarriqLedger()
        {
            return View();
        }
        //GET----24----Mutfarriq---ended---
        //POST----24----Mutfarriq---start---
        //POST----24----Mutfarriq---ended---

        //GET----25----InternalAccountClosingBalanceReceipt---start---  
        public IActionResult InternalAccountClosingBalanceReceiptLedger()
        {
            return View();
        }
        //GET----25----InternalAccountClosingBalanceReceipt---ended---
        //POST----25----InternalAccountClosingBalanceReceipt---start---
        //POST----25----InternalAccountClosingBalanceReceipt---ended---

        //GET----26----ClosingBalanceAddBank---start---  
        public IActionResult ClosingBalanceAddBankLedger()
        {
            return View();
        }
        //GET----26----ClosingBalanceAddBank---ended---
        //POST----26----ClosingBalanceAddBank---start---
        //POST----26----ClosingBalanceAddBank---ended---

        //GET----27----IndustryKitchenMaterial---start---  
        public IActionResult IndustryKitchenMaterialLedger()
        {
            return View();
        }
        //GET----27----IndustryKitchenMaterial---ended---
        //POST----27----IndustryKitchenMaterial---start---
        //POST----27----ClosingBIndustryKitchenMaterialalanceAddBank---ended---

        //GET----28----PettyCashExpenseInternalAccount---start---  
        public IActionResult PettyCashExpenseInternalAccountLedger()
        {
            return View();
        }
        //GET----28----PettyCashExpenseInternalAccount---ended---
        //POST----28----PettyCashExpenseInternalAccount---start---
        //POST----28----PettyCashExpenseInternalAccount---ended---

        //GET----29----GatePassExpense---start---  
        public IActionResult GatePassExpenseLedger()
        {
            return View();
        }
        //GET----29----GatePassExpense---ended---
        //POST----29----GatePassExpense---start---
        //POST----29----GatePassExpense---ended---

        //GET----30----ClosingCashInHandLedger---start---  
        public IActionResult ClosingCashInHandLedger()
        {
            return View();
        }
        //GET----30----ClosingCashInHandLedger---ended---
        //POST----30----ClosingCashInHandLedger---start---
        //POST----30----ClosingCashInHandLedger---ended---

        //GET----31----IndustryAutoRikshaServiceLedger---start---  
        public IActionResult IndustryAutoRikshaServiceLedger()
        {
            return View();
        }
        //GET----31----IndustryAutoRikshaServiceLedger---ended---
        //POST----31----IndustryAutoRikshaServiceLedger---start---
        //POST----31----IndustryAutoRikshaServiceLedger---ended---

        //-------Ended----------Internal Account Ledger Book------subledger------=--------------------------------------  

    }
}
