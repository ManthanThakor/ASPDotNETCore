using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models.Entities;

namespace WebApplication1.Controllers
{
    public class DataTransferController : Controller
    {
        public IActionResult GotAll()
        {
            // Passing a list of products (Model)
            List<Product> productList = new List<Product>
            {
                new() { Id = 1, StockLevel = 25, StackStatus = true, Title = "TV" },
                new() { Id = 2, StockLevel = 225, StackStatus = true, Title = "USB" },
                new() { Id = 3, StockLevel = 215, StackStatus = true, Title = "Phone" }
            };

            // Passing data using ViewData
            ViewData["Message"] = "Welcome to the Product List!";

            // Passing data using ViewBag
            ViewBag.TotalProducts = productList.Count;

            // Passing data using TempData (useful for redirect)
            TempData["Notification"] = "Product data has been loaded.";

            return View(productList); // Passing Model to the view
        }

        public IActionResult Notification()
        {
            // Example action to display TempData
            return View();
        }
    }
}
