using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Net;
using WeekOpdrachtDependencyInjection.Business;
using WeekOpdrachtDependencyInjection.Business.Interfaces;

namespace WeekOpdrachtDependencyInjection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PiController : ControllerBase
    {
        private readonly IPiStrategy _PiService;
        private readonly ICalculateAddingService _calculateAddingService;
        public PiController( IPiStrategy PiService, ICalculateAddingService calculateAddingService)
        {
            _PiService = PiService;
            _calculateAddingService = calculateAddingService;
        }

        [HttpGet]
        [Route("add/{number}")]
        public IActionResult Add(int number)
        {

            _PiService.SetStrategy(_calculateAddingService);
            return Ok(new
            {
                result = (_PiService.Add(number))
            });
        }

        [HttpGet]
        [Route("minus/{number}")]
        public IActionResult Minus(int number)
        {
            _PiService.SetStrategy(_calculateAddingService);
            return Ok(new
            {
                result = (_PiService.Substract(number))
            });
        }


        [HttpGet]
        [SwaggerResponse((int)HttpStatusCode.OK,"Swagger does not show tuples")]
        [Route("AddAndSubstract/{number}")]
        public IActionResult AddAndSubstract(int number)
        {
            _PiService.SetStrategy(_calculateAddingService);
            return Ok(new
            {
                result = (_PiService.AddAndSubstractRespectivaly((a) => _PiService.Add((int)a), (a) => _PiService.Substract((int)a), number))

            });
        }
    }
}
