using Microsoft.EntityFrameworkCore;
using OlympicFlights.DataAccess.AccountManagement;
using OlympicFlights.DataAccess.AirplaneManagement;
using OlympicFlights.DataAccess.AirplaneTypeManagement;
using OlympicFlights.DataAccess.AirportManagement;
using OlympicFlights.DataAccess.ClientManagement;
using OlympicFlights.DataAccess.CountryManagement;
using OlympicFlights.DataAccess.FlightManagement;
using OlympicFlights.DataAccess.TicketManagement;
using System;
using System.Linq;

namespace OlympicFlights.DataAccess.ConsoleTests
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var dbContext = new ApplicationDbContext()) {
                var _ctx = new CountryContext(new ApplicationDbContext());

                var countries = _ctx.Countries.Include(cntr => cntr.Cities).ToList();

                foreach (var country in countries)
                {
                    Console.WriteLine($"COUNTRY : ID : {country.CountryId} - NAME : {country.CountryName}");

                    foreach (var city in country.Cities)
                    {
                        Console.WriteLine($" ---- CITY : ID : {city.CityId} - NAME : {city.CityName}");
                    }
                }

                var _accCtx = new AccountContext(dbContext);
                var _clientCtx = new ClientContext(dbContext);


                var accounts = _accCtx.Accounts.Include(acc => acc.Client).ToList();
                var clients = _clientCtx.Clients.Include(cl => cl.Accounts).ToList();

                Console.WriteLine(">>>>>>>>>>>>>>>>ACCOUNTS<<<<<<<<<<<<<<<<<<<<<");

                accounts.ForEach(acc =>
                   {
                       Console.WriteLine($" ACCOUNT : ID {acc.AccountID}, LOGIN {acc.AccountLogin}, PASSWORD {acc.AccountPassword}, ROLE {acc.Role} " +
                           $" CREATED : {acc.Created.ToShortDateString()}, UPDATED {acc.Updated.ToShortDateString()}");

                       Console.WriteLine($" ---- CLIENT : ID {acc.ClientID}, NAME {acc.Client.ClientFirstname}, SURNAME {acc.Client.ClientLastname}, ADDRESS {acc.Client.ClientAddress}" +
                           $" CREATED : {acc.Client.Created.ToShortDateString()}, UPDATED {acc.Client.Updated.ToShortDateString()}");
                   });

                Console.WriteLine(">>>>>>>>>>>>>>>>CLIENTS<<<<<<<<<<<<<<<<<<<<<<<");

                clients.ForEach(cl =>
                {
                    Console.WriteLine($" CLIENT : ID {cl.ClientId}, NAME {cl.ClientFirstname}, SURNAME {cl.ClientLastname}, ADDRESS {cl.ClientAddress}" +
                           $" CREATED : {cl.Created.ToShortDateString()}, UPDATED {cl.Updated.ToShortDateString()}");

                    cl.Accounts.ToList().ForEach(acc =>
                   {
                       Console.WriteLine($" ---- ACCOUNT : ID {acc.AccountID}, LOGIN {acc.AccountLogin}, PASSWORD {acc.AccountPassword}, ROLE {acc.Role} " +
                          $" CREATED : {acc.Created.ToShortDateString()}, UPDATED {acc.Updated.ToShortDateString()}");
                   });
                });

                var _airportCtx = new AirportContext(dbContext);

                var airports = _airportCtx.Airports.Include(ap => ap.City).ToList();

                airports.ForEach(ap =>
                {
                    Console.WriteLine($"AIRPORT : ID {ap.AirportId}, CODE {ap.AirportCode}, NAME {ap.AirportName}" +
                        $" CREATED : {ap.Created.ToShortDateString()}, UPDATED {ap.Updated.ToShortDateString()}");

                    Console.WriteLine($" ---- CITY : ID : {ap.City.CityId} - NAME : {ap.City.CityName}");
                });

                var _airplaneCtx = new AirplaneContext(dbContext);

                var airplanes = _airplaneCtx.Airplanes.Include(apl => apl.Type).ToList();

                airplanes.ForEach(apl =>
                {
                    Console.WriteLine($"AIRPLANE : ID {apl.AirplaneId}, NUMBER {apl.AirplaneNumber} , EXISTS : {apl.IsDeleted}" +
                        $" CREATED : {apl.Created.ToShortDateString()}, UPDATED {apl.Updated.ToShortDateString()}");

                    Console.WriteLine($" ---- TYPE : ID : {apl.Type.AirplaneTypeId} - NAME : {apl.Type.AirplaneTypeName}" +
                        $"SITS COUNT : {apl.Type.AirplaneTypeSitsCount}, PRICE : {apl.Type.SitPriceInDollars}, BUSINESS : {apl.Type.HasBusinessClass}");
                });

                var _airplaneTypeCtx = new AirplaneTypeContext(dbContext);

                Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>TYPES <<<<<<<<<<<<<<<<<<<<<<<<<<<<< ");

                var _airplaneTypes = _airplaneTypeCtx.AirplaneTypes.Include(aplt => aplt.AirplanesOfCurrentType).ToList();

                _airplaneTypes.ForEach(aplt =>
                {
                    Console.WriteLine($" TYPE : ID : {aplt.AirplaneTypeId} - NAME : {aplt.AirplaneTypeName}" +
                       $"SITS COUNT : {aplt.AirplaneTypeSitsCount}, PRICE : {aplt.SitPriceInDollars}, BUSINESS : {aplt.HasBusinessClass}");

                    aplt.AirplanesOfCurrentType.ToList().ForEach(apl =>
                    {
                        Console.WriteLine($" ---- AIRPLANE : ID {apl.AirplaneId}, NUMBER {apl.AirplaneNumber} , EXISTS : {apl.IsDeleted}" +
                        $" CREATED : {apl.Created.ToShortDateString()}, UPDATED {apl.Updated.ToShortDateString()}");

                    });
                });

                var _flightCtx = new FlightContext(dbContext);

                var flights = _flightCtx.Flights.Include(fl => fl.Airplane).Include(fl => fl.Airports).ToList();

                Console.WriteLine(" >>>>>>>>>>>>>>>>>>>>>>>>FLIGHTS<<<<<<<<<<<<<<<<<<<<");

                Console.WriteLine("");
                Console.WriteLine("");

                foreach (var flight in flights)
                {
                    Console.WriteLine($"FLIGHT : ID {flight.FlightId} -  ARRIVE TIME {flight.ArriveTime.ToShortTimeString()} - DEPARTURE TIME {flight.DepartureTime.ToShortTimeString()} ");
                    Console.WriteLine("");
                    Console.WriteLine($" ---- AIRPLANE : ID {flight.Airplane.AirplaneId}, NUMBER {flight.Airplane.AirplaneNumber} , EXISTS : {flight.Airplane.IsDeleted}");

                    var arrive = flight.Airports.Where(ap => ap.IsArrive).ToArray()[0];
                    var departure = flight.Airports.Where(ap => !ap.IsArrive).ToArray()[0];

                    Console.WriteLine($"----- AIRPORTS----------");

                    Console.WriteLine("");

                    Console.WriteLine($"ARRIVE AIRPORT : ID {arrive.AirportID}, CODE {arrive.Airport.AirportCode}, NAME {arrive.Airport.AirportName}");
                    Console.WriteLine($" ---- CITY : ID : {arrive.Airport.City.CityID} - NAME : {arrive.Airport.City.CityName}");

                    Console.WriteLine("");

                    Console.WriteLine($"DEPARTURE AIRPORT : ID {departure.AirportID}, CODE {departure.Airport.AirportCode}, NAME {departure.Airport.AirportName}");
                    Console.WriteLine($" ---- CITY : ID : {departure.Airport.City.CityID} - NAME : {departure.Airport.City.CityName}");
                }

                var _ticketCtx = new TicketContext(dbContext);

                var tickets = _ticketCtx.Tickets.Include(t => t.Client).Include(t => t.Flight).ToList();

                tickets.ForEach(t =>
               {
                   Console.WriteLine($" ID : {t.TicketID} - CLIENT NAME : {t.Client.ClientFirstname + t.Client.ClientLastname} " +
                       $"- DEPARTURE CITY : {t.Flight.Airports.Where(ap => !ap.IsArrive).ToArray()[0].Airport.City.CityName}" +
                       $"- ARRIVE CITY {t.Flight.Airports.Where(ap => ap.IsArrive).ToArray()[0].Airport.City.CityName}");
               });


            }
        }

    }
}
