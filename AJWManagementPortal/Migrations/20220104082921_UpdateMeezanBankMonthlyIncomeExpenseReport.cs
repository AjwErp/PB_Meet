using Microsoft.EntityFrameworkCore.Migrations;

namespace AJWManagementPortal.Migrations
{
    public partial class UpdateMeezanBankMonthlyIncomeExpenseReport : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "TotalIncome",
                table: "MeezanBankMonthlyIncomeExpenseReports",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "TotalExpense",
                table: "MeezanBankMonthlyIncomeExpenseReports",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "StoreMaterialBalance",
                table: "MeezanBankMonthlyIncomeExpenseReports",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ScrabSaleBalance",
                table: "MeezanBankMonthlyIncomeExpenseReports",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ReparningBalance",
                table: "MeezanBankMonthlyIncomeExpenseReports",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "NoTitleBalance",
                table: "MeezanBankMonthlyIncomeExpenseReports",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "NoTitle2Balance",
                table: "MeezanBankMonthlyIncomeExpenseReports",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "InnuzalProjectBalance",
                table: "MeezanBankMonthlyIncomeExpenseReports",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DifferentIncomeBalance",
                table: "MeezanBankMonthlyIncomeExpenseReports",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ClosingBalance",
                table: "MeezanBankMonthlyIncomeExpenseReports",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "AccessorySaleBalance",
                table: "MeezanBankMonthlyIncomeExpenseReports",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "TotalIncome",
                table: "MeezanBankMonthlyIncomeExpenseReports",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TotalExpense",
                table: "MeezanBankMonthlyIncomeExpenseReports",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "StoreMaterialBalance",
                table: "MeezanBankMonthlyIncomeExpenseReports",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ScrabSaleBalance",
                table: "MeezanBankMonthlyIncomeExpenseReports",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ReparningBalance",
                table: "MeezanBankMonthlyIncomeExpenseReports",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "NoTitleBalance",
                table: "MeezanBankMonthlyIncomeExpenseReports",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "NoTitle2Balance",
                table: "MeezanBankMonthlyIncomeExpenseReports",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "InnuzalProjectBalance",
                table: "MeezanBankMonthlyIncomeExpenseReports",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DifferentIncomeBalance",
                table: "MeezanBankMonthlyIncomeExpenseReports",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ClosingBalance",
                table: "MeezanBankMonthlyIncomeExpenseReports",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AccessorySaleBalance",
                table: "MeezanBankMonthlyIncomeExpenseReports",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }
    }
}
