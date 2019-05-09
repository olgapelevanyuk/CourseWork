using Microsoft.EntityFrameworkCore;
using OlympicFlights.DataAccess.AirportManagement;
using OlympicFlights.DataAccess.CityManagement;
using OlympicFlights.DataAccess.ClientManagement;
using OlympicFlights.DataAccess.CountryManagement;
using OlympicFlights.DataAccess.FlightAirportManagement;
using OlympicFlights.DataAccess.FlightManagement;
using OlympicFlights.DataAccess.TicketManagement;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using OlympicFlights.DataAccess.UserManagement;

namespace OlympicFlights.DataAccess
{
    /// <summary>
    /// Represents an application database context.
    /// </summary>
    public sealed class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationDbContext"/> class.
        /// </summary>
        public ApplicationDbContext() : base()
        {

        }

        public DbSet<Country> Countries { get; set; }

        public DbSet<City> Cities { get; set; }

        public DbSet<Client> Clients { get; set; }

        public DbSet<Airport> Airports { get; set; }

        public DbSet<Flight> Flights { get; set; }

        public DbSet<FlightAirports> FlightAirports { get;set; }

        public DbSet<Ticket> Tickets { get; set; }

        public DbSet<ApplicationUser> AppUsers => this.Users;

        public DbSet<IdentityRole> AppUsersRoles => this.Roles;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=OlympicFlightsDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;");

