using Empty.Dto;
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
        public IActionResult CreateProduct( )
        {
            var Header = Request.Headers.ToList();
            return View();
        }


        [HttpPost]
        public IActionResult CreateProduct(Product entity)
        {
            return View();
        }
        

        [HttpPost]
        public IActionResult VeriAl( )
        {
            return View();
        }


        [HttpPost]
        public IActionResult GetValue(IFormCollection entity)
        {


            string value1 = entity["name"].ToString();
            return View();
        }

    }
}
