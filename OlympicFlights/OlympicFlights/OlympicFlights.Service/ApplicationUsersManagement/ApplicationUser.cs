using System;
using System.Collections.Generic;
using System.Text;

namespace OlympicFlights.Service.ApplicationUsersManagement
{
    public class ApplicationUser
    {
        public string ApplicationUserId { get; set; }

        public string ApplicationUserName { get; set; }

        public string ApplicationUserPassword { get; set; }

        public string ApplicationUserEmail { get; set; }

        public string ApplicationUserRole { get; set; }
    }
}
