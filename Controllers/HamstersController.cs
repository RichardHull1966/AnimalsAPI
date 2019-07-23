using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MoviesAPI.Domain.Models;
using MoviesAPI.Domain.Services;
using MoviesAPI.Resources;

namespace MoviesAPI.Controllers
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
    }
}