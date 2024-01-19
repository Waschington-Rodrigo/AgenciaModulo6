using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AgenciaApiCS.Context;
using AgenciaApiCS.Models;

namespace AgenciaApiCS.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PassagensController : ControllerBase
    {
        private readonly ApiDbContext _context;

        public PassagensController(ApiDbContext context)
        {
            _context = context;
        }

        // GET: api/Passagens
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Passagem>>> GetPassagens()
        {
            var passagens = await _context.Passagens.AsNoTracking().ToListAsync();
            foreach (var passagem in passagens)
            {
                passagem.Destino = await _context.Destinos.FindAsync(passagem.Destino_id_fk);
                passagem.Usuario = await _context.Usuarios.FindAsync(passagem.Usuario_id_fk);
            }
            return Ok(passagens);
        }

        // GET: api/Passagens/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Passagem>> GetPassagem(long id)
        {
            var passagem = await _context.Passagens.FindAsync(id);

            if (passagem == null)
            {
                return NotFound();
            }

            return passagem;
        }

        // PUT: api/Passagens/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPassagem(long id, Passagem passagem)
        {
            if (id != passagem.Id)
            {
                return BadRequest();
            }

            _context.Entry(passagem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PassagemExists(id))
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

        // POST: api/Passagens
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Passagem>> PostPassagem(Passagem passagem)
        {
            _context.Passagens.Add(passagem);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPassagem", new { id = passagem.Id }, passagem);
        }

        // DELETE: api/Passagens/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePassagem(long id)
        {
            var passagem = await _context.Passagens.FindAsync(id);
            if (passagem == null)
            {
                return NotFound();
            }

            _context.Passagens.Remove(passagem);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PassagemExists(long id)
        {
            return _context.Passagens.Any(e => e.Id == id);
        }
    }
}
