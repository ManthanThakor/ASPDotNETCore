using Microsoft.AspNetCore.Mvc;

namespace mvcProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult GetCategories()
        {
            return View();
        }
        public IActionResult GetProductResult()
        {
            return View();
        }
    }
}
