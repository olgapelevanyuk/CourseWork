using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OlympicFlights.DataAccess.Migrations
{
    public partial class FixAirplaneIdName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "tbl_accounts",
                keyColumn: "cln_account_id",
                keyValue: 1,
                columns: new[] { "cln_account_created", "cln_account_updated" },
                values: new object[] { new DateTime(2019, 4, 17, 19, 43, 7, 251, DateTimeKind.Utc).AddTicks(9345), new DateTime(2019, 4, 17, 19, 43, 7, 251, DateTimeKind.Utc).AddTicks(9345) });

            migrationBuilder.UpdateData(
                table: "tbl_accounts",
                keyColumn: "cln_account_id",
                keyValue: 2,
                columns: new[] { "cln_account_created", "cln_account_updated" },
                values: new object[] { new DateTime(2019, 4, 17, 19, 43, 7, 251, DateTimeKind.Utc).AddTicks(9345), new DateTime(2019, 4, 17, 19, 43, 7, 251, DateTimeKind.Utc).AddTicks(9345) });

            migrationBuilder.UpdateData(
                table: "tbl_airplanes",
                keyColumn: "cln_airplane_id",
                keyValue: 1,
                columns: new[] { "cln_airplane_created", "cln_airplane_updated" },
                values: new object[] { new DateTime(2019, 4, 17, 19, 43, 7, 251, DateTimeKind.Utc).AddTicks(9345), new DateTime(2019, 4, 17, 19, 43, 7, 251, DateTimeKind.Utc).AddTicks(9345) });

            migrationBuilder.UpdateData(
                table: "tbl_airplanes",
                keyColumn: "cln_airplane_id",
                keyValue: 2,
                columns: new[] { "cln_airplane_created", "cln_airplane_updated" },
                values: new object[] { new DateTime(2019, 4, 17, 19, 43, 7, 251, DateTimeKind.Utc).AddTicks(9345), new DateTime(2019, 4, 17, 19, 43, 7, 251, DateTimeKind.Utc).AddTicks(9345) });

            migrationBuilder.UpdateData(
                table: "tbl_airplanes",
                keyColumn: "cln_airplane_id",
                keyValue: 3,
                columns: new[] { "cln_airplane_created", "cln_airplane_updated" },
                values: new object[] { new DateTime(2019, 4, 17, 19, 43, 7, 251, DateTimeKind.Utc).AddTicks(9345), new DateTime(2019, 4, 17, 19, 43, 7, 251, DateTimeKind.Utc).AddTicks(9345) });

            migrationBuilder.UpdateData(
                table: "tbl_airplanes",
                keyColumn: "cln_airplane_id",
                keyValue: 4,
                columns: new[] { "cln_airplane_created", "cln_airplane_updated" },
                values: new object[] { new DateTime(2019, 4, 17, 19, 43, 7, 251, DateTimeKind.Utc).AddTicks(9345), new DateTime(2019, 4, 17, 19, 43, 7, 251, DateTimeKind.Utc).AddTicks(9345) });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 1,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 4, 17, 19, 43, 7, 251, DateTimeKind.Utc).AddTicks(9345), new DateTime(2019, 4, 17, 19, 43, 7, 251, DateTimeKind.Utc).AddTicks(9345) });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 2,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 4, 17, 19, 43, 7, 251, DateTimeKind.Utc).AddTicks(9345), new DateTime(2019, 4, 17, 19, 43, 7, 251, DateTimeKind.Utc).AddTicks(9345) });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 3,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 4, 17, 19, 43, 7, 251, DateTimeKind.Utc).AddTicks(9345), new DateTime(2019, 4, 17, 19, 43, 7, 251, DateTimeKind.Utc).AddTicks(9345) });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 4,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 4, 17, 19, 43, 7, 251, DateTimeKind.Utc).AddTicks(9345), new DateTime(2019, 4, 17, 19, 43, 7, 251, DateTimeKind.Utc).AddTicks(9345) });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 5,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 4, 17, 19, 43, 7, 251, DateTimeKind.Utc).AddTicks(9345), new DateTime(2019, 4, 17, 19, 43, 7, 251, DateTimeKind.Utc).AddTicks(9345) });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 6,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 4, 17, 19, 43, 7, 251, DateTimeKind.Utc).AddTicks(9345), new DateTime(2019, 4, 17, 19, 43, 7, 251, DateTimeKind.Utc).AddTicks(9345) });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 7,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 4, 17, 19, 43, 7, 251, DateTimeKind.Utc).AddTicks(9345), new DateTime(2019, 4, 17, 19, 43, 7, 251, DateTimeKind.Utc).AddTicks(9345) });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 8,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 4, 17, 19, 43, 7, 251, DateTimeKind.Utc).AddTicks(9345), new DateTime(2019, 4, 17, 19, 43, 7, 251, DateTimeKind.Utc).AddTicks(9345) });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 9,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 4, 17, 19, 43, 7, 251, DateTimeKind.Utc).AddTicks(9345), new DateTime(2019, 4, 17, 19, 43, 7, 251, DateTimeKind.Utc).AddTicks(9345) });

            migrationBuilder.UpdateData(
                table: "tbl_cities",
                keyColumn: "cln_city_id",
                keyValue: 1,
                columns: new[] { "cln_city_created", "cln_city_updated" },
                values: new object[] { new DateTime(2019, 4, 17, 19, 43, 7, 251, DateTimeKind.Utc).AddTicks(9345), new DateTime(2019, 4, 17, 19, 43, 7, 251, DateTimeKind.Utc).AddTicks(9345) });

            migrationBuilder.UpdateData(
                table: "tbl_cities",
                keyColumn: "cln_city_id",
                keyValue: 2,
                columns: new[] { "cln_city_created", "cln_city_updated" },
                values: new object[] { new DateTime(2019, 4, 17, 19, 43, 7, 251, DateTimeKind.Utc).AddTicks(9345), new DateTime(2019, 4, 17, 19, 43, 7, 251, DateTimeKind.Utc).AddTicks(9345) });

            migrationBuilder.UpdateData(
                table: "tbl_cities",
                keyColumn: "cln_city_id",
                keyValue: 3,
                columns: new[] { "cln_city_created", "cln_city_updated" },
                values: new object[] { new DateTime(2019, 4, 17, 19, 43, 7, 251, DateTimeKind.Utc).AddTicks(9345), new DateTime(2019, 4, 17, 19, 43, 7, 251, DateTimeKind.Utc).AddTicks(9345) });

            migrationBuilder.UpdateData(
                table: "tbl_clients",
                keyColumn: "ClientId",
                keyValue: 1,
                columns: new[] { "cln_client_created", "cln_client_updated" },
                values: new object[] { new DateTime(2019, 4, 17, 19, 43, 7, 251, DateTimeKind.Utc).AddTicks(9345), new DateTime(2019, 4, 17, 19, 43, 7, 251, DateTimeKind.Utc).AddTicks(9345) });

            migrationBuilder.UpdateData(
                table: "tbl_countries",
                keyColumn: "cln_country_id",
                keyValue: 1,
                columns: new[] { "cln_country_created", "cln_country_updated" },
                values: new object[] { new DateTime(2019, 4, 17, 19, 43, 7, 251, DateTimeKind.Utc).AddTicks(9345), new DateTime(2019, 4, 17, 19, 43, 7, 251, DateTimeKind.Utc).AddTicks(9345) });

            migrationBuilder.UpdateData(
                table: "tbl_countries",
                keyColumn: "cln_country_id",
                keyValue: 2,
                columns: new[] { "cln_country_created", "cln_country_updated" },
                values: new object[] { new DateTime(2019, 4, 17, 19, 43, 7, 251, DateTimeKind.Utc).AddTicks(9345), new DateTime(2019, 4, 17, 19, 43, 7, 251, DateTimeKind.Utc).AddTicks(9345) });

            migrationBuilder.UpdateData(
                table: "tbl_countries",
                keyColumn: "cln_country_id",
                keyValue: 3,
                columns: new[] { "cln_country_created", "cln_country_updated" },
                values: new object[] { new DateTime(2019, 4, 17, 19, 43, 7, 251, DateTimeKind.Utc).AddTicks(9345), new DateTime(2019, 4, 17, 19, 43, 7, 251, DateTimeKind.Utc).AddTicks(9345) });

            migrationBuilder.UpdateData(
                table: "tbl_flights",
                keyColumn: "cln_flight_id",
                keyValue: 1,
                columns: new[] { "cln_flight_arrive_time", "cln_flight_departure_time" },
                values: new object[] { new DateTime(2019, 4, 18, 2, 43, 7, 251, DateTimeKind.Utc).AddTicks(9345), new DateTime(2019, 4, 17, 19, 43, 7, 251, DateTimeKind.Utc).AddTicks(9345) });

            migrationBuilder.UpdateData(
                table: "tbl_flights",
                keyColumn: "cln_flight_id",
                keyValue: 2,
                columns: new[] { "cln_flight_arrive_time", "cln_flight_departure_time" },
                values: new object[] { new DateTime(2019, 4, 17, 21, 43, 7, 251, DateTimeKind.Utc).AddTicks(9345), new DateTime(2019, 4, 17, 19, 43, 7, 251, DateTimeKind.Utc).AddTicks(9345) });

            migrationBuilder.UpdateData(
                table: "tbl_flights",
                keyColumn: "cln_flight_id",
                keyValue: 3,
                columns: new[] { "cln_flight_arrive_time", "cln_flight_departure_time" },
                values: new object[] { new DateTime(2019, 4, 18, 1, 43, 7, 251, DateTimeKind.Utc).AddTicks(9345), new DateTime(2019, 4, 17, 19, 43, 7, 251, DateTimeKind.Utc).AddTicks(9345) });

            migrationBuilder.UpdateData(
                table: "tbl_tickets",
                keyColumn: "cln_ticket_id",
                keyValue: 1,
                column: "cln_ticket_purchase_time",
                value: new DateTime(2019, 4, 14, 19, 43, 7, 251, DateTimeKind.Utc).AddTicks(9345));

            migrationBuilder.UpdateData(
                table: "tbl_tickets",
                keyColumn: "cln_ticket_id",
                keyValue: 2,
                column: "cln_ticket_purchase_time",
                value: new DateTime(2019, 4, 13, 19, 43, 7, 251, DateTimeKind.Utc).AddTicks(9345));

            migrationBuilder.UpdateData(
                table: "tbl_tickets",
                keyColumn: "cln_ticket_id",
                keyValue: 3,
                column: "cln_ticket_purchase_time",
                value: new DateTime(2019, 4, 15, 19, 43, 7, 251, DateTimeKind.Utc).AddTicks(9345));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "tbl_accounts",
                keyColumn: "cln_account_id",
                keyValue: 1,
                columns: new[] { "cln_account_created", "cln_account_updated" },
                values: new object[] { new DateTime(2019, 4, 17, 8, 49, 27, 949, DateTimeKind.Utc).AddTicks(2911), new DateTime(2019, 4, 17, 8, 49, 27, 949, DateTimeKind.Utc).AddTicks(2911) });

            migrationBuilder.UpdateData(
                table: "tbl_accounts",
                keyColumn: "cln_account_id",
                keyValue: 2,
                columns: new[] { "cln_account_created", "cln_account_updated" },
                values: new object[] { new DateTime(2019, 4, 17, 8, 49, 27, 949, DateTimeKind.Utc).AddTicks(2911), new DateTime(2019, 4, 17, 8, 49, 27, 949, DateTimeKind.Utc).AddTicks(2911) });

            migrationBuilder.UpdateData(
                table: "tbl_airplanes",
                keyColumn: "cln_airplane_id",
                keyValue: 1,
                columns: new[] { "cln_airplane_created", "cln_airplane_updated" },
                values: new object[] { new DateTime(2019, 4, 17, 8, 49, 27, 949, DateTimeKind.Utc).AddTicks(2911), new DateTime(2019, 4, 17, 8, 49, 27, 949, DateTimeKind.Utc).AddTicks(2911) });

            migrationBuilder.UpdateData(
                table: "tbl_airplanes",
                keyColumn: "cln_airplane_id",
                keyValue: 2,
                columns: new[] { "cln_airplane_created", "cln_airplane_updated" },
                values: new object[] { new DateTime(2019, 4, 17, 8, 49, 27, 949, DateTimeKind.Utc).AddTicks(2911), new DateTime(2019, 4, 17, 8, 49, 27, 949, DateTimeKind.Utc).AddTicks(2911) });

            migrationBuilder.UpdateData(
                table: "tbl_airplanes",
                keyColumn: "cln_airplane_id",
                keyValue: 3,
                columns: new[] { "cln_airplane_created", "cln_airplane_updated" },
                values: new object[] { new DateTime(2019, 4, 17, 8, 49, 27, 949, DateTimeKind.Utc).AddTicks(2911), new DateTime(2019, 4, 17, 8, 49, 27, 949, DateTimeKind.Utc).AddTicks(2911) });

            migrationBuilder.UpdateData(
                table: "tbl_airplanes",
                keyColumn: "cln_airplane_id",
                keyValue: 4,
                columns: new[] { "cln_airplane_created", "cln_airplane_updated" },
                values: new object[] { new DateTime(2019, 4, 17, 8, 49, 27, 949, DateTimeKind.Utc).AddTicks(2911), new DateTime(2019, 4, 17, 8, 49, 27, 949, DateTimeKind.Utc).AddTicks(2911) });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 1,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 4, 17, 8, 49, 27, 949, DateTimeKind.Utc).AddTicks(2911), new DateTime(2019, 4, 17, 8, 49, 27, 949, DateTimeKind.Utc).AddTicks(2911) });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 2,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 4, 17, 8, 49, 27, 949, DateTimeKind.Utc).AddTicks(2911), new DateTime(2019, 4, 17, 8, 49, 27, 949, DateTimeKind.Utc).AddTicks(2911) });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 3,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 4, 17, 8, 49, 27, 949, DateTimeKind.Utc).AddTicks(2911), new DateTime(2019, 4, 17, 8, 49, 27, 949, DateTimeKind.Utc).AddTicks(2911) });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 4,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 4, 17, 8, 49, 27, 949, DateTimeKind.Utc).AddTicks(2911), new DateTime(2019, 4, 17, 8, 49, 27, 949, DateTimeKind.Utc).AddTicks(2911) });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 5,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 4, 17, 8, 49, 27, 949, DateTimeKind.Utc).AddTicks(2911), new DateTime(2019, 4, 17, 8, 49, 27, 949, DateTimeKind.Utc).AddTicks(2911) });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 6,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 4, 17, 8, 49, 27, 949, DateTimeKind.Utc).AddTicks(2911), new DateTime(2019, 4, 17, 8, 49, 27, 949, DateTimeKind.Utc).AddTicks(2911) });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 7,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 4, 17, 8, 49, 27, 949, DateTimeKind.Utc).AddTicks(2911), new DateTime(2019, 4, 17, 8, 49, 27, 949, DateTimeKind.Utc).AddTicks(2911) });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 8,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 4, 17, 8, 49, 27, 949, DateTimeKind.Utc).AddTicks(2911), new DateTime(2019, 4, 17, 8, 49, 27, 949, DateTimeKind.Utc).AddTicks(2911) });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 9,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 4, 17, 8, 49, 27, 949, DateTimeKind.Utc).AddTicks(2911), new DateTime(2019, 4, 17, 8, 49, 27, 949, DateTimeKind.Utc).AddTicks(2911) });

            migrationBuilder.UpdateData(
                table: "tbl_cities",
                keyColumn: "cln_city_id",
                keyValue: 1,
                columns: new[] { "cln_city_created", "cln_city_updated" },
                values: new object[] { new DateTime(2019, 4, 17, 8, 49, 27, 949, DateTimeKind.Utc).AddTicks(2911), new DateTime(2019, 4, 17, 8, 49, 27, 949, DateTimeKind.Utc).AddTicks(2911) });

            migrationBuilder.UpdateData(
                table: "tbl_cities",
                keyColumn: "cln_city_id",
                keyValue: 2,
                columns: new[] { "cln_city_created", "cln_city_updated" },
                values: new object[] { new DateTime(2019, 4, 17, 8, 49, 27, 949, DateTimeKind.Utc).AddTicks(2911), new DateTime(2019, 4, 17, 8, 49, 27, 949, DateTimeKind.Utc).AddTicks(2911) });

            migrationBuilder.UpdateData(
                table: "tbl_cities",
                keyColumn: "cln_city_id",
                keyValue: 3,
                columns: new[] { "cln_city_created", "cln_city_updated" },
                values: new object[] { new DateTime(2019, 4, 17, 8, 49, 27, 949, DateTimeKind.Utc).AddTicks(2911), new DateTime(2019, 4, 17, 8, 49, 27, 949, DateTimeKind.Utc).AddTicks(2911) });

            migrationBuilder.UpdateData(
                table: "tbl_clients",
                keyColumn: "ClientId",
                keyValue: 1,
                columns: new[] { "cln_client_created", "cln_client_updated" },
                values: new object[] { new DateTime(2019, 4, 17, 8, 49, 27, 949, DateTimeKind.Utc).AddTicks(2911), new DateTime(2019, 4, 17, 8, 49, 27, 949, DateTimeKind.Utc).AddTicks(2911) });

            migrationBuilder.UpdateData(
                table: "tbl_countries",
                keyColumn: "cln_country_id",
                keyValue: 1,
                columns: new[] { "cln_country_created", "cln_country_updated" },
                values: new object[] { new DateTime(2019, 4, 17, 8, 49, 27, 949, DateTimeKind.Utc).AddTicks(2911), new DateTime(2019, 4, 17, 8, 49, 27, 949, DateTimeKind.Utc).AddTicks(2911) });

            migrationBuilder.UpdateData(
                table: "tbl_countries",
                keyColumn: "cln_country_id",
                keyValue: 2,
                columns: new[] { "cln_country_created", "cln_country_updated" },
                values: new object[] { new DateTime(2019, 4, 17, 8, 49, 27, 949, DateTimeKind.Utc).AddTicks(2911), new DateTime(2019, 4, 17, 8, 49, 27, 949, DateTimeKind.Utc).AddTicks(2911) });

            migrationBuilder.UpdateData(
                table: "tbl_countries",
                keyColumn: "cln_country_id",
                keyValue: 3,
                columns: new[] { "cln_country_created", "cln_country_updated" },
                values: new object[] { new DateTime(2019, 4, 17, 8, 49, 27, 949, DateTimeKind.Utc).AddTicks(2911), new DateTime(2019, 4, 17, 8, 49, 27, 949, DateTimeKind.Utc).AddTicks(2911) });

            migrationBuilder.UpdateData(
                table: "tbl_flights",
                keyColumn: "cln_flight_id",
                keyValue: 1,
                columns: new[] { "cln_flight_arrive_time", "cln_flight_departure_time" },
                values: new object[] { new DateTime(2019, 4, 17, 15, 49, 27, 949, DateTimeKind.Utc).AddTicks(2911), new DateTime(2019, 4, 17, 8, 49, 27, 949, DateTimeKind.Utc).AddTicks(2911) });

            migrationBuilder.UpdateData(
                table: "tbl_flights",
                keyColumn: "cln_flight_id",
                keyValue: 2,
                columns: new[] { "cln_flight_arrive_time", "cln_flight_departure_time" },
                values: new object[] { new DateTime(2019, 4, 17, 10, 49, 27, 949, DateTimeKind.Utc).AddTicks(2911), new DateTime(2019, 4, 17, 8, 49, 27, 949, DateTimeKind.Utc).AddTicks(2911) });

            migrationBuilder.UpdateData(
                table: "tbl_flights",
                keyColumn: "cln_flight_id",
                keyValue: 3,
                columns: new[] { "cln_flight_arrive_time", "cln_flight_departure_time" },
                values: new object[] { new DateTime(2019, 4, 17, 14, 49, 27, 949, DateTimeKind.Utc).AddTicks(2911), new DateTime(2019, 4, 17, 8, 49, 27, 949, DateTimeKind.Utc).AddTicks(2911) });

            migrationBuilder.UpdateData(
                table: "tbl_tickets",
                keyColumn: "cln_ticket_id",
                keyValue: 1,
                column: "cln_ticket_purchase_time",
                value: new DateTime(2019, 4, 14, 8, 49, 27, 949, DateTimeKind.Utc).AddTicks(2911));

            migrationBuilder.UpdateData(
                table: "tbl_tickets",
                keyColumn: "cln_ticket_id",
                keyValue: 2,
                column: "cln_ticket_purchase_time",
                value: new DateTime(2019, 4, 13, 8, 49, 27, 949, DateTimeKind.Utc).AddTicks(2911));

            migrationBuilder.UpdateData(
                table: "tbl_tickets",
                keyColumn: "cln_ticket_id",
                keyValue: 3,
                column: "cln_ticket_purchase_time",
                value: new DateTime(2019, 4, 15, 8, 49, 27, 949, DateTimeKind.Utc).AddTicks(2911));
        }
    }
}
