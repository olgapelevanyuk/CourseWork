using System;
using System.Collections.Generic;
using System.Text;

namespace OlympicFlights.DataAccess.ClientManagement
{
    /// <summary>
    /// Provides set of entities to access <see cref="Client"/>
    /// </summary>
    public interface IClientContext : IAsyncEntityStorage
    {
        /// <summary>
        /// Represent current <see cref="IEntitySet{TEntity}"/> of <see cref="Client"/>
        /// </summary>
        IEntitySet<Client> Clients { get; }
    }
}
