using OlympicFlights.DataAccess.TicketManagement;
using System;
using System.Collections.Generic;
using System.Text;
using OlympicFlights.DataAccess.UserManagement;

namespace OlympicFlights.DataAccess.ClientManagement
{
    /// <summary>
    /// Represents client's dt object
    /// </summary>
    public class Client
    {
        /// <summary>
        /// Represents client's ID
        /// </summary>
        public int ClientId { get; set; }

        /// <summary>
        /// Represents client's first name
        /// </summary>
        public string ClientFirstname { get; set; }

        /// <summary>
        /// Represents client's last name
        /// </summary>
        public string ClientLastname { get; set; }

        /// <summary>
        /// Represents client's address
        /// </summary>
        public string ClientAddress { get; set; }

        /// <summary>
        /// Represents client's user id
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// Represent's created time
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// Represent's last update time
        /// </summary>
        public DateTime Updated { get; set; }
        
        /// <summary>
        /// Represent's if current instance is deleted
        /// </summary>
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Represent's user's entity
        /// </summary>
        public virtual ApplicationUser User { get; set; }

        /// <summary>
        /// Gets/sets client's tickets
        /// </summary>
        public virtual ICollection<Ticket> Tickets { get; set; }
        
    }
}
