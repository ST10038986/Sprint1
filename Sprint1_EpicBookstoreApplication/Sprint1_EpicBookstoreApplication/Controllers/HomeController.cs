using Microsoft.AspNetCore.Mvc;
using Sprint1_EpicBookstoreApplication.Data;
using Sprint1_EpicBookstoreApplication.Models;
using System.Diagnostics;

namespace Sprint1_EpicBookstoreApplication.Controllers
{
    public class HomeController : Controller
    {

        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var inventoryItems = _context.Inventory.ToList();
            return View(inventoryItems);
        }
        //private readonly List<Inventory> inventory = new List<Inventory>
        //{
        //    //new Inventory { Id = 1, BookName = "Harry Potter and the Philosophers Stone", Price =  250 },
        //    //new Inventory { Id = 2, BookName = "Harry Potter and the Chamber of Secrets", Price = 250 },
        //    //new Inventory { Id = 3, BookName = "Harry Potter and the Prisoner of Azkaban ", Price = 250},
        //    //new Inventory { Id = 4, BookName = "Harry Potter and the Goblet of Fire ", Price = 250},
        //    // Add more inventory items as needed
        //};

        //public IActionResult Index()
        //{

        //    //ViewBag.Inventory = inventory;
        //    //return View();
        //}

        [HttpPost]
        public IActionResult AddToCart(int productId)
        {
            // Implement cart functionality here (e.g., store in session or database)
            return Content($"Product {productId} added to cart.");
        }
    }
}

