using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AJWManagementPortal.Migrations
{
    public partial class addCXDToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MonthlyGeneralLedgerBook",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DailyCashId = table.Column<int>(nullable: false),
                    SignPManager = table.Column<string>(nullable: true),
                    PManagerRemarks = table.Column<string>(nullable: true),
                    SignGM = table.Column<string>(nullable: true),
                    GMRemarks = table.Column<string>(nullable: true),
                    SignCeo = table.Column<string>(nullable: true),
                    CeoRemarks = table.Column<string>(nullable: true),
                    Balance = table.Column<decimal>(nullable: true),
                    Credit = table.Column<decimal>(nullable: true),
                    Devit = table.Column<decimal>(nullable: true),
                    PreOrderCheckNo = table.Column<int>(nullable: true),
                    LedgerType = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DailyCashDate = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonthlyGeneralLedgerBook", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "YearlyGeneralLedgerBook",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DailyCashId = table.Column<int>(nullable: false),
                    MonthlyGeneralLedgerBookId = table.Column<int>(nullable: false),
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
                    LedgerType = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DailyCashDate = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YearlyGeneralLedgerBook", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MonthlyGeneralLedgerBook");

            migrationBuilder.DropTable(
                name: "YearlyGeneralLedgerBook");
        }
    }
}
