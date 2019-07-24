using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AnimalsAPI.Domain.Models;
using AnimalsAPI.Domain.Repositories;
using AnimalsAPI.Domain.Services;
using AnimalsAPI.Domain.Services.Communication;

namespace AnimalsAPI.Services
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

        public async Task<HamsterResponse> SaveAsync(Hamster hamster)
        {
            try
            {
                await _hamsterRepository.AddAsync(hamster);
                await _unitOfWork.CompleteAsync();

                return new HamsterResponse(hamster);
            }
            catch (Exception ex)
            {
                // Do some logging stuff
                return new HamsterResponse($"An error occurred when saving the hamster: {ex.Message}");
            }
        }

        public async Task<HamsterResponse> UpdateAsync(int id, Hamster hamster)
        {
            var existingHamster = await _hamsterRepository.FindByIdAsync(id);

            if (existingHamster == null)
                return new HamsterResponse("Hamster not found.");

            existingHamster.Name = hamster.Name;
            existingHamster.Age = hamster.Age;

            try
            {
                _hamsterRepository.Update(existingHamster);
                await _unitOfWork.CompleteAsync();

                return new HamsterResponse(existingHamster);
            }
            catch (Exception ex)
            {
                // Do some logging stuff
                return new HamsterResponse($"An error occurred when updating the hamster: {ex.Message}");
            }
        }

        public async Task<HamsterResponse> DeleteAsync(int id)
        {
            var existingHamster = await _hamsterRepository.FindByIdAsync(id);

            if (existingHamster == null)
                return new HamsterResponse("Hamster not found.");

            try
            {
                _hamsterRepository.Remove(existingHamster);
                await _unitOfWork.CompleteAsync();

                return new HamsterResponse(existingHamster);
            }
            catch (Exception ex)
            {
                // Do some logging stuff
                return new HamsterResponse($"An error occurred when deleting the hamster: {ex.Message}");
            }
        }
    }
}
