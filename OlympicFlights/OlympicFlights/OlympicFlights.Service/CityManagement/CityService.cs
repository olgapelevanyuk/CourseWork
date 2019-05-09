using OlympicFlights.DataAccess.CityManagement;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CityDTO = OlympicFlights.DataAccess.CityManagement.City;
using System.Linq;
using AutoMapper;
using OlympicFlights.DataAccess;
using OlympicFlights.Service.OlympicFlightsServiceExceptions;

namespace OlympicFlights.Service.CityManagement
{
    public class CityService : ICityService
    {
        private readonly ICityContext _cityCntx;
        private readonly IMapper _mapper;

        public CityService(ICityContext cityCntx, IMapper mapper)
        {
            _cityCntx = cityCntx ?? throw new ArgumentNullException(nameof(cityCntx));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<City> CreateCityAsync(UpdateCityRequest city)
        {
            var duplicateCityDb = await _cityCntx.Cities.Where(c => c.CountryId == city.CountryId && String.CompareOrdinal(c.CityName, city.CityName) == 0).ToArrayAsync();

            if(duplicateCityDb.Length > 0)
            {
                throw new DuplicateFoundException("Current city already exists");
            }

            var added = _cityCntx.Cities.Add(_mapper.Map<CityDTO>(city));

            var result = await _cityCntx.SaveChangesAsync();

            if(result == 0)
            {
                throw new DuplicateFoundException("Can not add city with requested parameters");
            }

            return _mapper.Map<City>(added);
        }

        public async Task<IEnumerable<City>> GetCitiesByCountryIdAsync(int countryId)
        {
            var dbCities = await _cityCntx.Cities.Where(c => c.CountryId == countryId).OrderBy(c => c.CityName).ToArrayAsync();

            if(dbCities?.Length == 0)
            {
                throw new ItemsNotFoundException("No cities of such country found");
            }

            return dbCities.Select(db => _mapper.Map<City>(db));
        }

        public async Task<City> GetCityByIdAsync(int cityId)
        {
            var dbCities = await _cityCntx.Cities.Where(c => c.CityId == cityId).ToArrayAsync();

            if(dbCities[0] is null)
            {
                throw new IdNotFoundException("No such city found");
            }

            return _mapper.Map<City>(dbCities[0]);
        }

        public async Task<IEnumerable<City>> GetCitiesAsync()
        {
            var dbCities = await _cityCntx.Cities.ToArrayAsync();

            if (dbCities?.Length == 0)
            {
                throw new ItemsNotFoundException("No cities found");
            }

            return dbCities.Select(db => _mapper.Map<City>(db));
        }

        public async Task<City> RemoveCityByIdAsync(int cityId)
        {
            var dbCity = await _cityCntx.Cities.Where(c => c.CityId == cityId).ToArrayAsync();

            if(dbCity?.Length == 0)
            {
                throw new IdNotFoundException("No city found");
            }
            
            var removed = _cityCntx.Cities.Remove(dbCity[0]);

            await _cityCntx.SaveChangesAsync();

            return _mapper.Map<City>(removed);
        }

        public async Task<City> UpdateCityByIdAsync(int cityId, UpdateCityRequest city)
        {
            var citiesDb = await _cityCntx.Cities.Where(c => c.CityId == cityId).ToArrayAsync();

            if (citiesDb?.Length < 1)
            {
                throw new IdNotFoundException("No city found");
            }

            var mapped = _mapper.Map<UpdateCityRequest, CityDTO>(city, citiesDb[0]);

            mapped.CityId = citiesDb[0].CityId;

            var updated = _cityCntx.Cities.Update(mapped);

            var result = await _cityCntx.SaveChangesAsync();

            if(result == 0)
            {
                throw new DuplicateFoundException("Can not update city with such requested parameters");
            }

            return _mapper.Map<City>(updated);
        }
    }
}
