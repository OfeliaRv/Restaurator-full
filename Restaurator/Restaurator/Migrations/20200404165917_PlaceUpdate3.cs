using Microsoft.EntityFrameworkCore.Migrations;

namespace Restaurator.Migrations
{
    public partial class PlaceUpdate3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Places",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OpenHours",
                table: "Places",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PlaceMap",
                table: "Places",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PlacePhone",
                table: "Places",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Places");

            migrationBuilder.DropColumn(
                name: "OpenHours",
                table: "Places");

            migrationBuilder.DropColumn(
                name: "PlaceMap",
                table: "Places");

            migrationBuilder.DropColumn(
                name: "PlacePhone",
                table: "Places");
        }
    }
}
