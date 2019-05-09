using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OlympicFlights.DataAccess.Migrations
{
    public partial class ImplementedTicket : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_tickets",
                columns: table => new
                {
                    cln_ticket_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    cln_ticket_client_id = table.Column<int>(nullable: false),
                    cln_ticket_flight_id = table.Column<int>(nullable: false),
                    cln_ticket_sit_number = table.Column<int>(nullable: false),
                    cln_ticket_purchase_time = table.Column<DateTime>(nullable: false),
                    cln_ticket_is_purchase_approved = table.Column<bool>(nullable: false, defaultValue: false),
                    cln_ticket_price_coefficient = table.Column<decimal>(nullable: false, defaultValue: 1.3m)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_tickets", x => x.cln_ticket_id);
                    table.ForeignKey(
                        name: "FK_tbl_tickets_tbl_clients_cln_ticket_client_id",
                        column: x => x.cln_ticket_client_id,
                        principalTable: "tbl_clients",
                        principalColumn: "ClientID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_tickets_tbl_flights_cln_ticket_flight_id",
                        column: x => x.cln_ticket_flight_id,
                        principalTable: "tbl_flights",
                        principalColumn: "cln_flight_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "tbl_accounts",
                keyColumn: "cln_account_id",
                keyValue: 1,
                columns: new[] { "cln_account_created", "cln_account_updated" },
                values: new object[] { new DateTime(2019, 3, 17, 15, 57, 52, 424, DateTimeKind.Utc).AddTicks(725), new DateTime(2019, 3, 17, 15, 57, 52, 424, DateTimeKind.Utc).AddTicks(725) });

            migrationBuilder.UpdateData(
                table: "tbl_accounts",
                keyColumn: "cln_account_id",
                keyValue: 2,
                columns: new[] { "cln_account_created", "cln_account_updated" },
                values: new object[] { new DateTime(2019, 3, 17, 15, 57, 52, 424, DateTimeKind.Utc).AddTicks(725), new DateTime(2019, 3, 17, 15, 57, 52, 424, DateTimeKind.Utc).AddTicks(725) });

            migrationBuilder.UpdateData(
                table: "tbl_airplanes",
                keyColumn: "cln_airplane_id",
                keyValue: 1,
                columns: new[] { "cln_airplane_created", "cln_airplane_updated" },
                values: new object[] { new DateTime(2019, 3, 17, 15, 57, 52, 424, DateTimeKind.Utc).AddTicks(725), new DateTime(2019, 3, 17, 15, 57, 52, 424, DateTimeKind.Utc).AddTicks(725) });

            migrationBuilder.UpdateData(
                table: "tbl_airplanes",
                keyColumn: "cln_airplane_id",
                keyValue: 2,
                columns: new[] { "cln_airplane_created", "cln_airplane_updated" },
                values: new object[] { new DateTime(2019, 3, 17, 15, 57, 52, 424, DateTimeKind.Utc).AddTicks(725), new DateTime(2019, 3, 17, 15, 57, 52, 424, DateTimeKind.Utc).AddTicks(725) });

            migrationBuilder.UpdateData(
                table: "tbl_airplanes",
                keyColumn: "cln_airplane_id",
                keyValue: 3,
                columns: new[] { "cln_airplane_created", "cln_airplane_updated" },
                values: new object[] { new DateTime(2019, 3, 17, 15, 57, 52, 424, DateTimeKind.Utc).AddTicks(725), new DateTime(2019, 3, 17, 15, 57, 52, 424, DateTimeKind.Utc).AddTicks(725) });

            migrationBuilder.UpdateData(
                table: "tbl_airplanes",
                keyColumn: "cln_airplane_id",
                keyValue: 4,
                columns: new[] { "cln_airplane_created", "cln_airplane_updated" },
                values: new object[] { new DateTime(2019, 3, 17, 15, 57, 52, 424, DateTimeKind.Utc).AddTicks(725), new DateTime(2019, 3, 17, 15, 57, 52, 424, DateTimeKind.Utc).AddTicks(725) });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 1,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 3, 17, 15, 57, 52, 424, DateTimeKind.Utc).AddTicks(725), new DateTime(2019, 3, 17, 15, 57, 52, 424, DateTimeKind.Utc).AddTicks(725) });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 2,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 3, 17, 15, 57, 52, 424, DateTimeKind.Utc).AddTicks(725), new DateTime(2019, 3, 17, 15, 57, 52, 424, DateTimeKind.Utc).AddTicks(725) });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 3,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 3, 17, 15, 57, 52, 424, DateTimeKind.Utc).AddTicks(725), new DateTime(2019, 3, 17, 15, 57, 52, 424, DateTimeKind.Utc).AddTicks(725) });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 4,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 3, 17, 15, 57, 52, 424, DateTimeKind.Utc).AddTicks(725), new DateTime(2019, 3, 17, 15, 57, 52, 424, DateTimeKind.Utc).AddTicks(725) });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 5,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 3, 17, 15, 57, 52, 424, DateTimeKind.Utc).AddTicks(725), new DateTime(2019, 3, 17, 15, 57, 52, 424, DateTimeKind.Utc).AddTicks(725) });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 6,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 3, 17, 15, 57, 52, 424, DateTimeKind.Utc).AddTicks(725), new DateTime(2019, 3, 17, 15, 57, 52, 424, DateTimeKind.Utc).AddTicks(725) });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 7,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 3, 17, 15, 57, 52, 424, DateTimeKind.Utc).AddTicks(725), new DateTime(2019, 3, 17, 15, 57, 52, 424, DateTimeKind.Utc).AddTicks(725) });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 8,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 3, 17, 15, 57, 52, 424, DateTimeKind.Utc).AddTicks(725), new DateTime(2019, 3, 17, 15, 57, 52, 424, DateTimeKind.Utc).AddTicks(725) });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 9,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 3, 17, 15, 57, 52, 424, DateTimeKind.Utc).AddTicks(725), new DateTime(2019, 3, 17, 15, 57, 52, 424, DateTimeKind.Utc).AddTicks(725) });

            migrationBuilder.UpdateData(
                table: "tbl_cities",
                keyColumn: "cln_city_id",
                keyValue: 1,
                columns: new[] { "cln_city_created", "cln_city_updated" },
                values: new object[] { new DateTime(2019, 3, 17, 15, 57, 52, 424, DateTimeKind.Utc).AddTicks(725), new DateTime(2019, 3, 17, 15, 57, 52, 424, DateTimeKind.Utc).AddTicks(725) });

            migrationBuilder.UpdateData(
                table: "tbl_cities",
                keyColumn: "cln_city_id",
                keyValue: 2,
                columns: new[] { "cln_city_created", "cln_city_updated" },
                values: new object[] { new DateTime(2019, 3, 17, 15, 57, 52, 424, DateTimeKind.Utc).AddTicks(725), new DateTime(2019, 3, 17, 15, 57, 52, 424, DateTimeKind.Utc).AddTicks(725) });

            migrationBuilder.UpdateData(
                table: "tbl_cities",
                keyColumn: "cln_city_id",
                keyValue: 3,
                columns: new[] { "cln_city_created", "cln_city_updated" },
                values: new object[] { new DateTime(2019, 3, 17, 15, 57, 52, 424, DateTimeKind.Utc).AddTicks(725), new DateTime(2019, 3, 17, 15, 57, 52, 424, DateTimeKind.Utc).AddTicks(725) });

            migrationBuilder.UpdateData(
                table: "tbl_clients",
                keyColumn: "ClientID",
                keyValue: 1,
                columns: new[] { "cln_client_created", "cln_client_updated" },
                values: new object[] { new DateTime(2019, 3, 17, 15, 57, 52, 424, DateTimeKind.Utc).AddTicks(725), new DateTime(2019, 3, 17, 15, 57, 52, 424, DateTimeKind.Utc).AddTicks(725) });

            migrationBuilder.UpdateData(
                table: "tbl_countries",
                keyColumn: "cln_country_id",
                keyValue: 1,
                columns: new[] { "cln_country_created", "cln_country_updated" },
                values: new object[] { new DateTime(2019, 3, 17, 15, 57, 52, 424, DateTimeKind.Utc).AddTicks(725), new DateTime(2019, 3, 17, 15, 57, 52, 424, DateTimeKind.Utc).AddTicks(725) });

            migrationBuilder.UpdateData(
                table: "tbl_countries",
                keyColumn: "cln_country_id",
                keyValue: 2,
                columns: new[] { "cln_country_created", "cln_country_updated" },
                values: new object[] { new DateTime(2019, 3, 17, 15, 57, 52, 424, DateTimeKind.Utc).AddTicks(725), new DateTime(2019, 3, 17, 15, 57, 52, 424, DateTimeKind.Utc).AddTicks(725) });

            migrationBuilder.UpdateData(
                table: "tbl_countries",
                keyColumn: "cln_country_id",
                keyValue: 3,
                columns: new[] { "cln_country_created", "cln_country_updated" },
                values: new object[] { new DateTime(2019, 3, 17, 15, 57, 52, 424, DateTimeKind.Utc).AddTicks(725), new DateTime(2019, 3, 17, 15, 57, 52, 424, DateTimeKind.Utc).AddTicks(725) });

            migrationBuilder.UpdateData(
                table: "tbl_flights",
                keyColumn: "cln_flight_id",
                keyValue: 1,
                columns: new[] { "cln_flight_arrive_time", "cln_flight_departure_time" },
                values: new object[] { new DateTime(2019, 3, 17, 22, 57, 52, 424, DateTimeKind.Utc).AddTicks(725), new DateTime(2019, 3, 17, 15, 57, 52, 424, DateTimeKind.Utc).AddTicks(725) });

            migrationBuilder.UpdateData(
                table: "tbl_flights",
                keyColumn: "cln_flight_id",
                keyValue: 2,
                columns: new[] { "cln_flight_arrive_time", "cln_flight_departure_time" },
                values: new object[] { new DateTime(2019, 3, 17, 17, 57, 52, 424, DateTimeKind.Utc).AddTicks(725), new DateTime(2019, 3, 17, 15, 57, 52, 424, DateTimeKind.Utc).AddTicks(725) });

            migrationBuilder.UpdateData(
                table: "tbl_flights",
                keyColumn: "cln_flight_id",
                keyValue: 3,
                columns: new[] { "cln_flight_arrive_time", "cln_flight_departure_time" },
                values: new object[] { new DateTime(2019, 3, 17, 21, 57, 52, 424, DateTimeKind.Utc).AddTicks(725), new DateTime(2019, 3, 17, 15, 57, 52, 424, DateTimeKind.Utc).AddTicks(725) });

            migrationBuilder.InsertData(
                table: "tbl_tickets",
                columns: new[] { "cln_ticket_id", "cln_ticket_client_id", "cln_ticket_flight_id", "cln_ticket_purchase_time", "cln_ticket_sit_number" },
                values: new object[] { 1, 1, 1, new DateTime(2019, 3, 14, 15, 57, 52, 424, DateTimeKind.Utc).AddTicks(725), 10 });

            migrationBuilder.InsertData(
                table: "tbl_tickets",
                columns: new[] { "cln_ticket_id", "cln_ticket_client_id", "cln_ticket_flight_id", "cln_ticket_purchase_time", "cln_ticket_sit_number" },
                values: new object[] { 2, 1, 2, new DateTime(2019, 3, 13, 15, 57, 52, 424, DateTimeKind.Utc).AddTicks(725), 30 });

            migrationBuilder.InsertData(
                table: "tbl_tickets",
                columns: new[] { "cln_ticket_id", "cln_ticket_client_id", "cln_ticket_flight_id", "cln_ticket_purchase_time", "cln_ticket_sit_number" },
                values: new object[] { 3, 1, 3, new DateTime(2019, 3, 15, 15, 57, 52, 424, DateTimeKind.Utc).AddTicks(725), 40 });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_tickets_cln_ticket_client_id",
                table: "tbl_tickets",
                column: "cln_ticket_client_id");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_tickets_cln_ticket_flight_id",
                table: "tbl_tickets",
                column: "cln_ticket_flight_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_tickets");

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

            migrationBuilder.UpdateData(
                table: "tbl_flights",
                keyColumn: "cln_flight_id",
                keyValue: 1,
                columns: new[] { "cln_flight_arrive_time", "cln_flight_departure_time" },
                values: new object[] { new DateTime(2019, 3, 17, 22, 6, 15, 524, DateTimeKind.Utc).AddTicks(9746), new DateTime(2019, 3, 17, 15, 6, 15, 524, DateTimeKind.Utc).AddTicks(9746) });

            migrationBuilder.UpdateData(
                table: "tbl_flights",
                keyColumn: "cln_flight_id",
                keyValue: 2,
                columns: new[] { "cln_flight_arrive_time", "cln_flight_departure_time" },
                values: new object[] { new DateTime(2019, 3, 17, 17, 6, 15, 524, DateTimeKind.Utc).AddTicks(9746), new DateTime(2019, 3, 17, 15, 6, 15, 524, DateTimeKind.Utc).AddTicks(9746) });

            migrationBuilder.UpdateData(
                table: "tbl_flights",
                keyColumn: "cln_flight_id",
                keyValue: 3,
                columns: new[] { "cln_flight_arrive_time", "cln_flight_departure_time" },
                values: new object[] { new DateTime(2019, 3, 17, 21, 6, 15, 524, DateTimeKind.Utc).AddTicks(9746), new DateTime(2019, 3, 17, 15, 6, 15, 524, DateTimeKind.Utc).AddTicks(9746) });
        }
    }
}
