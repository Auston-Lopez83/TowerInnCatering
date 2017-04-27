using System;
using TowerInnCatering.Models;
using Microsoft.AspNetCore.Mvc;

namespace TowerInnCatering.Controllers
{
    public class MenuController : Controller
    {
        public IActionResult Menu()
        {
            MenuItem[] array =
            {
                new MenuItem {Name="Chicken", Price=10},
                new MenuItem {Name="Beef", Price=10},
                new MenuItem {Name="Fish", Price=15}

            };
            return View(array);
        }
    }
}
