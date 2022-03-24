using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AJWManagementPortal.Migrations
{
    public partial class addMonthlyIncomeExpenseInternalAccountToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MonthlyIncomeExpenseInternalAccounts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IncomeNoTitleDesc1 = table.Column<string>(nullable: true),
                    IncomeNoTitleBalance1 = table.Column<int>(nullable: true),
                    IncomeNoTitleDesc2 = table.Column<string>(nullable: true),
                    IncomeNoTitleBalance2 = table.Column<int>(nullable: true),
                    IncomeNoTitleDesc3 = table.Column<string>(nullable: true),
                    IncomeNoTitleBalance3 = table.Column<int>(nullable: true),
                    ExpenseNoTitleDesc1 = table.Column<string>(nullable: true),
                    ExpenseNoTitleBalance1 = table.Column<int>(nullable: true),
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
                    table.PrimaryKey("PK_MonthlyIncomeExpenseInternalAccounts", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MonthlyIncomeExpenseInternalAccounts");
        }
    }
}
