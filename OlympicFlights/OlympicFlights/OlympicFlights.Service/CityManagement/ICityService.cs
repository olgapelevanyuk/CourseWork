using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OlympicFlights.Service.CityManagement
{
    public interface ICityService
    {
        Task<IEnumerable<City>> GetCitiesAsync();

        Task<City> GetCityByIdAsync(int cityId);

        Task<City> CreateCityAsync(UpdateCityRequest city);

        Task<City> RemoveCityByIdAsync(int cityId);

        Task<City> UpdateCityByIdAsync(int cityId, UpdateCityRequest city);

        Task<IEnumerable<City>> GetCitiesByCountryIdAsync(int countryId);
    }
}
