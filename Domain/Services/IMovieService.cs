using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using MoviesAPI.Models;

namespace MoviesAPI.Services

{
    public interface IMovieService
    {
         Task<IEnumerable<Movie>> ListAsync();
    }
}
