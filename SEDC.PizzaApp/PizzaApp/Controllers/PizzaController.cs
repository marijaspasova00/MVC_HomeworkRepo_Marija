using Microsoft.AspNetCore.Mvc;
using PizzaApp.Mappers;
using PizzaApp.Models;
using PizzaApp.Models.Enums;

namespace PizzaApp.Controllers
{
    public class PizzaController : Controller
    {

        private static List<Pizza> pizzas = new List<Pizza>
    {
        new Pizza { Id = 1, Name = "Margherita", Price = 12.99m, PizzaSize = PizzaSize.Normal, HasExtras = false },
        new Pizza { Id = 2, Name = "Pepperoni", Price = 14.99m, PizzaSize = PizzaSize.Normal, HasExtras = true },
        new Pizza { Id = 3, Name = "Supreme", Price = 17.99m, PizzaSize = PizzaSize.Family, HasExtras = false },
        // Add more pizzas here...
    };

        public IActionResult Index()
        {
            // Map the list of pizzas to view models
            var pizzaViewModels = pizzas.Select(pizza => pizza.ToViewModel()).ToList();

            return View(pizzaViewModels);
        }

        public IActionResult Details(int id)
        {
            // Find the pizza in the static list by the given id
            var pizza = pizzas.FirstOrDefault(p => p.Id == id);

            if (pizza == null)
            {
                return new EmptyResult();
            }

            // Map the pizza to view model and pass it to the view
            var pizzaViewModel = pizza.ToViewModel();
            return View(pizzaViewModel);
        }
    }
}
