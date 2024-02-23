using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sprint1_EpicBookstoreApplication.Data.Migrations
{
    public partial class Fifthmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CartId",
                table: "Inventory",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Cart",
                columns: table => new
                {
                    CartId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cart", x => x.CartId);
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
                name: "IX_Inventory_CartId",
                table: "Inventory",
                column: "CartId");

            migrationBuilder.AddForeignKey(
                name: "FK_Inventory_Cart_CartId",
                table: "Inventory",
                column: "CartId",
                principalTable: "Cart",
                principalColumn: "CartId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inventory_Cart_CartId",
                table: "Inventory");

            migrationBuilder.DropTable(
                name: "Cart");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropIndex(
                name: "IX_Inventory_CartId",
                table: "Inventory");

            migrationBuilder.DropColumn(
                name: "CartId",
                table: "Inventory");
        }
    }
}
