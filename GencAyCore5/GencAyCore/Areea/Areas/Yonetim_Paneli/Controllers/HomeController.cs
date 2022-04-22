using Microsoft.AspNetCore.Mvc;

namespace Areea.Areas.Yonetim_Paneli.Controllers
{

    [Area("Yonetim_Paneli")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            TempData["data"] = new[] { "", "", "", };
            return RedirectToAction("Index", "Home",new {area= "fatura_paneli"});
        }
    }
}
