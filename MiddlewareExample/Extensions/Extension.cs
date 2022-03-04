using MiddlewareExample.Middlewares;

namespace MiddlewareExample.Extensions
{
 static  public class Extension
    {

        // Daha önce oluşturduğumuz middlewari  çağıracağımız için Extension olarak tetikliyoruz.
        static public IApplicationBuilder UseHello(this IApplicationBuilder applicationBuilder)
        {
            return applicationBuilder.UseMiddleware<HelloMiddleware>();
        }
    }
}
