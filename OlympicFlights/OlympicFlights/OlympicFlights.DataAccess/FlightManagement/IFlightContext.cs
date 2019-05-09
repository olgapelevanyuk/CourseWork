using System;
using System.Collections.Generic;
using System.Text;

namespace OlympicFlights.DataAccess.FlightManagement
{
    /// <summary>
    /// Provides set of entities to access <see cref="Flight"/>
    /// </summary>
    public interface IFlightContext : IAsyncEntityStorage
    {
        /// <summary>
        /// Represent current <see cref="IEntitySet{TEntity}"/> of <see cref="Flight"/>
        /// </summary>
        IEntitySet<Flight>  Flights { get; }
    }
}
