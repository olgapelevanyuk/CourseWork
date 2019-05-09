using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OlympicFlights.DataAccess.Migrations
{
    public partial class FixedRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 1,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 4, 17, 23, 42, 29, 649, DateTimeKind.Utc).AddTicks(6516), new DateTime(2019, 4, 17, 23, 42, 29, 649, DateTimeKind.Utc).AddTicks(6516) });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 2,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 4, 17, 23, 42, 29, 649, DateTimeKind.Utc).AddTicks(6516), new DateTime(2019, 4, 17, 23, 42, 29, 649, DateTimeKind.Utc).AddTicks(6516) });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 3,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 4, 17, 23, 42, 29, 649, DateTimeKind.Utc).AddTicks(6516), new DateTime(2019, 4, 17, 23, 42, 29, 649, DateTimeKind.Utc).AddTicks(6516) });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 4,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 4, 17, 23, 42, 29, 649, DateTimeKind.Utc).AddTicks(6516), new DateTime(2019, 4, 17, 23, 42, 29, 649, DateTimeKind.Utc).AddTicks(6516) });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 5,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 4, 17, 23, 42, 29, 649, DateTimeKind.Utc).AddTicks(6516), new DateTime(2019, 4, 17, 23, 42, 29, 649, DateTimeKind.Utc).AddTicks(6516) });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 6,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 4, 17, 23, 42, 29, 649, DateTimeKind.Utc).AddTicks(6516), new DateTime(2019, 4, 17, 23, 42, 29, 649, DateTimeKind.Utc).AddTicks(6516) });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 7,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 4, 17, 23, 42, 29, 649, DateTimeKind.Utc).AddTicks(6516), new DateTime(2019, 4, 17, 23, 42, 29, 649, DateTimeKind.Utc).AddTicks(6516) });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 8,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 4, 17, 23, 42, 29, 649, DateTimeKind.Utc).AddTicks(6516), new DateTime(2019, 4, 17, 23, 42, 29, 649, DateTimeKind.Utc).AddTicks(6516) });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 9,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 4, 17, 23, 42, 29, 649, DateTimeKind.Utc).AddTicks(6516), new DateTime(2019, 4, 17, 23, 42, 29, 649, DateTimeKind.Utc).AddTicks(6516) });

            migrationBuilder.UpdateData(
                table: "tbl_cities",
                keyColumn: "cln_city_id",
                keyValue: 1,
                columns: new[] { "cln_city_created", "cln_city_updated" },
                values: new object[] { new DateTime(2019, 4, 17, 23, 42, 29, 649, DateTimeKind.Utc).AddTicks(6516), new DateTime(2019, 4, 17, 23, 42, 29, 649, DateTimeKind.Utc).AddTicks(6516) });

            migrationBuilder.UpdateData(
                table: "tbl_cities",
                keyColumn: "cln_city_id",
                keyValue: 2,
                columns: new[] { "cln_city_created", "cln_city_updated" },
                values: new object[] { new DateTime(2019, 4, 17, 23, 42, 29, 649, DateTimeKind.Utc).AddTicks(6516), new DateTime(2019, 4, 17, 23, 42, 29, 649, DateTimeKind.Utc).AddTicks(6516) });

            migrationBuilder.UpdateData(
                table: "tbl_cities",
                keyColumn: "cln_city_id",
                keyValue: 3,
                columns: new[] { "cln_city_created", "cln_city_updated" },
                values: new object[] { new DateTime(2019, 4, 17, 23, 42, 29, 649, DateTimeKind.Utc).AddTicks(6516), new DateTime(2019, 4, 17, 23, 42, 29, 649, DateTimeKind.Utc).AddTicks(6516) });

            migrationBuilder.UpdateData(
                table: "tbl_countries",
                keyColumn: "cln_country_id",
                keyValue: 1,
                columns: new[] { "cln_country_created", "cln_country_updated" },
                values: new object[] { new DateTime(2019, 4, 17, 23, 42, 29, 649, DateTimeKind.Utc).AddTicks(6516), new DateTime(2019, 4, 17, 23, 42, 29, 649, DateTimeKind.Utc).AddTicks(6516) });

            migrationBuilder.UpdateData(
                table: "tbl_countries",
                keyColumn: "cln_country_id",
                keyValue: 2,
                columns: new[] { "cln_country_created", "cln_country_updated" },
                values: new object[] { new DateTime(2019, 4, 17, 23, 42, 29, 649, DateTimeKind.Utc).AddTicks(6516), new DateTime(2019, 4, 17, 23, 42, 29, 649, DateTimeKind.Utc).AddTicks(6516) });

            migrationBuilder.UpdateData(
                table: "tbl_countries",
                keyColumn: "cln_country_id",
                keyValue: 3,
                columns: new[] { "cln_country_created", "cln_country_updated" },
                values: new object[] { new DateTime(2019, 4, 17, 23, 42, 29, 649, DateTimeKind.Utc).AddTicks(6516), new DateTime(2019, 4, 17, 23, 42, 29, 649, DateTimeKind.Utc).AddTicks(6516) });

            migrationBuilder.UpdateData(
                table: "tbl_flights",
                keyColumn: "cln_flight_id",
                keyValue: 1,
                columns: new[] { "cln_flight_arrive_time", "cln_flight_departure_time" },
                values: new object[] { new DateTime(2019, 4, 18, 6, 42, 29, 649, DateTimeKind.Utc).AddTicks(6516), new DateTime(2019, 4, 17, 23, 42, 29, 649, DateTimeKind.Utc).AddTicks(6516) });

            migrationBuilder.UpdateData(
                table: "tbl_flights",
                keyColumn: "cln_flight_id",
                keyValue: 2,
                columns: new[] { "cln_flight_arrive_time", "cln_flight_departure_time" },
                values: new object[] { new DateTime(2019, 4, 18, 1, 42, 29, 649, DateTimeKind.Utc).AddTicks(6516), new DateTime(2019, 4, 17, 23, 42, 29, 649, DateTimeKind.Utc).AddTicks(6516) });

            migrationBuilder.UpdateData(
                table: "tbl_flights",
                keyColumn: "cln_flight_id",
                keyValue: 3,
                columns: new[] { "cln_flight_arrive_time", "cln_flight_departure_time" },
                values: new object[] { new DateTime(2019, 4, 18, 5, 42, 29, 649, DateTimeKind.Utc).AddTicks(6516), new DateTime(2019, 4, 17, 23, 42, 29, 649, DateTimeKind.Utc).AddTicks(6516) });

            migrationBuilder.UpdateData(
                table: "tbl_tickets",
                keyColumn: "cln_ticket_id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2019, 4, 17, 23, 42, 29, 649, DateTimeKind.Utc).AddTicks(6516));

            migrationBuilder.UpdateData(
                table: "tbl_tickets",
                keyColumn: "cln_ticket_id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2019, 4, 17, 23, 42, 29, 649, DateTimeKind.Utc).AddTicks(6516));

            migrationBuilder.UpdateData(
                table: "tbl_tickets",
                keyColumn: "cln_ticket_id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2019, 4, 17, 23, 42, 29, 649, DateTimeKind.Utc).AddTicks(6516));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 1,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 4, 17, 23, 9, 19, 194, DateTimeKind.Utc).AddTicks(6549), new DateTime(2019, 4, 17, 23, 9, 19, 194, DateTimeKind.Utc).AddTicks(6549) });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 2,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 4, 17, 23, 9, 19, 194, DateTimeKind.Utc).AddTicks(6549), new DateTime(2019, 4, 17, 23, 9, 19, 194, DateTimeKind.Utc).AddTicks(6549) });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 3,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 4, 17, 23, 9, 19, 194, DateTimeKind.Utc).AddTicks(6549), new DateTime(2019, 4, 17, 23, 9, 19, 194, DateTimeKind.Utc).AddTicks(6549) });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 4,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 4, 17, 23, 9, 19, 194, DateTimeKind.Utc).AddTicks(6549), new DateTime(2019, 4, 17, 23, 9, 19, 194, DateTimeKind.Utc).AddTicks(6549) });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 5,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 4, 17, 23, 9, 19, 194, DateTimeKind.Utc).AddTicks(6549), new DateTime(2019, 4, 17, 23, 9, 19, 194, DateTimeKind.Utc).AddTicks(6549) });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 6,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 4, 17, 23, 9, 19, 194, DateTimeKind.Utc).AddTicks(6549), new DateTime(2019, 4, 17, 23, 9, 19, 194, DateTimeKind.Utc).AddTicks(6549) });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 7,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 4, 17, 23, 9, 19, 194, DateTimeKind.Utc).AddTicks(6549), new DateTime(2019, 4, 17, 23, 9, 19, 194, DateTimeKind.Utc).AddTicks(6549) });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 8,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 4, 17, 23, 9, 19, 194, DateTimeKind.Utc).AddTicks(6549), new DateTime(2019, 4, 17, 23, 9, 19, 194, DateTimeKind.Utc).AddTicks(6549) });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 9,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 4, 17, 23, 9, 19, 194, DateTimeKind.Utc).AddTicks(6549), new DateTime(2019, 4, 17, 23, 9, 19, 194, DateTimeKind.Utc).AddTicks(6549) });

            migrationBuilder.UpdateData(
                table: "tbl_cities",
                keyColumn: "cln_city_id",
                keyValue: 1,
                columns: new[] { "cln_city_created", "cln_city_updated" },
                values: new object[] { new DateTime(2019, 4, 17, 23, 9, 19, 194, DateTimeKind.Utc).AddTicks(6549), new DateTime(2019, 4, 17, 23, 9, 19, 194, DateTimeKind.Utc).AddTicks(6549) });

            migrationBuilder.UpdateData(
                table: "tbl_cities",
                keyColumn: "cln_city_id",
                keyValue: 2,
                columns: new[] { "cln_city_created", "cln_city_updated" },
                values: new object[] { new DateTime(2019, 4, 17, 23, 9, 19, 194, DateTimeKind.Utc).AddTicks(6549), new DateTime(2019, 4, 17, 23, 9, 19, 194, DateTimeKind.Utc).AddTicks(6549) });

            migrationBuilder.UpdateData(
                table: "tbl_cities",
                keyColumn: "cln_city_id",
                keyValue: 3,
                columns: new[] { "cln_city_created", "cln_city_updated" },
                values: new object[] { new DateTime(2019, 4, 17, 23, 9, 19, 194, DateTimeKind.Utc).AddTicks(6549), new DateTime(2019, 4, 17, 23, 9, 19, 194, DateTimeKind.Utc).AddTicks(6549) });

            migrationBuilder.UpdateData(
                table: "tbl_countries",
                keyColumn: "cln_country_id",
                keyValue: 1,
                columns: new[] { "cln_country_created", "cln_country_updated" },
                values: new object[] { new DateTime(2019, 4, 17, 23, 9, 19, 194, DateTimeKind.Utc).AddTicks(6549), new DateTime(2019, 4, 17, 23, 9, 19, 194, DateTimeKind.Utc).AddTicks(6549) });

            migrationBuilder.UpdateData(
                table: "tbl_countries",
                keyColumn: "cln_country_id",
                keyValue: 2,
                columns: new[] { "cln_country_created", "cln_country_updated" },
                values: new object[] { new DateTime(2019, 4, 17, 23, 9, 19, 194, DateTimeKind.Utc).AddTicks(6549), new DateTime(2019, 4, 17, 23, 9, 19, 194, DateTimeKind.Utc).AddTicks(6549) });

            migrationBuilder.UpdateData(
                table: "tbl_countries",
                keyColumn: "cln_country_id",
                keyValue: 3,
                columns: new[] { "cln_country_created", "cln_country_updated" },
                values: new object[] { new DateTime(2019, 4, 17, 23, 9, 19, 194, DateTimeKind.Utc).AddTicks(6549), new DateTime(2019, 4, 17, 23, 9, 19, 194, DateTimeKind.Utc).AddTicks(6549) });

            migrationBuilder.UpdateData(
                table: "tbl_flights",
                keyColumn: "cln_flight_id",
                keyValue: 1,
                columns: new[] { "cln_flight_arrive_time", "cln_flight_departure_time" },
                values: new object[] { new DateTime(2019, 4, 18, 6, 9, 19, 194, DateTimeKind.Utc).AddTicks(6549), new DateTime(2019, 4, 17, 23, 9, 19, 194, DateTimeKind.Utc).AddTicks(6549) });

            migrationBuilder.UpdateData(
                table: "tbl_flights",
                keyColumn: "cln_flight_id",
                keyValue: 2,
                columns: new[] { "cln_flight_arrive_time", "cln_flight_departure_time" },
                values: new object[] { new DateTime(2019, 4, 18, 1, 9, 19, 194, DateTimeKind.Utc).AddTicks(6549), new DateTime(2019, 4, 17, 23, 9, 19, 194, DateTimeKind.Utc).AddTicks(6549) });

            migrationBuilder.UpdateData(
                table: "tbl_flights",
                keyColumn: "cln_flight_id",
                keyValue: 3,
                columns: new[] { "cln_flight_arrive_time", "cln_flight_departure_time" },
                values: new object[] { new DateTime(2019, 4, 18, 5, 9, 19, 194, DateTimeKind.Utc).AddTicks(6549), new DateTime(2019, 4, 17, 23, 9, 19, 194, DateTimeKind.Utc).AddTicks(6549) });

            migrationBuilder.UpdateData(
                table: "tbl_tickets",
                keyColumn: "cln_ticket_id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2019, 4, 17, 23, 9, 19, 194, DateTimeKind.Utc).AddTicks(6549));

            migrationBuilder.UpdateData(
                table: "tbl_tickets",
                keyColumn: "cln_ticket_id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2019, 4, 17, 23, 9, 19, 194, DateTimeKind.Utc).AddTicks(6549));

            migrationBuilder.UpdateData(
                table: "tbl_tickets",
                keyColumn: "cln_ticket_id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2019, 4, 17, 23, 9, 19, 194, DateTimeKind.Utc).AddTicks(6549));
        }
    }
}
