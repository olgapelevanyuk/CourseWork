using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using OlympicFlights.Service.ClientManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OlympicFlights.WebApi.Controllers
{
    [Route("api/clients")]
    [ApiController]
    [EnableCors]
    [Authorize]
    public class ClientsController : ControllerBase
    {
        private readonly IClientService _clientService;

        public ClientsController(IClientService clientService)
        {
            _clientService = clientService ?? throw new ArgumentNullException(nameof(clientService));
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Client>>> GetAllClients()
        {
            var clients = await _clientService.GetClientsAsync();

            return Ok(clients);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Client>> GetClientById(int id)
        {
            var client = await _clientService.GetClientByIdAsync(id);

            return Ok(client);
        }

        [HttpPost]

        public async Task<ActionResult<Client>> CreateClient([FromBody] UpdateClientRequest client)
        {
            var created = await _clientService.CreateClientAsync(client);

            return Ok(new { status = 200, data = created, message = "New client created!" });
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Client>> DeleteClientById(int id)
        {
            var removed = await _clientService.RemoveClientByIdAsync(id);

            return Ok(removed);
        }

        [HttpPost("{id}")]
        public async Task<ActionResult<Client>> UpdateClientById([FromBody]UpdateClientRequest client, int id)
        {
            var updated = await _clientService.UpdateClientByIdAsync(id, client);

            return Ok(updated);
        }
    }
}
