using OlympicFlights.DataAccess.AirportManagement;
using OlympicFlights.DataAccess.FlightManagement;
using System;
using System.Collections.Generic;
using System.Text;

namespace OlympicFlights.DataAccess.FlightAirportManagement
{
    /// <summary>
    /// Represents instance to configure Many to Many between Flights and Airports
    /// </summary>
    public class FlightAirports
    {
        /// <summary>
        /// Gets/sets flightairport's id
        /// </summary>
        public int FlightAirportsId { get; set; }

        /// <summary>
        /// Gets/sets flight's ID
        /// </summary>
        public int FlightId { get; set; }

        /// <summary>
        /// Gets/sets airport's ID
        /// </summary>
        public int AirportId { get; set; }

        /// <summary>
        /// Gets/sets airport instance
        /// </summary>
        public virtual Airport Airport { get; set; }

        /// <summary>
        /// Gets/sets flight instance
        /// </summary>
        public virtual Flight Flight { get; set; }

        /// <summary>
        /// Gets/sets if current row references to arrive airport of instance <see cref="Flight"/>
        /// </summary>
        public bool IsArrive { get; set; }
    }
}
