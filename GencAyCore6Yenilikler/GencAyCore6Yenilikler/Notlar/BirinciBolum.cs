
/*
Core6 da en büyük değişiklik StartUp Dosyalarındaki kodlama 
Program.Cs dosyasına aktarıldı. Bu bölümde Bunu inceliceğiz

StartUp Projemizde Kullandığımız 3 parça nesnemiz vardı 
1. Ctor içinde Gelen IConfiguration configuration

2. ConfigureServices Metodu içersinde IServiceCollection services nesnesi vardı bunu kullanıyorduk

3.Configure metodu içersinde IApplicationBuilder app, IWebHostEnvironment env nesneleri vardı.

Burda Projede Kaba Taslak Notlar Alacağım ilerleyen zamanda projelerim içersinde Test edeceğim
*/
class NotAmaçlıKullanım
{
    static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);


        var app = builder.Build();

        app.MapGet("/", () => "Hello World!");

        app.Run();
    }
}