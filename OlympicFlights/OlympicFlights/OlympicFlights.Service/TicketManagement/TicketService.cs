using AutoMapper;
using OlympicFlights.DataAccess;
using OlympicFlights.DataAccess.TicketManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OlympicFlights.Service.OlympicFlightsServiceExceptions;
using TicketDb = OlympicFlights.DataAccess.TicketManagement.Ticket;


namespace OlympicFlights.Service.TicketManagement
{
    public class TicketService : ITicketService,ITicketAdministrate
    {
        private readonly ITicketContext _tCntx;
        private readonly IMapper _mapper;

        public TicketService(ITicketContext tCntx, IMapper mapper)
        {
            _tCntx = tCntx ?? throw new ArgumentNullException(nameof(tCntx));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<Ticket> CreateTicketAsync(UpdateTicketRequest ticketRequest)
        {
            var mappedRequest = _mapper.Map<TicketDb>(ticketRequest);

            mappedRequest.Created = DateTime.UtcNow;

            var added = _tCntx.Tickets.Add(mappedRequest);

            await _tCntx.SaveChangesAsync();

            return _mapper.Map<Ticket>(added);
        }

        public async Task<Ticket> GetTicketByIdAsync(int ticketId)
        {
            return _mapper.Map<Ticket>((await _tCntx.Tickets.Where(t => t.TicketId == ticketId).ToArrayAsync())[0]);
        }

        public async Task<IEnumerable<Ticket>> GetTicketsAsync()
        {
            return await _tCntx.Tickets.Select(t => _mapper.Map<Ticket>(t)).ToArrayAsync();
        }


        public async Task<IEnumerable<Ticket>> GetTicketsByClientId(int clientId)
        {
            return await _tCntx.Tickets.Where(t => t.ClientId == clientId).Select(t => _mapper.Map<Ticket>(t)).ToArrayAsync();
        }

        public async Task<IEnumerable<Ticket>> GetTicketsByUserId(string userId)
        {
            var ticketsDb = await _tCntx.Tickets.Where(t => t.Client.UserId == userId).ToListAsync();

            return ticketsDb.Select(t => _mapper.Map<Ticket>(t));

        }

        public async Task<Ticket> RemoveTicketByIdAsync(int ticketId)
        {
            var entity = (await _tCntx.Tickets.Where(t => t.TicketId == ticketId).ToArrayAsync())[0];

            var removed = _tCntx.Tickets.Remove(entity);

            await _tCntx.SaveChangesAsync();

            return _mapper.Map<Ticket>(removed);
        }

        public async Task<Ticket> UpdateTicketByIdAsync(int ticketId, UpdateTicketRequest ticketRequest)
        {
            var mappedRequest = _mapper.Map<TicketDb>(ticketRequest);

            mappedRequest.TicketId = ticketId;

            var updated = _tCntx.Tickets.Update(mappedRequest);

            await _tCntx.SaveChangesAsync();

            return _mapper.Map<Ticket>(updated);
        }

        public async Task<bool> ApproveTicket(int ticketId)
        {
            var foundTicket = await _tCntx.Tickets.Where(t => t.TicketId == ticketId).ToArrayAsync();

            if (foundTicket is null)
            {
                throw new IdNotFoundException("Ticket with specified id was not found");
            }

            foundTicket[0].IsPurchaseApproved = true;

            await _tCntx.SaveChangesAsync();

            return true;
        }

        public async Task<bool> ApproveTickets(int[] ticketIds)
        {
            var foundTickets = await _tCntx.Tickets.Where(t => ticketIds.Contains(t.TicketId)).ToListAsync();

            foundTickets.ForEach(t => t.IsPurchaseApproved = true);

            if (foundTickets.Count != ticketIds.Length)
            {
                throw new IdNotFoundException("Some or all tickets with requested ids not found");
            }

            await _tCntx.SaveChangesAsync();

            return true;
        }
    }
}
