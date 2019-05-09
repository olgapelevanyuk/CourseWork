using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OlympicFlights.DataAccess.Migrations
{
    public partial class RefactoredAppDbContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_flights_tbl_airplanes_cln_flight_airplane_id",
                table: "tbl_flights");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_flights_tbl_cities_CityID",
                table: "tbl_flights");

            migrationBuilder.DropTable(
                name: "tbl_accounts");

            migrationBuilder.DropTable(
                name: "tbl_airplanes");

            migrationBuilder.DropTable(
                name: "tbl_airplane_types");

            migrationBuilder.DropIndex(
                name: "IX_tbl_flights_cln_flight_airplane_id",
                table: "tbl_flights");

            migrationBuilder.DropIndex(
                name: "IX_tbl_flights_CityID",
                table: "tbl_flights");

            migrationBuilder.DeleteData(
                table: "tbl_clients",
                keyColumn: "ClientId",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "cln_ticket_price_coefficient",
                table: "tbl_tickets");

            migrationBuilder.DropColumn(
                name: "cln_ticket_sit_number",
                table: "tbl_tickets");

            migrationBuilder.DropColumn(
                name: "cln_flight_airplane_id",
                table: "tbl_flights");

            migrationBuilder.DropColumn(
                name: "CityID",
                table: "tbl_flights");

            migrationBuilder.RenameColumn(
                name: "cln_ticket_purchase_time",
                table: "tbl_tickets",
                newName: "Created");

            migrationBuilder.AddColumn<bool>(
                name: "cln_ticket_is_deleted",
                table: "tbl_tickets",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<decimal>(
                name: "FlightPrice",
                table: "tbl_flights",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<bool>(
                name: "cln_flight_is_deleted",
                table: "tbl_flights",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "cln_country_is_deleted",
                table: "tbl_countries",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "cln_client_user_id",
                table: "tbl_clients",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "tbl_cities",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "cln_airport_is_deleted",
                table: "tbl_airports",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "ApplicationUser",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    NormalizedUserName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    NormalizedEmail = table.Column<string>(nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
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
                columns: new[] { "cln_flight_arrive_time", "cln_flight_departure_time", "FlightPrice" },
                values: new object[] { new DateTime(2019, 4, 18, 6, 9, 19, 194, DateTimeKind.Utc).AddTicks(6549), new DateTime(2019, 4, 17, 23, 9, 19, 194, DateTimeKind.Utc).AddTicks(6549), 300m });

            migrationBuilder.UpdateData(
                table: "tbl_flights",
                keyColumn: "cln_flight_id",
                keyValue: 2,
                columns: new[] { "cln_flight_arrive_time", "cln_flight_departure_time", "FlightPrice" },
                values: new object[] { new DateTime(2019, 4, 18, 1, 9, 19, 194, DateTimeKind.Utc).AddTicks(6549), new DateTime(2019, 4, 17, 23, 9, 19, 194, DateTimeKind.Utc).AddTicks(6549), 400m });

            migrationBuilder.UpdateData(
                table: "tbl_flights",
                keyColumn: "cln_flight_id",
                keyValue: 3,
                columns: new[] { "cln_flight_arrive_time", "cln_flight_departure_time", "FlightPrice" },
                values: new object[] { new DateTime(2019, 4, 18, 5, 9, 19, 194, DateTimeKind.Utc).AddTicks(6549), new DateTime(2019, 4, 17, 23, 9, 19, 194, DateTimeKind.Utc).AddTicks(6549), 500m });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_clients_ApplicationUser_cln_client_user_id",
                table: "tbl_clients");

            migrationBuilder.DropTable(
                name: "ApplicationUser");

            migrationBuilder.DropIndex(
                name: "IX_tbl_clients_cln_client_user_id",
                table: "tbl_clients");

            migrationBuilder.DropColumn(
                name: "cln_ticket_is_deleted",
                table: "tbl_tickets");

            migrationBuilder.DropColumn(
                name: "FlightPrice",
                table: "tbl_flights");

            migrationBuilder.DropColumn(
                name: "cln_flight_is_deleted",
                table: "tbl_flights");

            migrationBuilder.DropColumn(
                name: "cln_country_is_deleted",
                table: "tbl_countries");

            migrationBuilder.DropColumn(
                name: "cln_client_user_id",
                table: "tbl_clients");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "tbl_cities");

            migrationBuilder.DropColumn(
                name: "cln_airport_is_deleted",
                table: "tbl_airports");

            migrationBuilder.RenameColumn(
                name: "Created",
                table: "tbl_tickets",
                newName: "cln_ticket_purchase_time");

            migrationBuilder.AddColumn<decimal>(
                name: "cln_ticket_price_coefficient",
                table: "tbl_tickets",
                nullable: false,
                defaultValue: 1.3m);

            migrationBuilder.AddColumn<int>(
                name: "cln_ticket_sit_number",
                table: "tbl_tickets",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "cln_flight_airplane_id",
                table: "tbl_flights",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CityID",
                table: "tbl_flights",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "tbl_accounts",
                columns: table => new
                {
                    cln_account_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    cln_account_login = table.Column<string>(maxLength: 255, nullable: false),
                    cln_account_password = table.Column<string>(maxLength: 255, nullable: false),
                    cln_account_client_id = table.Column<int>(nullable: false),
                    cln_account_created = table.Column<DateTime>(nullable: false),
                    cnl_account_role = table.Column<bool>(nullable: false),
                    cln_account_updated = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_accounts", x => x.cln_account_id);
                    table.ForeignKey(
                        name: "FK_tbl_accounts_tbl_clients_cln_account_client_id",
                        column: x => x.cln_account_client_id,
                        principalTable: "tbl_clients",
                        principalColumn: "ClientId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_airplane_types",
                columns: table => new
                {
                    cln_airplane_type_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    cln_airplane_type_name = table.Column<string>(nullable: false),
                    cln_airplane_type_sits_count = table.Column<int>(nullable: false),
                    cln_airplane_type_has_business_class = table.Column<bool>(nullable: false),
                    cln_airplane_type_sit_price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_airplane_types", x => x.cln_airplane_type_id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_airplanes",
                columns: table => new
                {
                    cln_airplane_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    cln_airplane_number = table.Column<int>(nullable: false),
                    cln_airplane_type_id = table.Column<int>(nullable: false),
                    cln_airplane_created = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    cln_airplane_updated = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_airplanes", x => x.cln_airplane_id);
                    table.ForeignKey(
                        name: "FK_tbl_airplanes_tbl_airplane_types_cln_airplane_type_id",
                        column: x => x.cln_airplane_type_id,
                        principalTable: "tbl_airplane_types",
                        principalColumn: "cln_airplane_type_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "tbl_airplane_types",
                columns: new[] { "cln_airplane_type_id", "cln_airplane_type_name", "cln_airplane_type_sits_count", "cln_airplane_type_has_business_class", "cln_airplane_type_sit_price" },
                values: new object[,]
                {
                    { 1, "Airbus-A310", 183, false, 200m },
                    { 2, "IL-96M", 318, true, 250m },
                    { 3, "Boeing-737", 192, true, 300m }
                });

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

            migrationBuilder.InsertData(
                table: "tbl_clients",
                columns: new[] { "ClientId", "cln_client_address", "cln_client_first_name", "cln_client_last_name", "cln_client_created", "cln_client_updated" },
                values: new object[] { 1, "Belarus,Brest,st.Suvorova,114,22", "Artsiom", "Lyshchyk", new DateTime(2019, 4, 17, 19, 43, 7, 251, DateTimeKind.Utc).AddTicks(9345), new DateTime(2019, 4, 17, 19, 43, 7, 251, DateTimeKind.Utc).AddTicks(9345) });

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

            migrationBuilder.InsertData(
                table: "tbl_accounts",
                columns: new[] { "cln_account_id", "cln_account_login", "cln_account_password", "cln_account_client_id", "cln_account_created", "cnl_account_role", "cln_account_updated" },
                values: new object[,]
                {
                    { 1, "48red", "Ar555321", 1, new DateTime(2019, 4, 17, 19, 43, 7, 251, DateTimeKind.Utc).AddTicks(9345), true, new DateTime(2019, 4, 17, 19, 43, 7, 251, DateTimeKind.Utc).AddTicks(9345) },
                    { 2, "simf11422", "Ar555321", 1, new DateTime(2019, 4, 17, 19, 43, 7, 251, DateTimeKind.Utc).AddTicks(9345), false, new DateTime(2019, 4, 17, 19, 43, 7, 251, DateTimeKind.Utc).AddTicks(9345) }
                });

            migrationBuilder.InsertData(
                table: "tbl_airplanes",
                columns: new[] { "cln_airplane_id", "cln_airplane_number", "cln_airplane_type_id", "cln_airplane_created", "IsDeleted", "cln_airplane_updated" },
                values: new object[,]
                {
                    { 1, 1001, 1, new DateTime(2019, 4, 17, 19, 43, 7, 251, DateTimeKind.Utc).AddTicks(9345), false, new DateTime(2019, 4, 17, 19, 43, 7, 251, DateTimeKind.Utc).AddTicks(9345) },
                    { 2, 2001, 2, new DateTime(2019, 4, 17, 19, 43, 7, 251, DateTimeKind.Utc).AddTicks(9345), false, new DateTime(2019, 4, 17, 19, 43, 7, 251, DateTimeKind.Utc).AddTicks(9345) },
                    { 4, 2002, 2, new DateTime(2019, 4, 17, 19, 43, 7, 251, DateTimeKind.Utc).AddTicks(9345), false, new DateTime(2019, 4, 17, 19, 43, 7, 251, DateTimeKind.Utc).AddTicks(9345) },
                    { 3, 3001, 3, new DateTime(2019, 4, 17, 19, 43, 7, 251, DateTimeKind.Utc).AddTicks(9345), false, new DateTime(2019, 4, 17, 19, 43, 7, 251, DateTimeKind.Utc).AddTicks(9345) }
                });

            migrationBuilder.UpdateData(
                table: "tbl_tickets",
                keyColumn: "cln_ticket_id",
                keyValue: 1,
                columns: new[] { "cln_ticket_purchase_time", "cln_ticket_sit_number" },
                values: new object[] { new DateTime(2019, 4, 14, 19, 43, 7, 251, DateTimeKind.Utc).AddTicks(9345), 10 });

            migrationBuilder.UpdateData(
                table: "tbl_tickets",
                keyColumn: "cln_ticket_id",
                keyValue: 2,
                columns: new[] { "cln_ticket_purchase_time", "cln_ticket_sit_number" },
                values: new object[] { new DateTime(2019, 4, 13, 19, 43, 7, 251, DateTimeKind.Utc).AddTicks(9345), 30 });

            migrationBuilder.UpdateData(
                table: "tbl_tickets",
                keyColumn: "cln_ticket_id",
                keyValue: 3,
                columns: new[] { "cln_ticket_purchase_time", "cln_ticket_sit_number" },
                values: new object[] { new DateTime(2019, 4, 15, 19, 43, 7, 251, DateTimeKind.Utc).AddTicks(9345), 40 });

            migrationBuilder.UpdateData(
                table: "tbl_flights",
                keyColumn: "cln_flight_id",
                keyValue: 1,
                columns: new[] { "cln_flight_airplane_id", "cln_flight_arrive_time", "cln_flight_departure_time" },
                values: new object[] { 1, new DateTime(2019, 4, 18, 2, 43, 7, 251, DateTimeKind.Utc).AddTicks(9345), new DateTime(2019, 4, 17, 19, 43, 7, 251, DateTimeKind.Utc).AddTicks(9345) });

            migrationBuilder.UpdateData(
                table: "tbl_flights",
                keyColumn: "cln_flight_id",
                keyValue: 2,
                columns: new[] { "cln_flight_airplane_id", "cln_flight_arrive_time", "cln_flight_departure_time" },
                values: new object[] { 2, new DateTime(2019, 4, 17, 21, 43, 7, 251, DateTimeKind.Utc).AddTicks(9345), new DateTime(2019, 4, 17, 19, 43, 7, 251, DateTimeKind.Utc).AddTicks(9345) });

            migrationBuilder.UpdateData(
                table: "tbl_flights",
                keyColumn: "cln_flight_id",
                keyValue: 3,
                columns: new[] { "cln_flight_airplane_id", "cln_flight_arrive_time", "cln_flight_departure_time" },
                values: new object[] { 3, new DateTime(2019, 4, 18, 1, 43, 7, 251, DateTimeKind.Utc).AddTicks(9345), new DateTime(2019, 4, 17, 19, 43, 7, 251, DateTimeKind.Utc).AddTicks(9345) });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_flights_cln_flight_airplane_id",
                table: "tbl_flights",
                column: "cln_flight_airplane_id");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_flights_CityID",
                table: "tbl_flights",
                column: "CityID");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_accounts_cln_account_client_id",
                table: "tbl_accounts",
                column: "cln_account_client_id");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_accounts_cln_account_login_cln_account_password",
                table: "tbl_accounts",
                columns: new[] { "cln_account_login", "cln_account_password" });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_airplanes_cln_airplane_number",
                table: "tbl_airplanes",
                column: "cln_airplane_number");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_airplanes_cln_airplane_type_id",
                table: "tbl_airplanes",
                column: "cln_airplane_type_id");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_flights_tbl_airplanes_cln_flight_airplane_id",
                table: "tbl_flights",
                column: "cln_flight_airplane_id",
                principalTable: "tbl_airplanes",
                principalColumn: "cln_airplane_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_flights_tbl_cities_CityID",
                table: "tbl_flights",
                column: "CityID",
                principalTable: "tbl_cities",
                principalColumn: "cln_city_id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
