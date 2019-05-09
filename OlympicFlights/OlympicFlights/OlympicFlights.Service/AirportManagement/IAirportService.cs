using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OlympicFlights.Service.AirportManagement
{
    public interface IAirportService
    {
        Task<IEnumerable<Airport>> GetAirportsAsync();

        Task<Airport> GetAirportByIdAsync(int airportId);

        Task<Airport> CreateAirportAsync(UpdateAirportRequest airport);

        Task<int> RemoveAirportByIdAsync(int airportId);

        Task<Airport> UpdateAirportByIdAsync(int airportId, UpdateAirportRequest airport);

        Task<IEnumerable<Airport>> GetAirportsByCityIdAsync(int cityId);
    }
}
