using configurationExample.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Diagnostics;

namespace configurationExample.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly MailInfo _o;

        public HomeController(IConfiguration configuration,IOptions<MailInfo> o)
        {
            _o = o.Value;
            _configuration = configuration;
        }

        public IActionResult Index()
        {

            //MailInfo a = _configuration.GetSection("MailInfo").Get<MailInfo>();
            //string b = a.EmailInfo.Email;
            MailInfo MI = _o;
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