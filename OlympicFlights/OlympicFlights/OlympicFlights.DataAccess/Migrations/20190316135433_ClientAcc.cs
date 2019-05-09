using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OlympicFlights.DataAccess.Migrations
{
    public partial class ClientAcc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_cities_tbl_countries_CountryID",
                table: "tbl_cities");

            migrationBuilder.RenameColumn(
                name: "CountryID",
                table: "tbl_cities",
                newName: "cln_city_country_id");

            migrationBuilder.RenameIndex(
                name: "IX_tbl_cities_CountryID",
                table: "tbl_cities",
                newName: "IX_tbl_cities_cln_city_country_id");

            migrationBuilder.AddColumn<DateTime>(
                name: "cln_country_created",
                table: "tbl_countries",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "cln_country_updated",
                table: "tbl_countries",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "cln_city_created",
                table: "tbl_cities",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "cln_city_updated",
                table: "tbl_cities",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "tbl_clients",
                columns: table => new
                {
                    ClientID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    cln_client_first_name = table.Column<string>(maxLength: 30, nullable: false),
                    cln_client_last_name = table.Column<string>(maxLength: 30, nullable: false),
                    cln_client_address = table.Column<string>(maxLength: 255, nullable: false),
                    cln_client_created = table.Column<DateTime>(nullable: false),
                    cln_client_updated = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_clients", x => x.ClientID);
                });

            migrationBuilder.CreateTable(
                name: "tbl_accounts",
                columns: table => new
                {
                    cln_account_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    cln_account_login = table.Column<string>(maxLength: 255, nullable: false),
                    cln_account_password = table.Column<string>(maxLength: 255, nullable: false),
                    cnl_account_role = table.Column<bool>(nullable: false),
                    cln_account_created = table.Column<DateTime>(nullable: false),
                    cln_account_updated = table.Column<DateTime>(nullable: false),
                    cln_account_client_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_accounts", x => x.cln_account_id);
                    table.ForeignKey(
                        name: "FK_tbl_accounts_tbl_clients_cln_account_client_id",
                        column: x => x.cln_account_client_id,
                        principalTable: "tbl_clients",
                        principalColumn: "ClientID",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.InsertData(
                table: "tbl_clients",
                columns: new[] { "ClientID", "cln_client_address", "cln_client_first_name", "cln_client_last_name", "cln_client_created", "cln_client_updated" },
                values: new object[] { 1, "Belarus,Brest,st.Suvorova,114,22", "Artsiom", "Lyshchyk", new DateTime(2019, 3, 16, 13, 54, 32, 272, DateTimeKind.Utc).AddTicks(6692), new DateTime(2019, 3, 16, 13, 54, 32, 272, DateTimeKind.Utc).AddTicks(6692) });

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

            migrationBuilder.InsertData(
                table: "tbl_accounts",
                columns: new[] { "cln_account_id", "cln_account_login", "cln_account_password", "cln_account_client_id", "cln_account_created", "cnl_account_role", "cln_account_updated" },
                values: new object[] { 1, "48red", "Ar555321", 1, new DateTime(2019, 3, 16, 13, 54, 32, 272, DateTimeKind.Utc).AddTicks(6692), true, new DateTime(2019, 3, 16, 13, 54, 32, 272, DateTimeKind.Utc).AddTicks(6692) });

            migrationBuilder.InsertData(
                table: "tbl_accounts",
                columns: new[] { "cln_account_id", "cln_account_login", "cln_account_password", "cln_account_client_id", "cln_account_created", "cnl_account_role", "cln_account_updated" },
                values: new object[] { 2, "simf11422", "Ar555321", 1, new DateTime(2019, 3, 16, 13, 54, 32, 272, DateTimeKind.Utc).AddTicks(6692), false, new DateTime(2019, 3, 16, 13, 54, 32, 272, DateTimeKind.Utc).AddTicks(6692) });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_accounts_cln_account_client_id",
                table: "tbl_accounts",
                column: "cln_account_client_id");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_accounts_cln_account_login_cln_account_password",
                table: "tbl_accounts",
                columns: new[] { "cln_account_login", "cln_account_password" });

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_cities_tbl_countries_cln_city_country_id",
                table: "tbl_cities",
                column: "cln_city_country_id",
                principalTable: "tbl_countries",
                principalColumn: "cln_country_id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_cities_tbl_countries_cln_city_country_id",
                table: "tbl_cities");

            migrationBuilder.DropTable(
                name: "tbl_accounts");

            migrationBuilder.DropTable(
                name: "tbl_clients");

            migrationBuilder.DropColumn(
                name: "cln_country_created",
                table: "tbl_countries");

            migrationBuilder.DropColumn(
                name: "cln_country_updated",
                table: "tbl_countries");

            migrationBuilder.DropColumn(
                name: "cln_city_created",
                table: "tbl_cities");

            migrationBuilder.DropColumn(
                name: "cln_city_updated",
                table: "tbl_cities");

            migrationBuilder.RenameColumn(
                name: "cln_city_country_id",
                table: "tbl_cities",
                newName: "CountryID");

            migrationBuilder.RenameIndex(
                name: "IX_tbl_cities_cln_city_country_id",
                table: "tbl_cities",
                newName: "IX_tbl_cities_CountryID");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_cities_tbl_countries_CountryID",
                table: "tbl_cities",
                column: "CountryID",
                principalTable: "tbl_countries",
                principalColumn: "cln_country_id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
