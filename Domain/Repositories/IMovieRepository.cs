using System.Collections.Generic;
using System.Threading.Tasks;
using AnimalsAPI.Domain.Models;

namespace AnimalsAPI.Domain.Repositories
{
    public interface IMovieRepository
    {
        Task<IEnumerable<Movie>> ListAsync();
    }
}