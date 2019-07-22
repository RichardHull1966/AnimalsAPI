using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MoviesAPI.Domain.Models;
using MoviesAPI.Domain.Repositories;
using MoviesAPI.Persistence.Contexts;

namespace MoviesAPI.Persistence.Repositories
{
    public class HamsterRepository : BaseRepository, IHamsterRepository
    {
        public HamsterRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Hamster>> ListAsync()
        {
            return await _context.Hamsters.ToListAsync();
        }
    }
}