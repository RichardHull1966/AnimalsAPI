using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MoviesAPI.Services;

namespace MoviesAPI.Controllers

{
    [Route("api/[controller]")]
    public class MoviesController : Controller
    {
        private MoviesDbContext _context;
        public MoviesController(MoviesDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_context.Movies);
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "id = " + id;
        }
    }
}
