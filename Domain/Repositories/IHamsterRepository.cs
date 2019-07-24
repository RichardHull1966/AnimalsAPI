using System.Collections.Generic;
using System.Threading.Tasks;
using AnimalsAPI.Domain.Models;

namespace AnimalsAPI.Domain.Repositories
{
    public interface IHamsterRepository
    {
        Task<IEnumerable<Hamster>> ListAsync();
	    Task AddAsync(Hamster hamster);
        Task<Hamster> FindByIdAsync(int id);
	    void Update(Hamster hamster);
        void Remove(Hamster hamster);
    }
}