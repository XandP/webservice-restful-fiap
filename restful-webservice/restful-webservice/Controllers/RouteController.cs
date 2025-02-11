﻿using Microsoft.AspNetCore.Mvc;

namespace restful_webservice.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RouteController : Controller
    {
        private static readonly string[] Summaries = new[]
        {
            ""
        };

        private readonly ILogger<RouteController> _logger;

        public RouteController(ILogger<RouteController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "getRoute")]
        public IEnumerable<Route> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new Route
            {
            })
            .ToArray();
        }

        [HttpPost("test")]
        public string test()
        {
            var url = Url.Link("xxx", null);
            return $"The url of Route Name xxx is {url}";
        }
    }
}
