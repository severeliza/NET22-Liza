namespace MyMVC.Models
{
    public enum Categories
    {
        Food = 1,
        Fashion = 2,
        Household = 3,
        Beauty = 4,
        Electronics = 5
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Categories Category { get; set; } = Categories.Food;

        public double Price { get; set; }
        public string Description { get; set; } = "";
    }
}
