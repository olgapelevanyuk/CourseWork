using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace OlympicFlights.DataAccess.AirportManagement
{
    /// <summary>
    /// Provides tools to work with entity sets of <see cref="Airport"/>
    /// </summary>
    public class AirportContext : DomainContextBase<ApplicationDbContext>, IAirportContext
    {
        /// <summary>
        /// Initializes a new instance of 
        /// </summary>
        /// <param name="dbContext">Root context, that contains <see cref="DbSet{TEntity}"/> of current <see cref="Airport"/></param>
        public AirportContext(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        /// <inheritdoc/>
        public IEntitySet<Airport> Airports => this.GetDbSet<Airport>();
    }
}
