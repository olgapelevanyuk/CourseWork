﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OlympicFlights.DataAccess;

namespace OlympicFlights.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20190421185908_FixTicketsAndClients")]
    partial class FixTicketsAndClients
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OlympicFlights.DataAccess.AirportManagement.Airport", b =>
                {
                    b.Property<int>("AirportId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("cln_airport_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AirportCode")
                        .IsRequired()
                        .HasColumnName("cln_airport_code");

                    b.Property<string>("AirportName")
                        .IsRequired()
                        .HasColumnName("cln_airport_name");

                    b.Property<int>("CityId")
                        .HasColumnName("cln_airport_city_id");

                    b.Property<DateTime>("Created")
                        .HasColumnName("cln_airport_created");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("cln_airport_is_deleted")
                        .HasDefaultValue(false);

                    b.Property<DateTime>("Updated")
                        .HasColumnName("cln_airport_updated");

                    b.HasKey("AirportId");

                    b.HasIndex("CityId");

                    b.HasIndex("AirportCode", "AirportName");

                    b.ToTable("tbl_airports");

                    b.HasData(
                        new
                        {
                            AirportId = 1,
                            AirportCode = "JFK",
                            AirportName = "Johne's F.Cannady",
                            CityId = 3,
                            Created = new DateTime(2019, 4, 21, 18, 59, 6, 954, DateTimeKind.Utc).AddTicks(9217),
                            IsDeleted = false,
                            Updated = new DateTime(2019, 4, 21, 18, 59, 6, 954, DateTimeKind.Utc).AddTicks(9217)
                        },
                        new
                        {
                            AirportId = 2,
                            AirportCode = "NLIA",
                            AirportName = "Newark Liberty International Airport",
                            CityId = 3,
                            Created = new DateTime(2019, 4, 21, 18, 59, 6, 954, DateTimeKind.Utc).AddTicks(9217),
                            IsDeleted = false,
                            Updated = new DateTime(2019, 4, 21, 18, 59, 6, 954, DateTimeKind.Utc).AddTicks(9217)
                        },
                        new
                        {
                            AirportId = 3,
                            AirportCode = "La-G",
                            AirportName = "La Guardia",
                            CityId = 3,
                            Created = new DateTime(2019, 4, 21, 18, 59, 6, 954, DateTimeKind.Utc).AddTicks(9217),
                            IsDeleted = false,
                            Updated = new DateTime(2019, 4, 21, 18, 59, 6, 954, DateTimeKind.Utc).AddTicks(9217)
                        },
                        new
                        {
                            AirportId = 4,
                            AirportCode = "I-AM",
                            AirportName = "International Airport Minsk",
                            CityId = 2,
                            Created = new DateTime(2019, 4, 21, 18, 59, 6, 954, DateTimeKind.Utc).AddTicks(9217),
                            IsDeleted = false,
                            Updated = new DateTime(2019, 4, 21, 18, 59, 6, 954, DateTimeKind.Utc).AddTicks(9217)
                        },
                        new
                        {
                            AirportId = 5,
                            AirportCode = "AM-1",
                            AirportName = "Airport Minsk - 1",
                            CityId = 2,
                            Created = new DateTime(2019, 4, 21, 18, 59, 6, 954, DateTimeKind.Utc).AddTicks(9217),
                            IsDeleted = false,
                            Updated = new DateTime(2019, 4, 21, 18, 59, 6, 954, DateTimeKind.Utc).AddTicks(9217)
                        },
                        new
                        {
                            AirportId = 6,
                            AirportCode = "AV",
                            AirportName = "Airport Vnukova",
                            CityId = 1,
                            Created = new DateTime(2019, 4, 21, 18, 59, 6, 954, DateTimeKind.Utc).AddTicks(9217),
                            IsDeleted = false,
                            Updated = new DateTime(2019, 4, 21, 18, 59, 6, 954, DateTimeKind.Utc).AddTicks(9217)
                        },
                        new
                        {
                            AirportId = 7,
                            AirportCode = "AD",
                            AirportName = "Airport Domodedova",
                            CityId = 1,
                            Created = new DateTime(2019, 4, 21, 18, 59, 6, 954, DateTimeKind.Utc).AddTicks(9217),
                            IsDeleted = false,
                            Updated = new DateTime(2019, 4, 21, 18, 59, 6, 954, DateTimeKind.Utc).AddTicks(9217)
                        },
                        new
                        {
                            AirportId = 8,
                            AirportCode = "AS",
                            AirportName = "Airport Sheremetieva",
                            CityId = 1,
                            Created = new DateTime(2019, 4, 21, 18, 59, 6, 954, DateTimeKind.Utc).AddTicks(9217),
                            IsDeleted = false,
                            Updated = new DateTime(2019, 4, 21, 18, 59, 6, 954, DateTimeKind.Utc).AddTicks(9217)
                        },
                        new
                        {
                            AirportId = 9,
                            AirportCode = "AGH",
                            AirportName = "Airport Ghukova",
                            CityId = 1,
                            Created = new DateTime(2019, 4, 21, 18, 59, 6, 954, DateTimeKind.Utc).AddTicks(9217),
                            IsDeleted = false,
                            Updated = new DateTime(2019, 4, 21, 18, 59, 6, 954, DateTimeKind.Utc).AddTicks(9217)
                        });
                });

            modelBuilder.Entity("OlympicFlights.DataAccess.CityManagement.City", b =>
                {
                    b.Property<int>("CityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("cln_city_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CityName")
                        .HasColumnName("cln_city_name");

                    b.Property<int>("CountryId")
                        .HasColumnName("cln_city_country_id");

                    b.Property<DateTime>("Created")
                        .HasColumnName("cln_city_created");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime>("Updated")
                        .HasColumnName("cln_city_updated");

                    b.HasKey("CityId");

                    b.HasIndex("CountryId");

                    b.ToTable("tbl_cities");

                    b.HasData(
                        new
                        {
                            CityId = 1,
                            CityName = "Moscow",
                            CountryId = 2,
                            Created = new DateTime(2019, 4, 21, 18, 59, 6, 954, DateTimeKind.Utc).AddTicks(9217),
                            IsDeleted = false,
                            Updated = new DateTime(2019, 4, 21, 18, 59, 6, 954, DateTimeKind.Utc).AddTicks(9217)
                        },
                        new
                        {
                            CityId = 2,
                            CityName = "Minsk",
                            CountryId = 1,
                            Created = new DateTime(2019, 4, 21, 18, 59, 6, 954, DateTimeKind.Utc).AddTicks(9217),
                            IsDeleted = false,
                            Updated = new DateTime(2019, 4, 21, 18, 59, 6, 954, DateTimeKind.Utc).AddTicks(9217)
                        },
                        new
                        {
                            CityId = 3,
                            CityName = "New York",
                            CountryId = 3,
                            Created = new DateTime(2019, 4, 21, 18, 59, 6, 954, DateTimeKind.Utc).AddTicks(9217),
                            IsDeleted = false,
                            Updated = new DateTime(2019, 4, 21, 18, 59, 6, 954, DateTimeKind.Utc).AddTicks(9217)
                        });
                });

            modelBuilder.Entity("OlympicFlights.DataAccess.ClientManagement.Client", b =>
                {
                    b.Property<int>("ClientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("cln_client_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClientAddress")
                        .IsRequired()
                        .HasColumnName("cln_client_address")
                        .HasMaxLength(255);

                    b.Property<string>("ClientFirstname")
                        .IsRequired()
                        .HasColumnName("cln_client_first_name")
                        .HasMaxLength(30);

                    b.Property<string>("ClientLastname")
                        .IsRequired()
                        .HasColumnName("cln_client_last_name")
                        .HasMaxLength(30);

                    b.Property<DateTime>("Created")
                        .HasColumnName("cln_client_created");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("cln_client_is_deleted")
                        .HasDefaultValue(false);

                    b.Property<DateTime>("Updated")
                        .HasColumnName("cln_client_updated");

                    b.Property<string>("UserId")
                        .HasColumnName("cln_client_user_id");

                    b.HasKey("ClientId");

                    b.ToTable("tbl_clients");

                    b.HasData(
                        new
                        {
                            ClientId = 1,
                            ClientAddress = "TestAddress",
                            ClientFirstname = "TestFirstName",
                            ClientLastname = "TestLastName",
                            Created = new DateTime(2019, 4, 21, 18, 59, 6, 954, DateTimeKind.Utc).AddTicks(9217),
                            IsDeleted = false,
                            Updated = new DateTime(2019, 4, 21, 18, 59, 6, 954, DateTimeKind.Utc).AddTicks(9217),
                            UserId = "b53d6f8f-085b-4953-9394-759ce406c99d"
                        });
                });

            modelBuilder.Entity("OlympicFlights.DataAccess.CountryManagement.Country", b =>
                {
                    b.Property<int>("CountryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("cln_country_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CountryName")
                        .HasColumnName("cln_country_name");

                    b.Property<DateTime>("Created")
                        .HasColumnName("cln_country_created");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("cln_country_is_deleted")
                        .HasDefaultValue(false);

                    b.Property<DateTime>("Updated")
                        .HasColumnName("cln_country_updated");

                    b.HasKey("CountryId");

                    b.HasIndex("CountryName");

                    b.ToTable("tbl_countries");

                    b.HasData(
                        new
                        {
                            CountryId = 1,
                            CountryName = "Belarus",
                            Created = new DateTime(2019, 4, 21, 18, 59, 6, 954, DateTimeKind.Utc).AddTicks(9217),
                            IsDeleted = false,
                            Updated = new DateTime(2019, 4, 21, 18, 59, 6, 954, DateTimeKind.Utc).AddTicks(9217)
                        },
                        new
                        {
                            CountryId = 2,
                            CountryName = "Russia",
                            Created = new DateTime(2019, 4, 21, 18, 59, 6, 954, DateTimeKind.Utc).AddTicks(9217),
                            IsDeleted = false,
                            Updated = new DateTime(2019, 4, 21, 18, 59, 6, 954, DateTimeKind.Utc).AddTicks(9217)
                        },
                        new
                        {
                            CountryId = 3,
                            CountryName = "United States of America",
                            Created = new DateTime(2019, 4, 21, 18, 59, 6, 954, DateTimeKind.Utc).AddTicks(9217),
                            IsDeleted = false,
                            Updated = new DateTime(2019, 4, 21, 18, 59, 6, 954, DateTimeKind.Utc).AddTicks(9217)
                        });
                });

            modelBuilder.Entity("OlympicFlights.DataAccess.FlightAirportManagement.FlightAirports", b =>
                {
                    b.Property<int>("FlightAirportsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("cln_flight_airport_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AirportId")
                        .HasColumnName("cln_flight_aiport_airport_id");

                    b.Property<int>("FlightId")
                        .HasColumnName("cln_flight_aiport_flight_id");

                    b.Property<bool>("IsArrive")
                        .HasColumnName("cln_flight_airport_is_arrive");

                    b.HasKey("FlightAirportsId");

                    b.HasIndex("AirportId");

                    b.HasIndex("FlightId");

                    b.ToTable("tbl_flight_airports");

                    b.HasData(
                        new
                        {
                            FlightAirportsId = 1,
                            AirportId = 3,
                            FlightId = 1,
                            IsArrive = true
                        },
                        new
                        {
                            FlightAirportsId = 2,
                            AirportId = 5,
                            FlightId = 1,
                            IsArrive = false
                        },
                        new
                        {
                            FlightAirportsId = 3,
                            AirportId = 4,
                            FlightId = 2,
                            IsArrive = false
                        },
                        new
                        {
                            FlightAirportsId = 4,
                            AirportId = 6,
                            FlightId = 2,
                            IsArrive = true
                        },
                        new
                        {
                            FlightAirportsId = 5,
                            AirportId = 2,
                            FlightId = 3,
                            IsArrive = true
                        },
                        new
                        {
                            FlightAirportsId = 6,
                            AirportId = 7,
                            FlightId = 3,
                            IsArrive = false
                        });
                });

            modelBuilder.Entity("OlympicFlights.DataAccess.FlightManagement.Flight", b =>
                {
                    b.Property<int>("FlightId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("cln_flight_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ArriveTime")
                        .HasColumnName("cln_flight_arrive_time");

                    b.Property<DateTime>("DepartureTime")
                        .HasColumnName("cln_flight_departure_time");

                    b.Property<decimal>("FlightPrice");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("cln_flight_is_deleted")
                        .HasDefaultValue(false);

                    b.HasKey("FlightId");

                    b.ToTable("tbl_flights");

                    b.HasData(
                        new
                        {
                            FlightId = 1,
                            ArriveTime = new DateTime(2019, 4, 22, 1, 59, 6, 954, DateTimeKind.Utc).AddTicks(9217),
                            DepartureTime = new DateTime(2019, 4, 21, 18, 59, 6, 954, DateTimeKind.Utc).AddTicks(9217),
                            FlightPrice = 300m,
                            IsDeleted = false
                        },
                        new
                        {
                            FlightId = 2,
                            ArriveTime = new DateTime(2019, 4, 21, 20, 59, 6, 954, DateTimeKind.Utc).AddTicks(9217),
                            DepartureTime = new DateTime(2019, 4, 21, 18, 59, 6, 954, DateTimeKind.Utc).AddTicks(9217),
                            FlightPrice = 400m,
                            IsDeleted = false
                        },
                        new
                        {
                            FlightId = 3,
                            ArriveTime = new DateTime(2019, 4, 22, 0, 59, 6, 954, DateTimeKind.Utc).AddTicks(9217),
                            DepartureTime = new DateTime(2019, 4, 21, 18, 59, 6, 954, DateTimeKind.Utc).AddTicks(9217),
                            FlightPrice = 500m,
                            IsDeleted = false
                        });
                });

            modelBuilder.Entity("OlympicFlights.DataAccess.TicketManagement.Ticket", b =>
                {
                    b.Property<int>("TicketId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("cln_ticket_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClientId")
                        .HasColumnName("cln_ticket_client_id");

                    b.Property<DateTime>("Created")
                        .HasColumnName("cln_ticket_created");

                    b.Property<int>("FlightId")
                        .HasColumnName("cln_ticket_flight_id");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("cln_ticket_is_deleted")
                        .HasDefaultValue(false);

                    b.Property<bool>("IsPurchaseApproved")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("cln_ticket_is_purchase_approved")
                        .HasDefaultValue(false);

                    b.HasKey("TicketId");

                    b.HasIndex("ClientId");

                    b.HasIndex("FlightId");

                    b.ToTable("tbl_tickets");

                    b.HasData(
                        new
                        {
                            TicketId = 1,
                            ClientId = 1,
                            Created = new DateTime(2019, 4, 21, 18, 59, 6, 954, DateTimeKind.Utc).AddTicks(9217),
                            FlightId = 1,
                            IsDeleted = false,
                            IsPurchaseApproved = false
                        },
                        new
                        {
                            TicketId = 2,
                            ClientId = 1,
                            Created = new DateTime(2019, 4, 21, 18, 59, 6, 954, DateTimeKind.Utc).AddTicks(9217),
                            FlightId = 2,
                            IsDeleted = false,
                            IsPurchaseApproved = false
                        },
                        new
                        {
                            TicketId = 3,
                            ClientId = 1,
                            Created = new DateTime(2019, 4, 21, 18, 59, 6, 954, DateTimeKind.Utc).AddTicks(9217),
                            FlightId = 3,
                            IsDeleted = false,
                            IsPurchaseApproved = false
                        });
                });

            modelBuilder.Entity("OlympicFlights.DataAccess.AirportManagement.Airport", b =>
                {
                    b.HasOne("OlympicFlights.DataAccess.CityManagement.City", "City")
                        .WithMany("Airports")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OlympicFlights.DataAccess.CityManagement.City", b =>
                {
                    b.HasOne("OlympicFlights.DataAccess.CountryManagement.Country", "Country")
                        .WithMany("Cities")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OlympicFlights.DataAccess.FlightAirportManagement.FlightAirports", b =>
                {
                    b.HasOne("OlympicFlights.DataAccess.AirportManagement.Airport", "Airport")
                        .WithMany("Flights")
                        .HasForeignKey("AirportId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OlympicFlights.DataAccess.FlightManagement.Flight", "Flight")
                        .WithMany("Airports")
                        .HasForeignKey("FlightId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OlympicFlights.DataAccess.TicketManagement.Ticket", b =>
                {
                    b.HasOne("OlympicFlights.DataAccess.ClientManagement.Client", "Client")
                        .WithMany("Tickets")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OlympicFlights.DataAccess.FlightManagement.Flight", "Flight")
                        .WithMany("Tickets")
                        .HasForeignKey("FlightId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
