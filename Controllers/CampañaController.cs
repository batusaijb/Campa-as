using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Campañas.Models;

namespace Campañas.Controllers
{
    [Route("campaña")]
    [ApiController]
    public class CampañaController : ControllerBase
    {
        private readonly CampañasContext _context;

        public CampañaController(CampañasContext context)
        {
            _context = context;
        }

        // GET: api/Campaña
        /// <summary>
        /// Consultar Todas las campanas
        /// </summary>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        
        public async Task<ActionResult<IEnumerable<Campaña>>> GetCampaña()
        {
            return await _context.Campaña.ToListAsync();
        }

        // GET: api/Campaña/5
        /// <summary>
        /// Consultar Campaña por ID
        /// </summary>
        [HttpGet("idCampaña")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Campaña>> GetCampaña(int? id)
        {
            var campaña = await _context.Campaña.FindAsync(id);

            if (campaña == null)
            {
                return NotFound();
            }

            return campaña;
        }

        // PUT: api/Campaña/5
        /// <summary>
        /// Actualizar/Inactivar Campaña por ID
        /// </summary>
        [HttpPut("idCampaña")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> PutCampaña(int? id, Campaña campaña)
        {
            if (id != campaña.IdCamapana)
            {
                return BadRequest();
            }

            _context.Entry(campaña).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CampañaExists(id))
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

        // POST: api/Campaña

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Campaña>> PostCampaña(Campaña campaña)
        {
            _context.Campaña.Add(campaña);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCampaña", new { id = campaña.IdCamapana }, campaña);
        }

        private bool CampañaExists(int? id)
        {
            return _context.Campaña.Any(e => e.IdCamapana == id);
        }
    }
}
