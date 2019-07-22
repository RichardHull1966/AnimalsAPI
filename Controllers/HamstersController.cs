using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MoviesAPI.Domain.Models;
using MoviesAPI.Domain.Services;

namespace HamstersAPI.Controllers

{
    [Route("api/[controller]")]
    public class HamstersController : Controller
    {
        private readonly IHamsterService _hamsterService;

        public HamstersController(IHamsterService hamsterService)
        {
            _hamsterService = hamsterService;
        }

        [HttpGet]
        public async Task<IEnumerable<Hamster>> GetAllAsync()
        {
            var hamsters = await _hamsterService.ListAsync();
            return hamsters;
        }
    }
}
