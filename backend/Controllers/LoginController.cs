using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using backend.Models;
using backend.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : ControllerBase
    {
        private readonly IUserService _service;
        private readonly IConfiguration _configuration;

        public LoginController(IUserService service,IConfiguration configuration)
        {
            _configuration = configuration ??
                throw new ArgumentException(nameof(configuration));
            _service = service;
        }

        [HttpPost]
        [Route("/login")]
        public async Task<IActionResult> Login(UserLogin user)
        {
            if (!string.IsNullOrEmpty(user.UserName) && !string.IsNullOrEmpty(user.Password))
            {
                var loggedInUser = await _service.GetAsync(user);
                if (loggedInUser is null) return NotFound("User not found");

                var claims = new[]
                {
            new Claim(ClaimTypes.NameIdentifier,loggedInUser.UserName),
            new Claim(ClaimTypes.Email,loggedInUser.EmailAddress),
            new Claim(ClaimTypes.Role,loggedInUser.Role),
        };

                var token = new JwtSecurityToken
                (
                    issuer: _configuration["Jwt:Issuer"],
                    audience: _configuration["Jwt:Audience"],
                    claims: claims,
                    expires: DateTime.UtcNow.AddDays(60),
                    notBefore: DateTime.UtcNow,
                    signingCredentials: new SigningCredentials(
                        new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]!)),
                        SecurityAlgorithms.HmacSha256
                    )
                );

                var tokenString = new JwtSecurityTokenHandler().WriteToken(token);

                return Ok(tokenString);
            }
            return NotFound();
        }
    }
}