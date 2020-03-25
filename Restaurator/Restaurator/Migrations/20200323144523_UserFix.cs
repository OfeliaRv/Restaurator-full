using Microsoft.EntityFrameworkCore.Migrations;

namespace Restaurator.Migrations
{
    public partial class UserFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Places_placeId",
                table: "Reservations");

            migrationBuilder.RenameColumn(
                name: "placeId",
                table: "Reservations",
                newName: "PlaceId");

            migrationBuilder.RenameIndex(
                name: "IX_Reservations_placeId",
                table: "Reservations",
                newName: "IX_Reservations_PlaceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Places_PlaceId",
                table: "Reservations",
                column: "PlaceId",
                principalTable: "Places",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Places_PlaceId",
                table: "Reservations");

            migrationBuilder.RenameColumn(
                name: "PlaceId",
                table: "Reservations",
                newName: "placeId");

            migrationBuilder.RenameIndex(
                name: "IX_Reservations_PlaceId",
                table: "Reservations",
                newName: "IX_Reservations_placeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Places_placeId",
                table: "Reservations",
                column: "placeId",
                principalTable: "Places",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
