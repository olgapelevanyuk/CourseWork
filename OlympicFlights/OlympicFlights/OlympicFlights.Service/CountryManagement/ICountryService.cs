using OlympicFlights.Service.CountryManagement;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OlympicFlights.Service.CountryManagement
{
    public interface ICountryService
    {
        Task<IEnumerable<Country>> GetCountriesAsync();

        Task<Country> GetCountryByIdAsync(int countryId);

        Task<Country> CreateCountryAsync(UpdateCountryRequest country);

        Task<Country> RemoveCountryByIdAsync(int countryId);

        Task<Country> UpdateCountryByIdAsync(int countryId, UpdateCountryRequest country);
    }
}
