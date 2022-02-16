using AJWManagementPortal.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AJWManagementPortal.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        //This is valid Referance for Application DB
        //This Referance for Application User for Identity Morefieldstoidentity in Register.cs/Register.cshtml
        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        //This Referance for UserTable but We confuse not Conform
        public DbSet<UserModel> UserTable { get; set; }

        //Model clases for DB Table these are not use are useless tables---start
        public DbSet<Noticb> Noticb { get; set; }
        public DbSet<DailyPlanIn> DailyPlanIn { get; set; }
        public DbSet<DailyPlanOut> DailyPlanOut { get; set; }
        public DbSet<DailyPlanInAccounts> DailyPlanInAccountss { get; set; }
        public DbSet<DailyPlanOutAccounts> DailyPlanOutAccountss { get; set; }
        public DbSet<MonthlyGeneralLedgerBook> MonthlyGeneralLedgerBook { get; set; }
        public DbSet<YearlyGeneralLedgerBook> YearlyGeneralLedgerBook { get; set; }
        public DbSet<Img> Img { get; set; }
        public DbSet<AccountDailyContinueSheetM> DailyContinueSheetMs { get; set; }
        public DbSet<aDailyCash> aDailyCashes { get; set; }
        public DbSet<BankBalane> bankBalane { get; set; }
        public DbSet<MeezanBankIEReport> MeezanBankIEReports { get; set; }
        public DbSet<MeezanBankIEReportVoucher> MeezanBankIEReportsVoucher { get; set; }
        public DbSet<MeezanBankIEVoucher> MeezanBankIEVouchers { get; set; }
        public DbSet<NoticBoard> NoticBoard{ get; set; }
        //Model clases for DB Talbe these are not use are useless tables--------Ended

        //This Referance is For DailyPlan In/Out in Production Office but next we remove it
        public DbSet<DailyPlanInOutModel> DailyPlanInOutModels { get; set; }


        //this is valid referance for AJWDailyPlanIOs migration/DB table/Model class
        public DbSet<AJWDailyPlanIO> AJWDailyPlanIOs { get; set; }

        ////this is valid referance for AJWNoticeBoardHrms migration/DB table/Model class
        public DbSet<AJWNoticeBoardHrm> AJWNoticeBoardHrms { get; set; }

        //this is valid referance for ledger migration/DB table/Model class
        public DbSet<Ledger> Ledgers { get; set; }
        //this is valid referance for Subledger migration/DB table/Model class
        public DbSet<SubLedger> SubLedgers { get; set; }

        //-------------start----------------LAW Books In Admin Department----------------------------------
        //This is Valid  LawBook referance and DB Table
        public DbSet<LawBook> LawBooks { get; set; }

        //This is Valid  FilesOnDatabase referance and DB Table
        public DbSet<FileOnDatabaseModel> FilesOnDatabase { get; set; }
        public DbSet<FileOnDatabaseDmsModel> FilesOnDatabaseDms { get; set; }

        //This is Valid  FilesOnFileSystem referance and DB Table
        public DbSet<FileOnFileSystem> FilesOnFileSystem { get; set; }



        //-------------Ended----------------LAW Books In Admin Department----------------------------------

        //This Valid Referance for AJW Techbnical Staff Working Plan
        public DbSet<TechnicalStaffWorkPlan> TechnicalStaffWorkPlans { get; set; }

        //This is Valid Referance for AJW Management Staff Work Plan
        public DbSet<ManagementStaffWorkPlan> ManagementStaffWorkPlans { get; set; }

        //-------------start----------------HRM Department---File Uploading by PDf Form-------------------------------

        //This is Valid  FilesOnDatabase referance and DB Table
        //public DbSet<HrmFileOnDatabaseModel> HrmFilesOnDatabase { get; set; }

        //This is Valid  FilesOnFileSystem referance and DB Table
        //public DbSet<HrmFileOnFileSystem> HrmFilesOnFileSystem { get; set; }

        //-------------Ended----------------HRM Department---File Uploading by PDf Form----------------------------------

        //This is Valid  FilesOnDatabase referance and DB Table
        public DbSet<HrmFileOnDatabaseModel> HrmFilesOnDatabase { get; set; }
        public DbSet<HrmFileOnDatabaseDmsModel> HrmFilesOnDatabaseDms { get; set; }

        //This is Valid  FilesOnFileSystem referance and DB Table
        public DbSet<HrmFileOnFileSystem> HrmFilesOnFileSystem { get; set; }
        //-------------Ended----------------HRM Department---File Uploading by PDf Form----------------------------------
        //-------------Ended----------------Production Department---File Uploading by PDf Form----------------------------------

        //This is Valid FilesOnDatabase referance and DB Table
        public DbSet<ProductionFileOnDatabaseModel> ProductionFilesOnDatabase { get; set; }
        public DbSet<ProductionFileOnDatabaseDmsModel> ProductionFilesOnDatabaseDms { get; set; }

        //This is Valid  FilesOnFileSystem referance and DB Table
        public DbSet<ProductionFileOnFileSystem> ProductionFilesOnFileSystem { get; set; }
        //-------------Ended----------------Production Department---File Uploading by PDf Form----------------------------------
        //-------------Ended----------------DGM Department---File Uploading by PDf Form----------------------------------

        //This is Valid FilesOnDatabase referance and DB Table
        public DbSet<DgmFileOnDatabaseModel> DgmFilesOnDatabase { get; set; }
        public DbSet<DgmFileOnDatabaseDmsModel> DgmFilesOnDatabaseDms { get; set; }

        //This is Valid  FilesOnFileSystem referance and DB Table
        public DbSet<DgmFileOnFileSystem> DgmFilesOnFileSystem { get; set; }
        //-------------Ended----------------DGM Department---File Uploading by PDf Form----------------------------------
        //-------------Ended----------------Accounts Department---File Uploading by PDf Form----------------------------------

        //This is Valid FilesOnDatabase referance and DB Table
        public DbSet<AccountsFileOnDatabaseModel> AccountsFilesOnDatabase { get; set; }
        public DbSet<AccountsFileOnDatabaseDmsModel> AccountsFilesOnDatabaseDms { get; set; }

        //This is Valid  FilesOnFileSystem referance and DB Table
        public DbSet<AccountsFileOnFileSystem> AccountsFilesOnFileSystem { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<DailySuppliersCashTransactionReport> dailySuppliers { get; set; }
        //This given referance is for Accounts Daily CashClosing Report external user inputs
        public DbSet<DCashClosingSupplierLedger> DCashClosingSupplierLedgers { get; set; }
        //This given referance is for Accounts Yearly Report Titile Page
        public DbSet<AccountsYearlyReportTitlePage> AccountsYearlyReportTitlePages { get; set; }
        //-------------Ended----------------Accounts Department---File Uploading by PDf Form----------------------------------
        //-------------Ended----------------Store Department---Category And Item ----------------------------------
       //This referance is used for Category of item just
        public DbSet<Category> Categories { get; set; }

        //This Referance used for Item for Category
        public DbSet<Item> Items { get; set; }
        //-------------Ended----------------Store Department---Category And Item----------------------------------
        //This is Valid FilesOnDatabase referance and DB Table
        public DbSet<StoreFileOnDatabaseModel> StoreFilesOnDatabase { get; set; }
        public DbSet<StoreFileOnDatabaseDmsModel> StoreFilesOnDatabaseDms { get; set; }

        //This is Valid  FilesOnFileSystem referance and DB Table
        public DbSet<StoreFileOnFileSystem> StoreFilesOnFileSystem { get; set; }
        //-------------Ended----------------Production Department---File Uploading by PDf Form----------------------------------
    }
}
