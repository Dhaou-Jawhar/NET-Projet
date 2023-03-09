using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class mig9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_MyFlight_FlightId",
                table: "Ticket");

            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_Passenger_PassengerPassportNumber",
                table: "Ticket");

            migrationBuilder.DropIndex(
                name: "IX_Ticket_FlightId",
                table: "Ticket");

            migrationBuilder.DropIndex(
                name: "IX_Ticket_PassengerPassportNumber",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "FlightId",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "PassengerPassportNumber",
                table: "Ticket");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_FlightFK",
                table: "Ticket",
                column: "FlightFK");

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_MyFlight_FlightFK",
                table: "Ticket",
                column: "FlightFK",
                principalTable: "MyFlight",
                principalColumn: "FlightId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_Passenger_PassengerPK",
                table: "Ticket",
                column: "PassengerPK",
                principalTable: "Passenger",
                principalColumn: "PassportNumber",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_MyFlight_FlightFK",
                table: "Ticket");

            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_Passenger_PassengerPK",
                table: "Ticket");

            migrationBuilder.DropIndex(
                name: "IX_Ticket_FlightFK",
                table: "Ticket");

            migrationBuilder.AddColumn<int>(
                name: "FlightId",
                table: "Ticket",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PassengerPassportNumber",
                table: "Ticket",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_FlightId",
                table: "Ticket",
                column: "FlightId");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_PassengerPassportNumber",
                table: "Ticket",
                column: "PassengerPassportNumber");

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_MyFlight_FlightId",
                table: "Ticket",
                column: "FlightId",
                principalTable: "MyFlight",
                principalColumn: "FlightId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_Passenger_PassengerPassportNumber",
                table: "Ticket",
                column: "PassengerPassportNumber",
                principalTable: "Passenger",
                principalColumn: "PassportNumber",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
