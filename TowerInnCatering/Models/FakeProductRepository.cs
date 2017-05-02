using System.Collections.Generic;
namespace TowerInnCatering.Models
{
    public class FakeProductRepository : IProductRepository
    {
        public IEnumerable<Product> Products => new List<Product>
        {
             //chicken
            new Product { Name = "Dijon Ritz Chicken", Category= "Chicken",Price = 10M},
            new Product { Name = "Chicken Pacatta", Category = "Chicken", Price = 10M},
            //beef
            new Product { Name = "Beef Borgonion", Category="Beef", Price = 14M},
            new Product { Name = "Beef and Onions", Category="Beef", Price = 13M},
            //fish
        };
    }
}