            base.OnConfiguring(optionsBuilder);
        }

        /// <summary>
        /// Overrides base method.
        /// </summary>
        /// <param name="modelBuilder"><see cref="ModelBuilder"/>.</param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var utc = DateTime.UtcNow;

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            modelBuilder.Entity<Country>().HasData(new List<Country>
            {
                new Country
                {
                    CountryId = 1,
                    CountryName = "Belarus",
                    Created = utc,
                    Updated = utc
                },
                new Country
                {
                    CountryId = 2,
                    CountryName = "Russia",
                    Created = utc,
                    Updated = utc
                },
                new Country
                {
                    CountryId = 3,
                    CountryName = "United States of America",
                    Created = utc,
                    Updated = utc
                }
            });

            modelBuilder.Entity<City>().HasData(new List<City>
            {
                new City
                {
                    CityId = 1,
                    CityName = "Moscow",
                    CountryId = 2,
                    Created = utc,
                    Updated = utc
                },
                new City
                {
                    CityId = 2,
                    CityName = "Minsk",
                    CountryId = 1,
                    Created = utc,
                    Updated = utc
                },
                new City
                {
                    CityId = 3,
                    CityName = "New York",
                    CountryId = 3,
                    Created = utc,
                    Updated = utc
                }
            });

            modelBuilder.Entity<Airport>().HasData(new List<Airport>
            {
                new Airport
                {
                    AirportId = 1,
                    AirportCode = "JFK",
                    AirportName = "Johne's F.Cannady",
                    CityId = 3,
                    Created = utc,
                    Updated = utc
                },
                new Airport
                {
                    AirportId = 2,
                    AirportCode = "NLIA",
                    AirportName = "Newark Liberty International Airport",
                    CityId = 3,
                    Created = utc,
                    Updated = utc
                },
                new Airport
                {
                    AirportId = 3,
                    AirportCode = "La-G",
                    AirportName = "La Guardia",
                    CityId = 3,
                    Created = utc,
                    Updated = utc
                },
                new Airport
                {
                    AirportId = 4,
                    AirportCode = "I-AM",
                    AirportName = "International Airport Minsk",
                    CityId = 2,
                    Created = utc,
                    Updated = utc
                },
                new Airport
                {
                    AirportId = 5,
                    AirportCode = "AM-1",
                    AirportName = "Airport Minsk - 1",
                    CityId = 2,
                    Created = utc,
                    Updated = utc
                },
                new Airport
                {
                    AirportId = 6,
                    AirportCode = "AV",
                    AirportName = "Airport Vnukova",
                    CityId = 1,
                    Created = utc,
                    Updated = utc
                },
                new Airport
                {
                    AirportId = 7,
                    AirportCode = "AD",
                    AirportName = "Airport Domodedova",
                    CityId = 1,
                    Created = utc,
                    Updated = utc
                },
                new Airport
                {
                    AirportId = 8,
                    AirportCode = "AS",
                    AirportName = "Airport Sheremetieva",
                    CityId = 1,
                    Created = utc,
                    Updated = utc
                },
                new Airport
                {
                    AirportId = 9,
                    AirportCode = "AGH",
                    AirportName = "Airport Ghukova",
                    CityId = 1,
                    Created = utc,
                    Updated = utc
                }
            });

            modelBuilder.Entity<Flight>().HasData(new List<Flight>
            {
                new Flight
                {
                    FlightId = 1,
                    DepartureTime = utc,
                    ArriveTime = utc.AddHours(7),
                    FlightPrice = 300
                },
                new Flight
                {
                    FlightId = 2,
                    DepartureTime = utc,
                    ArriveTime = utc.AddHours(2),
                    FlightPrice = 400
                },
                new Flight
                {
                    FlightId = 3,
                    DepartureTime = utc,
                    ArriveTime = utc.AddHours(6),
                    FlightPrice = 500
                },
                new Flight
                {
                    FlightId = 4,
                    DepartureTime = utc.AddMonths(1),
                    ArriveTime = utc.AddHours(7),
                    FlightPrice = 300
                },
                new Flight
                {
                    FlightId = 5,
                    DepartureTime = utc.AddMonths(1),
                    ArriveTime = utc.AddMonths(1).AddDays(2),
                    FlightPrice = 400
                },
                new Flight
                {
                    FlightId = 6,
                    DepartureTime = utc.AddMonths(1),
                    ArriveTime = utc.AddMonths(1).AddHours(6),
                    FlightPrice = 500
                },
                new Flight
                {
                    FlightId = 7,
                    DepartureTime = utc.AddMonths(1),
                    ArriveTime = utc.AddMonths(2).AddHours(6),
                    FlightPrice = 500
                },
                new Flight
                {
                    FlightId = 8,
                    DepartureTime = utc.AddMonths(1),
                    ArriveTime = utc.AddMonths(3).AddHours(6),
                    FlightPrice = 500
                }
            });

            modelBuilder.Entity<FlightAirports>().HasData(new List<FlightAirports>
            {
                new FlightAirports
                {
                    FlightAirportsId = 1,
                    FlightId = 1,
                    AirportId = 3,
                    IsArrive = true
                },
                new FlightAirports
                {
                    FlightAirportsId = 2,
                    FlightId = 1,
                    AirportId = 5,
                    IsArrive = false
                },
                new FlightAirports
                {
                    FlightAirportsId = 3,
                    FlightId = 2,
                    AirportId = 4,
                    IsArrive = false
                },
                new FlightAirports
                {
                    FlightAirportsId = 4,
                    FlightId = 2,
                    AirportId = 6,
                    IsArrive = true
                },
                new FlightAirports
                {
                    FlightAirportsId = 5,
                    FlightId = 3,
                    AirportId = 2,
                    IsArrive = true
                },
                new FlightAirports
                {
                    FlightAirportsId = 6,
                    FlightId = 3,
                    AirportId = 7,
                    IsArrive = false
                },
                new FlightAirports
                {
                    FlightAirportsId = 7,
                    FlightId = 4,
                    AirportId = 3,
                    IsArrive = true
                },
                new FlightAirports
                {
                    FlightAirportsId = 8,
                    FlightId = 4,
                    AirportId = 5,
                    IsArrive = false
                },
                new FlightAirports
                {
                    FlightAirportsId = 9,
                    FlightId = 5,
                    AirportId = 4,
                    IsArrive = false
                },
                new FlightAirports
                {
                    FlightAirportsId = 10,
                    FlightId = 5,
                    AirportId = 6,
                    IsArrive = true
                },
                new FlightAirports
                {
                    FlightAirportsId = 11,
                    FlightId = 6,
                    AirportId = 2,
                    IsArrive = true
                },
                new FlightAirports
                {
                    FlightAirportsId = 12,
                    FlightId = 6,
                    AirportId = 7,
                    IsArrive = false
                },
                new FlightAirports
                {
                    FlightAirportsId = 13,
                    FlightId = 7,
                    AirportId = 2,
                    IsArrive = true
                },
                new FlightAirports
                {
                    FlightAirportsId = 14,
                    FlightId = 7,
                    AirportId = 7,
                    IsArrive = false
                },
                new FlightAirports
                {
                    FlightAirportsId = 15,
                    FlightId = 8,
                    AirportId = 2,
                    IsArrive = true
                },
                new FlightAirports
                {
                    FlightAirportsId = 16,
                    FlightId = 8,
                    AirportId = 7,
                    IsArrive = false
                }
            });

            modelBuilder.Entity<Client>().HasData(new List<Client>
            {
                new Client
                {
                    ClientId = 1,
                    ClientFirstname = "TestFirstName",
                    ClientAddress = "TestAddress",
                    ClientLastname = "TestLastName",
                    Created = utc,
                    Updated = utc
                }
            });

            modelBuilder.Entity<Ticket>().HasData(new List<Ticket>
            {
                new Ticket
                {
                    TicketId = 1,
                    FlightId = 1,
                    ClientId = 1,
                    Created = utc,
                    IsDeleted = false,
                    IsPurchaseApproved = false
                },
                new Ticket
                {
                    TicketId = 2,
                    FlightId = 2,
                    ClientId = 1,
                    Created = utc,
                    IsDeleted = false,
                    IsPurchaseApproved = false
                },
                new Ticket
                {
                    TicketId = 3,
                    FlightId = 3,
                    ClientId = 1,
                    Created = utc,
                    IsDeleted = false,
                    IsPurchaseApproved = false
                }
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
