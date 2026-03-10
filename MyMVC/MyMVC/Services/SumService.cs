using MyMVC.Interfaces;
using MyMVC.Models;

namespace MyMVC.Services
{
    public class SumService : ISumService
    {
        public double FindSumAll(List<Product> products)
        {
            return products.Sum(p => p.Price);
        }

        public double FindSumByCategory(List<Product> products, Categories category)
        {
            return products.Where(a => a.Category == category).Sum(p => p.Price);
        }

    }
}
