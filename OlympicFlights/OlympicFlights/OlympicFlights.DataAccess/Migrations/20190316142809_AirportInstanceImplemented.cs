using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OlympicFlights.DataAccess.Migrations
{
    public partial class AirportInstanceImplemented : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_airports",
                columns: table => new
                {
                    cln_airport_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    cln_airport_name = table.Column<string>(nullable: false),
                    cln_airport_code = table.Column<string>(nullable: false),
                    cln_airport_created = table.Column<DateTime>(nullable: false),
                    cln_airport_updated = table.Column<DateTime>(nullable: false),
                    cln_airport_city_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_airports", x => x.cln_airport_id);
                    table.ForeignKey(
                        name: "FK_tbl_airports_tbl_cities_cln_airport_city_id",
                        column: x => x.cln_airport_city_id,
                        principalTable: "tbl_cities",
                        principalColumn: "cln_city_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "tbl_accounts",
                keyColumn: "cln_account_id",
                keyValue: 1,
                columns: new[] { "cln_account_created", "cln_account_updated" },
                values: new object[] { new DateTime(2019, 3, 16, 14, 28, 6, 750, DateTimeKind.Utc).AddTicks(8114), new DateTime(2019, 3, 16, 14, 28, 6, 750, DateTimeKind.Utc).AddTicks(8114) });

            migrationBuilder.UpdateData(
                table: "tbl_accounts",
                keyColumn: "cln_account_id",
                keyValue: 2,
                columns: new[] { "cln_account_created", "cln_account_updated" },
                values: new object[] { new DateTime(2019, 3, 16, 14, 28, 6, 750, DateTimeKind.Utc).AddTicks(8114), new DateTime(2019, 3, 16, 14, 28, 6, 750, DateTimeKind.Utc).AddTicks(8114) });

            migrationBuilder.InsertData(
                table: "tbl_airports",
                columns: new[] { "cln_airport_id", "cln_airport_code", "cln_airport_name", "cln_airport_city_id", "cln_airport_created", "cln_airport_updated" },
                values: new object[,]
                {
                    { 9, "AGH", "Airport Ghukova", 1, new DateTime(2019, 3, 16, 14, 28, 6, 750, DateTimeKind.Utc).AddTicks(8114), new DateTime(2019, 3, 16, 14, 28, 6, 750, DateTimeKind.Utc).AddTicks(8114) },
                    { 8, "AS", "Airport Sheremetieva", 1, new DateTime(2019, 3, 16, 14, 28, 6, 750, DateTimeKind.Utc).AddTicks(8114), new DateTime(2019, 3, 16, 14, 28, 6, 750, DateTimeKind.Utc).AddTicks(8114) },
                    { 6, "AV", "Airport Vnukova", 1, new DateTime(2019, 3, 16, 14, 28, 6, 750, DateTimeKind.Utc).AddTicks(8114), new DateTime(2019, 3, 16, 14, 28, 6, 750, DateTimeKind.Utc).AddTicks(8114) },
                    { 5, "AM-1", "Airport Minsk - 1", 2, new DateTime(2019, 3, 16, 14, 28, 6, 750, DateTimeKind.Utc).AddTicks(8114), new DateTime(2019, 3, 16, 14, 28, 6, 750, DateTimeKind.Utc).AddTicks(8114) },
                    { 7, "AD", "Airport Domodedova", 1, new DateTime(2019, 3, 16, 14, 28, 6, 750, DateTimeKind.Utc).AddTicks(8114), new DateTime(2019, 3, 16, 14, 28, 6, 750, DateTimeKind.Utc).AddTicks(8114) },
                    { 3, "La-G", "La Guardia", 3, new DateTime(2019, 3, 16, 14, 28, 6, 750, DateTimeKind.Utc).AddTicks(8114), new DateTime(2019, 3, 16, 14, 28, 6, 750, DateTimeKind.Utc).AddTicks(8114) },
                    { 2, "NLIA", "Newark Liberty International Airport", 3, new DateTime(2019, 3, 16, 14, 28, 6, 750, DateTimeKind.Utc).AddTicks(8114), new DateTime(2019, 3, 16, 14, 28, 6, 750, DateTimeKind.Utc).AddTicks(8114) },
                    { 1, "JFK", "Johne's F.Cannady", 3, new DateTime(2019, 3, 16, 14, 28, 6, 750, DateTimeKind.Utc).AddTicks(8114), new DateTime(2019, 3, 16, 14, 28, 6, 750, DateTimeKind.Utc).AddTicks(8114) },
                    { 4, "I-AM", "International Airport Minsk", 2, new DateTime(2019, 3, 16, 14, 28, 6, 750, DateTimeKind.Utc).AddTicks(8114), new DateTime(2019, 3, 16, 14, 28, 6, 750, DateTimeKind.Utc).AddTicks(8114) }
                });

            migrationBuilder.UpdateData(
                table: "tbl_cities",
                keyColumn: "cln_city_id",
                keyValue: 1,
                columns: new[] { "cln_city_created", "cln_city_updated" },
                values: new object[] { new DateTime(2019, 3, 16, 14, 28, 6, 750, DateTimeKind.Utc).AddTicks(8114), new DateTime(2019, 3, 16, 14, 28, 6, 750, DateTimeKind.Utc).AddTicks(8114) });

            migrationBuilder.UpdateData(
                table: "tbl_cities",
                keyColumn: "cln_city_id",
                keyValue: 2,
                columns: new[] { "cln_city_created", "cln_city_updated" },
                values: new object[] { new DateTime(2019, 3, 16, 14, 28, 6, 750, DateTimeKind.Utc).AddTicks(8114), new DateTime(2019, 3, 16, 14, 28, 6, 750, DateTimeKind.Utc).AddTicks(8114) });

            migrationBuilder.UpdateData(
                table: "tbl_cities",
                keyColumn: "cln_city_id",
                keyValue: 3,
                columns: new[] { "cln_city_created", "cln_city_updated" },
                values: new object[] { new DateTime(2019, 3, 16, 14, 28, 6, 750, DateTimeKind.Utc).AddTicks(8114), new DateTime(2019, 3, 16, 14, 28, 6, 750, DateTimeKind.Utc).AddTicks(8114) });

            migrationBuilder.UpdateData(
                table: "tbl_clients",
                keyColumn: "ClientID",
                keyValue: 1,
                columns: new[] { "cln_client_created", "cln_client_updated" },
                values: new object[] { new DateTime(2019, 3, 16, 14, 28, 6, 750, DateTimeKind.Utc).AddTicks(8114), new DateTime(2019, 3, 16, 14, 28, 6, 750, DateTimeKind.Utc).AddTicks(8114) });

            migrationBuilder.UpdateData(
                table: "tbl_countries",
                keyColumn: "cln_country_id",
                keyValue: 1,
                columns: new[] { "cln_country_created", "cln_country_updated" },
                values: new object[] { new DateTime(2019, 3, 16, 14, 28, 6, 750, DateTimeKind.Utc).AddTicks(8114), new DateTime(2019, 3, 16, 14, 28, 6, 750, DateTimeKind.Utc).AddTicks(8114) });

            migrationBuilder.UpdateData(
                table: "tbl_countries",
                keyColumn: "cln_country_id",
                keyValue: 2,
                columns: new[] { "cln_country_created", "cln_country_updated" },
                values: new object[] { new DateTime(2019, 3, 16, 14, 28, 6, 750, DateTimeKind.Utc).AddTicks(8114), new DateTime(2019, 3, 16, 14, 28, 6, 750, DateTimeKind.Utc).AddTicks(8114) });

            migrationBuilder.UpdateData(
                table: "tbl_countries",
                keyColumn: "cln_country_id",
                keyValue: 3,
                columns: new[] { "cln_country_created", "cln_country_updated" },
                values: new object[] { new DateTime(2019, 3, 16, 14, 28, 6, 750, DateTimeKind.Utc).AddTicks(8114), new DateTime(2019, 3, 16, 14, 28, 6, 750, DateTimeKind.Utc).AddTicks(8114) });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_airports_cln_airport_city_id",
                table: "tbl_airports",
                column: "cln_airport_city_id");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_airports_cln_airport_code_cln_airport_name",
                table: "tbl_airports",
                columns: new[] { "cln_airport_code", "cln_airport_name" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_airports");

            migrationBuilder.UpdateData(
                table: "tbl_accounts",
                keyColumn: "cln_account_id",
                keyValue: 1,
                columns: new[] { "cln_account_created", "cln_account_updated" },
                values: new object[] { new DateTime(2019, 3, 16, 13, 54, 32, 272, DateTimeKind.Utc).AddTicks(6692), new DateTime(2019, 3, 16, 13, 54, 32, 272, DateTimeKind.Utc).AddTicks(6692) });

            migrationBuilder.UpdateData(
                table: "tbl_accounts",
                keyColumn: "cln_account_id",
                keyValue: 2,
                columns: new[] { "cln_account_created", "cln_account_updated" },
                values: new object[] { new DateTime(2019, 3, 16, 13, 54, 32, 272, DateTimeKind.Utc).AddTicks(6692), new DateTime(2019, 3, 16, 13, 54, 32, 272, DateTimeKind.Utc).AddTicks(6692) });

            migrationBuilder.UpdateData(
                table: "tbl_cities",
                keyColumn: "cln_city_id",
                keyValue: 1,
                columns: new[] { "cln_city_created", "cln_city_updated" },
                values: new object[] { new DateTime(2019, 3, 16, 13, 54, 32, 272, DateTimeKind.Utc).AddTicks(6692), new DateTime(2019, 3, 16, 13, 54, 32, 272, DateTimeKind.Utc).AddTicks(6692) });

            migrationBuilder.UpdateData(
                table: "tbl_cities",
                keyColumn: "cln_city_id",
                keyValue: 2,
                columns: new[] { "cln_city_created", "cln_city_updated" },
                values: new object[] { new DateTime(2019, 3, 16, 13, 54, 32, 272, DateTimeKind.Utc).AddTicks(6692), new DateTime(2019, 3, 16, 13, 54, 32, 272, DateTimeKind.Utc).AddTicks(6692) });

            migrationBuilder.UpdateData(
                table: "tbl_cities",
                keyColumn: "cln_city_id",
                keyValue: 3,
                columns: new[] { "cln_city_created", "cln_city_updated" },
                values: new object[] { new DateTime(2019, 3, 16, 13, 54, 32, 272, DateTimeKind.Utc).AddTicks(6692), new DateTime(2019, 3, 16, 13, 54, 32, 272, DateTimeKind.Utc).AddTicks(6692) });

            migrationBuilder.UpdateData(
                table: "tbl_clients",
                keyColumn: "ClientID",
                keyValue: 1,
                columns: new[] { "cln_client_created", "cln_client_updated" },
                values: new object[] { new DateTime(2019, 3, 16, 13, 54, 32, 272, DateTimeKind.Utc).AddTicks(6692), new DateTime(2019, 3, 16, 13, 54, 32, 272, DateTimeKind.Utc).AddTicks(6692) });

            migrationBuilder.UpdateData(
                table: "tbl_countries",
                keyColumn: "cln_country_id",
                keyValue: 1,
                columns: new[] { "cln_country_created", "cln_country_updated" },
                values: new object[] { new DateTime(2019, 3, 16, 13, 54, 32, 272, DateTimeKind.Utc).AddTicks(6692), new DateTime(2019, 3, 16, 13, 54, 32, 272, DateTimeKind.Utc).AddTicks(6692) });

            migrationBuilder.UpdateData(
                table: "tbl_countries",
                keyColumn: "cln_country_id",
                keyValue: 2,
                columns: new[] { "cln_country_created", "cln_country_updated" },
                values: new object[] { new DateTime(2019, 3, 16, 13, 54, 32, 272, DateTimeKind.Utc).AddTicks(6692), new DateTime(2019, 3, 16, 13, 54, 32, 272, DateTimeKind.Utc).AddTicks(6692) });

            migrationBuilder.UpdateData(
                table: "tbl_countries",
                keyColumn: "cln_country_id",
                keyValue: 3,
                columns: new[] { "cln_country_created", "cln_country_updated" },
                values: new object[] { new DateTime(2019, 3, 16, 13, 54, 32, 272, DateTimeKind.Utc).AddTicks(6692), new DateTime(2019, 3, 16, 13, 54, 32, 272, DateTimeKind.Utc).AddTicks(6692) });
        }
    }
}
