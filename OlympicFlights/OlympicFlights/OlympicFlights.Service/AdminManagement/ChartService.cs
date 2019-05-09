using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using OlympicFlights.DataAccess;
using OlympicFlights.DataAccess.CityManagement;
using OlympicFlights.DataAccess.ClientManagement;
using OlympicFlights.DataAccess.CountryManagement;
using OlympicFlights.DataAccess.FlightAirportManagement;
using OlympicFlights.DataAccess.FlightManagement;
using OlympicFlights.DataAccess.TicketManagement;
using OlympicFlights.DataAccess.UserManagement;

namespace OlympicFlights.Service.AdminManagement
{
    public class ChartService
    {
        private readonly IClientContext _clientContext;
        private readonly IFlightContext _flightContext;
        private readonly IFlightAirportsContext _flightAirportsContext;
        private readonly ITicketContext _ticketContext;
        private readonly UserManager<ApplicationUser> _userContext;
        private readonly ICountryContext _countryContext;
        private readonly ICityContext _cityContext;

        public ChartService(IClientContext clientContext, IFlightContext flightContext, IFlightAirportsContext flightAirportsContext, ITicketContext ticketContext, UserManager<ApplicationUser> userContext, ICountryContext countryContext, ICityContext cityContext)
        {
            _clientContext = clientContext;
            _flightContext = flightContext;
            _flightAirportsContext = flightAirportsContext;
            _ticketContext = ticketContext;
            _userContext = userContext;
            _countryContext = countryContext;
            _cityContext = cityContext;
        }

        public async Task<ChartData[]> GetFlightsPerMonthData()
        {
            var flightsOfCurrentYear = await _flightContext.Flights.Where(fl => fl.ArriveTime.Year == DateTime.UtcNow.Year).ToListAsync();

            var grouppedFlights = flightsOfCurrentYear.GroupBy(fl => fl.ArriveTime.ToString("MMM"))
                .Select(gr => new {month = gr.Key, count = gr.Count()});

            return grouppedFlights.Select(gfl => new ChartData
            {
                ChartX = gfl.month,
                ChartY = gfl.count
            }).ToArray();
        }

        public async Task<ChartData[]> GetClientsPerMonthData()
        {
            var clientsOfCurrentYear = await _clientContext.Clients.Where(cl => cl.Created.Year == DateTime.UtcNow.Year).ToListAsync();

            var grouppedClients = clientsOfCurrentYear.GroupBy(cl => cl.Created.ToString("MMM"))
                .Select(gr => new { month = gr.Key, count = gr.Count() });

            return grouppedClients.Select(gcl => new ChartData
            {
                ChartX = gcl.month,
                ChartY = gcl.count
            }).ToArray();
        }

        public async Task<ChartData[]> GetTicketsPerMonthData()
        {
            var ticketsOfCurrentYear = await _ticketContext.Tickets.Where(t => t.Created.Year == DateTime.UtcNow.Year).ToListAsync();

            var grouppedTickets = ticketsOfCurrentYear.GroupBy(t => t.Created.ToString("MMM"))
                .Select(gr => new { month = gr.Key, count = gr.Count() });

            return grouppedTickets.Select(gt => new ChartData
            {
                ChartX = gt.month,
                ChartY = gt.count
            }).ToArray();
        }

        public async Task<object> GetOverallStatistics()
        {
            var overallUsers = (await _userContext.Users.ToListAsync()).Count();
            var overallClients = (await _clientContext.Clients.ToListAsync()).Count();
            var overallFlights = (await _flightContext.Flights.ToListAsync()).Count();
            var overallCountries = (await _countryContext.Countries.ToListAsync()).Count();
            var overallCities = (await _cityContext.Cities.ToListAsync()).Count();
            var overallProfit = (await _ticketContext.Tickets.Where(t => t.IsPurchaseApproved).ToListAsync()).Select(t => t.Flight.FlightPrice).Sum();
            var incomingProfit = (await _ticketContext.Tickets.ToListAsync()).Select(t => t.Flight.FlightPrice).Sum();

            return new
            {
                overallUsers,
                overallClients,
                overallFlights,
                overallCountries,
                overallCities,
                overallProfit,
                incomingProfit
            };
        }
    }
}
