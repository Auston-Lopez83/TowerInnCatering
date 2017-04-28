using System.Collections.Generic;
namespace TowerInnCatering.Models
{
    public class FakeProductRepository : IProductRepository
    {
        public IEnumerable<Product> Products => new List<Product>
        {
            new Product { Name = "Chicken",Price = 10},
            new Product { Name = "Beef", Price = 14},
        };
    }
}
