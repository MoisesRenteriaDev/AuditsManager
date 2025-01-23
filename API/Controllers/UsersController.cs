using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Authorize]
    public class UsersController(DataContext context) : BaseApiController
    {
        [HttpGet]
        public async Task<ActionResult<List<AppUser>>> GetAllUsersAsync()
        {
            var users = await context.Users.ToListAsync();

            return Ok(users);
        }


        [HttpGet("{id:int}")]
        public async Task<ActionResult<AppUser>> GetUserAsync(int id)
        {
            var user = await context.Users.FindAsync(id);

            return Ok(user);
        }
    }
}