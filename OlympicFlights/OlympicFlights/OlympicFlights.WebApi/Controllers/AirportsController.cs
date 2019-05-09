using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using OlympicFlights.Service.AirportManagement;

namespace OlympicFlights.WebApi.Controllers
{
    [Route("api/airports")]
    [ApiController]
    [EnableCors]
    //[Authorize]
    public class AirportsController : ControllerBase
    {
        private readonly IAirportService _airportService;

        public AirportsController(IAirportService airportService)
        {
            _airportService = airportService ?? throw new ArgumentNullException(nameof(airportService));
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Airport>>> GetAllAirports()
        {
            var airports = await _airportService.GetAirportsAsync();

            return Ok(airports);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Airport>> GetAirportById(int id)
        {
            var airport = await _airportService.GetAirportByIdAsync(id);

            return Ok(airport);
        }

        [HttpGet("city/{cityId}")]
        public async Task<ActionResult<IEnumerable<Airport>>> GetAirportsByCityId(int cityId)
        {
            var cities = await _airportService.GetAirportsByCityIdAsync(cityId);

            return Ok(cities);
        }

        [HttpPost]
        public async Task<ActionResult<Airport>> CreateAirport([FromBody] UpdateAirportRequest airport)
        {
            var created = await _airportService.CreateAirportAsync(airport);

            return Ok(new { status = 200, data = created, message = "Airport created!" });
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Airport>> DeleteAirportById(int id)
        {
            var removed = await _airportService.RemoveAirportByIdAsync(id);

            return Ok(new { status = 200, data = removed , message = "Airport removed!" });
        }

        [HttpPost("{id}")]
        public async Task<ActionResult<Airport>> UpdateAirportById([FromBody]UpdateAirportRequest airport, int id)
        {
            var updated = await _airportService.UpdateAirportByIdAsync(id, airport);

            return Ok(new { status = 200, data = updated, message = "Airport updated!" });
        }
    }
}
