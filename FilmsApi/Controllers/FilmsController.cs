using FilmsApi.Data;
using FilmsApi.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmsApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilmsController : ControllerBase
    {
        private readonly ApplicationContext _dbContext;

        public FilmsController(ApplicationContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IEnumerable<FilmDTO> Get(int count = 10)
        {
            return _dbContext.Films.Include(x => x.Genre).Select(x => new FilmDTO
            {
                Id = x.Id,
                Name = x.Name,
                Rating = x.Rating,
                GenreId = x.Genre.Id
            });
        }

        [HttpPost]
        public async Task<IActionResult> Add(FilmDTO film)
        {
            if (film == null)
            {
                return BadRequest();
            }

            _dbContext.Films.Add(new Film
            {
                Name = film.Name,
                Rating = film.Rating,
                Genre = _dbContext.Genres.FirstOrDefault(x => x.Id == film.GenreId)
            });

            await _dbContext.SaveChangesAsync();

            return Ok();
        }
    }
}

// CRUD
// C - Post
// R - Get
// U - Put
// D - Delete