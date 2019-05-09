using System;
using System.Collections.Generic;
using System.Text;

namespace OlympicFlights.Service.FlightManagement
{
    /// <summary>
    /// Represents flight dt object
    /// </summary>
    public class Flight
    {
        /// <summary>
        /// Gets/sets flight's ID
        /// </summary>
        public int FlightId { get; set; }

        /// <summary>
        /// Gets/sets filght's date and time of departure
        /// </summary>
        public DateTime DepartureTime { get; set; }

        /// <summary>
        /// Gets/sets flight's date and time of arrive
        /// </summary>
        public DateTime ArriveTime { get; set; }

        /// <summary>
        /// Gets/sets flight's arrive airport id
        /// </summary>
        public int ArriveAirportId { get; set; }

        /// <summary>
        /// Gets/sets flight's departure airport id
        /// </summary>
        public int DepartureAirportId { get; set; }

        /// <summary>
        /// Gets/sets flight's price
        /// </summary>
        public decimal FlightPrice { get; set; }

        /// <summary>
        /// Gets/sets is flight is deleted
        /// </summary>
        public bool IsDeleted { get; set; }

    }
}
