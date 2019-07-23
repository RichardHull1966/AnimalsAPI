using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AnimalsAPI.Domain.Models;
using AnimalsAPI.Domain.Services;

namespace AnimalsAPI.Controllers

{
    [Route("api/[controller]")]
    public class MoviesController : Controller
    {
        private readonly IMovieService _movieService;

        public MoviesController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        [HttpGet]
        public async Task<IEnumerable<Movie>> GetAllAsync()
        {
            var movies = await _movieService.ListAsync();
            return movies;
        }
    }
}
