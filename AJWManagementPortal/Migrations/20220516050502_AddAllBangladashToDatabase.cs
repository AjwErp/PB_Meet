using Microsoft.EntityFrameworkCore.Migrations;

namespace AJWManagementPortal.Migrations
{
    public partial class AddAllBangladashToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SYear",
                table: "YearlyClosingReports");

            migrationBuilder.AddColumn<int>(
                name: "KeyValue",
                table: "TrialBalanceAccountOffice",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KeyValue",
                table: "TrialBalanceAccountOffice");

            migrationBuilder.AddColumn<string>(
                name: "SYear",
                table: "YearlyClosingReports",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
