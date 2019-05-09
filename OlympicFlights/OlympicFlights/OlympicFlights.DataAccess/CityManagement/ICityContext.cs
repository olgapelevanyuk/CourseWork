namespace OlympicFlights.DataAccess.CityManagement
{
    /// <summary>
    /// Provides set of entities to access <see cref="City"/>
    /// </summary>
    public interface ICityContext : IAsyncEntityStorage
    {
        /// <summary>
        /// Represent current <see cref="IEntitySet{TEntity}"/> of <see cref="City"/>
        /// </summary>
        IEntitySet<City> Cities { get; }
    }
}
