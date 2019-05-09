using OlympicFlights.DataAccess.AirportManagement;
using OlympicFlights.DataAccess.CityManagement;
using OlympicFlights.DataAccess.FlightAirportManagement;
using OlympicFlights.DataAccess.TicketManagement;
using System;
using System.Collections.Generic;
using System.Text;

namespace OlympicFlights.DataAccess.FlightManagement
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
        /// Gets/sets flight's price
        /// </summary>
        public decimal FlightPrice { get; set; }

        /// <summary>
        /// Gets/sets is flight is deleted
        /// </summary>
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Gets/sets flight's airports (arrive and departure)
        /// </summary>
        public virtual ICollection<FlightAirports> Airports { get; set; }
        
        /// <summary>
        /// Gets/sets flight's tickets
        /// </summary>
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
