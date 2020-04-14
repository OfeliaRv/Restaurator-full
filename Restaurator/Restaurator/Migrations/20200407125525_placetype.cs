using Microsoft.EntityFrameworkCore.Migrations;

namespace Restaurator.Migrations
{
    public partial class placetype : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Type1",
                table: "Places",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Type2",
                table: "Places",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type1",
                table: "Places");

            migrationBuilder.DropColumn(
                name: "Type2",
                table: "Places");
        }
    }
}
