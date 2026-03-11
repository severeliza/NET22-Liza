using Microsoft.AspNetCore.Mvc;
using MyMVC.Filters;
using MyMVC.Interfaces;

namespace MyMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserService _userService;

        public HomeController(IUserService userService)
        {
            _userService = userService;
        }

        [ServiceFilter(typeof(LogActionFilter))]
        public IActionResult Get()
        {
            return Ok("Data");
        }

        //// Ограничения маршрута
        //[HttpGet("{id:int:min(1)}")]
        ////// Несколько HTTP методов
        //[AcceptVerbs("POST", "PUT")]
        //[Route("update")]
        //[HttpGet("search/{name}")]
        public IActionResult Index()
        {
            ViewData["IsAuthenticated"] = _userService.IsAuthenticated();
            ViewData["Username"] = _userService.GetCurrentUsername();
            return View();
        }

        // Защищенный метод - только для авторизованных пользователей
        [SimpleAuthorize]
        public IActionResult Privacy()
        {
            ViewData["Username"] = _userService.GetCurrentUsername();
            var aaa = "2123";
            return View();
        }

    }
}
