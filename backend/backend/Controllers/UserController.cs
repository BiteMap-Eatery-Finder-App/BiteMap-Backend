using backend.Data;
using backend.Models;
using backend.Repositories;
using backend.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserService userService;
        private readonly AppDbContext _context;

        public UserController(AppDbContext context)
        {
            _context = context;
            this.userService = new(new UserRepository(context));
        }


        [HttpGet("GetUserByUsername")]
        public ActionResult<User> GetByUsername(string username)
        {
            var user = userService.GetByUsername(username);

            if(user != null)
            {
                return Ok(user);
            } else
            {
                return BadRequest();
            }
        }
    }
}
