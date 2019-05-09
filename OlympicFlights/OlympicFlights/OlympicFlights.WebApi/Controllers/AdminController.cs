using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using OlympicFlights.Service.AdminManagement;
using OlympicFlights.Service.FlightManagement;
using OlympicFlights.Service.OlympicFlightsServiceExceptions;
using OlympicFlights.Service.TicketManagement;

namespace OlympicFlights.WebApi.Controllers
{
    [Route("api/admin")]
    [ApiController]
    [EnableCors]
    public class AdminController : ControllerBase
    {
        private readonly ChartService _chartService;
        private readonly ITicketAdministrate _tAdministrate;
        private readonly IFlightService _fService;

        public AdminController(ChartService chartService, ITicketAdministrate tAdministrate, IFlightService fService)
        {
            _chartService = chartService;
            _tAdministrate = tAdministrate;
            _fService = fService;
        }

        [HttpPut("tickets/approve/all")]
        public async Task<object> ApproveTickets(int[] ticketIds)
        {
            try
            {
                var areTicketsApproved = await _tAdministrate.ApproveTickets(ticketIds);

                return Ok(new { successMessage = "Tickets where apporved" });
            }
            catch (IdNotFoundException ex)
            {
                return NotFound(new { errorMessage = ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { errorMessage = ex.Message });
            }
        }

        [HttpPut("tickets/approve/{ticketId}")]
        public async Task<object> ApproveTicket([FromRoute] int ticketId)
        {
            try
            {
                var areTicketApproved = await _tAdministrate.ApproveTicket(ticketId);

                if (areTicketApproved)
                {
                    return Ok(new { successMessage = "Ticket was apporved" });
                }
                else
                {
                    throw new Exception("Some error occured while approving tickets");
                }
            }
            catch (IdNotFoundException ex)
            {
                return NotFound(new { errorMessage = ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { errorMessage = ex.Message });
            }
        }

        [HttpGet]
        [Route("stat/flpermonth")]
        public async Task<IActionResult>  GetFlightsPerMonthData()
        {
            var result = await _chartService.GetFlightsPerMonthData();
            return Ok(result);
        }

        [HttpGet]
        [Route("stat/clpermonth")]
        public async Task<IActionResult> GetClientsPerMonthData()
        {
            var result = await _chartService.GetClientsPerMonthData();
            return Ok(result);
        }

        [HttpGet]
        [Route("stat/tcktpermonth")]
        public async Task<IActionResult> GetTicketssPerMonthData()
        {
            var result = await _chartService.GetTicketsPerMonthData();
            return Ok(result);
        }

        [HttpGet]
        [Route("stat/overall")]
        public async Task<IActionResult> GetOverallStat()
        {
            var overallStat = await _chartService.GetOverallStatistics();

            return Ok(overallStat);
        }
    }
}
