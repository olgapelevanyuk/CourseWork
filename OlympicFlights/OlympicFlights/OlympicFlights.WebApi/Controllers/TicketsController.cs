using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using OlympicFlights.Service.TicketManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OlympicTickets.WebApi.Controllers
{
    [Route("api/tickets")]
    [ApiController]
    [EnableCors]
   
        public class TicketsController : ControllerBase
        {
            private readonly ITicketService _tService;

            public TicketsController(ITicketService tService)
            {
                _tService = tService ?? throw new ArgumentNullException(nameof(tService));
            }

            [HttpGet]
            public async Task<ActionResult<IEnumerable<Ticket>>> GetTicketsAsync()
            {
                var flights = await _tService.GetTicketsAsync();

                return Ok(flights);
            }

            [HttpGet]
            [Route("{flightId}")]
            public async Task<IActionResult> GetTicketById(int flightId)
            {
                var ticket = await _tService.GetTicketByIdAsync(flightId);

                return Ok(ticket);
            }

            [HttpGet]
            [Route("user/{userId}")]
            public async Task<IActionResult> GetTicketsByUserId(string userId)
            {
                var tickets = await _tService.GetTicketsByUserId(userId);

                return Ok(tickets);
            }

            [HttpPost]
            public async Task<IActionResult> CreateTicket([FromBody]UpdateTicketRequest updateTicketRequest)
            {
                var ticket = await _tService.CreateTicketAsync(updateTicketRequest);

                return Ok(new { status = 200,data = ticket, message = "You bought a ticket!" });
            }



            [HttpPost]
            [Route("{id}")]
            public async Task<IActionResult> UpdateTicketById(int id, [FromBody]UpdateTicketRequest updateTicketRequest)
            {
                var ticket = await _tService.UpdateTicketByIdAsync(id, updateTicketRequest);

                return Ok(ticket);
            }

            [HttpDelete]
            [Route("{id}")]
            public async Task<IActionResult> DeleteTicketById(int id)
            {
                var ticket = await _tService.RemoveTicketByIdAsync(id);

                return Ok(new { status = 200,data = ticket, message = "You removed ticket!" });
            }

        }
    }
