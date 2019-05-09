using OlympicFlights.Service.CountryManagement;
using System;
using System.Collections.Generic;
using System.Text;

namespace OlympicFlights.Service.CityManagement
{
    /// <summary>
    /// Provides City BLL instance
    /// </summary>
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
        /// Represent's city id applied to current city
        /// </summary>
        public int CountryId { get; set; }

        /// <summary>
        /// Gets/sets if city is deleted
        /// </summary>
        public bool IsDeleted { get; set; }
    }
}
