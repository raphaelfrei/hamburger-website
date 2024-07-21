using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Restaurante.Migrations
{
    /// <inheritdoc />
    public partial class CartShopItem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CartShopItems",
                columns: table => new
                {
                    CartShopItemID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HamburgerID = table.Column<int>(type: "int", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    CartShopId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartShopItems", x => x.CartShopItemID);
                    table.ForeignKey(
                        name: "FK_CartShopItems_Hamburgers_HamburgerID",
                        column: x => x.HamburgerID,
                        principalTable: "Hamburgers",
                        principalColumn: "HamburgerID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CartShopItems_HamburgerID",
                table: "CartShopItems",
                column: "HamburgerID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartShopItems");
        }
    }
}
