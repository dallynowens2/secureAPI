using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using secureAPI;
using secureAPI.Data;

namespace secureAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WireguardController : ControllerBase
    {
        private readonly WireGuardContext _context;

        public WireguardController(WireGuardContext context)
        {
            _context = context;
        }

        // GET: api/Wireguard
        [HttpGet]
        [Authorize]
        public async Task<ActionResult<IEnumerable<WireGuardInfo>>> GetwireGuardInfo()
        {
            return await _context.wireGuardInfo.ToListAsync();
        }

        // GET: api/Wireguard/5
        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<WireGuardInfo>> GetWireGuardInfo(int id)
        {
            var wireGuardInfo = await _context.wireGuardInfo.FindAsync(id);

            if (wireGuardInfo == null)
            {
                return NotFound();
            }

            return wireGuardInfo;
        }

        // PUT: api/Wireguard/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        [Authorize]
        public async Task<IActionResult> PutWireGuardInfo(int id, WireGuardInfo wireGuardInfo)
        {
            if (id != wireGuardInfo.id)
            {
                return BadRequest();
            }

            _context.Entry(wireGuardInfo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WireGuardInfoExists(id))
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

        // POST: api/Wireguard
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [Authorize]
        public async Task<ActionResult<WireGuardInfo>> PostWireGuardInfo(WireGuardInfo wireGuardInfo)
        {
            _context.wireGuardInfo.Add(wireGuardInfo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetWireGuardInfo", new { id = wireGuardInfo.id }, wireGuardInfo);
        }

        // DELETE: api/Wireguard/5
        [HttpDelete("{id}")]
        [Authorize]
        public async Task<IActionResult> DeleteWireGuardInfo(int id)
        {
            var wireGuardInfo = await _context.wireGuardInfo.FindAsync(id);
            if (wireGuardInfo == null)
            {
                return NotFound();
            }

            _context.wireGuardInfo.Remove(wireGuardInfo);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool WireGuardInfoExists(int id)
        {
            return _context.wireGuardInfo.Any(e => e.id == id);
        }
    }
}
