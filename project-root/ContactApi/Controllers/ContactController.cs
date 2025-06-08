using Microsoft.AspNetCore.Mvc;
using ContactApi.Models;
using ContactApi.Data;

namespace ContactApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContactController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ContactController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult SaveContact([FromBody] Contact contact)
        {
            // Save contact logic
            return Ok();
        }
    }
}