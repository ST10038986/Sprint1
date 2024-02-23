using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sprint1_EpicBookstoreApplication.Data.Migrations
{
    public partial class FourthMigratin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "Inventory",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Inventory");
        }
    }
}
