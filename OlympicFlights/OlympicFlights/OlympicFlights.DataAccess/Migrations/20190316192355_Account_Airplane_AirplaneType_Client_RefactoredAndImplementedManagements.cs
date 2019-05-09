using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OlympicFlights.DataAccess.Migrations
{
    public partial class Account_Airplane_AirplaneType_Client_RefactoredAndImplementedManagements : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "cln_client_is_deleted",
                table: "tbl_clients",
                nullable: false,
                defaultValue: false);

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
                    cln_airplane_created = table.Column<DateTime>(nullable: false),
                    cln_airplane_updated = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    cln_airplane_type_id = table.Column<int>(nullable: false)
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

            migrationBuilder.InsertData(
                table: "tbl_airplanes",
                columns: new[] { "cln_airplane_id", "cln_airplane_number", "cln_airplane_type_id", "cln_airplane_created", "IsDeleted", "cln_airplane_updated" },
                values: new object[,]
                {
                    { 1, 1001, 1, new DateTime(2019, 3, 16, 19, 23, 54, 913, DateTimeKind.Utc).AddTicks(9364), false, new DateTime(2019, 3, 16, 19, 23, 54, 913, DateTimeKind.Utc).AddTicks(9364) },
                    { 2, 2001, 2, new DateTime(2019, 3, 16, 19, 23, 54, 913, DateTimeKind.Utc).AddTicks(9364), false, new DateTime(2019, 3, 16, 19, 23, 54, 913, DateTimeKind.Utc).AddTicks(9364) },
                    { 4, 2002, 2, new DateTime(2019, 3, 16, 19, 23, 54, 913, DateTimeKind.Utc).AddTicks(9364), false, new DateTime(2019, 3, 16, 19, 23, 54, 913, DateTimeKind.Utc).AddTicks(9364) },
                    { 3, 3001, 3, new DateTime(2019, 3, 16, 19, 23, 54, 913, DateTimeKind.Utc).AddTicks(9364), false, new DateTime(2019, 3, 16, 19, 23, 54, 913, DateTimeKind.Utc).AddTicks(9364) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_airplanes_cln_airplane_number",
                table: "tbl_airplanes",
                column: "cln_airplane_number");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_airplanes_cln_airplane_type_id",
                table: "tbl_airplanes",
                column: "cln_airplane_type_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_airplanes");

            migrationBuilder.DropTable(
                name: "tbl_airplane_types");

            migrationBuilder.DropColumn(
                name: "cln_client_is_deleted",
                table: "tbl_clients");

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

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 1,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 3, 16, 14, 28, 6, 750, DateTimeKind.Utc).AddTicks(8114), new DateTime(2019, 3, 16, 14, 28, 6, 750, DateTimeKind.Utc).AddTicks(8114) });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 2,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 3, 16, 14, 28, 6, 750, DateTimeKind.Utc).AddTicks(8114), new DateTime(2019, 3, 16, 14, 28, 6, 750, DateTimeKind.Utc).AddTicks(8114) });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 3,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 3, 16, 14, 28, 6, 750, DateTimeKind.Utc).AddTicks(8114), new DateTime(2019, 3, 16, 14, 28, 6, 750, DateTimeKind.Utc).AddTicks(8114) });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 4,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 3, 16, 14, 28, 6, 750, DateTimeKind.Utc).AddTicks(8114), new DateTime(2019, 3, 16, 14, 28, 6, 750, DateTimeKind.Utc).AddTicks(8114) });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 5,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 3, 16, 14, 28, 6, 750, DateTimeKind.Utc).AddTicks(8114), new DateTime(2019, 3, 16, 14, 28, 6, 750, DateTimeKind.Utc).AddTicks(8114) });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 6,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 3, 16, 14, 28, 6, 750, DateTimeKind.Utc).AddTicks(8114), new DateTime(2019, 3, 16, 14, 28, 6, 750, DateTimeKind.Utc).AddTicks(8114) });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 7,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 3, 16, 14, 28, 6, 750, DateTimeKind.Utc).AddTicks(8114), new DateTime(2019, 3, 16, 14, 28, 6, 750, DateTimeKind.Utc).AddTicks(8114) });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 8,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 3, 16, 14, 28, 6, 750, DateTimeKind.Utc).AddTicks(8114), new DateTime(2019, 3, 16, 14, 28, 6, 750, DateTimeKind.Utc).AddTicks(8114) });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 9,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 3, 16, 14, 28, 6, 750, DateTimeKind.Utc).AddTicks(8114), new DateTime(2019, 3, 16, 14, 28, 6, 750, DateTimeKind.Utc).AddTicks(8114) });

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
        }
    }
}
