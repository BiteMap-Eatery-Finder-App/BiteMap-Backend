using backend.Data;
using backend.Dtos.User;
using backend.Models;
using backend.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        public static User user = new User();

        private readonly AuthService authService;
        private readonly AppDbContext _context;     

        public AuthController(AppDbContext context, IConfiguration configuration)
        {
            _context = context;
            this.authService = new AuthService(configuration);
        }

        [HttpPost("register")]
        public ActionResult<User> Register(RegisterDTO request)
        {
            string passwordHash = BCrypt.Net.BCrypt.HashPassword(request.Password);
            user.Username = request.Username;
            user.PasswordHash = passwordHash;

            return Ok(user);
        }

        [HttpPost("login")]
        public ActionResult<User> Login(LoginDTO request)
        {
            if(user.Username != request.Username)
            {
                return BadRequest("User not found");
            }
            
            if(!BCrypt.Net.BCrypt.Verify(request.Password, user.PasswordHash))
            {
                return BadRequest("Incorrect password");
            }

            string token = authService.CreateToken(user);

            return Ok(token);
        }
    }
}
