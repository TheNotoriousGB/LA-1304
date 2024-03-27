using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestApi_1304.Models;
using System.Linq;


namespace LB_295_BischofGabriel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VeranstaltungenController : ControllerBase
    {
        private readonly VeranstaltungenDbContext _context;

        public VeranstaltungenController(VeranstaltungenDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Veranstaltungen>>> GetVeranstaltungen()
        {
            if (_context.Veranstaltungen == null)
            {
                return NotFound();
            }
            return await _context.Veranstaltungen.ToListAsync();
        }
        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<Veranstaltungen>> GetVeranstaltung(int id)
        {
            var veranstaltung = await _context.Veranstaltungen.FindAsync(id);

            if (veranstaltung == null)
            {
                return NotFound();
            }

            return veranstaltung;
        }

            [HttpPost]
            public async Task<ActionResult<Veranstaltungen>> PostVeranstaltung(Veranstaltungen veranstaltung)
            {
                _context.Veranstaltungen.Add(veranstaltung);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetVeranstaltung", new { id = veranstaltung.Id }, veranstaltung);
            }

            [HttpPut]
            [Route("{id}")]
            public async Task<IActionResult> PutVeranstaltung(int id, Veranstaltungen veranstaltung)
            {
                if (id != veranstaltung.Id)
                {
                    return BadRequest();
                }

                _context.Entry(veranstaltung).State = EntityState.Modified;

                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VeranstaltungExists(id))
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

            [HttpDelete]
            [Route("{id}")]
            public async Task<IActionResult> DeleteVeranstaltung(int id)
            {
                var veranstaltung = await _context.Veranstaltungen.FindAsync(id);
                if (veranstaltung == null)
                {
                    return NotFound();
                }

                _context.Veranstaltungen.Remove(veranstaltung);
                await _context.SaveChangesAsync();

                return NoContent();
            }

        private bool VeranstaltungExists(int id)
        {
            return _context.Veranstaltungen.Any(e => e.Id == id);
        }

        }
    }

