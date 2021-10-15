using Microsoft.EntityFrameworkCore.Migrations;

namespace Candles_Database.Migrations
{
    public partial class UserRating : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Rating",
                table: "Candles",
                newName: "UserRating");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserRating",
                table: "Candles",
                newName: "Rating");
        }
    }
}
