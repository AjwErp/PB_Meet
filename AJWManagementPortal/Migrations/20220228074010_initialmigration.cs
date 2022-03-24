using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AJWManagementPortal.Migrations
{
    public partial class initialmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccountsFilesOnDatabase",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    FileType = table.Column<string>(nullable: true),
                    Extension = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    UploadedBy = table.Column<string>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    Data = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountsFilesOnDatabase", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AccountsFilesOnDatabaseDms",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    FileType = table.Column<string>(nullable: true),
                    Extension = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    UploadedBy = table.Column<string>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    Data = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountsFilesOnDatabaseDms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AccountsFilesOnFileSystem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    FileType = table.Column<string>(nullable: true),
                    Extension = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    UploadedBy = table.Column<string>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    FilePath = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountsFilesOnFileSystem", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AccountsYearlyReportTitlePages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YRDate = table.Column<string>(nullable: false),
                    SignAManagerYR = table.Column<string>(nullable: false),
                    AManagerRemarksYR = table.Column<string>(nullable: false),
                    SignDgmYR = table.Column<string>(nullable: true),
                    DgmRemarksYR = table.Column<string>(nullable: true),
                    SignGMYR = table.Column<string>(nullable: true),
                    GMRemarksYR = table.Column<string>(nullable: true),
                    YRStatus = table.Column<string>(nullable: true),
                    YRTitle = table.Column<string>(nullable: true),
                    DelAccountsYR = table.Column<int>(nullable: false),
                    DelDgmYR = table.Column<int>(nullable: false),
                    DelGmYR = table.Column<int>(nullable: false),
                    DelRepoYR = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountsYearlyReportTitlePages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "aDailyCashes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    ValueDate = table.Column<DateTime>(nullable: false),
                    paidAmount = table.Column<float>(nullable: false),
                    clearedAmount = table.Column<float>(nullable: false),
                    lnClearedAmount = table.Column<float>(nullable: false),
                    remainingGained = table.Column<float>(nullable: false),
                    surplus = table.Column<float>(nullable: false),
                    purchaser = table.Column<string>(nullable: true),
                    income = table.Column<float>(nullable: false),
                    pOrder = table.Column<float>(nullable: false),
                    online = table.Column<float>(nullable: false),
                    accountant = table.Column<float>(nullable: false),
                    Remarks = table.Column<string>(nullable: true),
                    SignPManager = table.Column<string>(nullable: true),
                    PManagerRemarks = table.Column<string>(nullable: true),
                    SignGM = table.Column<string>(nullable: true),
                    GMRemarks = table.Column<string>(nullable: true),
                    SignCeo = table.Column<string>(nullable: true),
                    CeoRemarks = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    DelProduction = table.Column<int>(nullable: false),
                    DelGm = table.Column<int>(nullable: false),
                    DelCeo = table.Column<int>(nullable: false),
                    DelRepo = table.Column<int>(nullable: false),
                    LedgerType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_aDailyCashes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AJWDailyPlanIOs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Designation = table.Column<string>(nullable: false),
                    DateTimeIn = table.Column<DateTime>(nullable: false),
                    DateTimeOut = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    Signature = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AJWDailyPlanIOs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AJWNoticeBoardHrms",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AJWNoticeBoardHrms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    CNIC = table.Column<string>(nullable: true),
                    MobileNumber = table.Column<string>(nullable: true),
                    Department = table.Column<string>(nullable: true),
                    Designation = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    Martialstatus = table.Column<string>(nullable: true),
                    Bloodgp = table.Column<string>(nullable: true),
                    Photo = table.Column<string>(nullable: true),
                    Photopath = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Profile = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "bankBalane",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BankBalance = table.Column<int>(nullable: false),
                    deposit = table.Column<int>(nullable: false),
                    transaction = table.Column<int>(nullable: false),
                    tax = table.Column<int>(nullable: false),
                    closingBankBalance = table.Column<int>(nullable: false),
                    BankName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bankBalane", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DailyContinueSheetMs",
                columns: table => new
                {
                    DCSId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DSDate = table.Column<DateTime>(nullable: false),
                    DCSAccountType = table.Column<string>(nullable: false),
                    DCSDescription = table.Column<string>(nullable: false),
                    DCSDate = table.Column<DateTime>(nullable: false),
                    DCSPaidAmount = table.Column<float>(nullable: false),
                    DCSClearedAmount = table.Column<float>(nullable: false),
                    DCSUnClearedAmount = table.Column<float>(nullable: false),
                    DCSRemainingGaineAmmount = table.Column<float>(nullable: false),
                    DCSIncome = table.Column<float>(nullable: false),
                    DCSPGSCDO = table.Column<float>(nullable: false),
                    DCSOpeningBalance = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DailyContinueSheetMs", x => x.DCSId);
                });

            migrationBuilder.CreateTable(
                name: "DailyPlanIn",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Designation = table.Column<string>(nullable: false),
                    DateTime = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    sign = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DailyPlanIn", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DailyPlanInAccountss",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameAccount = table.Column<string>(nullable: false),
                    DesignationAccount = table.Column<string>(nullable: false),
                    DateTimeinAccount = table.Column<DateTime>(nullable: false),
                    DescriptioninAccount = table.Column<string>(nullable: false),
                    signAccount = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DailyPlanInAccountss", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DailyPlanInOutModels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Designation = table.Column<string>(nullable: false),
                    DateTimeIn = table.Column<DateTime>(nullable: false),
                    DateTimeOut = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    Sign = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DailyPlanInOutModels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DailyPlanOut",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Designation = table.Column<string>(nullable: false),
                    DateTime = table.Column<DateTime>(nullable: false),
                    Descriptionout = table.Column<string>(nullable: false),
                    sign = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DailyPlanOut", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DailyPlanOutAccountss",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameAccount = table.Column<string>(nullable: false),
                    DesignationAccount = table.Column<string>(nullable: false),
                    DateTimeoutAccount = table.Column<DateTime>(nullable: false),
                    DescriptionoutAccount = table.Column<string>(nullable: false),
                    signAccount = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DailyPlanOutAccountss", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "dailySuppliers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ValueDate = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Debit = table.Column<float>(nullable: false),
                    Cradit = table.Column<float>(nullable: false),
                    Balance = table.Column<float>(nullable: false),
                    bCradit = table.Column<float>(nullable: false),
                    bDebit = table.Column<float>(nullable: false),
                    bBalance = table.Column<float>(nullable: false),
                    Remarks = table.Column<string>(nullable: true),
                    SignPManager = table.Column<string>(nullable: true),
                    PManagerRemarks = table.Column<string>(nullable: true),
                    SignGM = table.Column<string>(nullable: true),
                    GMRemarks = table.Column<string>(nullable: true),
                    SignCeo = table.Column<string>(nullable: true),
                    CeoRemarks = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    DelProduction = table.Column<int>(nullable: false),
                    DelGm = table.Column<int>(nullable: false),
                    DelCeo = table.Column<int>(nullable: false),
                    DelRepo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dailySuppliers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DCashClosingSupplierLedgers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateDCCS = table.Column<DateTime>(nullable: false),
                    Credit = table.Column<float>(nullable: false),
                    Debit = table.Column<float>(nullable: false),
                    TotalBillPay = table.Column<float>(nullable: false),
                    TotalBill = table.Column<float>(nullable: false),
                    TotalCash = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DCashClosingSupplierLedgers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DgmFilesOnDatabase",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    FileType = table.Column<string>(nullable: true),
                    Extension = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    UploadedBy = table.Column<string>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    Data = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DgmFilesOnDatabase", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DgmFilesOnDatabaseDms",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    FileType = table.Column<string>(nullable: true),
                    Extension = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    UploadedBy = table.Column<string>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    Data = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DgmFilesOnDatabaseDms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DgmFilesOnFileSystem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    FileType = table.Column<string>(nullable: true),
                    Extension = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    UploadedBy = table.Column<string>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    FilePath = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DgmFilesOnFileSystem", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FilesOnDatabase",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    FileType = table.Column<string>(nullable: true),
                    Extension = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    UploadedBy = table.Column<string>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    Data = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilesOnDatabase", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FilesOnDatabaseDms",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    FileType = table.Column<string>(nullable: true),
                    Extension = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    UploadedBy = table.Column<string>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    Data = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilesOnDatabaseDms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FilesOnFileSystem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    FileType = table.Column<string>(nullable: true),
                    Extension = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    UploadedBy = table.Column<string>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    FilePath = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilesOnFileSystem", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HrmFilesOnDatabase",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    FileType = table.Column<string>(nullable: true),
                    Extension = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    UploadedBy = table.Column<string>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    Data = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HrmFilesOnDatabase", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HrmFilesOnDatabaseDms",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    FileType = table.Column<string>(nullable: true),
                    Extension = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    UploadedBy = table.Column<string>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    Data = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HrmFilesOnDatabaseDms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HrmFilesOnFileSystem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    FileType = table.Column<string>(nullable: true),
                    Extension = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    UploadedBy = table.Column<string>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    FilePath = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HrmFilesOnFileSystem", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: true),
                    FileType = table.Column<string>(maxLength: 100, nullable: true),
                    DataFiles = table.Column<byte[]>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Img",
                columns: table => new
                {
                    Imgid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Imgidd = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    DateTime = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Imgnamed = table.Column<string>(nullable: true),
                    Imgpathd = table.Column<string>(nullable: true),
                    Imgname = table.Column<string>(nullable: true),
                    Imgpath = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Img", x => x.Imgid);
                });

            migrationBuilder.CreateTable(
                name: "LawBooks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    previousPageNumber = table.Column<string>(nullable: true),
                    previousEditNumber = table.Column<string>(nullable: true),
                    pageNumber = table.Column<string>(nullable: true),
                    editNumber = table.Column<string>(nullable: true),
                    lawDescription = table.Column<string>(nullable: true),
                    title = table.Column<string>(nullable: true),
                    department = table.Column<string>(nullable: true),
                    Date = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LawBooks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ledgers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LedgerName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ledgers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ManagementStaffWorkPlans",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MPDate = table.Column<string>(nullable: true),
                    MPName = table.Column<string>(nullable: true),
                    MPDesignation = table.Column<string>(nullable: true),
                    Timein = table.Column<string>(nullable: true),
                    Timeout = table.Column<string>(nullable: true),
                    MPDescription = table.Column<string>(nullable: true),
                    Signofficer = table.Column<string>(nullable: true),
                    SignPManagerMP = table.Column<string>(nullable: true),
                    PManagerRemarksMP = table.Column<string>(nullable: true),
                    SignGMMP = table.Column<string>(nullable: true),
                    GMRemarksMP = table.Column<string>(nullable: true),
                    SignCeoMP = table.Column<string>(nullable: true),
                    CeoRemarksMP = table.Column<string>(nullable: true),
                    MPStatus = table.Column<string>(nullable: true),
                    MPTitle = table.Column<string>(nullable: true),
                    DelProductionMP = table.Column<int>(nullable: false),
                    DelGmMP = table.Column<int>(nullable: false),
                    DelCeoMP = table.Column<int>(nullable: false),
                    DelRepoMP = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManagementStaffWorkPlans", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MeezanBankIEReports",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ValueDate = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    CDO = table.Column<string>(nullable: false),
                    Debit = table.Column<float>(nullable: false),
                    Cradit = table.Column<float>(nullable: false),
                    Balance = table.Column<float>(nullable: false),
                    Imgceo = table.Column<string>(nullable: true),
                    Imggm = table.Column<string>(nullable: true),
                    Imgdgm = table.Column<string>(nullable: true),
                    Imgam = table.Column<string>(nullable: true),
                    Remarks = table.Column<string>(nullable: true),
                    SignPManager = table.Column<string>(nullable: true),
                    PManagerRemarks = table.Column<string>(nullable: true),
                    SignGM = table.Column<string>(nullable: true),
                    GMRemarks = table.Column<string>(nullable: true),
                    SignCeo = table.Column<string>(nullable: true),
                    CeoRemarks = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    DelProduction = table.Column<int>(nullable: false),
                    DelGm = table.Column<int>(nullable: false),
                    DelCeo = table.Column<int>(nullable: false),
                    DelRepo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeezanBankIEReports", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MeezanBankIEReportsVoucher",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ValueDate = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    CDO = table.Column<string>(nullable: false),
                    Debit = table.Column<float>(nullable: false),
                    Cradit = table.Column<float>(nullable: false),
                    Balance = table.Column<float>(nullable: false),
                    Imgceo = table.Column<string>(nullable: true),
                    Imggm = table.Column<string>(nullable: true),
                    Imgdgm = table.Column<string>(nullable: true),
                    Imgam = table.Column<string>(nullable: true),
                    Remarks = table.Column<string>(nullable: true),
                    SignPManager = table.Column<string>(nullable: true),
                    PManagerRemarks = table.Column<string>(nullable: true),
                    SignGM = table.Column<string>(nullable: true),
                    GMRemarks = table.Column<string>(nullable: true),
                    SignCeo = table.Column<string>(nullable: true),
                    CeoRemarks = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    DelProduction = table.Column<int>(nullable: false),
                    DelGm = table.Column<int>(nullable: false),
                    DelCeo = table.Column<int>(nullable: false),
                    DelRepo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeezanBankIEReportsVoucher", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MeezanBankIEVouchers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dateTime = table.Column<DateTime>(nullable: false),
                    checkNumber = table.Column<string>(nullable: true),
                    amount = table.Column<string>(nullable: true),
                    purpose = table.Column<string>(nullable: true),
                    description = table.Column<string>(nullable: true),
                    Remarks = table.Column<string>(nullable: true),
                    SignPManager = table.Column<string>(nullable: true),
                    PManagerRemarks = table.Column<string>(nullable: true),
                    rBalance = table.Column<string>(nullable: true),
                    incomeTa = table.Column<string>(nullable: true),
                    checkcash = table.Column<string>(nullable: true),
                    currentBalance = table.Column<string>(nullable: true),
                    SignGM = table.Column<string>(nullable: true),
                    GMRemarks = table.Column<string>(nullable: true),
                    SignCeo = table.Column<string>(nullable: true),
                    CeoRemarks = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    DelProduction = table.Column<int>(nullable: false),
                    DelGm = table.Column<int>(nullable: false),
                    DelCeo = table.Column<int>(nullable: false),
                    DelRepo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeezanBankIEVouchers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MeezanBankMonthlyIncomeExpenseReportImages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MeezanBankMonthlyIncomeExpenseReportId = table.Column<int>(nullable: false),
                    Filepath = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeezanBankMonthlyIncomeExpenseReportImages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MeezanBankMonthlyIncomeExpenseReports",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InnuzalProjectDesc = table.Column<string>(nullable: true),
                    InnuzalProjectBalance = table.Column<int>(nullable: true),
                    AccessorySaleDesc = table.Column<string>(nullable: true),
                    AccessorySaleBalance = table.Column<int>(nullable: true),
                    StoreMaterialDesc = table.Column<string>(nullable: true),
                    StoreMaterialBalance = table.Column<int>(nullable: true),
                    ScrabSaleDesc = table.Column<string>(nullable: true),
                    ScrabSaleBalance = table.Column<int>(nullable: true),
                    ReparningDesc = table.Column<string>(nullable: true),
                    ReparningBalance = table.Column<int>(nullable: true),
                    DifferentIncomeDesc = table.Column<string>(nullable: true),
                    DifferentIncomeBalance = table.Column<int>(nullable: true),
                    NoTitleDesc = table.Column<string>(nullable: true),
                    NoTitleBalance = table.Column<int>(nullable: true),
                    NoTitle2Desc = table.Column<string>(nullable: true),
                    NoTitle2Balance = table.Column<int>(nullable: true),
                    TotalIncome = table.Column<int>(nullable: true),
                    TotalExpense = table.Column<int>(nullable: true),
                    ClosingBalance = table.Column<int>(nullable: true),
                    ValueDate = table.Column<DateTime>(nullable: false),
                    SignAManager = table.Column<string>(nullable: false),
                    AManagerRemarks = table.Column<string>(nullable: false),
                    SignDgm = table.Column<string>(nullable: true),
                    DgmRemarks = table.Column<string>(nullable: true),
                    SignGM = table.Column<string>(nullable: true),
                    GMRemarks = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    DelProduction = table.Column<int>(nullable: false),
                    Month = table.Column<int>(nullable: false),
                    Year = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeezanBankMonthlyIncomeExpenseReports", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MonthlyClosingReports",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ValueDate = table.Column<DateTime>(nullable: false),
                    SignAManager = table.Column<string>(nullable: false),
                    AManagerRemarks = table.Column<string>(nullable: false),
                    SignDgm = table.Column<string>(nullable: true),
                    DgmRemarks = table.Column<string>(nullable: true),
                    SignGM = table.Column<string>(nullable: true),
                    GMRemarks = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    DelProduction = table.Column<int>(nullable: false),
                    Month = table.Column<int>(nullable: false),
                    Year = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonthlyClosingReports", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MonthlyGeneralLedgerBook",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DailyCashId = table.Column<int>(nullable: false),
                    SignPManager = table.Column<string>(nullable: true),
                    PManagerRemarks = table.Column<string>(nullable: true),
                    SignGM = table.Column<string>(nullable: true),
                    GMRemarks = table.Column<string>(nullable: true),
                    SignCeo = table.Column<string>(nullable: true),
                    CeoRemarks = table.Column<string>(nullable: true),
                    Balance = table.Column<decimal>(nullable: true),
                    Credit = table.Column<decimal>(nullable: true),
                    Devit = table.Column<decimal>(nullable: true),
                    PreOrderCheckNo = table.Column<int>(nullable: true),
                    LedgerType = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DailyCashDate = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonthlyGeneralLedgerBook", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MonthlyMainBankLedgerBook",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MainBankDailyCashId = table.Column<int>(nullable: false),
                    SignPManager = table.Column<string>(nullable: true),
                    PManagerRemarks = table.Column<string>(nullable: true),
                    SignGM = table.Column<string>(nullable: true),
                    GMRemarks = table.Column<string>(nullable: true),
                    SignCeo = table.Column<string>(nullable: true),
                    CeoRemarks = table.Column<string>(nullable: true),
                    Balance = table.Column<decimal>(nullable: true),
                    Credit = table.Column<decimal>(nullable: true),
                    Devit = table.Column<decimal>(nullable: true),
                    CDO = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    MainBankDailyCashDate = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonthlyMainBankLedgerBook", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Noticb",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateTime = table.Column<DateTime>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    SDImgname = table.Column<string>(nullable: true),
                    SDImgpath = table.Column<string>(nullable: true),
                    SignImg = table.Column<string>(nullable: true),
                    SignImgpath = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Noticb", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NoticBoard",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NoticBoard", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductionFilesOnDatabase",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    FileType = table.Column<string>(nullable: true),
                    Extension = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    UploadedBy = table.Column<string>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    Date = table.Column<DateTime>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Data = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductionFilesOnDatabase", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductionFilesOnDatabaseDms",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    FileType = table.Column<string>(nullable: true),
                    Extension = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    UploadedBy = table.Column<string>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    Date = table.Column<DateTime>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Data = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductionFilesOnDatabaseDms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductionFilesOnFileSystem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    FileType = table.Column<string>(nullable: true),
                    Extension = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    UploadedBy = table.Column<string>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    Date = table.Column<DateTime>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    FilePath = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductionFilesOnFileSystem", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StoreFilesOnDatabase",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    FileType = table.Column<string>(nullable: true),
                    Extension = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    UploadedBy = table.Column<string>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    Date = table.Column<DateTime>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Data = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoreFilesOnDatabase", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StoreFilesOnDatabaseDms",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    FileType = table.Column<string>(nullable: true),
                    Extension = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    UploadedBy = table.Column<string>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    Date = table.Column<DateTime>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Data = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoreFilesOnDatabaseDms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StoreFilesOnFileSystem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    FileType = table.Column<string>(nullable: true),
                    Extension = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    UploadedBy = table.Column<string>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    Date = table.Column<DateTime>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    FilePath = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoreFilesOnFileSystem", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TechnicalStaffWorkPlans",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Designation = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    JobCard = table.Column<float>(nullable: false),
                    Remarks = table.Column<string>(nullable: true),
                    SignPManager = table.Column<string>(nullable: true),
                    PManagerRemarks = table.Column<string>(nullable: true),
                    SignGM = table.Column<string>(nullable: true),
                    GMRemarks = table.Column<string>(nullable: true),
                    SignCeo = table.Column<string>(nullable: true),
                    CeoRemarks = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    DelProduction = table.Column<int>(nullable: false),
                    DelGm = table.Column<int>(nullable: false),
                    DelCeo = table.Column<int>(nullable: false),
                    DelRepo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TechnicalStaffWorkPlans", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserTable",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTable", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "YearlyGeneralLedgerBook",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DailyCashId = table.Column<int>(nullable: false),
                    MonthlyGeneralLedgerBookId = table.Column<int>(nullable: false),
                    AMSignature = table.Column<string>(nullable: true),
                    AMRemark = table.Column<string>(nullable: true),
                    DGMSignature = table.Column<string>(nullable: true),
                    DGMRemark = table.Column<string>(nullable: true),
                    GMSignature = table.Column<string>(nullable: true),
                    GMRemark = table.Column<string>(nullable: true),
                    Balance = table.Column<decimal>(nullable: true),
                    Credit = table.Column<decimal>(nullable: true),
                    Devit = table.Column<decimal>(nullable: true),
                    PreOrderCheckNo = table.Column<int>(nullable: true),
                    LedgerType = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DailyCashDate = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YearlyGeneralLedgerBook", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "YearlyMainBankLedgerBook",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MainBankDailyCashId = table.Column<int>(nullable: false),
                    MonthlyMainBankLedgerBookId = table.Column<int>(nullable: false),
                    AMSignature = table.Column<string>(nullable: true),
                    AMRemark = table.Column<string>(nullable: true),
                    DGMSignature = table.Column<string>(nullable: true),
                    DGMRemark = table.Column<string>(nullable: true),
                    GMSignature = table.Column<string>(nullable: true),
                    GMRemark = table.Column<string>(nullable: true),
                    Balance = table.Column<decimal>(nullable: true),
                    Credit = table.Column<decimal>(nullable: true),
                    Devit = table.Column<decimal>(nullable: true),
                    CDO = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    MainBankDailyCashDate = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YearlyMainBankLedgerBook", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<string>(nullable: false),
                    CategoryName = table.Column<string>(nullable: false),
                    ItemName = table.Column<string>(nullable: false),
                    ItemSize = table.Column<string>(nullable: false),
                    ArrivalWeight = table.Column<string>(nullable: false),
                    ArrivalQuantity = table.Column<string>(nullable: false),
                    ArrivalPrice = table.Column<string>(nullable: false),
                    PerUnitPrice = table.Column<string>(nullable: false),
                    TotalPrice = table.Column<string>(nullable: false),
                    TotalUnit = table.Column<string>(nullable: false),
                    RemainUnit = table.Column<string>(nullable: false),
                    TotalWeight = table.Column<string>(nullable: false),
                    RemainWeight = table.Column<string>(nullable: false),
                    OfficerName = table.Column<string>(nullable: false),
                    MaterialvoucherNo = table.Column<string>(nullable: false),
                    PurchaseOrderNo = table.Column<string>(nullable: false),
                    SupplierName = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Items_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubLedgers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    LedgerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubLedgers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubLedgers_Ledgers_LedgerId",
                        column: x => x.LedgerId,
                        principalTable: "Ledgers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Items_CategoryId",
                table: "Items",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_SubLedgers_LedgerId",
                table: "SubLedgers",
                column: "LedgerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccountsFilesOnDatabase");

            migrationBuilder.DropTable(
                name: "AccountsFilesOnDatabaseDms");

            migrationBuilder.DropTable(
                name: "AccountsFilesOnFileSystem");

            migrationBuilder.DropTable(
                name: "AccountsYearlyReportTitlePages");

            migrationBuilder.DropTable(
                name: "aDailyCashes");

            migrationBuilder.DropTable(
                name: "AJWDailyPlanIOs");

            migrationBuilder.DropTable(
                name: "AJWNoticeBoardHrms");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "bankBalane");

            migrationBuilder.DropTable(
                name: "DailyContinueSheetMs");

            migrationBuilder.DropTable(
                name: "DailyPlanIn");

            migrationBuilder.DropTable(
                name: "DailyPlanInAccountss");

            migrationBuilder.DropTable(
                name: "DailyPlanInOutModels");

            migrationBuilder.DropTable(
                name: "DailyPlanOut");

            migrationBuilder.DropTable(
                name: "DailyPlanOutAccountss");

            migrationBuilder.DropTable(
                name: "dailySuppliers");

            migrationBuilder.DropTable(
                name: "DCashClosingSupplierLedgers");

            migrationBuilder.DropTable(
                name: "DgmFilesOnDatabase");

            migrationBuilder.DropTable(
                name: "DgmFilesOnDatabaseDms");

            migrationBuilder.DropTable(
                name: "DgmFilesOnFileSystem");

            migrationBuilder.DropTable(
                name: "FilesOnDatabase");

            migrationBuilder.DropTable(
                name: "FilesOnDatabaseDms");

            migrationBuilder.DropTable(
                name: "FilesOnFileSystem");

            migrationBuilder.DropTable(
                name: "HrmFilesOnDatabase");

            migrationBuilder.DropTable(
                name: "HrmFilesOnDatabaseDms");

            migrationBuilder.DropTable(
                name: "HrmFilesOnFileSystem");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "Img");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "LawBooks");

            migrationBuilder.DropTable(
                name: "ManagementStaffWorkPlans");

            migrationBuilder.DropTable(
                name: "MeezanBankIEReports");

            migrationBuilder.DropTable(
                name: "MeezanBankIEReportsVoucher");

            migrationBuilder.DropTable(
                name: "MeezanBankIEVouchers");

            migrationBuilder.DropTable(
                name: "MeezanBankMonthlyIncomeExpenseReportImages");

            migrationBuilder.DropTable(
                name: "MeezanBankMonthlyIncomeExpenseReports");

            migrationBuilder.DropTable(
                name: "MonthlyClosingReports");

            migrationBuilder.DropTable(
                name: "MonthlyGeneralLedgerBook");

            migrationBuilder.DropTable(
                name: "MonthlyMainBankLedgerBook");

            migrationBuilder.DropTable(
                name: "Noticb");

            migrationBuilder.DropTable(
                name: "NoticBoard");

            migrationBuilder.DropTable(
                name: "ProductionFilesOnDatabase");

            migrationBuilder.DropTable(
                name: "ProductionFilesOnDatabaseDms");

            migrationBuilder.DropTable(
                name: "ProductionFilesOnFileSystem");

            migrationBuilder.DropTable(
                name: "StoreFilesOnDatabase");

            migrationBuilder.DropTable(
                name: "StoreFilesOnDatabaseDms");

            migrationBuilder.DropTable(
                name: "StoreFilesOnFileSystem");

            migrationBuilder.DropTable(
                name: "SubLedgers");

            migrationBuilder.DropTable(
                name: "TechnicalStaffWorkPlans");

            migrationBuilder.DropTable(
                name: "UserTable");

            migrationBuilder.DropTable(
                name: "YearlyGeneralLedgerBook");

            migrationBuilder.DropTable(
                name: "YearlyMainBankLedgerBook");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Ledgers");
        }
    }
}
