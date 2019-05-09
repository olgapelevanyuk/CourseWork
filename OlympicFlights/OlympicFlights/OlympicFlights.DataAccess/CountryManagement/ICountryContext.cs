using System;
using System.Collections.Generic;
using System.Text;

namespace OlympicFlights.DataAccess.CountryManagement
{
    /// <summary>
    /// Provides set of entities to access <see cref="Country"/>
    /// </summary>
    public interface ICountryContext : IAsyncEntityStorage
    {
        /// <summary>
        /// Represents current <see cref="IEntitySet{TEntity}"/> of <see cref="Country"/>
        /// </summary>
        IEntitySet<Country> Countries { get; }
    }
}
