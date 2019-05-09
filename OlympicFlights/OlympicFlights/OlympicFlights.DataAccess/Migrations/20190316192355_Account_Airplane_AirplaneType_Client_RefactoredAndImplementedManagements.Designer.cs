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
    [Migration("20190316192355_Account_Airplane_AirplaneType_Client_RefactoredAndImplementedManagements")]
    partial class Account_Airplane_AirplaneType_Client_RefactoredAndImplementedManagements
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OlympicFlights.DataAccess.AccountManagement.Account", b =>
                {
                    b.Property<int>("AccountID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("cln_account_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AccountLogin")
                        .IsRequired()
                        .HasColumnName("cln_account_login")
                        .HasMaxLength(255);

                    b.Property<string>("AccountPassword")
                        .IsRequired()
                        .HasColumnName("cln_account_password")
                        .HasMaxLength(255);

                    b.Property<int>("ClientID")
                        .HasColumnName("cln_account_client_id");

                    b.Property<DateTime>("Created")
                        .HasColumnName("cln_account_created");

                    b.Property<bool>("Role")
                        .HasColumnName("cnl_account_role");

                    b.Property<DateTime>("Updated")
                        .HasColumnName("cln_account_updated");

                    b.HasKey("AccountID");

                    b.HasIndex("ClientID");

                    b.HasIndex("AccountLogin", "AccountPassword");

                    b.ToTable("tbl_accounts");

                    b.HasData(
                        new
                        {
                            AccountID = 1,
                            AccountLogin = "48red",
                            AccountPassword = "Ar555321",
                            ClientID = 1,
                            Created = new DateTime(2019, 3, 16, 19, 23, 54, 913, DateTimeKind.Utc).AddTicks(9364),
                            Role = true,
                            Updated = new DateTime(2019, 3, 16, 19, 23, 54, 913, DateTimeKind.Utc).AddTicks(9364)
                        },
                        new
                        {
                            AccountID = 2,
                            AccountLogin = "simf11422",
                            AccountPassword = "Ar555321",
                            ClientID = 1,
                            Created = new DateTime(2019, 3, 16, 19, 23, 54, 913, DateTimeKind.Utc).AddTicks(9364),
                            Role = false,
                            Updated = new DateTime(2019, 3, 16, 19, 23, 54, 913, DateTimeKind.Utc).AddTicks(9364)
                        });
                });

            modelBuilder.Entity("OlympicFlights.DataAccess.AirplaneManagement.Airplane", b =>
                {
                    b.Property<int>("AirplaneID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("cln_airplane_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AirplaneNumber")
                        .HasColumnName("cln_airplane_number");

                    b.Property<int>("AirplaneTypeID")
                        .HasColumnName("cln_airplane_type_id");

                    b.Property<DateTime>("Created")
                        .HasColumnName("cln_airplane_created");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime>("Updated")
                        .HasColumnName("cln_airplane_updated");

                    b.HasKey("AirplaneID");

                    b.HasIndex("AirplaneNumber");

                    b.HasIndex("AirplaneTypeID");

                    b.ToTable("tbl_airplanes");

                    b.HasData(
                        new
                        {
                            AirplaneID = 1,
                            AirplaneNumber = 1001,
                            AirplaneTypeID = 1,
                            Created = new DateTime(2019, 3, 16, 19, 23, 54, 913, DateTimeKind.Utc).AddTicks(9364),
                            IsDeleted = false,
                            Updated = new DateTime(2019, 3, 16, 19, 23, 54, 913, DateTimeKind.Utc).AddTicks(9364)
                        },
                        new
                        {
                            AirplaneID = 2,
                            AirplaneNumber = 2001,
                            AirplaneTypeID = 2,
                            Created = new DateTime(2019, 3, 16, 19, 23, 54, 913, DateTimeKind.Utc).AddTicks(9364),
                            IsDeleted = false,
                            Updated = new DateTime(2019, 3, 16, 19, 23, 54, 913, DateTimeKind.Utc).AddTicks(9364)
                        },
                        new
                        {
                            AirplaneID = 3,
                            AirplaneNumber = 3001,
                            AirplaneTypeID = 3,
                            Created = new DateTime(2019, 3, 16, 19, 23, 54, 913, DateTimeKind.Utc).AddTicks(9364),
                            IsDeleted = false,
                            Updated = new DateTime(2019, 3, 16, 19, 23, 54, 913, DateTimeKind.Utc).AddTicks(9364)
                        },
                        new
                        {
                            AirplaneID = 4,
                            AirplaneNumber = 2002,
                            AirplaneTypeID = 2,
                            Created = new DateTime(2019, 3, 16, 19, 23, 54, 913, DateTimeKind.Utc).AddTicks(9364),
                            IsDeleted = false,
                            Updated = new DateTime(2019, 3, 16, 19, 23, 54, 913, DateTimeKind.Utc).AddTicks(9364)
                        });
                });

            modelBuilder.Entity("OlympicFlights.DataAccess.AirplaneTypeManagement.AirplaneType", b =>
                {
                    b.Property<int>("AiplaneTypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("cln_airplane_type_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AirplaneTypeName")
                        .IsRequired()
                        .HasColumnName("cln_airplane_type_name");

                    b.Property<int>("AirplaneTypeSitsCount")
                        .HasColumnName("cln_airplane_type_sits_count");

                    b.Property<bool>("HasBusinessClass")
                        .HasColumnName("cln_airplane_type_has_business_class");

                    b.Property<decimal>("SitPriceInDollars")
                        .HasColumnName("cln_airplane_type_sit_price");

                    b.HasKey("AiplaneTypeID");

                    b.ToTable("tbl_airplane_types");

                    b.HasData(
                        new
                        {
                            AiplaneTypeID = 1,
                            AirplaneTypeName = "Airbus-A310",
                            AirplaneTypeSitsCount = 183,
                            HasBusinessClass = false,
                            SitPriceInDollars = 200m
                        },
                        new
                        {
                            AiplaneTypeID = 2,
                            AirplaneTypeName = "IL-96M",
                            AirplaneTypeSitsCount = 318,
                            HasBusinessClass = true,
                            SitPriceInDollars = 250m
                        },
                        new
                        {
                            AiplaneTypeID = 3,
                            AirplaneTypeName = "Boeing-737",
                            AirplaneTypeSitsCount = 192,
                            HasBusinessClass = true,
                            SitPriceInDollars = 300m
                        });
                });

            modelBuilder.Entity("OlympicFlights.DataAccess.AirportManagement.Airport", b =>
                {
                    b.Property<int>("AirportID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("cln_airport_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AirportCode")
                        .IsRequired()
                        .HasColumnName("cln_airport_code");

                    b.Property<string>("AirportName")
                        .IsRequired()
                        .HasColumnName("cln_airport_name");

                    b.Property<int>("CityID")
                        .HasColumnName("cln_airport_city_id");

                    b.Property<DateTime>("Created")
                        .HasColumnName("cln_airport_created");

                    b.Property<DateTime>("Updated")
                        .HasColumnName("cln_airport_updated");

                    b.HasKey("AirportID");

                    b.HasIndex("CityID");

                    b.HasIndex("AirportCode", "AirportName");

                    b.ToTable("tbl_airports");

                    b.HasData(
                        new
                        {
                            AirportID = 1,
                            AirportCode = "JFK",
                            AirportName = "Johne's F.Cannady",
                            CityID = 3,
                            Created = new DateTime(2019, 3, 16, 19, 23, 54, 913, DateTimeKind.Utc).AddTicks(9364),
                            Updated = new DateTime(2019, 3, 16, 19, 23, 54, 913, DateTimeKind.Utc).AddTicks(9364)
                        },
                        new
                        {
                            AirportID = 2,
                            AirportCode = "NLIA",
                            AirportName = "Newark Liberty International Airport",
                            CityID = 3,
                            Created = new DateTime(2019, 3, 16, 19, 23, 54, 913, DateTimeKind.Utc).AddTicks(9364),
                            Updated = new DateTime(2019, 3, 16, 19, 23, 54, 913, DateTimeKind.Utc).AddTicks(9364)
                        },
                        new
                        {
                            AirportID = 3,
                            AirportCode = "La-G",
                            AirportName = "La Guardia",
                            CityID = 3,
                            Created = new DateTime(2019, 3, 16, 19, 23, 54, 913, DateTimeKind.Utc).AddTicks(9364),
                            Updated = new DateTime(2019, 3, 16, 19, 23, 54, 913, DateTimeKind.Utc).AddTicks(9364)
                        },
                        new
                        {
                            AirportID = 4,
                            AirportCode = "I-AM",
                            AirportName = "International Airport Minsk",
                            CityID = 2,
                            Created = new DateTime(2019, 3, 16, 19, 23, 54, 913, DateTimeKind.Utc).AddTicks(9364),
                            Updated = new DateTime(2019, 3, 16, 19, 23, 54, 913, DateTimeKind.Utc).AddTicks(9364)
                        },
                        new
                        {
                            AirportID = 5,
                            AirportCode = "AM-1",
                            AirportName = "Airport Minsk - 1",
                            CityID = 2,
                            Created = new DateTime(2019, 3, 16, 19, 23, 54, 913, DateTimeKind.Utc).AddTicks(9364),
                            Updated = new DateTime(2019, 3, 16, 19, 23, 54, 913, DateTimeKind.Utc).AddTicks(9364)
                        },
                        new
                        {
                            AirportID = 6,
                            AirportCode = "AV",
                            AirportName = "Airport Vnukova",
                            CityID = 1,
                            Created = new DateTime(2019, 3, 16, 19, 23, 54, 913, DateTimeKind.Utc).AddTicks(9364),
                            Updated = new DateTime(2019, 3, 16, 19, 23, 54, 913, DateTimeKind.Utc).AddTicks(9364)
                        },
                        new
                        {
                            AirportID = 7,
                            AirportCode = "AD",
                            AirportName = "Airport Domodedova",
                            CityID = 1,
                            Created = new DateTime(2019, 3, 16, 19, 23, 54, 913, DateTimeKind.Utc).AddTicks(9364),
                            Updated = new DateTime(2019, 3, 16, 19, 23, 54, 913, DateTimeKind.Utc).AddTicks(9364)
                        },
                        new
                        {
                            AirportID = 8,
                            AirportCode = "AS",
                            AirportName = "Airport Sheremetieva",
                            CityID = 1,
                            Created = new DateTime(2019, 3, 16, 19, 23, 54, 913, DateTimeKind.Utc).AddTicks(9364),
                            Updated = new DateTime(2019, 3, 16, 19, 23, 54, 913, DateTimeKind.Utc).AddTicks(9364)
                        },
                        new
                        {
                            AirportID = 9,
                            AirportCode = "AGH",
                            AirportName = "Airport Ghukova",
                            CityID = 1,
                            Created = new DateTime(2019, 3, 16, 19, 23, 54, 913, DateTimeKind.Utc).AddTicks(9364),
                            Updated = new DateTime(2019, 3, 16, 19, 23, 54, 913, DateTimeKind.Utc).AddTicks(9364)
                        });
                });

            modelBuilder.Entity("OlympicFlights.DataAccess.CityManagement.City", b =>
                {
                    b.Property<int>("CityID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("cln_city_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CityName")
                        .HasColumnName("cln_city_name");

                    b.Property<int>("CountryID")
                        .HasColumnName("cln_city_country_id");

                    b.Property<DateTime>("Created")
                        .HasColumnName("cln_city_created");

                    b.Property<DateTime>("Updated")
                        .HasColumnName("cln_city_updated");

                    b.HasKey("CityID");

                    b.HasIndex("CountryID");

                    b.ToTable("tbl_cities");

                    b.HasData(
                        new
                        {
                            CityID = 1,
                            CityName = "Moscow",
                            CountryID = 2,
                            Created = new DateTime(2019, 3, 16, 19, 23, 54, 913, DateTimeKind.Utc).AddTicks(9364),
                            Updated = new DateTime(2019, 3, 16, 19, 23, 54, 913, DateTimeKind.Utc).AddTicks(9364)
                        },
                        new
                        {
                            CityID = 2,
                            CityName = "Minsk",
                            CountryID = 1,
                            Created = new DateTime(2019, 3, 16, 19, 23, 54, 913, DateTimeKind.Utc).AddTicks(9364),
                            Updated = new DateTime(2019, 3, 16, 19, 23, 54, 913, DateTimeKind.Utc).AddTicks(9364)
                        },
                        new
                        {
                            CityID = 3,
                            CityName = "New York",
                            CountryID = 3,
                            Created = new DateTime(2019, 3, 16, 19, 23, 54, 913, DateTimeKind.Utc).AddTicks(9364),
                            Updated = new DateTime(2019, 3, 16, 19, 23, 54, 913, DateTimeKind.Utc).AddTicks(9364)
                        });
                });

            modelBuilder.Entity("OlympicFlights.DataAccess.ClientManagement.Client", b =>
                {
                    b.Property<int>("ClientID")
                        .ValueGeneratedOnAdd()
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

                    b.HasKey("ClientID");

                    b.ToTable("tbl_clients");

                    b.HasData(
                        new
                        {
                            ClientID = 1,
                            ClientAddress = "Belarus,Brest,st.Suvorova,114,22",
                            ClientFirstname = "Artsiom",
                            ClientLastname = "Lyshchyk",
                            Created = new DateTime(2019, 3, 16, 19, 23, 54, 913, DateTimeKind.Utc).AddTicks(9364),
                            IsDeleted = false,
                            Updated = new DateTime(2019, 3, 16, 19, 23, 54, 913, DateTimeKind.Utc).AddTicks(9364)
                        });
                });

            modelBuilder.Entity("OlympicFlights.DataAccess.CountryManagement.Country", b =>
                {
                    b.Property<int>("CountryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("cln_country_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CountryName")
                        .HasColumnName("cln_country_name");

                    b.Property<DateTime>("Created")
                        .HasColumnName("cln_country_created");

                    b.Property<DateTime>("Updated")
                        .HasColumnName("cln_country_updated");

                    b.HasKey("CountryID");

                    b.HasIndex("CountryName");

                    b.ToTable("tbl_countries");

                    b.HasData(
                        new
                        {
                            CountryID = 1,
                            CountryName = "Belarus",
                            Created = new DateTime(2019, 3, 16, 19, 23, 54, 913, DateTimeKind.Utc).AddTicks(9364),
                            Updated = new DateTime(2019, 3, 16, 19, 23, 54, 913, DateTimeKind.Utc).AddTicks(9364)
                        },
                        new
                        {
                            CountryID = 2,
                            CountryName = "Russia",
                            Created = new DateTime(2019, 3, 16, 19, 23, 54, 913, DateTimeKind.Utc).AddTicks(9364),
                            Updated = new DateTime(2019, 3, 16, 19, 23, 54, 913, DateTimeKind.Utc).AddTicks(9364)
                        },
                        new
                        {
                            CountryID = 3,
                            CountryName = "United States of America",
                            Created = new DateTime(2019, 3, 16, 19, 23, 54, 913, DateTimeKind.Utc).AddTicks(9364),
                            Updated = new DateTime(2019, 3, 16, 19, 23, 54, 913, DateTimeKind.Utc).AddTicks(9364)
                        });
                });

            modelBuilder.Entity("OlympicFlights.DataAccess.AccountManagement.Account", b =>
                {
                    b.HasOne("OlympicFlights.DataAccess.ClientManagement.Client", "Client")
                        .WithMany("Accounts")
                        .HasForeignKey("ClientID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OlympicFlights.DataAccess.AirplaneManagement.Airplane", b =>
                {
                    b.HasOne("OlympicFlights.DataAccess.AirplaneTypeManagement.AirplaneType", "Type")
                        .WithMany("AirplanesOfCurrentType")
                        .HasForeignKey("AirplaneTypeID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OlympicFlights.DataAccess.AirportManagement.Airport", b =>
                {
                    b.HasOne("OlympicFlights.DataAccess.CityManagement.City", "City")
                        .WithMany("Airports")
                        .HasForeignKey("CityID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OlympicFlights.DataAccess.CityManagement.City", b =>
                {
                    b.HasOne("OlympicFlights.DataAccess.CountryManagement.Country", "Country")
                        .WithMany("Cities")
                        .HasForeignKey("CountryID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}