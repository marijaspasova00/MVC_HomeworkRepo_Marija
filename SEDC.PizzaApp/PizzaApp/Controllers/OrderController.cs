namespace PizzaApp.Controllers
{
    // OrderController.cs
    using Microsoft.AspNetCore.Mvc;
    using PizzaApp.Models;
    using System.Collections.Generic;

    public class OrderController : Controller
    {
        private static readonly List<Order> orders = new List<Order>
    {
        new Order { Id = 1, ProductName = "Product A", Price = 10.99m, Quantity = 5 },
        new Order { Id = 2, ProductName = "Product B", Price = 5.49m, Quantity = 10 },
        new Order { Id = 3, ProductName = "Product C", Price = 7.99m, Quantity = 2 }
    };

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return new EmptyResult();
            }

            var order = orders.Find(o => o.Id == id.Value);
            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        public IActionResult JsonData()
        {
            var exampleModel = new ExampleModel
            {
                Property1 = "Value1",
                Property2 = "Value2",
                Property3 = "Value3"
            };

            return Json(exampleModel);
        }

        public IActionResult RedirectToHome()
        {
            return RedirectToAction("Index", "Home");
        }
    }

    public class ExampleModel
    {
        public string Property1 { get; set; }
        public string Property2 { get; set; }
        public string Property3 { get; set; }
    }
}

