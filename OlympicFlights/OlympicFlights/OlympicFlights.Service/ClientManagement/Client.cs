using System;
using System.Collections.Generic;
using System.Text;

namespace OlympicFlights.Service.ClientManagement
{
    /// <summary>
    /// Represents client bll object
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

        public string UserId { get; set; }
        /// <summary>
        /// Represents client's address
        /// </summary>
        public string ClientAddress { get; set; }

        /// <summary>
        /// Represent's if current instance is deleted
        /// </summary>
        public bool IsDeleted { get; set; }
    }
}
