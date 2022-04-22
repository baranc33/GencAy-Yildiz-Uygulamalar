using Microsoft.AspNetCore.Mvc;

namespace Areea.Areas.Fatura_Paneli.Controllers
{

    [Area("Fatura_Paneli")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
