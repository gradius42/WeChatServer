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
    [Route("api/Marks")]
    public class MarksController : Controller
    {
        private readonly SNCFContext _context;

        public MarksController(SNCFContext context)
        {
            _context = context;
        }

        // GET: api/Marks
        [HttpGet]
        public IEnumerable<Mark> GetMarks()
        {
            return _context.Marks;
        }

        // GET: api/Marks/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMark([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mark = await _context.Marks.SingleOrDefaultAsync(m => m.ID == id);

            if (mark == null)
            {
                return NotFound();
            }

            return Ok(mark);
        }

        // POST: api/Marks
        [HttpPost]
        public async Task<IActionResult> PostMark([FromBody] Mark mark)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Marks.Add(mark);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMark", new { id = mark.ID }, mark);
        }

        // DELETE: api/Marks/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMark([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mark = await _context.Marks.SingleOrDefaultAsync(m => m.ID == id);
            if (mark == null)
            {
                return NotFound();
            }

            _context.Marks.Remove(mark);
            await _context.SaveChangesAsync();

            return Ok(mark);
        }

        private bool MarkExists(int id)
        {
            return _context.Marks.Any(e => e.ID == id);
        }
    }
}