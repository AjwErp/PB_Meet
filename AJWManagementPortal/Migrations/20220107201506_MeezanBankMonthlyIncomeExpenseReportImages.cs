using Microsoft.EntityFrameworkCore.Migrations;

namespace AJWManagementPortal.Migrations
{
    public partial class MeezanBankMonthlyIncomeExpenseReportImages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MeezanBankMonthlyIncomeExpenseReportImages");
        }
    }
}
