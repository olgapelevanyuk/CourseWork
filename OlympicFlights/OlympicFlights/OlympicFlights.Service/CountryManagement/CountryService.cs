using OlympicFlights.DataAccess.CountryManagement;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CountryDTO = OlympicFlights.DataAccess.CountryManagement.Country;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using OlympicFlights.Service.OlympicFlightsServiceExceptions;

namespace OlympicFlights.Service.CountryManagement
{
    public class CountryService : ICountryService
    {
        private readonly ICountryContext _cntryCtx;
        private readonly IMapper _mapper;

        public CountryService(ICountryContext cntryCtx, IMapper mapper)
        {
            _cntryCtx = cntryCtx ?? throw new ArgumentNullException(nameof(cntryCtx));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<Country> CreateCountryAsync(UpdateCountryRequest country)
        {
            var dbCountry = _mapper.Map<CountryDTO>(country);

            var added = _cntryCtx.Countries.Add(dbCountry);

            if(added is null)
            {
                throw new DuplicateFoundException("Can not add country with requested parameters");
            }

            var result = await _cntryCtx.SaveChangesAsync();

            if (result == 0)
            {
                throw new DuplicateFoundException("Can not add country with requested parameters");
            }


            return _mapper.Map<Country>(added);
        }

        public async Task<IEnumerable<Country>> GetCountriesAsync()
        {
            var countries = await  _cntryCtx.Countries.Select(db => _mapper.Map<Country>(db)).ToListAsync();
            
            if(countries is null)
            {
                throw new ItemsNotFoundException("Country list is empty");
            }

            return countries;
        }

        public async Task<Country> GetCountryByIdAsync(int countryId)
        {
            var dbCountries = await _cntryCtx.Countries.Where(cntr => cntr.CountryId == countryId).ToArrayAsync();

            if (dbCountries.Length < 1)
            {
                throw new IdNotFoundException("Such country not found");
            }

            return _mapper.Map<Country>(dbCountries[0]);
        }

        public async Task<Country> RemoveCountryByIdAsync(int countryId)
        {
            var entitiesToRemove = await _cntryCtx.Countries.Where(cntry => cntry.CountryId == countryId).ToArrayAsync();

            if(entitiesToRemove.Length < 1)
            {
                throw new IdNotFoundException("Such country not found");
            }

            var removed = _cntryCtx.Countries.Remove(entitiesToRemove[0]);

            if(removed is null)
            {
                throw new Exception("Some error occured while trying to remove country");
            }

            await _cntryCtx.SaveChangesAsync();

            return _mapper.Map<Country>(removed);
        }

        public async Task<Country> UpdateCountryByIdAsync(int countryId, UpdateCountryRequest country)
        {
            var dbCountries = await _cntryCtx.Countries.Where(c => c.CountryId == countryId).ToArrayAsync();

            if(dbCountries.Length < 1)
            {
                throw new IdNotFoundException("Such country not found");
            }

            var updatedCountry = _mapper.Map<UpdateCountryRequest,CountryDTO>(country,dbCountries[0]);
            
            var result = await _cntryCtx.SaveChangesAsync();

            if(result == 0)
            {
                throw new DuplicateFoundException("Can not update country with requested parameters");
            }

            return _mapper.Map<Country>(updatedCountry);
        }
    }
}
