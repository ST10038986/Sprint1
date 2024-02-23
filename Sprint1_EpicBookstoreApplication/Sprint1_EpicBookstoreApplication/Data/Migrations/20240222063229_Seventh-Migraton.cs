using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sprint1_EpicBookstoreApplication.Data.Migrations
{
    public partial class SeventhMigraton : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CartShoppingCartID",
                table: "Inventory",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Cart",
                columns: table => new
                {
                    ShoppingCartID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cart", x => x.ShoppingCartID);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Inventory_CartShoppingCartID",
                table: "Inventory",
                column: "CartShoppingCartID");

            migrationBuilder.AddForeignKey(
                name: "FK_Inventory_Cart_CartShoppingCartID",
                table: "Inventory",
                column: "CartShoppingCartID",
                principalTable: "Cart",
                principalColumn: "ShoppingCartID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inventory_Cart_CartShoppingCartID",
                table: "Inventory");

            migrationBuilder.DropTable(
                name: "Cart");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropIndex(
                name: "IX_Inventory_CartShoppingCartID",
                table: "Inventory");

            migrationBuilder.DropColumn(
                name: "CartShoppingCartID",
                table: "Inventory");
        }
    }
}
