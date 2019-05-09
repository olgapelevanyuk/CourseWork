using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OlympicFlights.DataAccess.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_countries",
                columns: table => new
                {
                    cln_country_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    cln_country_name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_countries", x => x.cln_country_id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_cities",
                columns: table => new
                {
                    cln_city_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    cln_city_name = table.Column<string>(nullable: true),
                    CountryID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_cities", x => x.cln_city_id);
                    table.ForeignKey(
                        name: "FK_tbl_cities_tbl_countries_CountryID",
                        column: x => x.CountryID,
                        principalTable: "tbl_countries",
                        principalColumn: "cln_country_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "tbl_countries",
                columns: new[] { "cln_country_id", "cln_country_name" },
                values: new object[] { 1, "Belarus" });

            migrationBuilder.InsertData(
                table: "tbl_countries",
                columns: new[] { "cln_country_id", "cln_country_name" },
                values: new object[] { 2, "Russia" });

            migrationBuilder.InsertData(
                table: "tbl_countries",
                columns: new[] { "cln_country_id", "cln_country_name" },
                values: new object[] { 3, "United States of America" });

            migrationBuilder.InsertData(
                table: "tbl_cities",
                columns: new[] { "cln_city_id", "cln_city_name", "CountryID" },
                values: new object[] { 2, "Minsk", 1 });

            migrationBuilder.InsertData(
                table: "tbl_cities",
                columns: new[] { "cln_city_id", "cln_city_name", "CountryID" },
                values: new object[] { 1, "Moscow", 2 });

            migrationBuilder.InsertData(
                table: "tbl_cities",
                columns: new[] { "cln_city_id", "cln_city_name", "CountryID" },
                values: new object[] { 3, "New York", 3 });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_cities_CountryID",
                table: "tbl_cities",
                column: "CountryID");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_countries_cln_country_name",
                table: "tbl_countries",
                column: "cln_country_name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_cities");

            migrationBuilder.DropTable(
                name: "tbl_countries");
        }
    }
}
