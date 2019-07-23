
using System.Collections.Generic;
using System.Threading.Tasks;
using AnimalsAPI.Domain.Models;
using AnimalsAPI.Domain.Services.Communication;

namespace AnimalsAPI.Domain.Services
{
    public interface ICatService
    {
         Task<IEnumerable<Cat>> ListAsync();
         Task<SaveCatResponse> SaveAsync(Cat cat);
    }
}