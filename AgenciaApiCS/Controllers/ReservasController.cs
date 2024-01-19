using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AgenciaApiCS.Context;
using AgenciaApiCS.Models;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace AgenciaApiCS.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ReservasController : ControllerBase
    {
        private readonly ApiDbContext _context;

        public ReservasController(ApiDbContext context)
        {
            _context = context;
        }

        // GET: api/Reservas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Reserva>>> GetReservas()
        {
            var reservas = await _context.Reservas.AsNoTracking().ToListAsync();

            foreach (var reserva in reservas)
            {
                reserva.Usuario = await _context.Usuarios.FindAsync(reserva.Usuario_id_fk);
                reserva.Hospedagem = await _context.Hospedagens.FindAsync(reserva.Hospedagem_id_fk);
            }

            return Ok(reservas);
        }


        // GET: api/Reservas/5
        [HttpGet("{id}")]
    public async Task<ActionResult<Reserva>> GetReserva(long id)
    {
        var reserva = await _context.Reservas.Include(r => r.Usuario).Include(r => r.Hospedagem).SingleOrDefaultAsync(r => r.Id == id);

        if (reserva == null)
        {
            return NotFound();
        }

        return reserva;
    }

    // PUT: api/Reservas/5
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPut("{id}")]
    public async Task<IActionResult> PutReserva(long id, Reserva reserva)
    {
        if (id != reserva.Id)
        {
            return BadRequest();
        }

        _context.Entry(reserva).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!ReservaExists(id))
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

    // POST: api/Reservas
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPost]
    public async Task<ActionResult<Reserva>> PostReserva(Reserva reserva)
    {
        _context.Reservas.Add(reserva);
        await _context.SaveChangesAsync();

        return CreatedAtAction("GetReserva", new { id = reserva.Id }, reserva);
    }

    // DELETE: api/Reservas/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteReserva(long id)
    {
        var reserva = await _context.Reservas.FindAsync(id);
        if (reserva == null)
        {
            return NotFound();
        }

        _context.Reservas.Remove(reserva);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool ReservaExists(long id)
    {
        return _context.Reservas.Any(e => e.Id == id);
    }
}
}
