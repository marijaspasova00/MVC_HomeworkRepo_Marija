using Microsoft.AspNetCore.Mvc;
using PizzaApp.Models;
using System.Diagnostics;

namespace PizzaApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult SeeUsers()
        {
            // Assuming you have a list of users in your system
            var users = new List<User>
        {
            new User { FirstName = "John", LastName = "Doe" },
            new User { FirstName = "Jane", LastName = "Smith" },
            // Add more users here...
        };

            // Assuming UserViewModel contains FullName property
            var userViewModels = users.Select(user => new UserViewModel
            {
                FullName = $"{user.FirstName} {user.LastName}"
            }).ToList();

            return View(userViewModels);
        }
    }
}