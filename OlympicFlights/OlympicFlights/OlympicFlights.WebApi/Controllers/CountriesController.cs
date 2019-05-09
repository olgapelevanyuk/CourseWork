using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OlympicFlights.Service.CountryManagement;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Authorization;

namespace OlympicFlights.WebApi.Controllers
{
    [Route("api/countries")]
    [ApiController]
    [EnableCors]
    //[Authorize]
    public class CountriesController : ControllerBase
    {
        private readonly ICountryService _service;

        public CountriesController(ICountryService service)
        {
            _service = service ?? throw new ArgumentNullException(nameof(service));
        }
        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Country>>> GetAllCountries()
        {
            var countries = await _service.GetCountriesAsync();

            return Ok(countries);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Country>> GetCountryById(int id)
        {
            var country = await _service.GetCountryByIdAsync(id);

            return Ok(country);
        }

        [HttpPost]
        //[Authorize(Roles = "Admin")]
        public async Task<ActionResult<Country>> CreateCountry([FromBody] UpdateCountryRequest country)
        {
            var created = await _service.CreateCountryAsync(country);

            return Ok(new {status = 200, data = created, message = "Country was successfully created!"});
        }

        [HttpDelete("{id}")]
        //[Authorize(Roles = "Admin")]
        public async Task<ActionResult<Country>> DeleteCountryById(int id)
        {
            var removed = await _service.RemoveCountryByIdAsync(id);

            return Ok(new { status = 200, data = removed, message = "Country was successfully removed!" });
        }

        [HttpPut("{id}")]
        //[Authorize(Roles = "Admin")]
        public async Task<ActionResult<Country>> UpdateCountryById([FromBody]UpdateCountryRequest country, int id)
        {
            var updated = await _service.UpdateCountryByIdAsync(id, country);

            return Ok(new { status = 200, data = updated, message = "Country was successfully updated!" });
        }
    }
}
