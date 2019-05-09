using System;
using System.Collections.Generic;
using System.Text;

namespace OlympicFlights.Service.ClientManagement
{
    /// <summary>
    /// Represents client update/create request object
    /// </summary>
    public class UpdateClientRequest
    {
        /// <summary>
        /// Gets/sets app user id
        /// </summary>
        public string UserId { get; set; }
        
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
    }
}
