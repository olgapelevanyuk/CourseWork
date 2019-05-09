using System;
using System.Collections.Generic;
using System.Text;

namespace OlympicFlights.DataAccess.FlightAirportManagement
{
    public class FlightAirportContext : DomainContextBase<ApplicationDbContext>, IFlightAirportsContext
    {
        public FlightAirportContext(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public IEntitySet<FlightAirports> FlightAirports => this.GetDbSet<FlightAirports>();
    }
}
