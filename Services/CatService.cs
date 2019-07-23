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

        public async Task<SaveCatResponse> SaveAsync(Cat cat)
        {
            try
            {
                await _catRepository.AddAsync(cat);
                await _unitOfWork.CompleteAsync();
                
                return new SaveCatResponse(cat);
            }
            catch (Exception ex)
            {
                // Do some logging stuff
                return new SaveCatResponse($"An error occurred when saving the cat: {ex.Message}");
            }
        }
    }
}
