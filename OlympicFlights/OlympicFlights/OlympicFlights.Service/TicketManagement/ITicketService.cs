using OlympicFlights.Service.TicketManagement;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OlympicFlights.Service.TicketManagement
{
    public interface ITicketService
    {
        Task<IEnumerable<Ticket>> GetTicketsAsync();

        Task<Ticket> GetTicketByIdAsync(int ticketId);

        Task<Ticket> CreateTicketAsync(UpdateTicketRequest ticketRequest);

        Task<Ticket> RemoveTicketByIdAsync(int ticketId);

        Task<Ticket> UpdateTicketByIdAsync(int ticketId, UpdateTicketRequest ticketRequest);

        Task<IEnumerable<Ticket>> GetTicketsByClientId(int userId);

        Task<IEnumerable<Ticket>> GetTicketsByUserId(string userId);
    }
}
