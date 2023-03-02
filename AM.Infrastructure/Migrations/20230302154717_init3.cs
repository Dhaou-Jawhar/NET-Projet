using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class init3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlightPassenger_MyFlight_flightsFlightId",
                table: "FlightPassenger");

            migrationBuilder.DropForeignKey(
                name: "FK_FlightPassenger_Passengers_passengersPassportNumber",
                table: "FlightPassenger");

            migrationBuilder.DropForeignKey(
                name: "FK_MyFlight_Planes_PlaneFK",
                table: "MyFlight");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FlightPassenger",
                table: "FlightPassenger");

            migrationBuilder.RenameTable(
                name: "FlightPassenger",
                newName: "My Reservation");

            migrationBuilder.RenameIndex(
                name: "IX_FlightPassenger_passengersPassportNumber",
                table: "My Reservation",
                newName: "IX_My Reservation_passengersPassportNumber");

            migrationBuilder.AlterColumn<int>(
                name: "PlaneFK",
                table: "MyFlight",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_My Reservation",
                table: "My Reservation",
                columns: new[] { "flightsFlightId", "passengersPassportNumber" });

            migrationBuilder.AddForeignKey(
                name: "FK_My Reservation_MyFlight_flightsFlightId",
                table: "My Reservation",
                column: "flightsFlightId",
                principalTable: "MyFlight",
                principalColumn: "FlightId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_My Reservation_Passengers_passengersPassportNumber",
                table: "My Reservation",
                column: "passengersPassportNumber",
                principalTable: "Passengers",
                principalColumn: "PassportNumber",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MyFlight_Planes_PlaneFK",
                table: "MyFlight",
                column: "PlaneFK",
                principalTable: "Planes",
                principalColumn: "PlaneId",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_My Reservation_MyFlight_flightsFlightId",
                table: "My Reservation");

            migrationBuilder.DropForeignKey(
                name: "FK_My Reservation_Passengers_passengersPassportNumber",
                table: "My Reservation");

            migrationBuilder.DropForeignKey(
                name: "FK_MyFlight_Planes_PlaneFK",
                table: "MyFlight");

            migrationBuilder.DropPrimaryKey(
                name: "PK_My Reservation",
                table: "My Reservation");

            migrationBuilder.RenameTable(
                name: "My Reservation",
                newName: "FlightPassenger");

            migrationBuilder.RenameIndex(
                name: "IX_My Reservation_passengersPassportNumber",
                table: "FlightPassenger",
                newName: "IX_FlightPassenger_passengersPassportNumber");

            migrationBuilder.AlterColumn<int>(
                name: "PlaneFK",
                table: "MyFlight",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_FlightPassenger",
                table: "FlightPassenger",
                columns: new[] { "flightsFlightId", "passengersPassportNumber" });

            migrationBuilder.AddForeignKey(
                name: "FK_FlightPassenger_MyFlight_flightsFlightId",
                table: "FlightPassenger",
                column: "flightsFlightId",
                principalTable: "MyFlight",
                principalColumn: "FlightId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FlightPassenger_Passengers_passengersPassportNumber",
                table: "FlightPassenger",
                column: "passengersPassportNumber",
                principalTable: "Passengers",
                principalColumn: "PassportNumber",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MyFlight_Planes_PlaneFK",
                table: "MyFlight",
                column: "PlaneFK",
                principalTable: "Planes",
                principalColumn: "PlaneId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
