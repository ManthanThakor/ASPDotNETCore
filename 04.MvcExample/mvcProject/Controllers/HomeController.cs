using Microsoft.AspNetCore.Mvc;
using mvcProject.Models.Entities;

namespace mvcProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult GetCategories()
        {
            return View();
        }
        [Route("GetProducts")]
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
