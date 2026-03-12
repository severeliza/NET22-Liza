using Microsoft.AspNetCore.Mvc;
using mvcDBFirst.Models;
using System.Diagnostics;

namespace mvcDBFirst.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            LegacyContext context = new LegacyContext();
            var Players = context.Players.ToList();
            return View(Players);
        }

        public IActionResult Privacy()
        { 
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
