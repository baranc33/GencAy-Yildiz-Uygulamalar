using Empty.Models;
using Microsoft.AspNetCore.Mvc;

namespace Empty.Controllers
{
    public class ProductController : Controller
    {


        public IActionResult GetProduct()
        {
            return View();
        }


        [HttpGet]
        public IActionResult CreateProduct()
        {
            return View();
        }


        [HttpPost]
        public IActionResult CreateProduct(Product entity)
        {
            return View();
        }

    }
}
