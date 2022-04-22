using Microsoft.AspNetCore.Mvc;
using ViewModelAndDto.Models;
using ViewModelAndDto.Models.ViewModel;

namespace ViewModelAndDto.Controllers
{
    public class PersonelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(PersonelCreateViewModel p)
        {
            return View();
        }
    }
}
