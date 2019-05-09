using Microsoft.EntityFrameworkCore;

namespace OlympicFlights.DataAccess.CityManagement
{
    /// <summary>
    /// Provides tools to work with entity sets of <see cref="City"/>
    /// </summary>
    public class CityContext : DomainContextBase<ApplicationDbContext>, ICityContext
    {
        /// <summary>
        /// Initializes a new instance of 
        /// </summary>
        /// <param name="dbContext">Root context, that contains <see cref="DbSet{TEntity}"/> of current <see cref="City"/></param>
        public CityContext(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        /// <inheritdoc/>
        public IEntitySet<City> Cities => this.GetDbSet<City>();
    }
}
