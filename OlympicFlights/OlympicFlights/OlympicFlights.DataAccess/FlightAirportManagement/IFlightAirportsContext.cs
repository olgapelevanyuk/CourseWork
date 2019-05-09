using System;
using System.Collections.Generic;
using System.Text;

namespace OlympicFlights.DataAccess.FlightAirportManagement
{
    /// <summary>
    /// Provides set of entities to access <see cref="FlightAirportManagement.FlightAirports"/>
    /// </summary>
    public interface IFlightAirportsContext : IAsyncEntityStorage
    {
        /// <summary>
        /// Represent current <see cref="IEntitySet{TEntity}"/> of <see cref="FlightAirportManagement.FlightAirports"/>
        /// </summary>
        IEntitySet<FlightAirports> FlightAirports { get;}
    }
}
