using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MoviesAPI.Domain.Models;
using MoviesAPI.Domain.Repositories;
using MoviesAPI.Domain.Services;
using MoviesAPI.Domain.Services.Communication;

namespace MoviesAPI.Services
{
    public class HamsterService : IHamsterService
    {
        private readonly IHamsterRepository _hamsterRepository;
        private readonly IUnitOfWork _unitOfWork;

        public HamsterService(IHamsterRepository hamsterRepository, IUnitOfWork unitOfWork)
        {
            _hamsterRepository = hamsterRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Hamster>> ListAsync()
        {
            return await _hamsterRepository.ListAsync();
        }

        public async Task<SaveHamsterResponse> SaveAsync(Hamster hamster)
        {
            try
            {
                await _hamsterRepository.AddAsync(hamster);
                await _unitOfWork.CompleteAsync();
                
                return new SaveHamsterResponse(hamster);
            }
            catch (Exception ex)
            {
                // Do some logging stuff
                return new SaveHamsterResponse($"An error occurred when saving the hamster: {ex.Message}");
            }
        }
    }
}
