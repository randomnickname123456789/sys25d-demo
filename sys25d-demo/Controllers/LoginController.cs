using Microsoft.AspNetCore.Mvc;

namespace sys25d_demo.Controllers
{
    [ApiController]
    [Route("[controller]")] // login
    public class LoginController : ControllerBase
    {
        public class LoginRequest
        {
            public string Username { get; set; }
            public string Password { get; set; }
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginRequest request)
        {
            // Hårdkodade loginuppgifter
            const string AdminUser = "admin";
            const string AdminPass = "password123";

            if (request.Username == AdminUser && request.Password == AdminPass)
            {
                return Ok(new { message = "Success", user = request.Username });
            }
            return Unauthorized(new { message = "Invalid username or password" });
        }
    }
}