using ConectaPorto.Dto;
using ConectaPorto.Services.BizService;
using ConectaPorto.Services.BizService.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ConectaPorto.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IWeatherForecast _weatherForecast;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IWeatherForecast weatherForecast )
        {
            _logger = logger;
            _weatherForecast = weatherForecast;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return _weatherForecast.GerarDados(Summaries);
        }
    }
}
