using HelloAppService.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HelloAppService.Controllers
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
            var model = new EnvironmentViewModel
            {
                ComputeRegion = Environment.GetEnvironmentVariable("REGION_NAME"),
                ResourceGroup = Environment.GetEnvironmentVariable("RESOURCE_GROUP"),
                PlanSku = Environment.GetEnvironmentVariable("PLAN_SKU"),
                TimeZone = Environment.GetEnvironmentVariable("TIME_ZONE"),
                ComputeZone = Environment.GetEnvironmentVariable("ZONE_NAME"),
                AspDotNetVersion = Environment.GetEnvironmentVariable("ASPNET_VERSION"),
                AspNetCoreEnvironment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT"),
                MachineName = Environment.MachineName,
                OSVersion = Environment.OSVersion.VersionString
            };

            return View(model);
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
