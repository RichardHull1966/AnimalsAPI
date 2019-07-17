using System.Collections.Generic;
using System.Threading.Tasks;
using MoviesAPI.Domain.Models;

namespace MoviesAPI.Domain.Repositories
{
    public interface IMovieRepository
    {
        Task<IEnumerable<Movie>> ListAsync();
    }
}