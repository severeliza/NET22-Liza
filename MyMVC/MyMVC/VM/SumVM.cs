using MyMVC.Interfaces;
using MyMVC.Models;

namespace MyMVC.VM
{
    public class SumVM
    {
        public List<Product> ProductsList { get; set; }

        public double Total { get; set; }

        public SumVM(IProductService productService, ISumService sumService)
        {
            ProductsList = productService.GetAllProducts();
            Total = sumService.FindSumAll(ProductsList);
        }
    }
}
