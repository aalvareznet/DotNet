using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FishesApi.Migrations
{
    /// <inheritdoc />
    public partial class InitDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FishCategories",
                columns: table => new
                {
                    FishCategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FishCategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FishCategories", x => x.FishCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Fishes",
                columns: table => new
                {
                    FishId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FishName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FishDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FishWeight = table.Column<int>(type: "int", nullable: false),
                    FishLength = table.Column<int>(type: "int", nullable: false),
                    FishColor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FishCategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fishes", x => x.FishId);
                    table.ForeignKey(
                        name: "FK_Fishes_FishCategories_FishCategoryId",
                        column: x => x.FishCategoryId,
                        principalTable: "FishCategories",
                        principalColumn: "FishCategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Fishes_FishCategoryId",
                table: "Fishes",
                column: "FishCategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fishes");

            migrationBuilder.DropTable(
                name: "FishCategories");
        }
    }
}
