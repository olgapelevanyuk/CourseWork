using OlympicFlights.DataAccess.AirportManagement;
using OlympicFlights.DataAccess.CountryManagement;
using OlympicFlights.DataAccess.FlightManagement;
using System;
using System.Collections.Generic;
using System.Text;

namespace OlympicFlights.DataAccess.CityManagement
{
    public class City
    {
        /// <summary>
        /// Represent's city's ID
        /// </summary>
        public int CityId { get; set; }

        /// <summary>
        /// Represent's city name
        /// </summary>
        public string CityName { get; set; }

        /// <summary>
        /// Represent's created time
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// Represent's last update time
        /// </summary>
        public DateTime Updated { get; set; }

        /// <summary>
        /// Represent's if object is deleted
        /// </summary>
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Represent's country's ID
        /// </summary>
        public int CountryId { get; set; }

        /// <summary>
        /// Represents set of countries
        /// </summary>
        public virtual Country Country { get; set; }

        /// <summary>
        /// Represents set of airports in current city
        /// </summary>
        public virtual ICollection<Airport> Airports { get; set; }
    }
}
