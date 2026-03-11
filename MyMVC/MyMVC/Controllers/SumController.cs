using Microsoft.AspNetCore.Mvc;
using MyMVC.Interfaces;
using MyMVC.VM;

namespace MyMVC.Controllers
{
    public class SumController : Controller
    {
        private readonly IProductService _productService;
        private readonly ISumService _sumService;

        public SumController(IProductService productService, ISumService sumService)
        {
            _productService = productService;
            _sumService = sumService;
        }

        [Route("Sum")]
        public IActionResult Index(int? id)
        {
            SumVM vM = new SumVM(_productService, _sumService);

            return View(vM);
        }
    }
}
