using System;
using System.Collections.Generic;
using System.Text;

namespace OlympicFlights.Service.AirportManagement
{
    /// <summary>
    /// Represents airport's update/create request object
    /// </summary>
    public class UpdateAirportRequest
    {
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
    }
}
