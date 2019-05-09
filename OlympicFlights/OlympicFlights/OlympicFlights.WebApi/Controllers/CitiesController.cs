using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using OlympicFlights.Service.CityManagement;
using OlympicFlights.Service.OlympicFlightsServiceExceptions;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OlympicFlights.WebApi.Controllers
{
    [Route("api/cities")]
    [ApiController]
    [EnableCors]
    //[Authorize]
    public class CitiesController : ControllerBase
    {
        private readonly ICityService _cityService;

        public CitiesController(ICityService cityService)
        {
            _cityService = cityService ?? throw new ArgumentNullException(nameof(cityService));
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCities()
        {
            try
            {
                var cities = await _cityService.GetCitiesAsync();

                return Ok(cities);
            }
            catch (ItemsNotFoundException ex)
            {
                return NotFound(new { status = 400,message = ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { status = 500, message = ex.Message });
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCityById(int id)
        {
            try
            {
                var city = await _cityService.GetCityByIdAsync(id);

                return Ok(city);
            }
            catch (IdNotFoundException ex)
            {
                return NotFound(new { status = 400, message = ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { status = 500, message = ex.Message });
            }
        }

        [HttpGet("/country/{countryId}")]
        public async Task<IActionResult> GetCitiesByCountryId(int countryId)
        {
            try
            {
                var cities = await _cityService.GetCitiesByCountryIdAsync(countryId);

                return Ok(cities);
            }
            catch (ItemsNotFoundException ex)
            {
                return NotFound(new { status = 400, message = ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { status = 500, message = ex.Message });
            }
        } 

        [HttpPost]
        [Authorize(Roles = "applicationAdmin")]
        public async Task<IActionResult> CreateCity([FromBody] UpdateCityRequest city)
        {
            try
            {
                var created = await _cityService.CreateCityAsync(city);

                return Ok(new { status = 200, data = created, message = "City was successfully created" });
            }
            catch (DuplicateFoundException ex)
            {
                return StatusCode(409,new { status = 409, message = ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { status = 500, message = ex.Message });
            }
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "applicationAdmin")]
        public async Task<IActionResult> DeleteCityById(int id)
        {
            try
            {
                var removed = await _cityService.RemoveCityByIdAsync(id);

                return Ok(new { status = 200, data = removed, message = "City was successfully removed" });
            }
            catch (IdNotFoundException ex)
            {
                return NotFound(new { status = 400, message = ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { status = 500, message = ex.Message });
            }
        }

        [HttpPost("{id}")]
        [Authorize(Roles = "applicationAdmin")]
        public async Task<IActionResult> UpdateCityById([FromBody]UpdateCityRequest city, int id)
        {
            try
            {
                var updated = await _cityService.UpdateCityByIdAsync(id, city);

                return Ok(new { status = 200, data = updated, message = "City was successfully updated" });
            }
            catch (IdNotFoundException ex)
            {
                return NotFound(new { status = 400, message = ex.Message });
            }
            catch (DuplicateFoundException ex)
            {
                return Conflict(new { status = 409, message = ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { status = 500, message = ex.Message });
            }
        }
    }
}
