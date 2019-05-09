using OlympicFlights.Service.CityManagement;
using System;
using System.Collections.Generic;
using System.Text;

namespace OlympicFlights.Service.CountryManagement
{
    /// <summary>
    /// Provides Country BLL instance
    /// </summary>
    public class Country
    {
        /// <summary>
        /// Represents country's ID
        /// </summary>
        public int CountryId { get; set; }

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
