using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IConfiguration _config;

        public AuthController(IConfiguration config)
        {
            _config = config;
        }


        [HttpPost("login")]
        public IActionResult Login([FromBody] User model)
        {

            if (model.Username != "admin" || model.Password != "12345")
            {
                return Unauthorized("Неверный логин или пароль");
            }

            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["JwtSettings:SecretKey"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                new Claim(ClaimTypes.Name, model.Username),
                new Claim(ClaimTypes.Role, "User")
            };

            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddMinutes(30),
                signingCredentials: credentials
            );

            var tokenString = new JwtSecurityTokenHandler().WriteToken(token);

            return Ok(tokenString);

        }

        [HttpPost("logout")]
        public IActionResult Logout()
        {
            return Ok(new { Message = "Выход выполнен. Удалите токен на клиенте." });
        }

    }
}
