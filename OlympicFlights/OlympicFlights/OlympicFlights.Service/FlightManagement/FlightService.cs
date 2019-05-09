using AutoMapper;
using OlympicFlights.DataAccess;
using OlympicFlights.DataAccess.FlightAirportManagement;
using OlympicFlights.DataAccess.FlightManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlightDb = OlympicFlights.DataAccess.FlightManagement.Flight;


namespace OlympicFlights.Service.FlightManagement
{
    public class FlightService : IFlightService
    {
        private readonly IFlightAirportsContext _faCntx;
        private readonly IFlightContext _fCntx;
        private readonly IMapper _mapper;

        public FlightService(IFlightAirportsContext faCntx, IFlightContext fCntx,IMapper mapper)
        {
            _faCntx = faCntx ?? throw new ArgumentNullException(nameof(faCntx));
            _fCntx = fCntx ?? throw new ArgumentNullException(nameof(fCntx));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<Flight> CreateFlightAsync(UpdateFlightRequest flightRequest)
        {
            var entityToCreate = _mapper.Map<FlightDb>(flightRequest);

            var created = _fCntx.Flights.Add(entityToCreate);

            await _fCntx.SaveChangesAsync();

            var faArrive = new FlightAirports
            {
                FlightId = created.FlightId,
                AirportId = flightRequest.ArriveAirportId,
                IsArrive = true,
            };

            var faDeparture = new FlightAirports
            {
                FlightId = created.FlightId,
                AirportId = flightRequest.DepartureAirportId,
                IsArrive = false
            };

            _faCntx.FlightAirports.Add(faArrive);
            _faCntx.FlightAirports.Add(faDeparture);

            await _fCntx.SaveChangesAsync();

            return new Flight
            {
                FlightId = created.FlightId,
                ArriveAirportId = faArrive.AirportId,
                ArriveTime = created.ArriveTime,
                DepartureAirportId = faDeparture.AirportId,
                DepartureTime = created.DepartureTime
            };
        }

        public async Task<IEnumerable<Flight>> GetFlightsAsync()
        {
            var flights = await _fCntx.Flights.Select(f => _mapper.Map<Flight>(f)).ToListAsync();

            foreach (var flight in flights)
            {
                flight.ArriveAirportId = _faCntx.FlightAirports.Where(air => air.FlightId == flight.FlightId && air.IsArrive).First().AirportId;
                flight.DepartureAirportId = _faCntx.FlightAirports.Where(air => air.FlightId == flight.FlightId && !air.IsArrive).First().AirportId;
            }

            return flights;
        }

        public async Task<Flight> GetFlightByIdAsync(int flightId)
        {
            var flight = (await _fCntx.Flights.Where(f => f.FlightId == flightId).Select(f => _mapper.Map<Flight>(f)).ToArrayAsync())[0];

            flight.ArriveAirportId = _faCntx.FlightAirports.Where(air => air.FlightId == flight.FlightId && air.IsArrive).First().AirportId;
            flight.DepartureAirportId = _faCntx.FlightAirports.Where(air => air.FlightId == flight.FlightId && !air.IsArrive).First().AirportId;

            return flight;
        }

        public async Task<Flight> RemoveFlightByIdAsync(int flightId)
        {
            var flight = (await _fCntx.Flights.Where(f => f.FlightId == flightId).ToArrayAsync())[0];

            var removed = _fCntx.Flights.Remove(flight);

            var mapped = _mapper.Map<Flight>(removed);

            mapped.ArriveAirportId = _faCntx.FlightAirports.Where(air => air.FlightId == flight.FlightId && air.IsArrive).First().AirportId;
            mapped.DepartureAirportId = _faCntx.FlightAirports.Where(air => air.FlightId == flight.FlightId && !air.IsArrive).First().AirportId;

            await _fCntx.SaveChangesAsync();

            return mapped;
        }

        public async Task<Flight> UpdateFlightByIdAsync(int flightId, UpdateFlightRequest flightRequest)
        {
            var flight = (await _fCntx.Flights.Where(f => f.FlightId == flightId).ToArrayAsync())[0];

            var flightToUpdate = _fCntx.Flights.Remove(flight);

            flightToUpdate.ArriveTime = DateTime.Parse(flightRequest.ArriveTime);
            flightToUpdate.DepartureTime = DateTime.Parse(flightRequest.DepartureTime);
            flightToUpdate.IsDeleted = flightRequest.IsDeleted;
            flightToUpdate.FlightPrice = flightRequest.FlightPrice;

            var arrFa = _faCntx.FlightAirports.Where(air => air.FlightId == flight.FlightId && air.IsArrive).First();
            var depFa = _faCntx.FlightAirports.Where(air => air.FlightId == flight.FlightId && !air.IsArrive).First();

            arrFa.AirportId = flightRequest.ArriveAirportId;
            depFa.AirportId = flightRequest.DepartureAirportId;

            _faCntx.FlightAirports.Update(arrFa);
            _faCntx.FlightAirports.Update(depFa);
            _fCntx.Flights.Update(flightToUpdate);

            await _faCntx.SaveChangesAsync();
            await _fCntx.SaveChangesAsync();

            return null;
        }
    }
}
