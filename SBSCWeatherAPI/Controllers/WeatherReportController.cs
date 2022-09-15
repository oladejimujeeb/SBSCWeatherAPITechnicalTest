using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SBSCWeatherAPI.Interface.IServices;
using System;
using System.Threading.Tasks;

namespace SBSCWeatherAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherReportController : ControllerBase
    {
        private readonly IWeatherService _weatherService;

        public WeatherReportController(IWeatherService weatherService)
        {
            _weatherService = weatherService;
        }
       
        [HttpGet("/date")]
        public IActionResult WeatherReportByDate(DateTime date)
        {
            var result = _weatherService.GetWeatherReportByDate(date);
            if (result.Status)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }
        [HttpGet("/state")]
        public IActionResult WeatherReportByState(string state)
        {
            var result = _weatherService.GetWeatherReportByState(state);
            if (result.Status)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }
    }
}
