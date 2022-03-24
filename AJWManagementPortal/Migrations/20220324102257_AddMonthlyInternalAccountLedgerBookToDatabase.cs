using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AJWManagementPortal.Migrations
{
    public partial class AddMonthlyInternalAccountLedgerBookToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MonthlyIndustrySupplierLedgerBook",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DailyCashId = table.Column<int>(nullable: false),
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
                    Description = table.Column<string>(nullable: true),
                    DailyCashDate = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonthlyIndustrySupplierLedgerBook", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MonthlyInternalAccountLedgerBook",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DailyCashId = table.Column<int>(nullable: false),
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
                    Description = table.Column<string>(nullable: true),
                    DailyCashDate = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonthlyInternalAccountLedgerBook", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MonthlyIndustrySupplierLedgerBook");

            migrationBuilder.DropTable(
                name: "MonthlyInternalAccountLedgerBook");
        }
    }
}
