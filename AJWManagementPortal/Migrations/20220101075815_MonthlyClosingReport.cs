using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AJWManagementPortal.Migrations
{
    public partial class MonthlyClosingReport : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    GMRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonthlyClosingReports", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MonthlyClosingReports");
        }
    }
}
