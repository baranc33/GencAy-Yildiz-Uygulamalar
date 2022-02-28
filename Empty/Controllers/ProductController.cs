using Empty.Dto;
using Empty.Models;
using Microsoft.AspNetCore.Mvc;

namespace Empty.Controllers
{
    public class ProductController : Controller
    {


        public IActionResult GetProduct()
        {
            var Tuple = (new Product(), new User());

            return View(Tuple);
        }


        [HttpPost]
        public IActionResult VeriAl([Bind(Prefix = "Item1")] Product product, [Bind(Prefix = "Item1")] User user)
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
        public IActionResult GetValue(IFormCollection entity)
        {


            string value1 = entity["name"].ToString();
            return View();
        }

    }
}
