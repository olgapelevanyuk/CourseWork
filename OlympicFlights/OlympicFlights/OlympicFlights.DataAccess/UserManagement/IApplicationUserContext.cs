using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace OlympicFlights.DataAccess.UserManagement
{
    public interface IApplicationUserContext
    {
        DbSet<ApplicationUser> Users { get; }
        DbSet<IdentityRole> Roles { get; }
    }
}
