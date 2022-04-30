using Microsoft.EntityFrameworkCore.Migrations;

namespace AJWManagementPortal.Migrations
{
    public partial class AddCOXALLToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UniId",
                table: "MonthlyInternalAccountLedgerBook",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UniId",
                table: "MonthlyIndustrySupplierLedgerBook",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UniId",
                table: "MonthlyInternalAccountLedgerBook");

            migrationBuilder.DropColumn(
                name: "UniId",
                table: "MonthlyIndustrySupplierLedgerBook");
        }
    }
}
