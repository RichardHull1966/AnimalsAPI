
using System.Collections.Generic;
using System.Threading.Tasks;
using AnimalsAPI.Domain.Models;
using AnimalsAPI.Domain.Services.Communication;

namespace AnimalsAPI.Domain.Services
{
    public interface IHamsterService
    {
         Task<IEnumerable<Hamster>> ListAsync();
         Task<SaveHamsterResponse> SaveAsync(Hamster hamster);
    }
}