using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using OlympicFlights.Service.AirportManagement;
using OlympicFlights.Service.FlightManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OlympicFlights.WebApi.Controllers
{
    [Route("api/flights")]
    [ApiController]
    [EnableCors]
    public class FlightsController : ControllerBase
    {
        private readonly IFlightService _flService;

        public FlightsController(IFlightService flService)
        {
            _flService = flService ?? throw new ArgumentNullException(nameof(flService));
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Flight>>> GetFlightsAsync()
        {
            var flights = await _flService.GetFlightsAsync();

            return Ok(flights);
        }

        [HttpGet]
        [Route("{flightId}")]
        public async Task<IActionResult> GetFlightById(int flightId)
        {
            var flight = await _flService.GetFlightByIdAsync(flightId);

            return Ok(flight);
        }

        [HttpPost]
        public async Task<IActionResult> CreateFlight([FromBody]UpdateFlightRequest updateFlightRequest)
        {
            var flight = await _flService.CreateFlightAsync(updateFlightRequest);

            return Ok(new {status = 200, data = flight, message = "Flight successfully created" });
        }

        [HttpPost]
        [Route("{id}")]
        public async Task<IActionResult> UpdateFlightById(int id,[FromBody]UpdateFlightRequest updateFlightRequest)
        {
            var flight = await _flService.UpdateFlightByIdAsync(id, updateFlightRequest);

            return Ok(new {status = 200, data = flight, message = "Flight successfully updated"});
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> DeleteFlightById(int id)
        {
            var flight = await _flService.RemoveFlightByIdAsync(id);

            return Ok(new { status = 200, data = flight, message = "Flight was successfully removed" });
        }

        [HttpGet]
        [Route("incoming")]
        public async Task<ActionResult<IEnumerable<Flight>>> GetIncomingFlightsAsync()
        {
            var flights = (await _flService.GetFlightsAsync()).Where(fl => fl.DepartureTime.CompareTo(DateTime.Now) >= 0);

            return Ok(flights);
        }
    }
}
