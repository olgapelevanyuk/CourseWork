using System;
using System.Collections.Generic;
using System.Text;

namespace OlympicFlights.Service.CountryManagement
{
    /// <summary>
    /// Represents update request for <see cref="Country"/>
    /// </summary>
    public class UpdateCountryRequest
    {
        /// <summary>
        /// Represents country's name
        /// </summary>
        public string CountryName { get; set; }

        /// <summary>
        /// Gets/sets if country is deleted
        /// </summary>
        public bool IsDeleted { get; set; }
    }
}
