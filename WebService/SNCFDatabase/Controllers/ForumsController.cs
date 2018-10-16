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
    [Route("api/Forums")]
    public class ForumsController : Controller
    {
        private readonly SNCFContext _context;

        public ForumsController(SNCFContext context)
        {
            _context = context;
        }

        // GET: api/Forums
        [HttpGet]
        public IEnumerable<Forum> GetForums()
        {
            return _context.Forums;
        }

        // GET: api/Forums/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetForum([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var forum = await _context.Forums.SingleOrDefaultAsync(m => m.ID == id);

            if (forum == null)
            {
                return NotFound();
            }

            return Ok(forum);
        }

        // POST: api/Forums
        [HttpPost]
        public async Task<IActionResult> PostForum([FromBody] Forum forum)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Forums.Add(forum);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetForum", new { id = forum.ID }, forum);
        }

        // DELETE: api/Forums/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteForum([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var forum = await _context.Forums.SingleOrDefaultAsync(m => m.ID == id);
            if (forum == null)
            {
                return NotFound();
            }

            _context.Forums.Remove(forum);
            await _context.SaveChangesAsync();

            return Ok(forum);
        }

        private bool ForumExists(int id)
        {
            return _context.Forums.Any(e => e.ID == id);
        }
    }
}