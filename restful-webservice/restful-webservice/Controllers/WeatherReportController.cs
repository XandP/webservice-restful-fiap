using Microsoft.AspNetCore.Mvc;

namespace restful_webservice.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherReportController : Controller
    {
        private static readonly string[] Summaries = new[]
        {
            "Informa ao usuario sobre o clima"
        };

        private readonly ILogger<WeatherReportController> _logger;

        public WeatherReportController(ILogger<WeatherReportController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "getWeatherReport")]
        public IEnumerable<WeatherReport> Get(String localizacao)
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherReport
            {
            })
            .ToArray();
        }
    }
}
