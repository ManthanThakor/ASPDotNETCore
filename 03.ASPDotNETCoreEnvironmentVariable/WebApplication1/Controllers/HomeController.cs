using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;  // Add this for IOptions
using System.Diagnostics;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MyAppSettings _appSettings;

        // Inject IOptions<MyAppSettings> to access configuration
        public HomeController(ILogger<HomeController> logger, IOptions<MyAppSettings> appSettings)
        {
            _logger = logger;
            _appSettings = appSettings.Value;  // Access the strongly-typed configuration values
        }

        public IActionResult Index()
        {
            // Access configuration values
            ViewBag.ApiKey = _appSettings.ApiKey;
            ViewBag.DatabaseConnection = _appSettings.DatabaseConnection;

            // Access an environment variable
            ViewBag.CustomVariable = Environment.GetEnvironmentVariable("MyCustomVariable");

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
