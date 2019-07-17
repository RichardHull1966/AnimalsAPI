using System.Collections.Generic;
using System.Threading.Tasks;
using MoviesAPI.Domain.Models;
using MoviesAPI.Domain.Repositories;
using MoviesAPI.Domain.Services;

namespace MoviesAPI.Services
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRepository;

        public MovieService(IMovieRepository movieRepository)
        {
            this._movieRepository = movieRepository;
        }

        public async Task<IEnumerable<Movie>> ListAsync()
        {
            return await _movieRepository.ListAsync();
        }
    }
}