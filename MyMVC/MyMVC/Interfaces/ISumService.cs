using MyMVC.Models;

namespace MyMVC.Interfaces
{
    public interface ISumService
    {
        public double FindSumAll(List<Product> products);
        public double FindSumByCategory(List<Product> products, Categories category);
    }
}
