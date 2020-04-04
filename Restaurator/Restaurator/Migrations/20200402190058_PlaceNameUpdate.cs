using Microsoft.EntityFrameworkCore.Migrations;

namespace Restaurator.Migrations
{
    public partial class PlaceNameUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Places");

            migrationBuilder.AddColumn<string>(
                name: "NamePt1",
                table: "Places",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NamePt2",
                table: "Places",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NamePt1",
                table: "Places");

            migrationBuilder.DropColumn(
                name: "NamePt2",
                table: "Places");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Places",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);
        }
    }
}
