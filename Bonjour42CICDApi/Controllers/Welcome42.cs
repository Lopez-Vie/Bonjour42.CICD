using Bonjour42.CICD.Api.Services;
using Bonjour42CICDApi;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bonjour42.CICD.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Welcome42 : ControllerBase
    {
        [HttpGet]
        public IActionResult GetWelcomeMessage()
        {
            MathService math = new MathService();
            int resultat = math.Addition(40, 2);
            string welcomeMessage = $"Welcome to the {resultat} CICD API!";
           
            return Ok(welcomeMessage);
        }

    }
}
