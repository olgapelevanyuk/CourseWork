using Microsoft.EntityFrameworkCore;

namespace OlympicFlights.DataAccess.CountryManagement
{
    /// <summary>
    /// Provides tools to work with entity sets of <see cref="Country"/>
    /// </summary>
    public class CountryContext : DomainContextBase<ApplicationDbContext>, ICountryContext
    {
        /// <summary>
        /// Initializes a new instance of <see cref="CountryContext"/>
        /// </summary>
        /// <param name="dbContext">Root context, that contains <see cref="DbSet{TEntity}"/> of current <see cref="Country"/></param>
        public CountryContext(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        /// <summary>
        /// Represents current <see cref="IEntitySet{TEntity}"/> of <see cref="Country"/>
        /// </summary>
        public IEntitySet<Country> Countries => this.GetDbSet<Country>();
    }
}
