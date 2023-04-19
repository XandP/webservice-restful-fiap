using Microsoft.AspNetCore.Mvc;

namespace restful_webservice.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CicloviaController : Controller
    {
        private static readonly string[] Summaries = new[]
        {
            "Utilizado para obter info sobre a rota"
        };  

        private readonly ILogger<CicloviaController> _logger;

        public CicloviaController(ILogger<CicloviaController> logger)
        {
            _logger = logger;
        }

        [HttpGet("get_informacao_rota")]
        public string get_informacao_rota(String localizacao)
        {
            return "Essa localizacao consta como perigosa, retorne.";
        }


        [HttpPost("alertar_perigo")]
        public string alertar_perigo(String localizacao)
        {
            // Funcao para salvar localizacao como area de risco

            return $"Lugar marcado como perigoso";
        }
    }
}
