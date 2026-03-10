using MyMVC.Models;

namespace MyMVC.Interfaces
{
    public interface IProductService
    {
        public List<Product> GetAllProducts();
        public Product GetProductById(int Id);
        public List<Product> AddProduct(Product product);
    }
}
