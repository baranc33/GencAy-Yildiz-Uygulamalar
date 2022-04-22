using EnviromentExample.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EnviromentExample.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWebHostEnvironment _environment;
        private readonly IConfiguration _configuration;

        public HomeController(IWebHostEnvironment environment, IConfiguration configuration)
        {
            _environment = environment;
            _configuration = configuration;
        }

        public IActionResult Index()
        {

            var a = _configuration["Deneme"];
            var b = _configuration["Hakan"];
            bool Enviroment = _environment.IsEnvironment("MyEnviroment");
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