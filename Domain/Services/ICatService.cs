
using System.Collections.Generic;
using System.Threading.Tasks;
using AnimalsAPI.Domain.Models;
using AnimalsAPI.Domain.Services.Communication;

namespace AnimalsAPI.Domain.Services
{
    public interface ICatService
    {
        Task<IEnumerable<Cat>> ListAsync();
        Task<CatResponse> GetAsync(int id);
        Task<CatResponse> SaveAsync(Cat cat);
        Task<CatResponse> UpdateAsync(int id, Cat cat);
        Task<CatResponse> DeleteAsync(int id);
    }
}