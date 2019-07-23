using System.Collections.Generic;
using System.Threading.Tasks;
using AnimalsAPI.Domain.Models;

namespace AnimalsAPI.Domain.Services

{
    public interface IMovieService
    {
         Task<IEnumerable<Movie>> ListAsync();
    }
}
