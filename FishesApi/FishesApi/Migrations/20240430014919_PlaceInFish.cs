using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FishesApi.Migrations
{
    /// <inheritdoc />
    public partial class PlaceInFish : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PlaceOfCapture",
                table: "Fishes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PlaceOfCapture",
                table: "Fishes");
        }
    }
}
