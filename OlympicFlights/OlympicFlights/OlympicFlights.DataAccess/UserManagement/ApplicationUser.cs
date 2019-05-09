using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Infrastructure;
using OlympicFlights.DataAccess.ClientManagement;
using System;
using System.Collections.Generic;
using System.Text;

namespace OlympicFlights.DataAccess.UserManagement
{
    public class ApplicationUser : IdentityUser
    {
        public virtual ICollection<Client> Clients { get; set; }
    }
}
