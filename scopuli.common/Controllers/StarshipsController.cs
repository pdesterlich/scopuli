using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace scopuli.common.Controllers
{
    [Route("api/[controller]")]
    public class StarshipsController : Controller
    {
        private readonly ScopuliDbContext _context;

        public StarshipsController(ScopuliDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var starships = _context.Starships.ToList();

            return Ok(starships);
        }
    }
}