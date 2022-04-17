using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using secureAPI.Data;
using secureAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace secureAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentsController : Controller
    {
        private readonly WireGuardContext _context;

        public CommentsController(WireGuardContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Comments>>> GetComments()
        {
            return await _context.comments.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<Comments>> PostComments(Comments comments)
        {
            _context.comments.Add(comments);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetComments", new { id = comments.Id }, comments); ;
        }
    }
}
