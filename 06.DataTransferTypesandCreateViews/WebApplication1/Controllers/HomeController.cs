using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models.Entities;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetCategories()
        {
            return View();
        }
        public IActionResult GetProductResult()
        {
            Product television = new()
            {
                Id = 1,
                Title = "Samsung Oled Tv",
                StockLevel = 520,
                StackStatus = true,
            };

            return View(television);
        }

    }
}
