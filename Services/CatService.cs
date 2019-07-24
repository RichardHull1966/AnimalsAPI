using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AnimalsAPI.Domain.Models;
using AnimalsAPI.Domain.Repositories;
using AnimalsAPI.Domain.Services;
using AnimalsAPI.Domain.Services.Communication;

namespace AnimalsAPI.Services
{
    public class CatService : ICatService
    {
        private readonly ICatRepository _catRepository;
        private readonly IUnitOfWork _unitOfWork;

        public CatService(ICatRepository catRepository, IUnitOfWork unitOfWork)
        {
            _catRepository = catRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Cat>> ListAsync()
        {
            return await _catRepository.ListAsync();
        }

        public async Task<CatResponse> GetAsync(int id){
            var cat = await _catRepository.FindByIdAsync(id);
            if (cat == null)
                return new CatResponse("Cat not found.");

            return new CatResponse(cat);
        }

        public async Task<CatResponse> SaveAsync(Cat cat)
        {
            try
            {
                await _catRepository.AddAsync(cat);
                await _unitOfWork.CompleteAsync();

                return new CatResponse(cat);
            }
            catch (Exception ex)
            {
                // Do some logging stuff
                return new CatResponse($"An error occurred when saving the cat: {ex.Message}");
            }
        }

        public async Task<CatResponse> UpdateAsync(int id, Cat cat)
        {
            var existingCat = await _catRepository.FindByIdAsync(id);

            if (existingCat == null)
                return new CatResponse("Cat not found.");

            existingCat.Name = cat.Name;
            existingCat.Type = cat.Type;
            existingCat.YearOfBirth = cat.YearOfBirth;

            try
            {
                _catRepository.Update(existingCat);
                await _unitOfWork.CompleteAsync();

                return new CatResponse(existingCat);
            }
            catch (Exception ex)
            {
                // Do some logging stuff
                return new CatResponse($"An error occurred when updating the cat: {ex.Message}");
            }
        }

        public async Task<CatResponse> DeleteAsync(int id)
        {
            var existingCat = await _catRepository.FindByIdAsync(id);

            if (existingCat == null)
                return new CatResponse("Cat not found.");

            try
            {
                _catRepository.Remove(existingCat);
                await _unitOfWork.CompleteAsync();

                return new CatResponse(existingCat);
            }
            catch (Exception ex)
            {
                // Do some logging stuff
                return new CatResponse($"An error occurred when deleting the cat: {ex.Message}");
            }
        }
    }
}
