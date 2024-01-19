﻿using System;
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
    public class HospedagensController : ControllerBase
    {
        private readonly ApiDbContext _context;

        public HospedagensController(ApiDbContext context)
        {
            _context = context;
        }

        // GET: api/Hospedagens
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Hospedagem>>> GetHospedagens()
        {
            return await _context.Hospedagens.ToListAsync();
        }

        // GET: api/Hospedagens/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Hospedagem>> GetHospedagem(long id)
        {
            var hospedagem = await _context.Hospedagens.FindAsync(id);

            if (hospedagem == null)
            {
                return NotFound();
            }

            return hospedagem;
        }

        // PUT: api/Hospedagens/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHospedagem(long id, Hospedagem hospedagem)
        {
            if (id != hospedagem.Id)
            {
                return BadRequest();
            }

            _context.Entry(hospedagem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HospedagemExists(id))
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

        // POST: api/Hospedagens
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Hospedagem>> PostHospedagem(Hospedagem hospedagem)
        {
            _context.Hospedagens.Add(hospedagem);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHospedagem", new { id = hospedagem.Id }, hospedagem);
        }

        // DELETE: api/Hospedagens/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHospedagem(long id)
        {
            var hospedagem = await _context.Hospedagens.FindAsync(id);
            if (hospedagem == null)
            {
                return NotFound();
            }

            _context.Hospedagens.Remove(hospedagem);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HospedagemExists(long id)
        {
            return _context.Hospedagens.Any(e => e.Id == id);
        }
    }
}
