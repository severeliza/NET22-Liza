using Microsoft.AspNetCore.Mvc;
using mvcCodeFirst.Models;
using mvcCodeFirst.Services;
using System.Diagnostics;

namespace mvcCodeFirst.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICourseService service;

        public HomeController(ICourseService service)
        {
            this.service = service;
        }
        public IActionResult Index()
        {
            return View(service.GetStudentList());
        }

        public IActionResult Privacy()
        {
            return View(service.Get());
        }

    }
}
