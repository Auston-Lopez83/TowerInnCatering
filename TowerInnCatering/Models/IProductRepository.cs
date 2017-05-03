using System;
using System.Collections.Generic;

namespace TowerInnCatering.Models
{
    public interface IProductRepository
    {
        List<Product> Products { get; }
        //List<Fish> Fishs { get; }
    }
}
