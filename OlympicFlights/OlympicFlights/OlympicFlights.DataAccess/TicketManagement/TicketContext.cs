using System;
using System.Collections.Generic;
using System.Text;

namespace OlympicFlights.DataAccess.TicketManagement
{
    public class TicketContext : DomainContextBase<ApplicationDbContext>, ITicketContext
    {
        public TicketContext(ApplicationDbContext dbContext) : base(dbContext)
        {

        }

        public IEntitySet<Ticket> Tickets => this.GetDbSet<Ticket>();
    }
}
