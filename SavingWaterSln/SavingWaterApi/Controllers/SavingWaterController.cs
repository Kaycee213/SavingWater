using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SavingWaterApi.Data;
using SavingWaterApi.Model;

namespace SavingWaterApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SavingWaterController : ControllerBase
    {
        private readonly UserContext _context;
        public SavingWaterController(UserContext context)
        {
            _context = context;
        }
        [HttpGet]
        public ActionResult<List<User>> GetAll() =>
          _context.UserInfo.ToList();
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetById(long id)
        {
            var userContext = await _context.UserInfo.FindAsync(id);
            if (userContext == null)
            {
                return NotFound();
            }
            return userContext;
        }
        [HttpPost]
        public async Task<ActionResult<User>> Create(User user)
        {
            _context.UserInfo.Add(user);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetById), new { id = user.id }, user);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(long id, User user)
        {
            if (id != user.id)
            {
                return BadRequest();
            }
            _context.Entry(user).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            var user = await _context.UserInfo.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            _context.UserInfo.Remove(user);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}