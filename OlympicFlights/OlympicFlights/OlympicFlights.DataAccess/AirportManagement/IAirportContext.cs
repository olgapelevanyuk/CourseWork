using System;
using System.Collections.Generic;
using System.Text;

namespace OlympicFlights.DataAccess.AirportManagement
{
    /// <summary>
    /// Provides set of entities to access <see cref="Airport"/>
    /// </summary>
    public interface IAirportContext : IAsyncEntityStorage
    {
        /// <summary>
        /// Represent current <see cref="IEntitySet{TEntity}"/> of <see cref="Airport"/>
        /// </summary>
        IEntitySet<Airport> Airports { get; }
    }
}
