using System;
using System.Collections.Generic;
using System.Text;

namespace OlympicFlights.Service.CityManagement
{
    /// <summary>
    /// Represents city update request object
    /// </summary>
    public class UpdateCityRequest
    {
        /// <summary>
        /// Represent's city name
        /// </summary>
        public string CityName { get; set; }

        /// <summary>
        /// Represent's country id applied to current city
        /// </summary>
        public int CountryId { get; set; }

        /// <summary>
        /// Gets/sets if city is deleted
        /// </summary>
        public bool IsDeleted { get; set; }
    }
}
