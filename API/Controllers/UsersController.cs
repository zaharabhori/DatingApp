using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using API.Entities;
using System.Linq;
using API.Data;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class UsersController : ControllerBase
    {
        private readonly DataContext _context;
        public UsersController(DataContext context){
            _context = context;

        }

    //api/users :returns the whole list
    [HttpGet]
    public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
    {
        return await _context.Users.ToListAsync();
    }

    //api/User/3 :returns the user with the specified id
    [HttpGet("{id}")]
    public async Task<ActionResult<AppUser>> GetUsers(int id)
    {
        return await _context.Users.FindAsync(id);
    }

    }

    
}