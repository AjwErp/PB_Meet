using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AJWManagementPortal.Migrations
{
    public partial class MeezanBankMonthlyIncomeExpenseReport : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MeezanBankMonthlyIncomeExpenseReports",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InnuzalProjectDesc = table.Column<string>(nullable: true),
                    InnuzalProjectBalance = table.Column<int>(nullable: false),
                    AccessorySaleDesc = table.Column<string>(nullable: true),
                    AccessorySaleBalance = table.Column<int>(nullable: false),
                    StoreMaterialDesc = table.Column<string>(nullable: true),
                    StoreMaterialBalance = table.Column<int>(nullable: false),
                    ScrabSaleDesc = table.Column<string>(nullable: true),
                    ScrabSaleBalance = table.Column<int>(nullable: false),
                    ReparningDesc = table.Column<string>(nullable: true),
                    ReparningBalance = table.Column<int>(nullable: false),
                    DifferentIncomeDesc = table.Column<string>(nullable: true),
                    DifferentIncomeBalance = table.Column<int>(nullable: false),
                    NoTitleDesc = table.Column<string>(nullable: true),
                    NoTitleBalance = table.Column<int>(nullable: false),
                    NoTitle2Desc = table.Column<string>(nullable: true),
                    NoTitle2Balance = table.Column<int>(nullable: false),
                    TotalIncome = table.Column<int>(nullable: false),
                    TotalExpense = table.Column<int>(nullable: false),
                    ClosingBalance = table.Column<int>(nullable: false),
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MeezanBankMonthlyIncomeExpenseReports");
        }
    }
}
