using Microsoft.EntityFrameworkCore.Migrations;

namespace AJWManagementPortal.Migrations
{
    public partial class UpdateMonthlyClosingReport : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DelProduction",
                table: "MonthlyClosingReports",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "MonthlyClosingReports",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DelProduction",
                table: "MonthlyClosingReports");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "MonthlyClosingReports");
        }
    }
}
