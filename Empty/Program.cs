using FluentValidation.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews().AddFluentValidation(x=>x.RegisterValidatorsFromAssemblyContaining<Program>());// controller ve view kullanýlacak
//builder.Services.AddControllers();//sadece kontroller

var app = builder.Build();
app.UseStaticFiles();
app.UseRouting();// Gelen isteklerin Rotasýný bu middleware belirler. 

app.UseEndpoints(endpoints =>
{ 
// þimdilik defaulta ayarladýk

    // ilk parametre route ismi verilir daha sonra standrt controler ve action gelir
    // istersek bunlara default deðer verebiliriz ardýndan gelen parametreler ? null olabilir diyebiliriz
    // route mekanizmasýnda her parametre {} süslüler içersinde yer alýr
    //endpoints.MapControllerRoute("MyRoute", "{controller=product}/{action=GetProduct}/{id?}/{name?}");

    // eðer yukardaki tanýma uymazsa bu çalýþýr  eðer bunada uymazsa  alttakine geçer o yüzden
    // default tanýmlama herzaman en altta kalmalýdýr
    endpoints.MapDefaultControllerRoute();
});


//app.MapGet("/", () => "Hello World!");


app.Run();
