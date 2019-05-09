using OlympicFlights.DataAccess.ClientManagement;
using OlympicFlights.DataAccess.FlightManagement;
using System;
using System.Collections.Generic;
using System.Text;

namespace OlympicFlights.DataAccess.TicketManagement
{
    /// <summary>
    /// Represents ticket dt object
    /// </summary>
    public class Ticket
    {
        /// <summary>
        /// Gets/sets ticket's ID
        /// </summary>
        public int TicketId { get; set; }

        /// <summary>
        /// Gets/sets ticket's client ID
        /// </summary>
        public int ClientId { get; set; }

        /// <summary>
        /// Gets/sets ticket's flight ID
        /// </summary>
        public int FlightId { get; set; }

        /// <summary>
        /// Gets/sets is ticket's purchase approved
        /// </summary>
        public bool IsPurchaseApproved { get; set; }

        /// <summary>
        /// Gets/sets is ticket deleted
        /// </summary>
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Gets/sets is ticket's purchase approved
        /// </summary>
        public DateTime Created { get; set; }
        
        /// <summary>
        /// Gets/sets ticket's flight instance
        /// </summary>
        public virtual Flight Flight { get; set; }

        /// <summary>
        /// Gets/sets ticket's client instance
        /// </summary>
        public virtual Client Client { get; set; }
    }
}
