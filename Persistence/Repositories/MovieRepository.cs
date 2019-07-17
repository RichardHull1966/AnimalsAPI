using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MoviesAPI.Domain.Models;
using MoviesAPI.Domain.Repositories;
using MoviesAPI.Persistence.Contexts;

namespace MoviesAPI.Persistence.Repositories
{
    public class MovieRepository : BaseRepository, IMovieRepository
    {
        public MovieRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Movie>> ListAsync()
        {
            return await _context.Movies.ToListAsync();
        }
    }
}