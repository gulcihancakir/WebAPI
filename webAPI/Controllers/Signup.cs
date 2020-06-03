using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using webAPI.Domain.Models;
using webAPI.Persistance.Contexts;

namespace webAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Signup : ControllerBase
    {
        private readonly AppDbContext _context;

        public Signup(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/TemsilciOl
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Domain.Models.Signup>>> GetTemsilciOl()
        {
            return await _context.Signup.ToListAsync();
        }

        // GET: api/TemsilciOl/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Domain.Models.Signup>> GetTemsilciOl(int id)
        {
            var temsilciOl = await _context.Signup.FindAsync(id);

            if (temsilciOl == null)
            {
                return NotFound();
            }

            return temsilciOl;
        }

        // PUT: api/TemsilciOl/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTemsilciOl(int id, Domain.Models.Signup temsilciOl)
        {
            if (id != temsilciOl.Id)
            {
                return BadRequest();
            }

            _context.Entry(temsilciOl).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TemsilciOlExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/TemsilciOl
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Domain.Models.Signup>> PostTemsilciOl(Domain.Models.Signup temsilciOl)
        {
            _context.Signup.Add(temsilciOl);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTemsilciOl", new { id = temsilciOl.Id }, temsilciOl);
        }

        // DELETE: api/TemsilciOl/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Domain.Models.Signup>> DeleteTemsilciOl(int id)
        {
            var temsilciOl = await _context.Signup.FindAsync(id);
            if (temsilciOl == null)
            {
                return NotFound();
            }

            _context.Signup.Remove(temsilciOl);
            await _context.SaveChangesAsync();

            return temsilciOl;
        }

        private bool TemsilciOlExists(int id)
        {
            return _context.Signup.Any(e => e.Id == id);
        }
    }
}
