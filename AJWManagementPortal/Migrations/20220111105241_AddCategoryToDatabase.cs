using Microsoft.EntityFrameworkCore.Migrations;

namespace AJWManagementPortal.Migrations
{
    public partial class AddCategoryToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<string>(nullable: false),
                    CategoryName = table.Column<string>(nullable: false),
                    ItemName = table.Column<string>(nullable: false),
                    ItemSize = table.Column<string>(nullable: false),
                    ArrivalWeight = table.Column<string>(nullable: false),
                    ArrivalQuantity = table.Column<string>(nullable: false),
                    ArrivalPrice = table.Column<string>(nullable: false),
                    PerUnitPrice = table.Column<string>(nullable: false),
                    TotalPrice = table.Column<string>(nullable: false),
                    TotalUnit = table.Column<string>(nullable: false),
                    RemainUnit = table.Column<string>(nullable: false),
                    TotalWeight = table.Column<string>(nullable: false),
                    RemainWeight = table.Column<string>(nullable: false),
                    OfficerName = table.Column<string>(nullable: false),
                    MaterialvoucherNo = table.Column<string>(nullable: false),
                    PurchaseOrderNo = table.Column<string>(nullable: false),
                    SupplierName = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Items_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Items_CategoryId",
                table: "Items",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
