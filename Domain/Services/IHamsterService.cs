
using System.Collections.Generic;
using System.Threading.Tasks;
using AnimalsAPI.Domain.Models;
using AnimalsAPI.Domain.Services.Communication;

namespace AnimalsAPI.Domain.Services
{
    public interface IHamsterService
    {
        Task<IEnumerable<Hamster>> ListAsync();
        Task<HamsterResponse> GetAsync(int id);
        Task<HamsterResponse> SaveAsync(Hamster hamster);
        Task<HamsterResponse> UpdateAsync(int id, Hamster hamster);
        Task<HamsterResponse> DeleteAsync(int id);
    }
}