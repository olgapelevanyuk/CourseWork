using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OlympicFlights.DataAccess.Migrations
{
    public partial class Flight_FlightAirport_Airport_RefactoredAndImplementedRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_flights",
                columns: table => new
                {
                    cln_flight_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    cln_flight_departure_time = table.Column<DateTime>(nullable: false),
                    cln_flight_arrive_time = table.Column<DateTime>(nullable: false),
                    cln_flight_airplane_id = table.Column<int>(nullable: false),
                    CityID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_flights", x => x.cln_flight_id);
                    table.ForeignKey(
                        name: "FK_tbl_flights_tbl_airplanes_cln_flight_airplane_id",
                        column: x => x.cln_flight_airplane_id,
                        principalTable: "tbl_airplanes",
                        principalColumn: "cln_airplane_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_flights_tbl_cities_CityID",
                        column: x => x.CityID,
                        principalTable: "tbl_cities",
                        principalColumn: "cln_city_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tbl_flight_airports",
                columns: table => new
                {
                    cln_flight_airport_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    cln_flight_aiport_flight_id = table.Column<int>(nullable: false),
                    cln_flight_aiport_airport_id = table.Column<int>(nullable: false),
                    cln_flight_airport_is_arrive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_flight_airports", x => x.cln_flight_airport_id);
                    table.ForeignKey(
                        name: "FK_tbl_flight_airports_tbl_airports_cln_flight_aiport_airport_id",
                        column: x => x.cln_flight_aiport_airport_id,
                        principalTable: "tbl_airports",
                        principalColumn: "cln_airport_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_flight_airports_tbl_flights_cln_flight_aiport_flight_id",
                        column: x => x.cln_flight_aiport_flight_id,
                        principalTable: "tbl_flights",
                        principalColumn: "cln_flight_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "tbl_accounts",
                keyColumn: "cln_account_id",
                keyValue: 1,
                columns: new[] { "cln_account_created", "cln_account_updated" },
                values: new object[] { new DateTime(2019, 3, 17, 15, 6, 15, 524, DateTimeKind.Utc).AddTicks(9746), new DateTime(2019, 3, 17, 15, 6, 15, 524, DateTimeKind.Utc).AddTicks(9746) });

            migrationBuilder.UpdateData(
                table: "tbl_accounts",
                keyColumn: "cln_account_id",
                keyValue: 2,
                columns: new[] { "cln_account_created", "cln_account_updated" },
                values: new object[] { new DateTime(2019, 3, 17, 15, 6, 15, 524, DateTimeKind.Utc).AddTicks(9746), new DateTime(2019, 3, 17, 15, 6, 15, 524, DateTimeKind.Utc).AddTicks(9746) });

            migrationBuilder.UpdateData(
                table: "tbl_airplanes",
                keyColumn: "cln_airplane_id",
                keyValue: 1,
                columns: new[] { "cln_airplane_created", "cln_airplane_updated" },
                values: new object[] { new DateTime(2019, 3, 17, 15, 6, 15, 524, DateTimeKind.Utc).AddTicks(9746), new DateTime(2019, 3, 17, 15, 6, 15, 524, DateTimeKind.Utc).AddTicks(9746) });

            migrationBuilder.UpdateData(
                table: "tbl_airplanes",
                keyColumn: "cln_airplane_id",
                keyValue: 2,
                columns: new[] { "cln_airplane_created", "cln_airplane_updated" },
                values: new object[] { new DateTime(2019, 3, 17, 15, 6, 15, 524, DateTimeKind.Utc).AddTicks(9746), new DateTime(2019, 3, 17, 15, 6, 15, 524, DateTimeKind.Utc).AddTicks(9746) });

            migrationBuilder.UpdateData(
                table: "tbl_airplanes",
                keyColumn: "cln_airplane_id",
                keyValue: 3,
                columns: new[] { "cln_airplane_created", "cln_airplane_updated" },
                values: new object[] { new DateTime(2019, 3, 17, 15, 6, 15, 524, DateTimeKind.Utc).AddTicks(9746), new DateTime(2019, 3, 17, 15, 6, 15, 524, DateTimeKind.Utc).AddTicks(9746) });

            migrationBuilder.UpdateData(
                table: "tbl_airplanes",
                keyColumn: "cln_airplane_id",
                keyValue: 4,
                columns: new[] { "cln_airplane_created", "cln_airplane_updated" },
                values: new object[] { new DateTime(2019, 3, 17, 15, 6, 15, 524, DateTimeKind.Utc).AddTicks(9746), new DateTime(2019, 3, 17, 15, 6, 15, 524, DateTimeKind.Utc).AddTicks(9746) });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 1,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 3, 17, 15, 6, 15, 524, DateTimeKind.Utc).AddTicks(9746), new DateTime(2019, 3, 17, 15, 6, 15, 524, DateTimeKind.Utc).AddTicks(9746) });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 2,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 3, 17, 15, 6, 15, 524, DateTimeKind.Utc).AddTicks(9746), new DateTime(2019, 3, 17, 15, 6, 15, 524, DateTimeKind.Utc).AddTicks(9746) });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 3,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 3, 17, 15, 6, 15, 524, DateTimeKind.Utc).AddTicks(9746), new DateTime(2019, 3, 17, 15, 6, 15, 524, DateTimeKind.Utc).AddTicks(9746) });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 4,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 3, 17, 15, 6, 15, 524, DateTimeKind.Utc).AddTicks(9746), new DateTime(2019, 3, 17, 15, 6, 15, 524, DateTimeKind.Utc).AddTicks(9746) });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 5,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 3, 17, 15, 6, 15, 524, DateTimeKind.Utc).AddTicks(9746), new DateTime(2019, 3, 17, 15, 6, 15, 524, DateTimeKind.Utc).AddTicks(9746) });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 6,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 3, 17, 15, 6, 15, 524, DateTimeKind.Utc).AddTicks(9746), new DateTime(2019, 3, 17, 15, 6, 15, 524, DateTimeKind.Utc).AddTicks(9746) });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 7,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 3, 17, 15, 6, 15, 524, DateTimeKind.Utc).AddTicks(9746), new DateTime(2019, 3, 17, 15, 6, 15, 524, DateTimeKind.Utc).AddTicks(9746) });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 8,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 3, 17, 15, 6, 15, 524, DateTimeKind.Utc).AddTicks(9746), new DateTime(2019, 3, 17, 15, 6, 15, 524, DateTimeKind.Utc).AddTicks(9746) });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 9,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 3, 17, 15, 6, 15, 524, DateTimeKind.Utc).AddTicks(9746), new DateTime(2019, 3, 17, 15, 6, 15, 524, DateTimeKind.Utc).AddTicks(9746) });

            migrationBuilder.UpdateData(
                table: "tbl_cities",
                keyColumn: "cln_city_id",
                keyValue: 1,
                columns: new[] { "cln_city_created", "cln_city_updated" },
                values: new object[] { new DateTime(2019, 3, 17, 15, 6, 15, 524, DateTimeKind.Utc).AddTicks(9746), new DateTime(2019, 3, 17, 15, 6, 15, 524, DateTimeKind.Utc).AddTicks(9746) });

            migrationBuilder.UpdateData(
                table: "tbl_cities",
                keyColumn: "cln_city_id",
                keyValue: 2,
                columns: new[] { "cln_city_created", "cln_city_updated" },
                values: new object[] { new DateTime(2019, 3, 17, 15, 6, 15, 524, DateTimeKind.Utc).AddTicks(9746), new DateTime(2019, 3, 17, 15, 6, 15, 524, DateTimeKind.Utc).AddTicks(9746) });

            migrationBuilder.UpdateData(
                table: "tbl_cities",
                keyColumn: "cln_city_id",
                keyValue: 3,
                columns: new[] { "cln_city_created", "cln_city_updated" },
                values: new object[] { new DateTime(2019, 3, 17, 15, 6, 15, 524, DateTimeKind.Utc).AddTicks(9746), new DateTime(2019, 3, 17, 15, 6, 15, 524, DateTimeKind.Utc).AddTicks(9746) });

            migrationBuilder.UpdateData(
                table: "tbl_clients",
                keyColumn: "ClientID",
                keyValue: 1,
                columns: new[] { "cln_client_created", "cln_client_updated" },
                values: new object[] { new DateTime(2019, 3, 17, 15, 6, 15, 524, DateTimeKind.Utc).AddTicks(9746), new DateTime(2019, 3, 17, 15, 6, 15, 524, DateTimeKind.Utc).AddTicks(9746) });

            migrationBuilder.UpdateData(
                table: "tbl_countries",
                keyColumn: "cln_country_id",
                keyValue: 1,
                columns: new[] { "cln_country_created", "cln_country_updated" },
                values: new object[] { new DateTime(2019, 3, 17, 15, 6, 15, 524, DateTimeKind.Utc).AddTicks(9746), new DateTime(2019, 3, 17, 15, 6, 15, 524, DateTimeKind.Utc).AddTicks(9746) });

            migrationBuilder.UpdateData(
                table: "tbl_countries",
                keyColumn: "cln_country_id",
                keyValue: 2,
                columns: new[] { "cln_country_created", "cln_country_updated" },
                values: new object[] { new DateTime(2019, 3, 17, 15, 6, 15, 524, DateTimeKind.Utc).AddTicks(9746), new DateTime(2019, 3, 17, 15, 6, 15, 524, DateTimeKind.Utc).AddTicks(9746) });

            migrationBuilder.UpdateData(
                table: "tbl_countries",
                keyColumn: "cln_country_id",
                keyValue: 3,
                columns: new[] { "cln_country_created", "cln_country_updated" },
                values: new object[] { new DateTime(2019, 3, 17, 15, 6, 15, 524, DateTimeKind.Utc).AddTicks(9746), new DateTime(2019, 3, 17, 15, 6, 15, 524, DateTimeKind.Utc).AddTicks(9746) });

            migrationBuilder.InsertData(
                table: "tbl_flights",
                columns: new[] { "cln_flight_id", "cln_flight_airplane_id", "cln_flight_arrive_time", "CityID", "cln_flight_departure_time" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2019, 3, 17, 22, 6, 15, 524, DateTimeKind.Utc).AddTicks(9746), null, new DateTime(2019, 3, 17, 15, 6, 15, 524, DateTimeKind.Utc).AddTicks(9746) },
                    { 2, 2, new DateTime(2019, 3, 17, 17, 6, 15, 524, DateTimeKind.Utc).AddTicks(9746), null, new DateTime(2019, 3, 17, 15, 6, 15, 524, DateTimeKind.Utc).AddTicks(9746) },
                    { 3, 3, new DateTime(2019, 3, 17, 21, 6, 15, 524, DateTimeKind.Utc).AddTicks(9746), null, new DateTime(2019, 3, 17, 15, 6, 15, 524, DateTimeKind.Utc).AddTicks(9746) }
                });

            migrationBuilder.InsertData(
                table: "tbl_flight_airports",
                columns: new[] { "cln_flight_airport_id", "cln_flight_aiport_airport_id", "cln_flight_aiport_flight_id", "cln_flight_airport_is_arrive" },
                values: new object[,]
                {
                    { 1, 3, 1, true },
                    { 2, 5, 1, false },
                    { 3, 4, 2, false },
                    { 4, 6, 2, true },
                    { 5, 2, 3, true },
                    { 6, 7, 3, false }
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_flight_airports_cln_flight_aiport_airport_id",
                table: "tbl_flight_airports",
                column: "cln_flight_aiport_airport_id");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_flight_airports_cln_flight_aiport_flight_id",
                table: "tbl_flight_airports",
                column: "cln_flight_aiport_flight_id");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_flights_cln_flight_airplane_id",
                table: "tbl_flights",
                column: "cln_flight_airplane_id");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_flights_CityID",
                table: "tbl_flights",
                column: "CityID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_flight_airports");

            migrationBuilder.DropTable(
                name: "tbl_flights");

            migrationBuilder.UpdateData(
                table: "tbl_accounts",
                keyColumn: "cln_account_id",
                keyValue: 1,
                columns: new[] { "cln_account_created", "cln_account_updated" },
                values: new object[] { new DateTime(2019, 3, 16, 19, 23, 54, 913, DateTimeKind.Utc).AddTicks(9364), new DateTime(2019, 3, 16, 19, 23, 54, 913, DateTimeKind.Utc).AddTicks(9364) });

            migrationBuilder.UpdateData(
                table: "tbl_accounts",
                keyColumn: "cln_account_id",
                keyValue: 2,
                columns: new[] { "cln_account_created", "cln_account_updated" },
                values: new object[] { new DateTime(2019, 3, 16, 19, 23, 54, 913, DateTimeKind.Utc).AddTicks(9364), new DateTime(2019, 3, 16, 19, 23, 54, 913, DateTimeKind.Utc).AddTicks(9364) });

            migrationBuilder.UpdateData(
                table: "tbl_airplanes",
                keyColumn: "cln_airplane_id",
                keyValue: 1,
                columns: new[] { "cln_airplane_created", "cln_airplane_updated" },
                values: new object[] { new DateTime(2019, 3, 16, 19, 23, 54, 913, DateTimeKind.Utc).AddTicks(9364), new DateTime(2019, 3, 16, 19, 23, 54, 913, DateTimeKind.Utc).AddTicks(9364) });

            migrationBuilder.UpdateData(
                table: "tbl_airplanes",
                keyColumn: "cln_airplane_id",
                keyValue: 2,
                columns: new[] { "cln_airplane_created", "cln_airplane_updated" },
                values: new object[] { new DateTime(2019, 3, 16, 19, 23, 54, 913, DateTimeKind.Utc).AddTicks(9364), new DateTime(2019, 3, 16, 19, 23, 54, 913, DateTimeKind.Utc).AddTicks(9364) });

            migrationBuilder.UpdateData(
                table: "tbl_airplanes",
                keyColumn: "cln_airplane_id",
                keyValue: 3,
                columns: new[] { "cln_airplane_created", "cln_airplane_updated" },
                values: new object[] { new DateTime(2019, 3, 16, 19, 23, 54, 913, DateTimeKind.Utc).AddTicks(9364), new DateTime(2019, 3, 16, 19, 23, 54, 913, DateTimeKind.Utc).AddTicks(9364) });

            migrationBuilder.UpdateData(
                table: "tbl_airplanes",
                keyColumn: "cln_airplane_id",
                keyValue: 4,
                columns: new[] { "cln_airplane_created", "cln_airplane_updated" },
                values: new object[] { new DateTime(2019, 3, 16, 19, 23, 54, 913, DateTimeKind.Utc).AddTicks(9364), new DateTime(2019, 3, 16, 19, 23, 54, 913, DateTimeKind.Utc).AddTicks(9364) });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 1,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 3, 16, 19, 23, 54, 913, DateTimeKind.Utc).AddTicks(9364), new DateTime(2019, 3, 16, 19, 23, 54, 913, DateTimeKind.Utc).AddTicks(9364) });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 2,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 3, 16, 19, 23, 54, 913, DateTimeKind.Utc).AddTicks(9364), new DateTime(2019, 3, 16, 19, 23, 54, 913, DateTimeKind.Utc).AddTicks(9364) });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 3,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 3, 16, 19, 23, 54, 913, DateTimeKind.Utc).AddTicks(9364), new DateTime(2019, 3, 16, 19, 23, 54, 913, DateTimeKind.Utc).AddTicks(9364) });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 4,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 3, 16, 19, 23, 54, 913, DateTimeKind.Utc).AddTicks(9364), new DateTime(2019, 3, 16, 19, 23, 54, 913, DateTimeKind.Utc).AddTicks(9364) });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 5,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 3, 16, 19, 23, 54, 913, DateTimeKind.Utc).AddTicks(9364), new DateTime(2019, 3, 16, 19, 23, 54, 913, DateTimeKind.Utc).AddTicks(9364) });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 6,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 3, 16, 19, 23, 54, 913, DateTimeKind.Utc).AddTicks(9364), new DateTime(2019, 3, 16, 19, 23, 54, 913, DateTimeKind.Utc).AddTicks(9364) });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 7,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 3, 16, 19, 23, 54, 913, DateTimeKind.Utc).AddTicks(9364), new DateTime(2019, 3, 16, 19, 23, 54, 913, DateTimeKind.Utc).AddTicks(9364) });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 8,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 3, 16, 19, 23, 54, 913, DateTimeKind.Utc).AddTicks(9364), new DateTime(2019, 3, 16, 19, 23, 54, 913, DateTimeKind.Utc).AddTicks(9364) });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 9,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 3, 16, 19, 23, 54, 913, DateTimeKind.Utc).AddTicks(9364), new DateTime(2019, 3, 16, 19, 23, 54, 913, DateTimeKind.Utc).AddTicks(9364) });

            migrationBuilder.UpdateData(
                table: "tbl_cities",
                keyColumn: "cln_city_id",
                keyValue: 1,
                columns: new[] { "cln_city_created", "cln_city_updated" },
                values: new object[] { new DateTime(2019, 3, 16, 19, 23, 54, 913, DateTimeKind.Utc).AddTicks(9364), new DateTime(2019, 3, 16, 19, 23, 54, 913, DateTimeKind.Utc).AddTicks(9364) });

            migrationBuilder.UpdateData(
                table: "tbl_cities",
                keyColumn: "cln_city_id",
                keyValue: 2,
                columns: new[] { "cln_city_created", "cln_city_updated" },
                values: new object[] { new DateTime(2019, 3, 16, 19, 23, 54, 913, DateTimeKind.Utc).AddTicks(9364), new DateTime(2019, 3, 16, 19, 23, 54, 913, DateTimeKind.Utc).AddTicks(9364) });

            migrationBuilder.UpdateData(
                table: "tbl_cities",
                keyColumn: "cln_city_id",
                keyValue: 3,
                columns: new[] { "cln_city_created", "cln_city_updated" },
                values: new object[] { new DateTime(2019, 3, 16, 19, 23, 54, 913, DateTimeKind.Utc).AddTicks(9364), new DateTime(2019, 3, 16, 19, 23, 54, 913, DateTimeKind.Utc).AddTicks(9364) });

            migrationBuilder.UpdateData(
                table: "tbl_clients",
                keyColumn: "ClientID",
                keyValue: 1,
                columns: new[] { "cln_client_created", "cln_client_updated" },
                values: new object[] { new DateTime(2019, 3, 16, 19, 23, 54, 913, DateTimeKind.Utc).AddTicks(9364), new DateTime(2019, 3, 16, 19, 23, 54, 913, DateTimeKind.Utc).AddTicks(9364) });

            migrationBuilder.UpdateData(
                table: "tbl_countries",
                keyColumn: "cln_country_id",
                keyValue: 1,
                columns: new[] { "cln_country_created", "cln_country_updated" },
                values: new object[] { new DateTime(2019, 3, 16, 19, 23, 54, 913, DateTimeKind.Utc).AddTicks(9364), new DateTime(2019, 3, 16, 19, 23, 54, 913, DateTimeKind.Utc).AddTicks(9364) });

            migrationBuilder.UpdateData(
                table: "tbl_countries",
                keyColumn: "cln_country_id",
                keyValue: 2,
                columns: new[] { "cln_country_created", "cln_country_updated" },
                values: new object[] { new DateTime(2019, 3, 16, 19, 23, 54, 913, DateTimeKind.Utc).AddTicks(9364), new DateTime(2019, 3, 16, 19, 23, 54, 913, DateTimeKind.Utc).AddTicks(9364) });

            migrationBuilder.UpdateData(
                table: "tbl_countries",
                keyColumn: "cln_country_id",
                keyValue: 3,
                columns: new[] { "cln_country_created", "cln_country_updated" },
                values: new object[] { new DateTime(2019, 3, 16, 19, 23, 54, 913, DateTimeKind.Utc).AddTicks(9364), new DateTime(2019, 3, 16, 19, 23, 54, 913, DateTimeKind.Utc).AddTicks(9364) });
        }
    }
}
