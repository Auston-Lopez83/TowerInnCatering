using System.Collections.Generic;
namespace TowerInnCatering.Models
{
    public class FakeProductRepository : IProductRepository
    {
        public List<Product> Products => new List<Product>
        {
            //chicken & Pasta
            new Product { Name = "Chicken and Pasta", Description = "Ritz Dijon Chicken, BBQ Chicken, Chicken Piccata, your choice of two pastas, and fresh baked bread.", Price = 10M, Image = "~/images/banner1.jpg"},
            new Product { Name = "The Tower Inn’s Grand Buffet", Description = "Roast Beef, Ritz Dijon Chicken, Sun-dried Tomato Penne, Parmesan Roasted Potatoes, Vegetable Medley, and Fresh Baked Bread.", Price = 19m, Image = "~/images/banner2.jpg"},
            new Product { Name = "The Pasta Buffet", Description = "Ritz Dijon Chicken, BBQ Chicken, Chicken Piccata, your choice of two pastas, and fresh baked bread.", Price = 10M, Image = "~/images/banner3.jpg"},
            new Product { Name = "The Pasta Buffet", Description = "Your choice of two pastas, vegetable, & breadsticks.", Price = 9M,Image =""},
            new Product { Name = "Pizza and Pasta Buffet", Description = "Your choice of gourmet pizzas, pastas, garlic breadsticks, and cinnamon twists.", Price = 9M,Image =""},

        };
        public List<Fish> Fishs => new List<Fish>
        {
            new Fish { Name = "Chicken and Pasta", Description = "Ritz Dijon Chicken, BBQ Chicken, Chicken Piccata, your choice of two pastas, and fresh baked bread.", Price = 10M, Image = "~/images/banner1.jpg"},

        };
    }
}
