using System.Threading.Tasks;
using DatingApp.API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        private readonly DbContextSqlite _context;
        public PersonsController(DbContextSqlite context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetPersons() {
            var persons = await _context.Persons.ToListAsync();
            return Ok(persons);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPerson(int id) {
            var person = await _context.Persons.FirstOrDefaultAsync(p => p.Id == id);
            return Ok(person.name);
        }
        

    }
}