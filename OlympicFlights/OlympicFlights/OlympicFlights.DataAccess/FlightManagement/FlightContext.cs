namespace OlympicFlights.DataAccess.FlightManagement
{
    public class FlightContext : DomainContextBase<ApplicationDbContext>, IFlightContext
    {
        public FlightContext(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public IEntitySet<Flight> Flights => this.GetDbSet<Flight>();
    }
}
