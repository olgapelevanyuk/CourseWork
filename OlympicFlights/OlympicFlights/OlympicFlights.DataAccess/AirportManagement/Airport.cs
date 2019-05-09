using OlympicFlights.DataAccess.CityManagement;
using OlympicFlights.DataAccess.FlightAirportManagement;
using OlympicFlights.DataAccess.FlightManagement;
using System;
using System.Collections.Generic;
using System.Text;

namespace OlympicFlights.DataAccess.AirportManagement
{
    /// <summary>
    /// Represents airport dt object
    /// </summary>
    public class Airport
    {
        /// <summary>
        /// Gets/sets airport's ID
        /// </summary>
        public int AirportId { get; set; }

        /// <summary>
        /// Gets/sets aiport's name
        /// </summary>
        public string AirportName { get; set; }

        /// <summary>
        /// Gets/sets airport's code
        /// </summary>
        public string AirportCode { get; set; }

        /// <summary>
        /// Represent's created time
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// Represent's last update time
        /// </summary>
        public DateTime Updated { get; set; }

        /// <summary>
        /// Gets/sets is airport deleted
        /// </summary>
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Gets/sets aiport's city ID
        /// </summary>
        public int CityId { get; set; }

        /// <summary>
        /// Gets/sets airport's city instance
        /// </summary>
        public virtual City City { get; set; }
        
        /// <summary>
        /// Get/sets collection of flights in/out of current airport
        /// </summary>
        public virtual ICollection<FlightAirports> Flights { get; set; }
    }
}
