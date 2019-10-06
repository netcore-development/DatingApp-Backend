using System.Threading.Tasks;
using DatingApp.API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly DbContextSqlite _context;

        public ValuesController(DbContextSqlite context)
        {
            _context = context;
        }

        // GET api/values
        [HttpGet]
        public async Task<IActionResult> GetValues() {
            var values = await _context.Values.ToListAsync();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetValue(int id) {
            var value = await _context.Values.FirstOrDefaultAsync(p => p.Id == id);
            return Ok(value);
        }

    }
}