using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace sercretManagerExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        readonly IConfiguration _configuration;
        public HomeController(IConfiguration configuration)
        {
            _configuration = configuration;

        }


        public  void Index()
        {
            var connection = _configuration.GetConnectionString("SQL");

            SqlConnectionStringBuilder builder= new SqlConnectionStringBuilder();
            builder.UserID = _configuration["SQL:KullaniciAdi"];
            builder.Password= _configuration["Sifre"];
            var ConnectionString = builder.ConnectionString;
        }

    }
}
