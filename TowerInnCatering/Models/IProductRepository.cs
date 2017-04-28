using System;
using System.Collections.Generic;

namespace TowerInnCatering.Models
{
    public interface IProductRepository
    {
        IEnumerable<Product> Products { get; }
    }
}
