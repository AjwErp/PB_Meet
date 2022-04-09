using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AJWManagementPortal.Migrations
{
    public partial class AddMonthlyIncomeExpenceInternalAccountReportToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MonthlyIncomeExpenceInternalAccountReport",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SelectedDate = table.Column<string>(nullable: true),
                    IncomeBalance1 = table.Column<string>(nullable: true),
                    IncomeDescription1 = table.Column<string>(nullable: true),
                    IncomeBalance2 = table.Column<string>(nullable: true),
                    IncomeDescription2 = table.Column<string>(nullable: true),
                    IncomeBalance3 = table.Column<string>(nullable: true),
                    IncomeDescription3 = table.Column<string>(nullable: true),
                    ExpenceBalance = table.Column<string>(nullable: true),
                    ExpenceDescription = table.Column<string>(nullable: true),
                    TotalIncomeBalance = table.Column<string>(nullable: true),
                    TotalExpenceBalance = table.Column<string>(nullable: true),
                    ClosingBalance = table.Column<string>(nullable: true),
                    AMSignature = table.Column<string>(nullable: true),
                    AMRemark = table.Column<string>(nullable: true),
                    DGMSignature = table.Column<string>(nullable: true),
                    DGMRemark = table.Column<string>(nullable: true),
                    GMSignature = table.Column<string>(nullable: true),
                    GMRemark = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonthlyIncomeExpenceInternalAccountReport", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TrialBalanceAccountOffice",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SelectedDate = table.Column<string>(nullable: true),
                    Credit = table.Column<decimal>(nullable: true),
                    Debit = table.Column<decimal>(nullable: true),
                    Page = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    AMSignature = table.Column<string>(nullable: true),
                    AMRemark = table.Column<string>(nullable: true),
                    DGMSignature = table.Column<string>(nullable: true),
                    DGMRemark = table.Column<string>(nullable: true),
                    GMSignature = table.Column<string>(nullable: true),
                    GMRemark = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrialBalanceAccountOffice", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MonthlyIncomeExpenceInternalAccountReport");

            migrationBuilder.DropTable(
                name: "TrialBalanceAccountOffice");
        }
    }
}
