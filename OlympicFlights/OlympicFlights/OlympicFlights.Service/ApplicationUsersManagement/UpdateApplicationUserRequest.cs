using System;
using System.Collections.Generic;
using System.Text;

namespace OlympicFlights.Service.ApplicationUsersManagement
{
    /// <summary>
    /// Represents user update/create request object
    /// </summary>
    public class UpdateApplicationUserRequest
    {
        public string UserId { get; set; }
        /// <summary>
        /// Gets/sets user name
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Gets/sets user password
        /// </summary>
        public string UserPassword { get; set; }

        /// <summary>
        /// Gets/sets user email
        /// </summary>
        public string UserEmail { get; set; }

        /// <summary>
        /// Gets/sets user role
        /// </summary>
        public string UserRole { get; set; }

        public string NewPassword { get; set; }
    }
}
