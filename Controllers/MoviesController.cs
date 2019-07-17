using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MoviesAPI.Domain.Models;
using MoviesAPI.Domain.Services;

namespace MoviesAPI.Controllers

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
