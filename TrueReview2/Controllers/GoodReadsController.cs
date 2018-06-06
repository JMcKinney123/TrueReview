using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TrueReview2.Data;
using TrueReview2.Models;

namespace TrueReview2.Controllers
{
   /* [Produces("application/json")]
    [Route("api/GoodReads")]
    public class BACKUPGoodReadsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BACKUPGoodReadsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/GoodReads
        [HttpGet]
        public IEnumerable<GoodRead> GetGoodRead()
        {
            return _context.GoodRead;
        }

        // GET: api/GoodReads/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetGoodRead([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var goodRead = await _context.GoodRead.SingleOrDefaultAsync(m => m.GoodReadId == id);

            if (goodRead == null)
            {
                return NotFound();
            }

            return Ok(goodRead);
        }

        // PUT: api/GoodReads/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGoodRead([FromRoute] int id, [FromBody] GoodRead goodRead)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != goodRead.GoodReadId)
            {
                return BadRequest();
            }

            _context.Entry(goodRead).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GoodReadExists(id))
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

        // POST: api/GoodReads
        [HttpPost]
        public async Task<IActionResult> PostGoodRead([FromBody] GoodRead goodRead)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.GoodRead.Add(goodRead);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetGoodRead", new { id = goodRead.GoodReadId }, goodRead);
        }

        // DELETE: api/GoodReads/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGoodRead([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var goodRead = await _context.GoodRead.SingleOrDefaultAsync(m => m.GoodReadId == id);
            if (goodRead == null)
            {
                return NotFound();
            }

            _context.GoodRead.Remove(goodRead);
            await _context.SaveChangesAsync();

            return Ok(goodRead);
        }

        private bool GoodReadExists(int id)
        {
            return _context.GoodRead.Any(e => e.GoodReadId == id);
        }
    }*/
}
