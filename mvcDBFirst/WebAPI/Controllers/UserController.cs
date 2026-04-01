using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UserController : ControllerBase
    {
        [HttpGet("profile")]
        public IActionResult GetProfile()
        {
            var username = User.FindFirst(System.Security.Claims.ClaimTypes.Name)?.Value;

            return Ok(new
            {
                Message = "Доступ разрешен",
                Username = username,
                Data = "Секретные данные пользователя"
            });
        }

        [HttpGet("public-data")]
        [AllowAnonymous]
        public IActionResult GetPublicData()
        {
            return Ok(new { Message = "Это видно всем даже без токена" });
        }
    }
}
