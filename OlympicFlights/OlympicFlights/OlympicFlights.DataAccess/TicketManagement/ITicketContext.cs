using System;
using System.Collections.Generic;
using System.Text;

namespace OlympicFlights.DataAccess.TicketManagement
{
    /// <summary>
    /// Provides set of entities to access <see cref="Ticket"/>
    /// </summary>
    public interface ITicketContext : IAsyncEntityStorage
    {
        /// <summary>
        /// Represent current <see cref="IEntitySet{TEntity}"/> of <see cref="Ticket"/>
        /// </summary>
        IEntitySet<Ticket> Tickets { get;}
    }
}
