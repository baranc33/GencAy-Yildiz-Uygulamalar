using Empty.Models;
using Empty.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace Empty.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Product product = new Product { Id = 1, ProductName = "", Quantity = 10 };
            User user = new User { Id = 1, Name = "", LastName = "" };
            
            List<string> Kelimler = new List<string> { "Hakan", "Baran ", "Çakır" };
            return View(Kelimler);
        }



    }


}
