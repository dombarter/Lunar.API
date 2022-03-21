using Lunar.Data;
using Lunar.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lunar.API.Controllers
{
    [ApiController]
    [Route("moons")]
    public class MoonController : Controller
    {
        private readonly LunarDbContext _db;
        public MoonController(LunarDbContext db)
        {
            _db = db;
        }

        [HttpGet("")]
        public IEnumerable<Moon> GetAll()
        {
            return _db.Moons.ToArray();
        } 

        /// <summary>
        /// Create a new Moon!
        /// </summary>
        /// <param name="moon"></param>
        /// <returns></returns>
        [HttpPost("")]
        public Moon Create([FromBody] Moon moon)
        {
            _db.Moons.Add(moon);
            _db.SaveChanges();
            return moon;
        }
    }
}
