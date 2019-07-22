using System.Collections.Generic;
using System.Threading.Tasks;
using MoviesAPI.Domain.Models;

namespace MoviesAPI.Domain.Services

{
    public interface IHamsterService
    {
        Task<IEnumerable<Hamster>> ListAsync();
    }
}
