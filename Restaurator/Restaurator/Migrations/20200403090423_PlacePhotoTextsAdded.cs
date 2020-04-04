using Microsoft.EntityFrameworkCore.Migrations;

namespace Restaurator.Migrations
{
    public partial class PlacePhotoTextsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Text",
                table: "PlacePhotos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CircleText",
                table: "PlaceInCirclePhotos",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Text",
                table: "PlacePhotos");

            migrationBuilder.DropColumn(
                name: "CircleText",
                table: "PlaceInCirclePhotos");
        }
    }
}
