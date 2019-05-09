using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OlympicFlights.Service.FlightManagement
{
    public interface IFlightService
    {
        Task<IEnumerable<Flight>> GetFlightsAsync();

        Task<Flight> GetFlightByIdAsync(int flightId);

        Task<Flight> CreateFlightAsync(UpdateFlightRequest flight);

        Task<Flight> RemoveFlightByIdAsync(int flightId);

        Task<Flight> UpdateFlightByIdAsync(int flightId, UpdateFlightRequest flight);
    }
}
