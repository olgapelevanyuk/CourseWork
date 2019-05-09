using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OlympicFlights.DataAccess.Migrations
{
    public partial class FixCLientAndAppUserRelationConflict : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_clients_ApplicationUser_cln_client_user_id",
                table: "tbl_clients");

            migrationBuilder.DropTable(
                name: "ApplicationUser");

            migrationBuilder.DropIndex(
                name: "IX_tbl_clients_cln_client_user_id",
                table: "tbl_clients");

            migrationBuilder.AlterColumn<string>(
                name: "cln_client_user_id",
                table: "tbl_clients",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "cln_client_user_id",
                table: "tbl_clients",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "ApplicationUser",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    NormalizedEmail = table.Column<string>(nullable: true),
                    NormalizedUserName = table.Column<string>(nullable: true),
                    PasswordHash = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    SecurityStamp = table.Column<string>(nullable: true),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    UserName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUser", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 1,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 4, 18, 21, 54, 6, 937, DateTimeKind.Utc).AddTicks(4976), new DateTime(2019, 4, 18, 21, 54, 6, 937, DateTimeKind.Utc).AddTicks(4976) });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 2,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 4, 18, 21, 54, 6, 937, DateTimeKind.Utc).AddTicks(4976), new DateTime(2019, 4, 18, 21, 54, 6, 937, DateTimeKind.Utc).AddTicks(4976) });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 3,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 4, 18, 21, 54, 6, 937, DateTimeKind.Utc).AddTicks(4976), new DateTime(2019, 4, 18, 21, 54, 6, 937, DateTimeKind.Utc).AddTicks(4976) });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 4,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 4, 18, 21, 54, 6, 937, DateTimeKind.Utc).AddTicks(4976), new DateTime(2019, 4, 18, 21, 54, 6, 937, DateTimeKind.Utc).AddTicks(4976) });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 5,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 4, 18, 21, 54, 6, 937, DateTimeKind.Utc).AddTicks(4976), new DateTime(2019, 4, 18, 21, 54, 6, 937, DateTimeKind.Utc).AddTicks(4976) });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 6,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 4, 18, 21, 54, 6, 937, DateTimeKind.Utc).AddTicks(4976), new DateTime(2019, 4, 18, 21, 54, 6, 937, DateTimeKind.Utc).AddTicks(4976) });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 7,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 4, 18, 21, 54, 6, 937, DateTimeKind.Utc).AddTicks(4976), new DateTime(2019, 4, 18, 21, 54, 6, 937, DateTimeKind.Utc).AddTicks(4976) });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 8,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 4, 18, 21, 54, 6, 937, DateTimeKind.Utc).AddTicks(4976), new DateTime(2019, 4, 18, 21, 54, 6, 937, DateTimeKind.Utc).AddTicks(4976) });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 9,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 4, 18, 21, 54, 6, 937, DateTimeKind.Utc).AddTicks(4976), new DateTime(2019, 4, 18, 21, 54, 6, 937, DateTimeKind.Utc).AddTicks(4976) });

            migrationBuilder.UpdateData(
                table: "tbl_cities",
                keyColumn: "cln_city_id",
                keyValue: 1,
                columns: new[] { "cln_city_created", "cln_city_updated" },
                values: new object[] { new DateTime(2019, 4, 18, 21, 54, 6, 937, DateTimeKind.Utc).AddTicks(4976), new DateTime(2019, 4, 18, 21, 54, 6, 937, DateTimeKind.Utc).AddTicks(4976) });

            migrationBuilder.UpdateData(
                table: "tbl_cities",
                keyColumn: "cln_city_id",
                keyValue: 2,
                columns: new[] { "cln_city_created", "cln_city_updated" },
                values: new object[] { new DateTime(2019, 4, 18, 21, 54, 6, 937, DateTimeKind.Utc).AddTicks(4976), new DateTime(2019, 4, 18, 21, 54, 6, 937, DateTimeKind.Utc).AddTicks(4976) });

            migrationBuilder.UpdateData(
                table: "tbl_cities",
                keyColumn: "cln_city_id",
                keyValue: 3,
                columns: new[] { "cln_city_created", "cln_city_updated" },
                values: new object[] { new DateTime(2019, 4, 18, 21, 54, 6, 937, DateTimeKind.Utc).AddTicks(4976), new DateTime(2019, 4, 18, 21, 54, 6, 937, DateTimeKind.Utc).AddTicks(4976) });

            migrationBuilder.UpdateData(
                table: "tbl_countries",
                keyColumn: "cln_country_id",
                keyValue: 1,
                columns: new[] { "cln_country_created", "cln_country_updated" },
                values: new object[] { new DateTime(2019, 4, 18, 21, 54, 6, 937, DateTimeKind.Utc).AddTicks(4976), new DateTime(2019, 4, 18, 21, 54, 6, 937, DateTimeKind.Utc).AddTicks(4976) });

            migrationBuilder.UpdateData(
                table: "tbl_countries",
                keyColumn: "cln_country_id",
                keyValue: 2,
                columns: new[] { "cln_country_created", "cln_country_updated" },
                values: new object[] { new DateTime(2019, 4, 18, 21, 54, 6, 937, DateTimeKind.Utc).AddTicks(4976), new DateTime(2019, 4, 18, 21, 54, 6, 937, DateTimeKind.Utc).AddTicks(4976) });

            migrationBuilder.UpdateData(
                table: "tbl_countries",
                keyColumn: "cln_country_id",
                keyValue: 3,
                columns: new[] { "cln_country_created", "cln_country_updated" },
                values: new object[] { new DateTime(2019, 4, 18, 21, 54, 6, 937, DateTimeKind.Utc).AddTicks(4976), new DateTime(2019, 4, 18, 21, 54, 6, 937, DateTimeKind.Utc).AddTicks(4976) });

            migrationBuilder.UpdateData(
                table: "tbl_flights",
                keyColumn: "cln_flight_id",
                keyValue: 1,
                columns: new[] { "cln_flight_arrive_time", "cln_flight_departure_time" },
                values: new object[] { new DateTime(2019, 4, 19, 4, 54, 6, 937, DateTimeKind.Utc).AddTicks(4976), new DateTime(2019, 4, 18, 21, 54, 6, 937, DateTimeKind.Utc).AddTicks(4976) });

            migrationBuilder.UpdateData(
                table: "tbl_flights",
                keyColumn: "cln_flight_id",
                keyValue: 2,
                columns: new[] { "cln_flight_arrive_time", "cln_flight_departure_time" },
                values: new object[] { new DateTime(2019, 4, 18, 23, 54, 6, 937, DateTimeKind.Utc).AddTicks(4976), new DateTime(2019, 4, 18, 21, 54, 6, 937, DateTimeKind.Utc).AddTicks(4976) });

            migrationBuilder.UpdateData(
                table: "tbl_flights",
                keyColumn: "cln_flight_id",
                keyValue: 3,
                columns: new[] { "cln_flight_arrive_time", "cln_flight_departure_time" },
                values: new object[] { new DateTime(2019, 4, 19, 3, 54, 6, 937, DateTimeKind.Utc).AddTicks(4976), new DateTime(2019, 4, 18, 21, 54, 6, 937, DateTimeKind.Utc).AddTicks(4976) });

            migrationBuilder.UpdateData(
                table: "tbl_tickets",
                keyColumn: "cln_ticket_id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2019, 4, 18, 21, 54, 6, 937, DateTimeKind.Utc).AddTicks(4976));

            migrationBuilder.UpdateData(
                table: "tbl_tickets",
                keyColumn: "cln_ticket_id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2019, 4, 18, 21, 54, 6, 937, DateTimeKind.Utc).AddTicks(4976));

            migrationBuilder.UpdateData(
                table: "tbl_tickets",
                keyColumn: "cln_ticket_id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2019, 4, 18, 21, 54, 6, 937, DateTimeKind.Utc).AddTicks(4976));

            migrationBuilder.CreateIndex(
                name: "IX_tbl_clients_cln_client_user_id",
                table: "tbl_clients",
                column: "cln_client_user_id");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_clients_ApplicationUser_cln_client_user_id",
                table: "tbl_clients",
                column: "cln_client_user_id",
                principalTable: "ApplicationUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
