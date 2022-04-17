using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using secureAPI.Data;
using secureAPI.Models;

namespace secureAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserModelController : ControllerBase
    {
        private readonly WireGuardContext _context;
        public static IWebHostEnvironment _environment;

        public UserModelController(WireGuardContext context, IWebHostEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }

        // GET: api/UserModel
        [HttpGet]
        [Authorize]
        public async Task<ActionResult<IEnumerable<UserModelInfo>>> GetUserModelInfo()
        {
            return await _context.userModelInfo.ToListAsync();
        }

        // GET: api/UserModel/5
        [HttpGet("{userName}")]
        [Authorize]
        public async Task<ActionResult<UserModelInfo>> GetUserModelInfo(string userName)
        {

            var userModelInfo = await _context.userModelInfo.ToListAsync();
            var userModel = userModelInfo.FirstOrDefault(x => x.userName == userName);//.Result.Single(x => x.userName == userName);
            if (userModel == null)
            {
                return NotFound();
            }

            return userModel;
        }

        // PUT: api/UserModel/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        [Authorize]
        public async Task<IActionResult> PutUserModelInfo(int id, UserModelInfo userModelInfo)
        {
            if (id != userModelInfo.id)
            {
                return BadRequest();
            }

            _context.Entry(userModelInfo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserModelInfoExists(id))
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

        // POST: api/UserModel
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [Authorize]
        public async Task<ActionResult<UserModelInfo>> PostUserModelInfo(UserModelInfo userModelInfo)
        {
            userModelInfo.profilePictureName = await SaveImage(userModelInfo.profilePicture);
            _context.userModelInfo.Add(userModelInfo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUserModelInfo", new { id = userModelInfo.id }, userModelInfo);
        }

        // DELETE: api/UserModel/5
        [HttpDelete("{id}")]
        [Authorize]
        public async Task<IActionResult> DeleteUserModelInfo(int id)
        {
            var userModelInfo = await _context.userModelInfo.FindAsync(id);
            if (userModelInfo == null)
            {
                return NotFound();
            }

            _context.userModelInfo.Remove(userModelInfo);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UserModelInfoExists(int id)
        {
            return _context.userModelInfo.Any(e => e.id == id);
        }

        [NonAction]
        public async Task<string> SaveImage( IFormFile imageFile)
        {
            string imageName = new String(Path.GetFileNameWithoutExtension(imageFile.FileName).Take(10).ToArray()).Replace(' ', '-');
            imageName = imageName + DateTime.Now.ToString("yymmssfff") + Path.GetExtension(imageFile.FileName);
            var imagePath = Path.Combine(_environment.ContentRootPath, "Images", imageName);
            using (var fileStream = new FileStream(imagePath, FileMode.Create))
            {
                await imageFile.CopyToAsync(fileStream);
            }
            return imageName;
        }
    }
}
