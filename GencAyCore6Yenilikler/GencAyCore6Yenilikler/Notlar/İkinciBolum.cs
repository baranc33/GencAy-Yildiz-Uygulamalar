/*
 1. Ctor içinde Gelen IConfiguration configuration
 */
public class NotAmaçlıKullanım2
{
    static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        var app = builder.Build();

        app.MapGet("/", () => "Hello World!");

        app.Run();
    }
}

