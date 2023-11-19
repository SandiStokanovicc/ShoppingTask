using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TactaShoppingTask.DAL.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    ItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ItemQuantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.ItemId);
                });

            migrationBuilder.CreateTable(
                name: "Shoppers",
                columns: table => new
                {
                    ShopperId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShopperName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shoppers", x => x.ShopperId);
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "ItemId", "ItemName", "ItemQuantity" },
                values: new object[,]
                {
                    { 1, "Bread", 3 },
                    { 2, "Milk", 3 },
                    { 3, "Eggs", 3 },
                    { 4, "Honey", 3 },
                    { 5, "Ketchup", 3 }
                });

            migrationBuilder.InsertData(
                table: "Shoppers",
                columns: new[] { "ShopperId", "ShopperName" },
                values: new object[,]
                {
                    { 1, "Jim" },
                    { 2, "John" },
                    { 3, "Emma" },
                    { 4, "Andrea" },
                    { 5, "Martin" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Shoppers");
        }
    }
}
