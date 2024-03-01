using backend.Data;
using backend.Dtos.User;
using backend.Mappers;
using backend.Models;
using backend.Repositories;
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
        private readonly UserService userService;

        public AuthController(AppDbContext context, IConfiguration configuration)
        {
            _context = context;
            this.authService = new AuthService(configuration);
            this.userService = new(new UserRepository(context));
        }

        [HttpPost("register")]
        public ActionResult<User> Register([FromBody] RegisterDTO request)
        {
            string passwordHash = BCrypt.Net.BCrypt.HashPassword(request.Password);

            request.Password = passwordHash;

            var user = request.ToUserFromRegisterDto();

            if (!userService.Exists(user))
            {
                userService.Save(user);
                _context.SaveChanges();
                return Ok(user);
            } else
            {
                return BadRequest("User already exists");
            }
        }

        [HttpPost("login")]
        public ActionResult<User> Login(LoginDTO request)
        {
            var user = userService.GetByUsername(request.Username);

            if(user  == null)
            {
                return BadRequest("User not found");
            } else
            {
                if(!BCrypt.Net.BCrypt.Verify(request.Password, user.PasswordHash)){
                    return BadRequest("Incorrect password");
                } else
                {
                    string token = authService.CreateToken(user);

                    return Ok(token);
                }
            }
        }
    }
}
