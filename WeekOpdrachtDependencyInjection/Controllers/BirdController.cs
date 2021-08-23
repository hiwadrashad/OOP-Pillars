using Microsoft.AspNetCore.Mvc;
using WeekOpdrachtDependencyInjection.Business.Entities;
using WeekOpdrachtDependencyInjection.Business.Factories;
using WeekOpdrachtDependencyInjection.Business.Interfaces;

namespace WeekOpdrachtDependencyInjection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BirdController : ControllerBase
    {
        private readonly IPoultryFactory<IDuckDTO> _duckFactory;
        private readonly IPoultryFactory<IGooseDTO> _gooseFactory;
        private readonly IPoultryFactory<IChickenDTO> _chickenFactory;

        public BirdController(IPoultryFactory<IDuckDTO> duckFactory, IPoultryFactory<IGooseDTO> gooseFactory, IPoultryFactory<IChickenDTO> chickenfactory)
        {
            _duckFactory = duckFactory;
            _gooseFactory = gooseFactory;
            _chickenFactory = chickenfactory;
        }

        [HttpGet]
        [Route("duck")]
        public IActionResult Duck()
        {
            return Ok(_duckFactory.CreateDTO().Sound());
        }

        [HttpGet]
        [Route("goose")]
        public IActionResult Goose()
        {
            return Ok(_gooseFactory.CreateDTO().Sound());
        }

        [HttpGet]
        [Route("chicken")]
        public IActionResult Chicken()
        {
            return Ok(_chickenFactory.CreateDTO().Sound());
        }
    }
}
