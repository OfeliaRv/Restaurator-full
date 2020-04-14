using Microsoft.EntityFrameworkCore.Migrations;

namespace Restaurator.Migrations
{
    public partial class updates4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "ItemPrice",
                table: "PlaceMenuItems",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "money");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "ItemPrice",
                table: "PlaceMenuItems",
                type: "money",
                nullable: false,
                oldClrType: typeof(decimal));
        }
    }
}
