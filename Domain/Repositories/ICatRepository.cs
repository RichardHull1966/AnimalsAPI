using System.Collections.Generic;
using System.Threading.Tasks;
using AnimalsAPI.Domain.Models;

namespace AnimalsAPI.Domain.Repositories
{
    public interface ICatRepository
    {
        Task<IEnumerable<Cat>> ListAsync();
	    Task AddAsync(Cat cat);
    }
}