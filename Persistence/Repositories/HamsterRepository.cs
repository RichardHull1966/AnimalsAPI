﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AnimalsAPI.Domain.Models;
using AnimalsAPI.Domain.Repositories;
using AnimalsAPI.Persistence.Contexts;

namespace AnimalsAPI.Persistence.Repositories
{
    public class HamsterRepository : BaseRepository, IHamsterRepository
	{
		public HamsterRepository(AppDbContext context) : base(context)
		{ }

		public async Task<IEnumerable<Hamster>> ListAsync()
		{
			return await _context.Hamsters.ToListAsync();
		}

		public async Task AddAsync(Hamster hamster)
		{
			await _context.Hamsters.AddAsync(hamster);
		}

		public async Task<Hamster> FindByIdAsync(int id)
		{
			return await _context.Hamsters.FindAsync(id);
		}

		public void Update(Hamster hamster)
		{
			_context.Hamsters.Update(hamster);
		}

		public void Remove(Hamster hamster)
		{
			_context.Hamsters.Remove(hamster);
		}
	}
}