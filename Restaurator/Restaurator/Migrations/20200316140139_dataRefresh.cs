using Microsoft.EntityFrameworkCore.Migrations;

namespace Restaurator.Migrations
{
    public partial class dataRefresh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Places_PlaceId",
                table: "Reservations");

            migrationBuilder.RenameColumn(
                name: "PlaceId",
                table: "Reservations",
                newName: "placeId");

            migrationBuilder.RenameColumn(
                name: "NumOfPersons",
                table: "Reservations",
                newName: "numOfPersons");

            migrationBuilder.RenameIndex(
                name: "IX_Reservations_PlaceId",
                table: "Reservations",
                newName: "IX_Reservations_placeId");

            migrationBuilder.AlterColumn<int>(
                name: "placeId",
                table: "Reservations",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Places_placeId",
                table: "Reservations",
                column: "placeId",
                principalTable: "Places",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Places_placeId",
                table: "Reservations");

            migrationBuilder.RenameColumn(
                name: "placeId",
                table: "Reservations",
                newName: "PlaceId");

            migrationBuilder.RenameColumn(
                name: "numOfPersons",
                table: "Reservations",
                newName: "NumOfPersons");

            migrationBuilder.RenameIndex(
                name: "IX_Reservations_placeId",
                table: "Reservations",
                newName: "IX_Reservations_PlaceId");

            migrationBuilder.AlterColumn<int>(
                name: "PlaceId",
                table: "Reservations",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Places_PlaceId",
                table: "Reservations",
                column: "PlaceId",
                principalTable: "Places",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
