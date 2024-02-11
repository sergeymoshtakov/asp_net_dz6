using dz6.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace dz6.Controllers
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

        public IActionResult Test()
        {
            var products = new List<Product>
            {
                new Product { Name = "Apple", Quantity = 10, PricePerUnit = 10 },
                new Product { Name = "Banana", Quantity = 1, PricePerUnit = 8 },
                new Product { Name = "Pineapple", Quantity = 3, PricePerUnit = 20 }
            };

            return View(products);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
