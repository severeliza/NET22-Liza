using Microsoft.AspNetCore.Mvc;
using MyMVC.Interfaces;
using MyMVC.Models;
using MyMVC.VM;

namespace MyMVC.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [Route("")]
        [Route("Product")]
        [Route("Product/{id?}")]
        public IActionResult Index(int? id)
        {
            ProductVM vM = new ProductVM()
            {
                ProductsList = _productService.GetAllProducts(),
                SelectedProduct = _productService.GetProductById(id ?? 1)
            };

            return View(vM);
        }

        [HttpPost]
        [Route("Product/AddProduct")]
        public IActionResult AddProduct()
        {
            Product newProduct = new Product();
            
            return View(newProduct);
        }

        [HttpPost]
        [Route("Product/SaveProduct")]
        public IActionResult SaveProduct([FromForm] Product newProduct)
        {
            ProductVM vM = new ProductVM()
            {
                ProductsList = _productService.AddProduct(newProduct),
                SelectedProduct = _productService.GetProductById(1)
            };
            
            return View("Index", vM);
        }
    }
}
