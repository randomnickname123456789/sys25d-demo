using Microsoft.AspNetCore.Mvc;

namespace sys25d_demo.Controllers
{
    [ApiController]
    [Route("[controller]")] // Accessible at /login
    public class LoginController : ControllerBase
    {
        public class LoginRequest
        {
            public string Username { get; set; }
            public string Password { get; set; }
        }

        [HttpPost]
        public IActionResult Login([FromBody] LoginRequest request)
        {
            // Hardcoded credentials for demo purposes
            const string AdminUser = "admin";
            const string AdminPass = "password123";

            if (request.Username == AdminUser && request.Password == AdminPass)
            {
                return Ok(new { message = "Success", user = request.Username });
            }

            // Returns a 401 Unauthorized status code
            return Unauthorized(new { message = "Invalid username or password" });
        }
    }
}