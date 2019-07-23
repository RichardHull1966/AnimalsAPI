using System.Collections.Generic;
using System.Threading.Tasks;
using MoviesAPI.Domain.Models;

namespace MoviesAPI.Domain.Repositories
{
    public interface IHamsterRepository
    {
        Task<IEnumerable<Hamster>> ListAsync();
	    Task AddAsync(Hamster hamster);
    }
}