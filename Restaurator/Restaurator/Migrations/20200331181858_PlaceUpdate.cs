using Microsoft.EntityFrameworkCore.Migrations;

namespace Restaurator.Migrations
{
    public partial class PlaceUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Places",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MainImage",
                table: "Places",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PlaceType",
                table: "Places",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Places");

            migrationBuilder.DropColumn(
                name: "MainImage",
                table: "Places");

            migrationBuilder.DropColumn(
                name: "PlaceType",
                table: "Places");
        }
    }
}
