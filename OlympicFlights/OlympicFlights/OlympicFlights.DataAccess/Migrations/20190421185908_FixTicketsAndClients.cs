using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OlympicFlights.DataAccess.Migrations
{
    public partial class FixTicketsAndClients : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Created",
                table: "tbl_tickets",
                newName: "cln_ticket_created");

            migrationBuilder.RenameColumn(
                name: "ClientId",
                table: "tbl_clients",
                newName: "cln_client_id");

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 1,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 4, 21, 18, 59, 6, 954, DateTimeKind.Utc).AddTicks(9217), new DateTime(2019, 4, 21, 18, 59, 6, 954, DateTimeKind.Utc).AddTicks(9217) });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 2,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 4, 21, 18, 59, 6, 954, DateTimeKind.Utc).AddTicks(9217), new DateTime(2019, 4, 21, 18, 59, 6, 954, DateTimeKind.Utc).AddTicks(9217) });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 3,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 4, 21, 18, 59, 6, 954, DateTimeKind.Utc).AddTicks(9217), new DateTime(2019, 4, 21, 18, 59, 6, 954, DateTimeKind.Utc).AddTicks(9217) });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 4,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 4, 21, 18, 59, 6, 954, DateTimeKind.Utc).AddTicks(9217), new DateTime(2019, 4, 21, 18, 59, 6, 954, DateTimeKind.Utc).AddTicks(9217) });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 5,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 4, 21, 18, 59, 6, 954, DateTimeKind.Utc).AddTicks(9217), new DateTime(2019, 4, 21, 18, 59, 6, 954, DateTimeKind.Utc).AddTicks(9217) });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 6,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 4, 21, 18, 59, 6, 954, DateTimeKind.Utc).AddTicks(9217), new DateTime(2019, 4, 21, 18, 59, 6, 954, DateTimeKind.Utc).AddTicks(9217) });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 7,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 4, 21, 18, 59, 6, 954, DateTimeKind.Utc).AddTicks(9217), new DateTime(2019, 4, 21, 18, 59, 6, 954, DateTimeKind.Utc).AddTicks(9217) });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 8,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 4, 21, 18, 59, 6, 954, DateTimeKind.Utc).AddTicks(9217), new DateTime(2019, 4, 21, 18, 59, 6, 954, DateTimeKind.Utc).AddTicks(9217) });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 9,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 4, 21, 18, 59, 6, 954, DateTimeKind.Utc).AddTicks(9217), new DateTime(2019, 4, 21, 18, 59, 6, 954, DateTimeKind.Utc).AddTicks(9217) });

            migrationBuilder.UpdateData(
                table: "tbl_cities",
                keyColumn: "cln_city_id",
                keyValue: 1,
                columns: new[] { "cln_city_created", "cln_city_updated" },
                values: new object[] { new DateTime(2019, 4, 21, 18, 59, 6, 954, DateTimeKind.Utc).AddTicks(9217), new DateTime(2019, 4, 21, 18, 59, 6, 954, DateTimeKind.Utc).AddTicks(9217) });

            migrationBuilder.UpdateData(
                table: "tbl_cities",
                keyColumn: "cln_city_id",
                keyValue: 2,
                columns: new[] { "cln_city_created", "cln_city_updated" },
                values: new object[] { new DateTime(2019, 4, 21, 18, 59, 6, 954, DateTimeKind.Utc).AddTicks(9217), new DateTime(2019, 4, 21, 18, 59, 6, 954, DateTimeKind.Utc).AddTicks(9217) });

            migrationBuilder.UpdateData(
                table: "tbl_cities",
                keyColumn: "cln_city_id",
                keyValue: 3,
                columns: new[] { "cln_city_created", "cln_city_updated" },
                values: new object[] { new DateTime(2019, 4, 21, 18, 59, 6, 954, DateTimeKind.Utc).AddTicks(9217), new DateTime(2019, 4, 21, 18, 59, 6, 954, DateTimeKind.Utc).AddTicks(9217) });

            migrationBuilder.InsertData(
                table: "tbl_clients",
                columns: new[] { "cln_client_id", "cln_client_address", "cln_client_first_name", "cln_client_last_name", "cln_client_created", "cln_client_updated", "cln_client_user_id" },
                values: new object[] { 1, "TestAddress", "TestFirstName", "TestLastName", new DateTime(2019, 4, 21, 18, 59, 6, 954, DateTimeKind.Utc).AddTicks(9217), new DateTime(2019, 4, 21, 18, 59, 6, 954, DateTimeKind.Utc).AddTicks(9217), "b53d6f8f-085b-4953-9394-759ce406c99d" });

            migrationBuilder.UpdateData(
                table: "tbl_countries",
                keyColumn: "cln_country_id",
                keyValue: 1,
                columns: new[] { "cln_country_created", "cln_country_updated" },
                values: new object[] { new DateTime(2019, 4, 21, 18, 59, 6, 954, DateTimeKind.Utc).AddTicks(9217), new DateTime(2019, 4, 21, 18, 59, 6, 954, DateTimeKind.Utc).AddTicks(9217) });

            migrationBuilder.UpdateData(
                table: "tbl_countries",
                keyColumn: "cln_country_id",
                keyValue: 2,
                columns: new[] { "cln_country_created", "cln_country_updated" },
                values: new object[] { new DateTime(2019, 4, 21, 18, 59, 6, 954, DateTimeKind.Utc).AddTicks(9217), new DateTime(2019, 4, 21, 18, 59, 6, 954, DateTimeKind.Utc).AddTicks(9217) });

            migrationBuilder.UpdateData(
                table: "tbl_countries",
                keyColumn: "cln_country_id",
                keyValue: 3,
                columns: new[] { "cln_country_created", "cln_country_updated" },
                values: new object[] { new DateTime(2019, 4, 21, 18, 59, 6, 954, DateTimeKind.Utc).AddTicks(9217), new DateTime(2019, 4, 21, 18, 59, 6, 954, DateTimeKind.Utc).AddTicks(9217) });

            migrationBuilder.UpdateData(
                table: "tbl_flights",
                keyColumn: "cln_flight_id",
                keyValue: 1,
                columns: new[] { "cln_flight_arrive_time", "cln_flight_departure_time" },
                values: new object[] { new DateTime(2019, 4, 22, 1, 59, 6, 954, DateTimeKind.Utc).AddTicks(9217), new DateTime(2019, 4, 21, 18, 59, 6, 954, DateTimeKind.Utc).AddTicks(9217) });

            migrationBuilder.UpdateData(
                table: "tbl_flights",
                keyColumn: "cln_flight_id",
                keyValue: 2,
                columns: new[] { "cln_flight_arrive_time", "cln_flight_departure_time" },
                values: new object[] { new DateTime(2019, 4, 21, 20, 59, 6, 954, DateTimeKind.Utc).AddTicks(9217), new DateTime(2019, 4, 21, 18, 59, 6, 954, DateTimeKind.Utc).AddTicks(9217) });

            migrationBuilder.UpdateData(
                table: "tbl_flights",
                keyColumn: "cln_flight_id",
                keyValue: 3,
                columns: new[] { "cln_flight_arrive_time", "cln_flight_departure_time" },
                values: new object[] { new DateTime(2019, 4, 22, 0, 59, 6, 954, DateTimeKind.Utc).AddTicks(9217), new DateTime(2019, 4, 21, 18, 59, 6, 954, DateTimeKind.Utc).AddTicks(9217) });

            migrationBuilder.UpdateData(
                table: "tbl_tickets",
                keyColumn: "cln_ticket_id",
                keyValue: 1,
                column: "cln_ticket_created",
                value: new DateTime(2019, 4, 21, 18, 59, 6, 954, DateTimeKind.Utc).AddTicks(9217));

            migrationBuilder.UpdateData(
                table: "tbl_tickets",
                keyColumn: "cln_ticket_id",
                keyValue: 2,
                column: "cln_ticket_created",
                value: new DateTime(2019, 4, 21, 18, 59, 6, 954, DateTimeKind.Utc).AddTicks(9217));

            migrationBuilder.UpdateData(
                table: "tbl_tickets",
                keyColumn: "cln_ticket_id",
                keyValue: 3,
                column: "cln_ticket_created",
                value: new DateTime(2019, 4, 21, 18, 59, 6, 954, DateTimeKind.Utc).AddTicks(9217));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "tbl_clients",
                keyColumn: "cln_client_id",
                keyValue: 1);

            migrationBuilder.RenameColumn(
                name: "cln_ticket_created",
                table: "tbl_tickets",
                newName: "Created");

            migrationBuilder.RenameColumn(
                name: "cln_client_id",
                table: "tbl_clients",
                newName: "ClientId");

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 1,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 4, 18, 21, 59, 1, 463, DateTimeKind.Utc).AddTicks(3770), new DateTime(2019, 4, 18, 21, 59, 1, 463, DateTimeKind.Utc).AddTicks(3770) });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 2,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 4, 18, 21, 59, 1, 463, DateTimeKind.Utc).AddTicks(3770), new DateTime(2019, 4, 18, 21, 59, 1, 463, DateTimeKind.Utc).AddTicks(3770) });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 3,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 4, 18, 21, 59, 1, 463, DateTimeKind.Utc).AddTicks(3770), new DateTime(2019, 4, 18, 21, 59, 1, 463, DateTimeKind.Utc).AddTicks(3770) });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 4,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 4, 18, 21, 59, 1, 463, DateTimeKind.Utc).AddTicks(3770), new DateTime(2019, 4, 18, 21, 59, 1, 463, DateTimeKind.Utc).AddTicks(3770) });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 5,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 4, 18, 21, 59, 1, 463, DateTimeKind.Utc).AddTicks(3770), new DateTime(2019, 4, 18, 21, 59, 1, 463, DateTimeKind.Utc).AddTicks(3770) });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 6,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 4, 18, 21, 59, 1, 463, DateTimeKind.Utc).AddTicks(3770), new DateTime(2019, 4, 18, 21, 59, 1, 463, DateTimeKind.Utc).AddTicks(3770) });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 7,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 4, 18, 21, 59, 1, 463, DateTimeKind.Utc).AddTicks(3770), new DateTime(2019, 4, 18, 21, 59, 1, 463, DateTimeKind.Utc).AddTicks(3770) });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 8,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 4, 18, 21, 59, 1, 463, DateTimeKind.Utc).AddTicks(3770), new DateTime(2019, 4, 18, 21, 59, 1, 463, DateTimeKind.Utc).AddTicks(3770) });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 9,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 4, 18, 21, 59, 1, 463, DateTimeKind.Utc).AddTicks(3770), new DateTime(2019, 4, 18, 21, 59, 1, 463, DateTimeKind.Utc).AddTicks(3770) });

            migrationBuilder.UpdateData(
                table: "tbl_cities",
                keyColumn: "cln_city_id",
                keyValue: 1,
                columns: new[] { "cln_city_created", "cln_city_updated" },
                values: new object[] { new DateTime(2019, 4, 18, 21, 59, 1, 463, DateTimeKind.Utc).AddTicks(3770), new DateTime(2019, 4, 18, 21, 59, 1, 463, DateTimeKind.Utc).AddTicks(3770) });

            migrationBuilder.UpdateData(
                table: "tbl_cities",
                keyColumn: "cln_city_id",
                keyValue: 2,
                columns: new[] { "cln_city_created", "cln_city_updated" },
                values: new object[] { new DateTime(2019, 4, 18, 21, 59, 1, 463, DateTimeKind.Utc).AddTicks(3770), new DateTime(2019, 4, 18, 21, 59, 1, 463, DateTimeKind.Utc).AddTicks(3770) });

            migrationBuilder.UpdateData(
                table: "tbl_cities",
                keyColumn: "cln_city_id",
                keyValue: 3,
                columns: new[] { "cln_city_created", "cln_city_updated" },
                values: new object[] { new DateTime(2019, 4, 18, 21, 59, 1, 463, DateTimeKind.Utc).AddTicks(3770), new DateTime(2019, 4, 18, 21, 59, 1, 463, DateTimeKind.Utc).AddTicks(3770) });

            migrationBuilder.UpdateData(
                table: "tbl_countries",
                keyColumn: "cln_country_id",
                keyValue: 1,
                columns: new[] { "cln_country_created", "cln_country_updated" },
                values: new object[] { new DateTime(2019, 4, 18, 21, 59, 1, 463, DateTimeKind.Utc).AddTicks(3770), new DateTime(2019, 4, 18, 21, 59, 1, 463, DateTimeKind.Utc).AddTicks(3770) });

            migrationBuilder.UpdateData(
                table: "tbl_countries",
                keyColumn: "cln_country_id",
                keyValue: 2,
                columns: new[] { "cln_country_created", "cln_country_updated" },
                values: new object[] { new DateTime(2019, 4, 18, 21, 59, 1, 463, DateTimeKind.Utc).AddTicks(3770), new DateTime(2019, 4, 18, 21, 59, 1, 463, DateTimeKind.Utc).AddTicks(3770) });

            migrationBuilder.UpdateData(
                table: "tbl_countries",
                keyColumn: "cln_country_id",
                keyValue: 3,
                columns: new[] { "cln_country_created", "cln_country_updated" },
                values: new object[] { new DateTime(2019, 4, 18, 21, 59, 1, 463, DateTimeKind.Utc).AddTicks(3770), new DateTime(2019, 4, 18, 21, 59, 1, 463, DateTimeKind.Utc).AddTicks(3770) });

            migrationBuilder.UpdateData(
                table: "tbl_flights",
                keyColumn: "cln_flight_id",
                keyValue: 1,
                columns: new[] { "cln_flight_arrive_time", "cln_flight_departure_time" },
                values: new object[] { new DateTime(2019, 4, 19, 4, 59, 1, 463, DateTimeKind.Utc).AddTicks(3770), new DateTime(2019, 4, 18, 21, 59, 1, 463, DateTimeKind.Utc).AddTicks(3770) });

            migrationBuilder.UpdateData(
                table: "tbl_flights",
                keyColumn: "cln_flight_id",
                keyValue: 2,
                columns: new[] { "cln_flight_arrive_time", "cln_flight_departure_time" },
                values: new object[] { new DateTime(2019, 4, 18, 23, 59, 1, 463, DateTimeKind.Utc).AddTicks(3770), new DateTime(2019, 4, 18, 21, 59, 1, 463, DateTimeKind.Utc).AddTicks(3770) });

            migrationBuilder.UpdateData(
                table: "tbl_flights",
                keyColumn: "cln_flight_id",
                keyValue: 3,
                columns: new[] { "cln_flight_arrive_time", "cln_flight_departure_time" },
                values: new object[] { new DateTime(2019, 4, 19, 3, 59, 1, 463, DateTimeKind.Utc).AddTicks(3770), new DateTime(2019, 4, 18, 21, 59, 1, 463, DateTimeKind.Utc).AddTicks(3770) });

            migrationBuilder.UpdateData(
                table: "tbl_tickets",
                keyColumn: "cln_ticket_id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2019, 4, 18, 21, 59, 1, 463, DateTimeKind.Utc).AddTicks(3770));

            migrationBuilder.UpdateData(
                table: "tbl_tickets",
                keyColumn: "cln_ticket_id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2019, 4, 18, 21, 59, 1, 463, DateTimeKind.Utc).AddTicks(3770));

            migrationBuilder.UpdateData(
                table: "tbl_tickets",
                keyColumn: "cln_ticket_id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2019, 4, 18, 21, 59, 1, 463, DateTimeKind.Utc).AddTicks(3770));
        }
    }
}
