using OlympicFlights.DataAccess.CityManagement;
using System;
using System.Collections.Generic;
using System.Text;

namespace OlympicFlights.DataAccess.CountryManagement
{
    /// <summary>
    /// Provides Country DTO 
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

        /// <summary>
        /// Represent's created time
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// Represent's last update time
        /// </summary>
        public DateTime Updated { get; set; }

        /// <summary>
        /// Represents country's cities <see cref="City"/>
        /// </summary>
        public virtual ICollection<City> Cities { get; set; }
    }
}
