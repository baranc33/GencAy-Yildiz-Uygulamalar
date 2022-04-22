 using FluentValidation.AspNetCore;
using GencAyCore6Yenilikler.Extensions;
/*
 
2. ConfigureServices Metodu içersinde IServiceCollection services nesnesi vardı bunu kullanıyorduk

Aşşağıda yorum satırı haline getirdiğim kısımları gerekli paketleri ve sınıfları oluşturark baktım
hata vermiyor ama gerçek bir test yapmadım hata çımicağını ümit ediyoru hata çıkarsada halledirz :)
 */


public class NotAmaçlıKullanım3
{
    static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        /*
         Services Katmanı
      
        builder.Services.AddCors(opt =>
        {
            opt.AddPolicy("CorsPolicy", policy =>
            {
                policy.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin();
            });
        });
        
           builder.Services.AddControllersWithViews().AddFluentValidation(options =>
        {
            options.RegisterValidatorsFromAssemblyContaining<Program>();
        });// fluent Validasyon
         
        builder.Services.AddScopedExtens();// extesnion metot
          */

        builder.Services.AddHttpContextAccessor();
        var app = builder.Build();
        // servis tanımlamasını burda yaparsak  uygulama servisleri build ettiğinden dolayı
        // burdaki servisleri uygulamaya eklemicektir.
        app.Services.GetService<IHttpContextAccessor>();// class ların içinde http context i kullanmamızı sağlar.
        // Fakat IOC Conteinardan nesne almam gerekiyorusa bu kısımdan alacağız
        // loc kosusunu  kendime oluşturduğu ders programında 2 bölüm 3. kısım içersinde Öğrencem.


      




        app.MapGet("/", () => "Hello World!");

        app.Run();
    }
}

