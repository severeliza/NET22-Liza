using MyMVC.Interfaces;
using MyMVC.Models;

namespace MyMVC.Services
{
    public class ProductService : IProductService
    {
        private List<Product> _products = new List<Product>()
        {
            new Product { Id = 1, Name = "Apple", Category = Categories.Food, Price = 0.2, Description = "Fresh and crisp red apples. Perfect for a healthy snack or baking." },
            new Product { Id = 2, Name = "Bread", Category = Categories.Food, Price = 1.1, Description = "Freshly baked whole wheat bread. Soft on the inside with a perfectly crusty exterior." },
            new Product { Id = 3, Name = "Meat", Category = Categories.Food, Price = 25, Description = "Premium cut of fresh beef. Ideal for grilling, roasting, or pan-searing." },
            new Product { Id = 4, Name = "Sneakers Nike", Category = Categories.Fashion, Price = 130, Description = "Comfortable and stylish athletic shoes. Features breathable mesh and responsive cushioning." },
            new Product { Id = 5, Name = "Dress", Category = Categories.Fashion, Price = 50, Description = "Elegant evening dress with a flattering silhouette. Suitable for formal events and special occasions." },
            new Product { Id = 6, Name = "Sweater", Category = Categories.Fashion, Price = 32, Description = "Cozy knit sweater made from a soft wool blend. Keeps you warm and stylish during colder days." },
            new Product { Id = 7, Name = "Washing powder", Category = Categories.Household, Price = 13, Description = "High-efficiency laundry detergent powder. Removes tough stains and leaves clothes smelling fresh." },
            new Product { Id = 8, Name = "Toilet paper", Category = Categories.Household, Price = 0.7, Description = "Soft and absorbent two-ply bath tissue. Gentle on skin and safe for standard plumbing systems." },
            new Product { Id = 9, Name = "Shampoo", Category = Categories.Beauty, Price = 6, Description = "Nourishing shampoo infused with natural oils. Cleanses the scalp while leaving hair silky and manageable." },
            new Product { Id = 10, Name = "Mascara", Category = Categories.Beauty, Price = 10, Description = "Volumizing black mascara for long-lasting wear. Features a specialized brush to separate and lengthen lashes." },
            new Product { Id = 11, Name = "Pomade", Category = Categories.Beauty, Price = 4, Description = "Classic hair styling pomade with a medium hold and natural shine. Easy to apply and wash out." },
            new Product { Id = 12, Name = "Headphones", Category = Categories.Electronics, Price = 210, Description = "Wireless noise-canceling over-ear headphones. Delivers crisp audio quality and features a long battery life." },
            new Product { Id = 13, Name = "Phone", Category = Categories.Electronics, Price = 869, Description = "Latest generation smartphone with a high-resolution display and advanced camera system. Offers fast performance and all-day battery." },
            new Product { Id = 14, Name = "Vacuum cleaner", Category = Categories.Electronics, Price = 451, Description = "Powerful bagless vacuum cleaner with HEPA filtration. Easily handles dust, pet hair, and debris on multiple floor types." }
        };


        public List<Product> GetAllProducts()
        {
            return _products;
        }

        public Product GetProductById(int Id)
        {
            return _products.FirstOrDefault(p => p.Id == Id, _products[0]);
        }

        public List<Product> AddProduct(Product product)
        {
            _products.Add(product);
            return _products; 
        }
    }
}
