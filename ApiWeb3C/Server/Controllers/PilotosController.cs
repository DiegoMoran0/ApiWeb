using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiWeb3C.Server.Data;
using ApiWeb3C.Shared.Modelos;

namespace ApiWeb3C.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PilotosController : ControllerBase
    {
        private readonly BasedeDatosContext _context;

        public PilotosController(BasedeDatosContext context)
        {
            _context = context;
        }

        // GET: api/Pilotos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Piloto>>> GetPiloto()
        {
          if (_context.Piloto == null)
          {
              return NotFound();
          }
            return await _context.Piloto.ToListAsync();
        }

        // GET: api/Pilotos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Piloto>> GetPiloto(int id)
        {
          if (_context.Piloto == null)
          {
              return NotFound();
          }
            var piloto = await _context.Piloto.FindAsync(id);

            if (piloto == null)
            {
                return NotFound();
            }

            return piloto;
        }

        // PUT: api/Pilotos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPiloto(int id, Piloto piloto)
        {
            if (id != piloto.Id)
            {
                return BadRequest();
            }

            _context.Entry(piloto).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PilotoExists(id))
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

        // POST: api/Pilotos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Piloto>> PostPiloto(Piloto piloto)
        {
          if (_context.Piloto == null)
          {
              return Problem("Entity set 'BasedeDatosContext.Piloto'  is null.");
          }
            _context.Piloto.Add(piloto);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPiloto", new { id = piloto.Id }, piloto);
        }

        // DELETE: api/Pilotos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePiloto(int id)
        {
            if (_context.Piloto == null)
            {
                return NotFound();
            }
            var piloto = await _context.Piloto.FindAsync(id);
            if (piloto == null)
            {
                return NotFound();
            }

            _context.Piloto.Remove(piloto);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PilotoExists(int id)
        {
            return (_context.Piloto?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
