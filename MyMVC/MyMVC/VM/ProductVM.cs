using MyMVC.Models;

namespace MyMVC.VM
{
    public class ProductVM
    {
        public List<Product> ProductsList {  get; set; }
        public Product? SelectedProduct { get; set; }
    }
}
