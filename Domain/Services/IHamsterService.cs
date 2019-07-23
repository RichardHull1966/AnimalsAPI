
using System.Collections.Generic;
using System.Threading.Tasks;
using MoviesAPI.Domain.Models;
using MoviesAPI.Domain.Services.Communication;

namespace MoviesAPI.Domain.Services
{
    public interface IHamsterService
    {
         Task<IEnumerable<Hamster>> ListAsync();
         Task<SaveHamsterResponse> SaveAsync(Hamster hamster);
    }
}