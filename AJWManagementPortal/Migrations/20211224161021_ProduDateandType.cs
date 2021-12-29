using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AJWManagementPortal.Migrations
{
    public partial class ProduDateandType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "ProductionFilesOnFileSystem",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "ProductionFilesOnFileSystem",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "ProductionFilesOnDatabaseDms",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "ProductionFilesOnDatabaseDms",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "ProductionFilesOnDatabase",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "ProductionFilesOnDatabase",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "ProductionFilesOnFileSystem");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "ProductionFilesOnFileSystem");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "ProductionFilesOnDatabaseDms");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "ProductionFilesOnDatabaseDms");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "ProductionFilesOnDatabase");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "ProductionFilesOnDatabase");
        }
    }
}
