using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SNCFDatabase.Data;
using SNCFDatabase.Models;

namespace SNCFDatabase.Controllers
{
    [Produces("application/json")]
    [Route("api/Opinions")]
    public class OpinionsController : Controller
    {
        private readonly SNCFContext _context;

        public OpinionsController(SNCFContext context)
        {
            _context = context;
        }

        // GET: api/Opinions
        [HttpGet]
        public IEnumerable<Opinion> GetOpinions()
        {
            return _context.Opinions;
        }

        // GET: api/Opinions/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetOpinion([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var opinion = await _context.Opinions.SingleOrDefaultAsync(m => m.ID == id);

            if (opinion == null)
            {
                return NotFound();
            }

            return Ok(opinion);
        }
        
        // POST: api/Opinions
        [HttpPost]
        public async Task<IActionResult> PostOpinion([FromBody] Opinion opinion)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Opinions.Add(opinion);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOpinion", new { id = opinion.ID }, opinion);
        }

        // DELETE: api/Opinions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOpinion([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var opinion = await _context.Opinions.SingleOrDefaultAsync(m => m.ID == id);
            if (opinion == null)
            {
                return NotFound();
            }

            _context.Opinions.Remove(opinion);
            await _context.SaveChangesAsync();

            return Ok(opinion);
        }

        private bool OpinionExists(int id)
        {
            return _context.Opinions.Any(e => e.ID == id);
        }
    }
}