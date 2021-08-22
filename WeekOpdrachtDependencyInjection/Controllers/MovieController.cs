using Microsoft.AspNetCore.Mvc;
using WeekOpdrachtDependencyInjection.Business;

namespace WeekOpdrachtDependencyInjection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly MovieService movieService;

        public MovieController()
        {
            movieService = new MovieService();
        }

        [HttpGet("id")]
        public IActionResult GetById(int id)
        {
            var movie = movieService.Get(id);
            return Ok(movie);
        }

        [HttpGet("title")]
        public IActionResult GetByName(string title)
        {
            var movie = movieService.Get(title);
            return Ok(movie);
        }
    }
}
