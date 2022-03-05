using Microsoft.AspNetCore.Mvc;

namespace ViewModelAndDto.Controllers
{
    public class PersonelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
