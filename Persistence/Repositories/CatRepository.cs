using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AnimalsAPI.Domain.Models;
using AnimalsAPI.Domain.Repositories;
using AnimalsAPI.Persistence.Contexts;

namespace AnimalsAPI.Persistence.Repositories
{
    public class CatRepository : BaseRepository, ICatRepository
{
	public CatRepository(AppDbContext context) : base(context)
	{ }

	public async Task<IEnumerable<Cat>> ListAsync()
	{
		return await _context.Cats.ToListAsync();
	}

	public async Task AddAsync(Cat cat)
	{
		await _context.Cats.AddAsync(cat);
	}
}
}