using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OlympicFlights.Service.TicketManagement
{
    public interface ITicketAdministrate
    {
        Task<bool> ApproveTickets(int[] ticketIds);
        Task<bool> ApproveTicket(int ticketId);
    }
}
