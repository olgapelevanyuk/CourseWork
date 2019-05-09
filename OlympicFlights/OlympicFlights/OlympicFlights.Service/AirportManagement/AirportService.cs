using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using OlympicFlights.DataAccess;
using OlympicFlights.DataAccess.AirportManagement;
using AirportDb = OlympicFlights.DataAccess.AirportManagement.Airport;

namespace OlympicFlights.Service.AirportManagement
{
    public sealed class AirportService : IAirportService
    {
        private readonly IAirportContext _apCntx;
        private readonly IMapper _mapper;

        public AirportService(IAirportContext apCntx, IMapper mapper)
        {
            _apCntx = apCntx ?? throw new ArgumentNullException(nameof(apCntx));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<Airport> CreateAirportAsync(UpdateAirportRequest airport)
        {
            var airportsDb = await _apCntx.Airports.Where(ap => ap.AirportCode.Equals(airport.AirportCode)
                                                               && ap.AirportName.Equals(airport.AirportName)).ToArrayAsync();

            if(airportsDb.Length > 0)
            {
                return null;
            }

            var airportToCreate = _mapper.Map<AirportDb>(airport);

            airportToCreate.Created = DateTime.UtcNow;
            airportToCreate.Updated = DateTime.UtcNow;

            var added = _apCntx.Airports.Add(airportToCreate);

            await _apCntx.SaveChangesAsync();

            return _mapper.Map<Airport>(added);
        }

        public async Task<Airport> GetAirportByIdAsync(int airportId)
        {
            var airportsDb = await _apCntx.Airports.Where(ap => ap.AirportId == airportId).ToArrayAsync();

            if(airportsDb is null)
            {
                return null;
            }

            return _mapper.Map<Airport>(airportsDb[0]);
        }

        public async Task<IEnumerable<Airport>> GetAirportsAsync()
        {
            var airportsDb = await _apCntx.Airports.ToListAsync();

            return airportsDb.Select(ap => _mapper.Map<Airport>(ap));
        }

        public async Task<IEnumerable<Airport>> GetAirportsByCityIdAsync(int cityId)
        {
            var airportsDb = await _apCntx.Airports.Where(ap => ap.CityId == cityId).ToArrayAsync();

            return airportsDb.Select(ap => _mapper.Map<Airport>(ap));
        }

        public async Task<int> RemoveAirportByIdAsync(int airportId)
        {
            var airportDbToRemove = await _apCntx.Airports.Where(ap => ap.AirportId == airportId).ToArrayAsync();

            if(airportDbToRemove is null)
            {
                return 0;
            }

            _apCntx.Airports.Remove(airportDbToRemove[0]);

            await _apCntx.SaveChangesAsync();

            return 1;
        }

        public async Task<Airport> UpdateAirportByIdAsync(int airportId, UpdateAirportRequest airport)
        {
            var airportsDb = await _apCntx.Airports.Where(ap => ap.AirportId == airportId).ToArrayAsync();

            if(airportsDb?.Length < 1)
            {
                return null;
            }

            var airportToUpdate = airportsDb[0];

            _mapper.Map<UpdateAirportRequest, AirportDb>(airport, airportToUpdate);

            airportToUpdate.Updated = DateTime.UtcNow;

            await _apCntx.SaveChangesAsync();

            return _mapper.Map<Airport>(airportToUpdate);
        }
    }
}
