using System;
using System.Collections.Generic;
using System.Text;

namespace OlympicFlights.Service.AirportManagement
{
    /// <summary>
    /// Represents airport's object
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
        /// Gets/sets aiport's city ID
        /// </summary>
        public int CityId { get; set; }

        /// <summary>
        /// Gets/sets if airport is deleted
        /// </summary>
        public bool IsDeleted { get; set; }
    }
}
