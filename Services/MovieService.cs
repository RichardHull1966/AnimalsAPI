using System.Collections.Generic;
using System.Threading.Tasks;
using AnimalsAPI.Domain.Models;
using AnimalsAPI.Domain.Repositories;
using AnimalsAPI.Domain.Services;

namespace AnimalsAPI.Services
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