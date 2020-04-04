using Microsoft.EntityFrameworkCore.Migrations;

namespace Restaurator.Migrations
{
    public partial class PlacePhotoTextsHeadingUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CircleTextHeading",
                table: "PlaceInCirclePhotos");

            migrationBuilder.AddColumn<string>(
                name: "CircleTextHeading1",
                table: "PlaceInCirclePhotos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CircleTextHeading2",
                table: "PlaceInCirclePhotos",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CircleTextHeading1",
                table: "PlaceInCirclePhotos");

            migrationBuilder.DropColumn(
                name: "CircleTextHeading2",
                table: "PlaceInCirclePhotos");

            migrationBuilder.AddColumn<string>(
                name: "CircleTextHeading",
                table: "PlaceInCirclePhotos",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
