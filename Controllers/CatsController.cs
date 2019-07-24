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
    public class CatsController : Controller
    {
        private readonly ICatService _catService;
        private readonly IMapper _mapper;

        public CatsController(ICatService catService, IMapper mapper)
        {
            _catService = catService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<CatResource>> GetAllAsync()
        {
            var cats = await _catService.ListAsync();
            var resources = _mapper.Map<IEnumerable<Cat>, IEnumerable<CatResource>>(cats);
            
            return resources;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync(int id)
        {
            var result = await _catService.GetAsync(id);

            if (!result.Success)
                return BadRequest(result.Message);

            var catResource = _mapper.Map<Cat, CatResource>(result.Cat);
            return Ok(catResource);
        }


        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] SaveCatResource resource)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.GetErrorMessages());

            var cat = _mapper.Map<SaveCatResource, Cat>(resource);
            var result = await _catService.SaveAsync(cat);

            if (!result.Success)
                return BadRequest(result.Message);

            var catResource = _mapper.Map<Cat, CatResource>(result.Cat);
            return Ok(catResource);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsync(int id, [FromBody] SaveCatResource resource)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.GetErrorMessages());

            var cat = _mapper.Map<SaveCatResource, Cat>(resource);
            var result = await _catService.UpdateAsync(id, cat);

            if (!result.Success)
                return BadRequest(result.Message);

            var catResource = _mapper.Map<Cat, CatResource>(result.Cat);
            return Ok(catResource);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var result = await _catService.DeleteAsync(id);

            if (!result.Success)
                return BadRequest(result.Message);

            var catResource = _mapper.Map<Cat, CatResource>(result.Cat);
            return Ok(catResource);
        }
    }
}