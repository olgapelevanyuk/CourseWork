using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OlympicFlights.DataAccess.Migrations
{
    public partial class FixSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "cln_client_user_id",
                table: "tbl_clients",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
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
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 1,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 5, 1, 12, 24, 17, 639, DateTimeKind.Utc).AddTicks(2857), new DateTime(2019, 5, 1, 12, 24, 17, 639, DateTimeKind.Utc).AddTicks(2857) });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 2,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 5, 1, 12, 24, 17, 639, DateTimeKind.Utc).AddTicks(2857), new DateTime(2019, 5, 1, 12, 24, 17, 639, DateTimeKind.Utc).AddTicks(2857) });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 3,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 5, 1, 12, 24, 17, 639, DateTimeKind.Utc).AddTicks(2857), new DateTime(2019, 5, 1, 12, 24, 17, 639, DateTimeKind.Utc).AddTicks(2857) });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 4,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 5, 1, 12, 24, 17, 639, DateTimeKind.Utc).AddTicks(2857), new DateTime(2019, 5, 1, 12, 24, 17, 639, DateTimeKind.Utc).AddTicks(2857) });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 5,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 5, 1, 12, 24, 17, 639, DateTimeKind.Utc).AddTicks(2857), new DateTime(2019, 5, 1, 12, 24, 17, 639, DateTimeKind.Utc).AddTicks(2857) });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 6,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 5, 1, 12, 24, 17, 639, DateTimeKind.Utc).AddTicks(2857), new DateTime(2019, 5, 1, 12, 24, 17, 639, DateTimeKind.Utc).AddTicks(2857) });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 7,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 5, 1, 12, 24, 17, 639, DateTimeKind.Utc).AddTicks(2857), new DateTime(2019, 5, 1, 12, 24, 17, 639, DateTimeKind.Utc).AddTicks(2857) });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 8,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 5, 1, 12, 24, 17, 639, DateTimeKind.Utc).AddTicks(2857), new DateTime(2019, 5, 1, 12, 24, 17, 639, DateTimeKind.Utc).AddTicks(2857) });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 9,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 5, 1, 12, 24, 17, 639, DateTimeKind.Utc).AddTicks(2857), new DateTime(2019, 5, 1, 12, 24, 17, 639, DateTimeKind.Utc).AddTicks(2857) });

            migrationBuilder.UpdateData(
                table: "tbl_cities",
                keyColumn: "cln_city_id",
                keyValue: 1,
                columns: new[] { "cln_city_created", "cln_city_updated" },
                values: new object[] { new DateTime(2019, 5, 1, 12, 24, 17, 639, DateTimeKind.Utc).AddTicks(2857), new DateTime(2019, 5, 1, 12, 24, 17, 639, DateTimeKind.Utc).AddTicks(2857) });

            migrationBuilder.UpdateData(
                table: "tbl_cities",
                keyColumn: "cln_city_id",
                keyValue: 2,
                columns: new[] { "cln_city_created", "cln_city_updated" },
                values: new object[] { new DateTime(2019, 5, 1, 12, 24, 17, 639, DateTimeKind.Utc).AddTicks(2857), new DateTime(2019, 5, 1, 12, 24, 17, 639, DateTimeKind.Utc).AddTicks(2857) });

            migrationBuilder.UpdateData(
                table: "tbl_cities",
                keyColumn: "cln_city_id",
                keyValue: 3,
                columns: new[] { "cln_city_created", "cln_city_updated" },
                values: new object[] { new DateTime(2019, 5, 1, 12, 24, 17, 639, DateTimeKind.Utc).AddTicks(2857), new DateTime(2019, 5, 1, 12, 24, 17, 639, DateTimeKind.Utc).AddTicks(2857) });

            migrationBuilder.UpdateData(
                table: "tbl_clients",
                keyColumn: "cln_client_id",
                keyValue: 1,
                columns: new[] { "cln_client_created", "cln_client_updated", "cln_client_user_id" },
                values: new object[] { new DateTime(2019, 5, 1, 12, 24, 17, 639, DateTimeKind.Utc).AddTicks(2857), new DateTime(2019, 5, 1, 12, 24, 17, 639, DateTimeKind.Utc).AddTicks(2857), null });

            migrationBuilder.UpdateData(
                table: "tbl_countries",
                keyColumn: "cln_country_id",
                keyValue: 1,
                columns: new[] { "cln_country_created", "cln_country_updated" },
                values: new object[] { new DateTime(2019, 5, 1, 12, 24, 17, 639, DateTimeKind.Utc).AddTicks(2857), new DateTime(2019, 5, 1, 12, 24, 17, 639, DateTimeKind.Utc).AddTicks(2857) });

            migrationBuilder.UpdateData(
                table: "tbl_countries",
                keyColumn: "cln_country_id",
                keyValue: 2,
                columns: new[] { "cln_country_created", "cln_country_updated" },
                values: new object[] { new DateTime(2019, 5, 1, 12, 24, 17, 639, DateTimeKind.Utc).AddTicks(2857), new DateTime(2019, 5, 1, 12, 24, 17, 639, DateTimeKind.Utc).AddTicks(2857) });

            migrationBuilder.UpdateData(
                table: "tbl_countries",
                keyColumn: "cln_country_id",
                keyValue: 3,
                columns: new[] { "cln_country_created", "cln_country_updated" },
                values: new object[] { new DateTime(2019, 5, 1, 12, 24, 17, 639, DateTimeKind.Utc).AddTicks(2857), new DateTime(2019, 5, 1, 12, 24, 17, 639, DateTimeKind.Utc).AddTicks(2857) });

            migrationBuilder.UpdateData(
                table: "tbl_flights",
                keyColumn: "cln_flight_id",
                keyValue: 1,
                columns: new[] { "cln_flight_arrive_time", "cln_flight_departure_time" },
                values: new object[] { new DateTime(2019, 5, 1, 19, 24, 17, 639, DateTimeKind.Utc).AddTicks(2857), new DateTime(2019, 5, 1, 12, 24, 17, 639, DateTimeKind.Utc).AddTicks(2857) });

            migrationBuilder.UpdateData(
                table: "tbl_flights",
                keyColumn: "cln_flight_id",
                keyValue: 2,
                columns: new[] { "cln_flight_arrive_time", "cln_flight_departure_time" },
                values: new object[] { new DateTime(2019, 5, 1, 14, 24, 17, 639, DateTimeKind.Utc).AddTicks(2857), new DateTime(2019, 5, 1, 12, 24, 17, 639, DateTimeKind.Utc).AddTicks(2857) });

            migrationBuilder.UpdateData(
                table: "tbl_flights",
                keyColumn: "cln_flight_id",
                keyValue: 3,
                columns: new[] { "cln_flight_arrive_time", "cln_flight_departure_time" },
                values: new object[] { new DateTime(2019, 5, 1, 18, 24, 17, 639, DateTimeKind.Utc).AddTicks(2857), new DateTime(2019, 5, 1, 12, 24, 17, 639, DateTimeKind.Utc).AddTicks(2857) });

            migrationBuilder.UpdateData(
                table: "tbl_flights",
                keyColumn: "cln_flight_id",
                keyValue: 4,
                columns: new[] { "cln_flight_arrive_time", "cln_flight_departure_time" },
                values: new object[] { new DateTime(2019, 5, 1, 19, 24, 17, 639, DateTimeKind.Utc).AddTicks(2857), new DateTime(2019, 6, 1, 12, 24, 17, 639, DateTimeKind.Utc).AddTicks(2857) });

            migrationBuilder.UpdateData(
                table: "tbl_flights",
                keyColumn: "cln_flight_id",
                keyValue: 5,
                columns: new[] { "cln_flight_arrive_time", "cln_flight_departure_time" },
                values: new object[] { new DateTime(2019, 6, 3, 12, 24, 17, 639, DateTimeKind.Utc).AddTicks(2857), new DateTime(2019, 6, 1, 12, 24, 17, 639, DateTimeKind.Utc).AddTicks(2857) });

            migrationBuilder.UpdateData(
                table: "tbl_flights",
                keyColumn: "cln_flight_id",
                keyValue: 6,
                columns: new[] { "cln_flight_arrive_time", "cln_flight_departure_time" },
                values: new object[] { new DateTime(2019, 6, 1, 18, 24, 17, 639, DateTimeKind.Utc).AddTicks(2857), new DateTime(2019, 6, 1, 12, 24, 17, 639, DateTimeKind.Utc).AddTicks(2857) });

            migrationBuilder.UpdateData(
                table: "tbl_flights",
                keyColumn: "cln_flight_id",
                keyValue: 7,
                columns: new[] { "cln_flight_arrive_time", "cln_flight_departure_time" },
                values: new object[] { new DateTime(2019, 7, 1, 18, 24, 17, 639, DateTimeKind.Utc).AddTicks(2857), new DateTime(2019, 6, 1, 12, 24, 17, 639, DateTimeKind.Utc).AddTicks(2857) });

            migrationBuilder.UpdateData(
                table: "tbl_flights",
                keyColumn: "cln_flight_id",
                keyValue: 8,
                columns: new[] { "cln_flight_arrive_time", "cln_flight_departure_time" },
                values: new object[] { new DateTime(2019, 8, 1, 18, 24, 17, 639, DateTimeKind.Utc).AddTicks(2857), new DateTime(2019, 6, 1, 12, 24, 17, 639, DateTimeKind.Utc).AddTicks(2857) });

            migrationBuilder.UpdateData(
                table: "tbl_tickets",
                keyColumn: "cln_ticket_id",
                keyValue: 1,
                column: "cln_ticket_created",
                value: new DateTime(2019, 5, 1, 12, 24, 17, 639, DateTimeKind.Utc).AddTicks(2857));

            migrationBuilder.UpdateData(
                table: "tbl_tickets",
                keyColumn: "cln_ticket_id",
                keyValue: 2,
                column: "cln_ticket_created",
                value: new DateTime(2019, 5, 1, 12, 24, 17, 639, DateTimeKind.Utc).AddTicks(2857));

            migrationBuilder.UpdateData(
                table: "tbl_tickets",
                keyColumn: "cln_ticket_id",
                keyValue: 3,
                column: "cln_ticket_created",
                value: new DateTime(2019, 5, 1, 12, 24, 17, 639, DateTimeKind.Utc).AddTicks(2857));

            migrationBuilder.CreateIndex(
                name: "IX_tbl_clients_cln_client_user_id",
                table: "tbl_clients",
                column: "cln_client_user_id");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_clients_AspNetUsers_cln_client_user_id",
                table: "tbl_clients",
                column: "cln_client_user_id",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_clients_AspNetUsers_cln_client_user_id",
                table: "tbl_clients");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

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
                values: new object[] { new DateTime(2019, 4, 30, 11, 33, 33, 963, DateTimeKind.Utc).AddTicks(9861), new DateTime(2019, 4, 30, 11, 33, 33, 963, DateTimeKind.Utc).AddTicks(9861) });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 2,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 4, 30, 11, 33, 33, 963, DateTimeKind.Utc).AddTicks(9861), new DateTime(2019, 4, 30, 11, 33, 33, 963, DateTimeKind.Utc).AddTicks(9861) });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 3,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 4, 30, 11, 33, 33, 963, DateTimeKind.Utc).AddTicks(9861), new DateTime(2019, 4, 30, 11, 33, 33, 963, DateTimeKind.Utc).AddTicks(9861) });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 4,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 4, 30, 11, 33, 33, 963, DateTimeKind.Utc).AddTicks(9861), new DateTime(2019, 4, 30, 11, 33, 33, 963, DateTimeKind.Utc).AddTicks(9861) });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 5,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 4, 30, 11, 33, 33, 963, DateTimeKind.Utc).AddTicks(9861), new DateTime(2019, 4, 30, 11, 33, 33, 963, DateTimeKind.Utc).AddTicks(9861) });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 6,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 4, 30, 11, 33, 33, 963, DateTimeKind.Utc).AddTicks(9861), new DateTime(2019, 4, 30, 11, 33, 33, 963, DateTimeKind.Utc).AddTicks(9861) });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 7,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 4, 30, 11, 33, 33, 963, DateTimeKind.Utc).AddTicks(9861), new DateTime(2019, 4, 30, 11, 33, 33, 963, DateTimeKind.Utc).AddTicks(9861) });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 8,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 4, 30, 11, 33, 33, 963, DateTimeKind.Utc).AddTicks(9861), new DateTime(2019, 4, 30, 11, 33, 33, 963, DateTimeKind.Utc).AddTicks(9861) });

            migrationBuilder.UpdateData(
                table: "tbl_airports",
                keyColumn: "cln_airport_id",
                keyValue: 9,
                columns: new[] { "cln_airport_created", "cln_airport_updated" },
                values: new object[] { new DateTime(2019, 4, 30, 11, 33, 33, 963, DateTimeKind.Utc).AddTicks(9861), new DateTime(2019, 4, 30, 11, 33, 33, 963, DateTimeKind.Utc).AddTicks(9861) });

            migrationBuilder.UpdateData(
                table: "tbl_cities",
                keyColumn: "cln_city_id",
                keyValue: 1,
                columns: new[] { "cln_city_created", "cln_city_updated" },
                values: new object[] { new DateTime(2019, 4, 30, 11, 33, 33, 963, DateTimeKind.Utc).AddTicks(9861), new DateTime(2019, 4, 30, 11, 33, 33, 963, DateTimeKind.Utc).AddTicks(9861) });

            migrationBuilder.UpdateData(
                table: "tbl_cities",
                keyColumn: "cln_city_id",
                keyValue: 2,
                columns: new[] { "cln_city_created", "cln_city_updated" },
                values: new object[] { new DateTime(2019, 4, 30, 11, 33, 33, 963, DateTimeKind.Utc).AddTicks(9861), new DateTime(2019, 4, 30, 11, 33, 33, 963, DateTimeKind.Utc).AddTicks(9861) });

            migrationBuilder.UpdateData(
                table: "tbl_cities",
                keyColumn: "cln_city_id",
                keyValue: 3,
                columns: new[] { "cln_city_created", "cln_city_updated" },
                values: new object[] { new DateTime(2019, 4, 30, 11, 33, 33, 963, DateTimeKind.Utc).AddTicks(9861), new DateTime(2019, 4, 30, 11, 33, 33, 963, DateTimeKind.Utc).AddTicks(9861) });

            migrationBuilder.UpdateData(
                table: "tbl_clients",
                keyColumn: "cln_client_id",
                keyValue: 1,
                columns: new[] { "cln_client_created", "cln_client_updated", "cln_client_user_id" },
                values: new object[] { new DateTime(2019, 4, 30, 11, 33, 33, 963, DateTimeKind.Utc).AddTicks(9861), new DateTime(2019, 4, 30, 11, 33, 33, 963, DateTimeKind.Utc).AddTicks(9861), "b53d6f8f-085b-4953-9394-759ce406c99d" });

            migrationBuilder.UpdateData(
                table: "tbl_countries",
                keyColumn: "cln_country_id",
                keyValue: 1,
                columns: new[] { "cln_country_created", "cln_country_updated" },
                values: new object[] { new DateTime(2019, 4, 30, 11, 33, 33, 963, DateTimeKind.Utc).AddTicks(9861), new DateTime(2019, 4, 30, 11, 33, 33, 963, DateTimeKind.Utc).AddTicks(9861) });

            migrationBuilder.UpdateData(
                table: "tbl_countries",
                keyColumn: "cln_country_id",
                keyValue: 2,
                columns: new[] { "cln_country_created", "cln_country_updated" },
                values: new object[] { new DateTime(2019, 4, 30, 11, 33, 33, 963, DateTimeKind.Utc).AddTicks(9861), new DateTime(2019, 4, 30, 11, 33, 33, 963, DateTimeKind.Utc).AddTicks(9861) });

            migrationBuilder.UpdateData(
                table: "tbl_countries",
                keyColumn: "cln_country_id",
                keyValue: 3,
                columns: new[] { "cln_country_created", "cln_country_updated" },
                values: new object[] { new DateTime(2019, 4, 30, 11, 33, 33, 963, DateTimeKind.Utc).AddTicks(9861), new DateTime(2019, 4, 30, 11, 33, 33, 963, DateTimeKind.Utc).AddTicks(9861) });

            migrationBuilder.UpdateData(
                table: "tbl_flights",
                keyColumn: "cln_flight_id",
                keyValue: 1,
                columns: new[] { "cln_flight_arrive_time", "cln_flight_departure_time" },
                values: new object[] { new DateTime(2019, 4, 30, 18, 33, 33, 963, DateTimeKind.Utc).AddTicks(9861), new DateTime(2019, 4, 30, 11, 33, 33, 963, DateTimeKind.Utc).AddTicks(9861) });

            migrationBuilder.UpdateData(
                table: "tbl_flights",
                keyColumn: "cln_flight_id",
                keyValue: 2,
                columns: new[] { "cln_flight_arrive_time", "cln_flight_departure_time" },
                values: new object[] { new DateTime(2019, 4, 30, 13, 33, 33, 963, DateTimeKind.Utc).AddTicks(9861), new DateTime(2019, 4, 30, 11, 33, 33, 963, DateTimeKind.Utc).AddTicks(9861) });

            migrationBuilder.UpdateData(
                table: "tbl_flights",
                keyColumn: "cln_flight_id",
                keyValue: 3,
                columns: new[] { "cln_flight_arrive_time", "cln_flight_departure_time" },
                values: new object[] { new DateTime(2019, 4, 30, 17, 33, 33, 963, DateTimeKind.Utc).AddTicks(9861), new DateTime(2019, 4, 30, 11, 33, 33, 963, DateTimeKind.Utc).AddTicks(9861) });

            migrationBuilder.UpdateData(
                table: "tbl_flights",
                keyColumn: "cln_flight_id",
                keyValue: 4,
                columns: new[] { "cln_flight_arrive_time", "cln_flight_departure_time" },
                values: new object[] { new DateTime(2019, 4, 30, 18, 33, 33, 963, DateTimeKind.Utc).AddTicks(9861), new DateTime(2019, 5, 30, 11, 33, 33, 963, DateTimeKind.Utc).AddTicks(9861) });

            migrationBuilder.UpdateData(
                table: "tbl_flights",
                keyColumn: "cln_flight_id",
                keyValue: 5,
                columns: new[] { "cln_flight_arrive_time", "cln_flight_departure_time" },
                values: new object[] { new DateTime(2019, 6, 1, 11, 33, 33, 963, DateTimeKind.Utc).AddTicks(9861), new DateTime(2019, 5, 30, 11, 33, 33, 963, DateTimeKind.Utc).AddTicks(9861) });

            migrationBuilder.UpdateData(
                table: "tbl_flights",
                keyColumn: "cln_flight_id",
                keyValue: 6,
                columns: new[] { "cln_flight_arrive_time", "cln_flight_departure_time" },
                values: new object[] { new DateTime(2019, 5, 30, 17, 33, 33, 963, DateTimeKind.Utc).AddTicks(9861), new DateTime(2019, 5, 30, 11, 33, 33, 963, DateTimeKind.Utc).AddTicks(9861) });

            migrationBuilder.UpdateData(
                table: "tbl_flights",
                keyColumn: "cln_flight_id",
                keyValue: 7,
                columns: new[] { "cln_flight_arrive_time", "cln_flight_departure_time" },
                values: new object[] { new DateTime(2019, 6, 30, 17, 33, 33, 963, DateTimeKind.Utc).AddTicks(9861), new DateTime(2019, 5, 30, 11, 33, 33, 963, DateTimeKind.Utc).AddTicks(9861) });

            migrationBuilder.UpdateData(
                table: "tbl_flights",
                keyColumn: "cln_flight_id",
                keyValue: 8,
                columns: new[] { "cln_flight_arrive_time", "cln_flight_departure_time" },
                values: new object[] { new DateTime(2019, 7, 30, 17, 33, 33, 963, DateTimeKind.Utc).AddTicks(9861), new DateTime(2019, 5, 30, 11, 33, 33, 963, DateTimeKind.Utc).AddTicks(9861) });

            migrationBuilder.UpdateData(
                table: "tbl_tickets",
                keyColumn: "cln_ticket_id",
                keyValue: 1,
                column: "cln_ticket_created",
                value: new DateTime(2019, 4, 30, 11, 33, 33, 963, DateTimeKind.Utc).AddTicks(9861));

            migrationBuilder.UpdateData(
                table: "tbl_tickets",
                keyColumn: "cln_ticket_id",
                keyValue: 2,
                column: "cln_ticket_created",
                value: new DateTime(2019, 4, 30, 11, 33, 33, 963, DateTimeKind.Utc).AddTicks(9861));

            migrationBuilder.UpdateData(
                table: "tbl_tickets",
                keyColumn: "cln_ticket_id",
                keyValue: 3,
                column: "cln_ticket_created",
                value: new DateTime(2019, 4, 30, 11, 33, 33, 963, DateTimeKind.Utc).AddTicks(9861));
        }
    }
}
