using System.Collections.Generic;
using System.Threading.Tasks;
using MoviesAPI.Domain.Models;
using MoviesAPI.Domain.Repositories;
using MoviesAPI.Domain.Services;

namespace MoviesAPI.Services
{
    public class HamsterService : IHamsterService
    {
        private readonly IHamsterRepository _hamsterRepository;

        public HamsterService(IHamsterRepository hamsterRepository)
        {
            this._hamsterRepository = hamsterRepository;
        }

        public async Task<IEnumerable<Hamster>> ListAsync()
        {
            return await _hamsterRepository.ListAsync();
        }
    }
}