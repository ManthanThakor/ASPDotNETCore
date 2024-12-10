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
            _logger.LogInformation("API Key: " + _appSettings.ApiKey);
            _logger.LogInformation("Database Connection: " + _appSettings.DatabaseConnection);

            var customVariable = Environment.GetEnvironmentVariable("MyCustomVariable");

            if (string.IsNullOrEmpty(customVariable))
            {
                _logger.LogWarning("Custom Variable is not set.");
            }
            else
            {
                _logger.LogInformation("Custom Variable: " + customVariable);
            }

            ViewBag.ApiKey = _appSettings.ApiKey;
            ViewBag.DatabaseConnection = _appSettings.DatabaseConnection;
            ViewBag.CustomVariable = customVariable; // Pass to ViewBag
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
