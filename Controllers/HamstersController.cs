using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using AnimalsAPI.Domain.Models;
using AnimalsAPI.Domain.Services;
using AnimalsAPI.Resources;
using AnimalsAPI.Extensions;

namespace AnimalsAPI.Controllers
{
    [Route("/api/[controller]")]
    public class HamstersController : Controller
    {
        private readonly IHamsterService _hamsterService;
        private readonly IMapper _mapper;

        public HamstersController(IHamsterService hamsterService, IMapper mapper)
        {
            _hamsterService = hamsterService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<HamsterResource>> GetAllAsync()
        {
            var hamsters = await _hamsterService.ListAsync();
            var resources = _mapper.Map<IEnumerable<Hamster>, IEnumerable<HamsterResource>>(hamsters);
            
            return resources;
        }


        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] SaveHamsterResource resource)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.GetErrorMessages());

            var hamster = _mapper.Map<SaveHamsterResource, Hamster>(resource);
            var result = await _hamsterService.SaveAsync(hamster);

            if (!result.Success)
                return BadRequest(result.Message);

            var hamsterResource = _mapper.Map<Hamster, HamsterResource>(result.Hamster);
            return Ok(hamsterResource);
        }
    }
}