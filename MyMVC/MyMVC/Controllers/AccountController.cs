using Microsoft.AspNetCore.Mvc;
using MyMVC.Interfaces;
using MyMVC.VM;

namespace MyMVC.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserService _userService;
        private readonly ILogger<AccountController> _logger;

        public AccountController(IUserService userService, ILogger<AccountController> logger)
        {
            _userService = userService;
            _logger = logger;
        }

        // GET: /Account/Login
        public IActionResult Login(string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }

        // POST: /Account/Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(LoginVM model, string returnUrl = null)
        {
            if (ModelState.IsValid)
            {
                var result = _userService.Login(model.Username, model.Password);
                if (result)
                {
                    _logger.LogInformation($"Пользователь {model.Username} вошел в систему");

                    if (!string.IsNullOrEmpty(returnUrl) && Url.IsLocalUrl(returnUrl))
                    {
                        return Redirect(returnUrl);
                    }
                    return RedirectToAction("Index", "Courses");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Неверное имя пользователя или пароль");
                }
            }
            return View(model);
        }

        // GET: /Account/Register
        public IActionResult Register()
        {
            return View();
        }

        // POST: /Account/Register
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(RegisterVM model)
        {
            if (ModelState.IsValid)
            {
                var userExists = _userService.UserExists(model.Username);
                if (userExists)
                {
                    ModelState.AddModelError("Username", "Пользователь с таким именем уже существует");
                    return View(model);
                }

                var user = new Models.User
                {
                    Username = model.Username,
                    Email = model.Email,
                    Password = model.Password // В реальном проекте здесь должен быть хэш!
                };

                var result = _userService.Register(user);
                if (result)
                {
                    _logger.LogInformation($"Зарегистрирован новый пользователь: {model.Username}");
                    return RedirectToAction("Index", "Courses");
                }
            }
            return View(model);
        }

        // POST: /Account/Logout
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Logout()
        {
            var username = _userService.GetCurrentUsername();
            _userService.Logout();
            _logger.LogInformation($"Пользователь {username} вышел из системы");
            return RedirectToAction("Index", "Courses");
        }

        // GET: /Account/AccessDenied
        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}
