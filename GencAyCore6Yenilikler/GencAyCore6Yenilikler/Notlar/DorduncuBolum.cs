
/*
 3.Configure metodu içersinde IApplicationBuilder app nesneleri vardı.
 */

public class NotAmaçlıKullanım4
{
    static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        var app = builder.Build();

        /*middleware ve app fonksyonları burda kullanılıyor.*/

        app.MapGet("/", () => "Hello World!");

        app.Run();
    }
}

