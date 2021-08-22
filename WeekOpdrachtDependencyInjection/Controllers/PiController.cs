using Microsoft.AspNetCore.Mvc;
using WeekOpdrachtDependencyInjection.Business;
using WeekOpdrachtDependencyInjection.Business.Interfaces;

namespace WeekOpdrachtDependencyInjection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PiController : ControllerBase
    {
        private readonly string a;
        private readonly ICalculatePiService _calculatePiService;

        public PiController( ICalculatePiService calculatePiService)
        {
            _calculatePiService = calculatePiService;
        }

        [HttpGet]
        [Route("add/{number}")]
        public IActionResult Add(int number)
        {
            var calculatePiService = new CalculatePiService();

            return Ok(new
            {
                result = (_calculatePiService.Add(number))
            });
        }

        [HttpGet]
        [Route("minus/{number}")]
        public IActionResult Minus(int number)
        {
            //return Ok(new
            //{
            //    result = (_calculatePiService.Minus(number))
            //});
            return Ok();
        }
    }
}
